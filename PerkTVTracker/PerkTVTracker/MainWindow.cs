using HtmlAgilityPack;
using HttpServer;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Xml.Serialization;

namespace PerkTVTracker
{
    public partial class MainWindow : Form
    {
        private Random _generator = new Random();
        private Timer _sampleTimer = new Timer();
        private Timer _displayTimer = new Timer();
        private HttpListenerManager _httpServer;
        private NotifyIcon trayIcon;
        private ContextMenu trayMenu;
        private FormWindowState windowState;

        public MainWindow()
        {
            InitializeComponent();

            var now = DateTime.Now;
            var oneSecondLater = now.AddSeconds(1);
            var nextInterval = new DateTime(oneSecondLater.Year, oneSecondLater.Month,
                                            oneSecondLater.Day, oneSecondLater.Hour,
                                            oneSecondLater.Minute, oneSecondLater.Second);

            _displayTimer.Interval = (nextInterval - DateTime.Now).Milliseconds;
            _displayTimer.Tick += OnDisplayTimerTick;
            _displayTimer.Start();

            _httpServer = new HttpListenerManager(1);
            _httpServer.ProcessRequest += httpServer_ProcessRequest;
            _httpServer.Start(10000);

            // Create a simple tray menu with only one item.
            trayMenu = new ContextMenu();
            trayMenu.MenuItems.Add("Show", OnShow);
            trayMenu.MenuItems.Add("Exit", OnExit);

            // Create a tray icon. In this example we use a
            // standard system icon for simplicity, but you
            // can of course use your own custom icon too.
            trayIcon = new NotifyIcon();
            trayIcon.Text = "Perk TV Tracker";
            trayIcon.Icon = Icon.FromHandle(PerkTVTracker.Properties.Resources.perkLogoSmall.GetHicon());
            trayIcon.Click += OnShow;

            // Add menu to tray icon and show it.
            trayIcon.ContextMenu = trayMenu;
            trayIcon.Visible = true;
        }

        #region System Tray code

        private void OnExit(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void OnShow(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = windowState;
        }

        private void MainWindow_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                if (Program.Settings.MinimizeToTray)
                    this.Hide();
            }
            else
                windowState = WindowState;
        }

        #endregion

        void httpServer_ProcessRequest(IHttpClientContext context, IHttpRequest req)
        {
            HttpResponse httpResponse = new HttpResponse(context, req);

            using(Stream outputStream = httpResponse.Body)
            {
                if (req.UriPath == "/app")
                {
                    AppData appData = new AppData();
                    appData.Accounts = new List<AccountData>();
                    int allPointCount = 0;
                    int allLifetimePointCount = 0;
                    double allHourlyRate = 0;
                    foreach (Account account in Program.Settings.Accounts)
                    {
                        DataSummary summary = account.LinearDataProcessor.GetDataSummary();

                        appData.Accounts.Add(new AccountData()
                        {
                            Email = account.Email,
                            CurrentPoints = summary.PointCount,
                            LifetimePoints = summary.LifetimePointCount,
                            EstimatedHourlyRate = summary.HourlyRate
                        });

                        allPointCount += summary.PointCount;
                        allLifetimePointCount += summary.LifetimePointCount;
                        allHourlyRate += summary.HourlyRate;
                    }

                    int totalHourlyRateAmt = (int)Math.Round(allHourlyRate);
                    appData.Total = new AccountData()
                    {
                        CurrentPoints = allPointCount,
                        LifetimePoints = allLifetimePointCount,
                        EstimatedHourlyRate = totalHourlyRateAmt
                    };

                    XmlSerializer serializer = new XmlSerializer(typeof(AppData));
                    serializer.Serialize(outputStream, appData);
                    httpResponse.AddHeader("Content-Type", "text/xml");
                }
                else
                {
                    System.Drawing.Bitmap bmp = new System.Drawing.Bitmap(this.Width, this.Height);
                    Invoke(new Action(() =>
                    {
                        this.DrawToBitmap(bmp, this.ClientRectangle);
                    }));
                    bmp.Save(outputStream, ImageFormat.Png);
                    httpResponse.AddHeader("Content-Type", "image/png");
                }
                outputStream.Flush();
                httpResponse.Send();
            }
        }

        private void OnDisplayTimerTick(object sender, EventArgs e)
        {
            int cnt = 1;
            int allPointCount = 0;
            int allLifetimePointCount = 0;
            double allHourlyRate = 0;
            int numSecondsTilNextSample = 0;

            foreach (Account account in Program.Settings.Accounts)
            {
                DataSummary summary = account.LinearDataProcessor.GetDataSummary();

                (tableLayoutPanel1.Controls[cnt] as SessionViewControl).UpdateDisplay(summary);

                if (numSecondsTilNextSample == 0)
                    numSecondsTilNextSample = (int)Math.Round((summary.LastSampleTimestamp.AddMilliseconds(_sampleTimer.Interval) -
                        DateTime.Now).TotalSeconds);
            
                allPointCount += summary.PointCount;
                allLifetimePointCount += summary.LifetimePointCount;
                allHourlyRate += summary.HourlyRate;
                cnt++;
            }

            if (numSecondsTilNextSample < 0)
            {
                numSecondsTilNextSample = 0;
                OnSampleTimerTick(_sampleTimer, EventArgs.Empty);
            }

            nextSampletoolStripStatusLabel.Text = numSecondsTilNextSample + (numSecondsTilNextSample != 1 ? " seconds" : " second");

            int totalHourlyRateAmt = (int)Math.Round(allHourlyRate);
            DataSummary totalSummary = new DataSummary()
            { 
                HourlyRate = totalHourlyRateAmt,
                PointCount = allPointCount,
                LifetimePointCount = allLifetimePointCount
            };
            (tableLayoutPanel1.Controls[0] as SessionViewControl).UpdateDisplay(totalSummary);
        }

        private void OnFormShown(object sender, EventArgs e)
        {
            showLifetimePointsToolStripMenuItem.Checked = !Program.Settings.HideLifetimePoints;
            minimizeToTrayToolStripMenuItem.Checked = Program.Settings.MinimizeToTray;
            persistDataToolStripMenuItem.Checked = !Program.Settings.ClearDataPointsOnStartup;
            comboBox_timeSpan.SelectedIndex = 1;
            if(Program.Settings.GraphMinimum != DateTime.MinValue)
            {
                lineCurvesChartType.SetMinMax(Program.Settings.GraphMinimum, Program.Settings.GraphMaximum);
                SetGraphType(Program.Settings.GraphType);
            }

            if(Program.Settings.LastWindowSize.Width != 0 && Program.Settings.LastWindowSize.Height != 0 &&
                Program.Settings.LastWindowState != FormWindowState.Minimized)
            {
                Location = Program.Settings.LastWindowLocation;
                Size = Program.Settings.LastWindowSize;
                WindowState = Program.Settings.LastWindowState;
            }

            foreach(Account account in Program.Settings.Accounts)
            {
                AddAccount(account);
            }

            OnSampleTimerTick(_sampleTimer, EventArgs.Empty);
        }

        private void AddAccount(Account account)
        {
            SessionViewControl control = new SessionViewControl(account, RemoveAccount, RebuildGraphs);
            control.Dock = DockStyle.Fill;
            control.AutoSize = true;
            control.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel1.Controls.Add(control);

            if (account.Session == null || !account.Session.HasCookies)
                account.Session = PerkLogInAgent.Login(account);
        }

        private void RemoveAccount(Account account, SessionViewControl control)
        {
            tableLayoutPanel1.Controls.Remove(control);
            Program.Settings.RemoveAccount(account);
        }

        private void OnSampleTimerTick(object sender, EventArgs e)
        {
            OnSampleTimerTick(sender, e, true);
        }

        private async void OnSampleTimerTick(object sender, EventArgs e, bool updateGraph = true)
        {
            double allHourlyRate = 0;
            DateTime sampleTime = DateTime.Now;
            foreach(Account account in Program.Settings.Accounts)
            {
                try
                {
                    KeyValuePair<int, int> pointCount = await account.Session.GetCurrentPointCount();
                    account.LinearDataProcessor.AddSample(pointCount.Key, pointCount.Value, sampleTime);

                    DataSummary summary = account.LinearDataProcessor.GetDataSummary();

                    if (summary.HourlyRate != 0 && updateGraph)
                    {
                        DataPoints points = Program.Settings.GetDataPointsForAccount(account);
                        points.AddPoint(summary);
                    }

                    allHourlyRate += summary.HourlyRate;
                }
                catch { }//We just won't have a data point here
            }

            DateTime minimum, maximum;
            lineCurvesChartType.GetMinMax(out minimum, out maximum);

            Program.Settings.GraphMinimum = minimum;
            Program.Settings.GraphMaximum = maximum;
            Program.Settings.GraphType = GetGraphType();

            Program.Settings.SaveSettings();

            if (updateGraph)
            {
                RebuildGraphs();
                _sampleTimer.Interval = 60000;
            }

            if (!_sampleTimer.Enabled)
            {
                // Timer isn't running
                _sampleTimer.Tick += OnSampleTimerTick;
                _sampleTimer.Start();
            }
        }

        private void RebuildGraphs()
        {
            GraphType graphType = GetGraphType();
            List<Series> series = new List<Series>();
            foreach (var acc in Program.Settings.Accounts)
            {
                if (acc.ShowOnGraph)
                    series.AddRange(acc.DataPoints.ConstructSeries(acc));
            }
            lineCurvesChartType.SetSeries(series, graphType);
        }

        private GraphType GetGraphType()
        {
            return allTimeToolStripMenuItem.Checked ? GraphType.AllTime :
                weekToolStripMenuItem.Checked ? GraphType.Week :
                todayToolStripMenuItem.Checked ? GraphType.Today : last6HoursToolStripMenuItem.Checked ?
                GraphType.LastSixHours : GraphType.LastHour;
        }

        private void SetGraphType(GraphType type)
        {
            switch(type)
            {
                case GraphType.AllTime:
                    graphDisplayToolStripMenuItem_Click(allTimeToolStripMenuItem, EventArgs.Empty);
                    break;
                case GraphType.LastHour:
                    graphDisplayToolStripMenuItem_Click(lastHourToolStripMenuItem, EventArgs.Empty);
                    break;
                case GraphType.LastSixHours:
                    graphDisplayToolStripMenuItem_Click(last6HoursToolStripMenuItem, EventArgs.Empty);
                    break;
                case GraphType.Today:
                    graphDisplayToolStripMenuItem_Click(todayToolStripMenuItem, EventArgs.Empty);
                    break;
                case GraphType.Week:
                    graphDisplayToolStripMenuItem_Click(weekToolStripMenuItem, EventArgs.Empty);
                    break;
            }
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            AddAccount form = new AddAccount();
            if(form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                AddAccount(form.Account);
                Program.Settings.AddAccount(form.Account);
                OnSampleTimerTick(_sampleTimer, EventArgs.Empty, false);
            }
        }

        private void graphDisplayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            allTimeToolStripMenuItem.Checked =
                weekToolStripMenuItem.Checked =
                todayToolStripMenuItem.Checked =
                last6HoursToolStripMenuItem.Checked =
                lastHourToolStripMenuItem.Checked = false;
            ((ToolStripMenuItem)sender).Checked = true;
            RebuildGraphs();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void hideSidebarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel1Collapsed = !splitContainer1.Panel1Collapsed;

            hideSidebarToolStripMenuItem.Checked = !splitContainer1.Panel1Collapsed;
            hideGraphToolStripMenuItem.Checked = !splitContainer1.Panel2Collapsed;
        }

        private void hideGraphToolStripMenuItem_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel2Collapsed = !splitContainer1.Panel2Collapsed;
        }

        private void splitContainer1_Panel2_ClientSizeChanged(object sender, EventArgs e)
        {
            hideSidebarToolStripMenuItem.Checked = !splitContainer1.Panel1Collapsed;
            hideGraphToolStripMenuItem.Checked = !splitContainer1.Panel2Collapsed;
        }

        private void showLifetimePointsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.Settings.HideLifetimePoints = !showLifetimePointsToolStripMenuItem.Checked;
            Program.Settings.SaveSettings();
        }

        private void clearDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var acc in Program.Settings.Accounts)
            {
                acc.DataPoints.ClearPoints();
            }
            RebuildGraphs();
            Program.Settings.SaveSettings();
        }

        private void removeTop10OfDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var acc in Program.Settings.Accounts)
            {
                double maxValue = acc.DataPoints.Points.Max((s) => s.HourlyRate);

                double pointToRemove = maxValue - (maxValue * 0.10);

                List<DataSummary> pointsToRemove = new List<DataSummary>();
                foreach (DataSummary summary in acc.DataPoints.Points)
                {
                    if(summary.HourlyRate >= pointToRemove)
                        pointsToRemove.Add(summary);
                }

                foreach(DataSummary summary in pointsToRemove)
                    acc.DataPoints.RemovePoint(summary);
            }
            RebuildGraphs();
            Program.Settings.SaveSettings();
        }

        private void persistDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.Settings.ClearDataPointsOnStartup = !persistDataToolStripMenuItem.Checked;
            Program.Settings.SaveSettings();
        }

        private void button_previousTime_Click(object sender, EventArgs e)
        {
            DateTime minimum, maximum;
            lineCurvesChartType.GetMinMax(out minimum, out maximum);

            minimum = AddTime(minimum, false, (TimeChangeEnum)comboBox_timeSpan.SelectedIndex);
            maximum = AddTime(maximum, false, (TimeChangeEnum)comboBox_timeSpan.SelectedIndex);

            lineCurvesChartType.SetMinMax(minimum, maximum);
        }

        private void button_nextTime_Click(object sender, EventArgs e)
        {
            DateTime minimum, maximum;
            lineCurvesChartType.GetMinMax(out minimum, out maximum);

            minimum = AddTime(minimum, true, (TimeChangeEnum)comboBox_timeSpan.SelectedIndex);
            maximum = AddTime(maximum, true, (TimeChangeEnum)comboBox_timeSpan.SelectedIndex);

            lineCurvesChartType.SetMinMax(minimum, maximum);
        }

        private DateTime AddTime(DateTime time, bool forward, TimeChangeEnum change)
        {
            if (change == TimeChangeEnum.Day)
                return time.AddDays(1 * (forward ? 1 : -1));
            if (change == TimeChangeEnum.Hour)
                return time.AddHours(1 * (forward ? 1 : -1));
            if (change == TimeChangeEnum.SixHours)
                return time.AddHours(6 * (forward ? 1 : -1));
            if (change == TimeChangeEnum.ThirtyMinutes)
                return time.AddMinutes(30 * (forward ? 1 : -1));
            return time;
        }

        private void button_removeData_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure you want to remove this data?", "Remove?", MessageBoxButtons.YesNo) ==
                DialogResult.Yes)
            {
                DateTime minimum, maximum;
                lineCurvesChartType.GetSelectionMinMax(out minimum, out maximum);
                foreach (var acc in Program.Settings.Accounts)
                {
                    List<DataSummary> pointsToRemove = new List<DataSummary>();
                    foreach (DataSummary summary in acc.DataPoints.Points)
                    {
                        if(summary.LastSampleTimestamp >= minimum && summary.LastSampleTimestamp <= maximum)
                        {
                            pointsToRemove.Add(summary);
                        }
                    }
                    foreach (DataSummary summary in pointsToRemove)
                        acc.DataPoints.RemovePoint(summary);
                }
                RebuildGraphs();
                Program.Settings.SaveSettings();
            }
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            _httpServer.Stop();
            trayIcon.Visible = false;

            // Save window state
            Program.Settings.LastWindowState = WindowState;
            Program.Settings.LastWindowSize = Size;
            Program.Settings.LastWindowLocation = Location;
            Program.Settings.SaveSettings();
        }

        private void minimizeToTrayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.Settings.MinimizeToTray = !Program.Settings.MinimizeToTray;
            Program.Settings.SaveSettings();
        }

        private void clearSamplesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Account acc in Program.Settings.Accounts)
            {
                acc.LinearDataProcessor.ClearSamples();
            }
        }

        private void showMoreStatisticsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MoreStatsWindow window = new MoreStatsWindow();
            window.UpdateStatsDisplay();
            window.ShowDialog();
        }
    }

    public enum TimeChangeEnum
    {
        ThirtyMinutes,
        Hour,
        SixHours,
        Day
    }
}
