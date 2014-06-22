using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace PerkTVTracker
{
    public partial class MainWindow : Form
    {
        private Random _generator = new Random();
        private Timer _sampleTimer = new Timer();
        private Timer _displayTimer = new Timer();
        private Dictionary<PerkSession, LinearDataProcessor> _sessions = new Dictionary<PerkSession, LinearDataProcessor>();
        
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
        }

        private void OnDisplayTimerTick(object sender, EventArgs e)
        {
            int cnt = 1;
            int allPointCount = 0;
            int allLifetimePointCount = 0;
            double allHourlyRate = 0;
            int numSecondsTilNextSample = 0;

            foreach (KeyValuePair<PerkSession, LinearDataProcessor> kvp in _sessions)
            {
                DataSummary summary = kvp.Value.GetDataSummary();

                (flowLayoutPanel1.Controls[cnt] as SessionViewControl).UpdateDisplay(summary);

                if (numSecondsTilNextSample == 0)
                    numSecondsTilNextSample = (int)Math.Round((summary.LastSampleTimestamp.AddMilliseconds(_sampleTimer.Interval) -
                        DateTime.Now).TotalSeconds);
            
                allPointCount += summary.PointCount;
                allLifetimePointCount += summary.LifetimePointCount;
                allHourlyRate += summary.HourlyRate;
                cnt++;
            }

            nextSampletoolStripStatusLabel.Text = numSecondsTilNextSample + (numSecondsTilNextSample != 1 ? " seconds" : " second");

            int totalHourlyRateAmt = (int)Math.Round(allHourlyRate);
            DataSummary totalSummary = new DataSummary()
            { 
                HourlyRate = totalHourlyRateAmt,
                PointCount = allPointCount,
                LifetimePointCount = allLifetimePointCount
            };
            (flowLayoutPanel1.Controls[0] as SessionViewControl).UpdateDisplay(totalSummary);
        }

        private void OnFormShown(object sender, EventArgs e)
        {
            showLifetimePointsToolStripMenuItem.Checked = !Program.Settings.HideLifetimePoints;
            persistDataToolStripMenuItem.Checked = !Program.Settings.ClearDataPointsOnStartup;
            comboBox_timeSpan.SelectedIndex = 1;
            splitContainer1.SplitterDistance = flowLayoutPanel1.Width = flowLayoutPanel1.Controls[0].Width + 6;

            foreach(Account account in Program.Settings.Accounts)
            {
                AddAccount(account);
            }

            OnSampleTimerTick(_sampleTimer, EventArgs.Empty);
        }

        private void AddAccount(Account account)
        {
            SessionViewControl control = new SessionViewControl(account, RemoveAccount, RebuildGraphs);
            flowLayoutPanel1.Controls.Add(control);

            _sessions.Add(PerkLogInAgent.Login(account), new LinearDataProcessor() { SampleAgeLimit = new TimeSpan(1, 0, 0) });
        }

        private void RemoveAccount(Account account, SessionViewControl control)
        {
            flowLayoutPanel1.Controls.Remove(control);
            _sessions.Remove(_sessions.FirstOrDefault((kvp) => kvp.Key._account == account).Key);
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
            foreach(KeyValuePair<PerkSession, LinearDataProcessor> kvp in _sessions)
            {
                try
                {
                    KeyValuePair<int, int> pointCount = await kvp.Key.GetCurrentPointCount();
                    kvp.Value.AddSample(pointCount.Key, pointCount.Value, sampleTime);

                    DataSummary summary = kvp.Value.GetDataSummary();

                    if (summary.HourlyRate != 0 && updateGraph)
                    {
                        DataPoints points = Program.Settings.GetDataPointsForAccount(kvp.Key._account);
                        points.AddPoint(summary);
                    }

                    allHourlyRate += summary.HourlyRate;
                }
                catch { }//We just won't have a data point here
            }

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
            GraphType graphType = allTimeToolStripMenuItem.Checked ? GraphType.AllTime :
                weekToolStripMenuItem.Checked ? GraphType.Week :
                todayToolStripMenuItem.Checked ? GraphType.Today : last6HoursToolStripMenuItem.Checked ? 
                GraphType.LastSixHours : GraphType.LastHour;
            List<Series> series = new List<Series>();
            foreach (var acc in Program.Settings.Accounts)
            {
                if (acc.ShowOnGraph)
                    series.AddRange(acc.DataPoints.ConstructSeries(acc));
            }
            lineCurvesChartType.SetSeries(series, graphType);
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
        }

        private void clearDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var acc in Program.Settings.Accounts)
            {
                acc.DataPoints.ClearPoints();
            }
            RebuildGraphs();
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
        }

        private void persistDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.Settings.ClearDataPointsOnStartup = !persistDataToolStripMenuItem.Checked;
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
    }

    public enum TimeChangeEnum
    {
        ThirtyMinutes,
        Hour,
        SixHours,
        Day
    }
}
