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
        private int _seriesCntr = 0;
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
            int cnt = 0;
            int allPointCount = 0;
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
                allHourlyRate += summary.HourlyRate;
                cnt++;
            }

            nextSample.Text = numSecondsTilNextSample + (numSecondsTilNextSample != 1 ? " seconds" : " second");
            
            totalPointCount.Text = allPointCount.ToString("#,##0 points");

            int totalHourlyRateAmt = (int)Math.Round(allHourlyRate);
            string formattedHourly = totalHourlyRateAmt.ToString("#,##0");
            totalHourlyRate.Text = string.Format("{0} {1}/hour", formattedHourly, totalHourlyRateAmt != 1 ? "points" : "point");
        }

        private void UpdateDisplay(DataSummary summary, Label pointCountLbl, Label hourlyRateLbl)
        {
            pointCountLbl.Text = summary.PointCount.ToString("#,##0 points");

            int hourlyRate = (int)Math.Round(summary.HourlyRate);
            string formattedHourly = hourlyRate.ToString("#,##0");
            hourlyRateLbl.Text = string.Format("{0} {1}/hour", formattedHourly, hourlyRate != 1 ? "points" : "point");
        }

        private void OnFormShown(object sender, EventArgs e)
        {
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
                        DataPoints points = Program.Settings.DataPoints[kvp.Key._account];
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
            GraphType graphType = radioButton_allTime.Checked ? GraphType.AllTime :
                radioButton_week.Checked ? GraphType.Week :
                radioButton_today.Checked ? GraphType.Today : radioButton_lastSixHours.Checked ? 
                GraphType.LastSixHours : GraphType.LastHour;
            List<Series> series = new List<Series>();
            foreach (var kvp in Program.Settings.DataPoints)
            {
                if (kvp.Key.ShowOnGraph)
                    series.Add(kvp.Value.ConstructSeries(kvp.Key, graphType));
            }
            lineCurvesChartType.SetSeries(series);
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

        private void radioButton_graphDisplay_CheckedChanged(object sender, EventArgs e)
        {
            RebuildGraphs();
        }
    }
}
