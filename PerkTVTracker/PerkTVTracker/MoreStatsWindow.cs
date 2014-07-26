using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PerkTVTracker
{
    public partial class MoreStatsWindow : Form
    {
        public MoreStatsWindow()
        {
            InitializeComponent();
        }

        public void UpdateStatsDisplay()
        {
            Dictionary<DateTime, DataSummary> yesterdaysData = new Dictionary<DateTime, DataSummary>();
            Dictionary<DateTime, DataSummary> todayData = new Dictionary<DateTime, DataSummary>();
            Dictionary<DateTime, DataSummary> allTimeData = new Dictionary<DateTime, DataSummary>();

            //List<Dictionary<DateTime, DataSummary>> datas = new List<Dictionary<DateTime, DataSummary>>();

            DataSummary todaysMinCount = null;
            DataSummary todaysMaxCount = null;

            DataSummary yesterdaysMinCount = null;
            DataSummary yesterdaysMaxCount = null;

            DataSummary allTimesMinCount = null;
            DataSummary allTimesMaxCount = null;
            
            foreach(Account account in Program.Settings.Accounts)
            {
                DataSummary todaysMinCountAcc = null;
                DataSummary todaysMaxCountAcc = null;

                DataSummary yesterdaysMinCountAcc = null;
                DataSummary yesterdaysMaxCountAcc = null;

                DataSummary allTimesMinCountAcc = null;
                DataSummary allTimesMaxCountAcc = null;

                foreach(DataSummary summary in account.DataPoints.Points)
                {
                    if (allTimesMinCountAcc == null)
                        allTimesMinCountAcc = summary;
                    allTimesMaxCountAcc = summary;

                    if ((DateTime.Now - summary.LastSampleTimestamp).TotalHours < 24)
                    {
                        if (todaysMinCountAcc == null)
                            todaysMinCountAcc = summary;
                        todaysMaxCountAcc = summary;

                        if (!todayData.ContainsKey(summary.LastSampleTimestamp))
                            todayData.Add(summary.LastSampleTimestamp, summary.Copy());
                        else
                        {
                            DataSummary s = todayData[summary.LastSampleTimestamp];
                            s.HourlyRate += summary.HourlyRate;
                            s.LifetimePointCount += summary.LifetimePointCount;
                            s.PointCount += summary.PointCount;
                        }
                    }

                    if ((DateTime.Now - summary.LastSampleTimestamp).TotalHours < 48 &&
                        (DateTime.Now - summary.LastSampleTimestamp).TotalHours >= 24)
                    {
                        if (yesterdaysMinCountAcc == null)
                            yesterdaysMinCountAcc = summary;
                        yesterdaysMaxCountAcc = summary;

                        if (!yesterdaysData.ContainsKey(summary.LastSampleTimestamp))
                            yesterdaysData.Add(summary.LastSampleTimestamp, summary.Copy());
                        else
                        {
                            DataSummary s = yesterdaysData[summary.LastSampleTimestamp];
                            s.HourlyRate += summary.HourlyRate;
                            s.LifetimePointCount += summary.LifetimePointCount;
                            s.PointCount += summary.PointCount;
                        }
                    }

                    if (!allTimeData.ContainsKey(summary.LastSampleTimestamp))
                        allTimeData.Add(summary.LastSampleTimestamp, summary.Copy());
                    else
                    {
                        DataSummary s = allTimeData[summary.LastSampleTimestamp];
                        s.HourlyRate += summary.HourlyRate;
                        s.LifetimePointCount += summary.LifetimePointCount;
                        s.PointCount += summary.PointCount;
                    }
                }

                CopySummary(yesterdaysMinCountAcc, ref yesterdaysMinCount);
                CopySummary(yesterdaysMaxCountAcc, ref yesterdaysMaxCount);
                CopySummary(todaysMinCountAcc, ref todaysMinCount);
                CopySummary(todaysMaxCountAcc, ref todaysMaxCount);
                CopySummary(allTimesMinCountAcc, ref allTimesMinCount);
                CopySummary(allTimesMaxCountAcc, ref allTimesMaxCount);
            }

            if (todayData.Count == 0)
                return;

            #region Today's stats

            double hourlyRate = 0;

            foreach(DataSummary summary in todayData.Values)
            {
                hourlyRate += summary.HourlyRate;
            }
            hourlyRate /= todayData.Count;

            pointsGained.Text = (todaysMaxCount.LifetimePointCount - todaysMinCount.LifetimePointCount).ToString("#,##0 pts");

            int todaysHourlyRate = (int)Math.Round(hourlyRate);
            string formattedHourly = todaysHourlyRate.ToString("#,##0");
            this.todaysHourlyRate.Text = string.Format("{0} {1}/hour", formattedHourly, hourlyRate != 1 ? "pts" : "pt");

            #endregion

            #region Yesterday's stats

            if (yesterdaysMinCount != null && yesterdaysMaxCount != null)
            {
                hourlyRate = 0;

                foreach (DataSummary summary in yesterdaysData.Values)
                {
                    hourlyRate += summary.HourlyRate;
                }
                hourlyRate /= yesterdaysData.Count;

                yesterdaysPointsGained.Text = (yesterdaysMaxCount.LifetimePointCount - yesterdaysMinCount.LifetimePointCount).ToString("#,##0 pts");

                int yesterdaysHourlyRate = (int)Math.Round(hourlyRate);
                formattedHourly = yesterdaysHourlyRate.ToString("#,##0");
                this.yesterdaysHourlyRate.Text = string.Format("{0} {1}/hour", formattedHourly, yesterdaysHourlyRate != 1 ? "pts" : "pt");
            }
            else
            {
                yesterdaysPointsGained.Text = "No data available";
                this.yesterdaysHourlyRate.Text = "No data available";
            }

            #endregion

            #region All time stats

            hourlyRate = 0;

            foreach (DataSummary summary in allTimeData.Values)
            {
                hourlyRate += summary.HourlyRate;
            }
            hourlyRate /= allTimeData.Count;

            allTimePointsGained.Text = (allTimesMaxCount.LifetimePointCount - allTimesMinCount.LifetimePointCount).ToString("#,##0 pts");

            int allTimeHourlyRate = (int)Math.Round(hourlyRate);
            formattedHourly = allTimeHourlyRate.ToString("#,##0");
            this.allTimeHourlyRate.Text = string.Format("{0} {1}/hour", formattedHourly, allTimeHourlyRate != 1 ? "pts" : "pt");

            #endregion
        }

        private void CopySummary(DataSummary minCountAcc, ref DataSummary minCount)
        {
            if (minCountAcc == null)
                return;

            if (minCount == null)
                minCount = minCountAcc.Copy();
            else
            {
                minCount.HourlyRate += minCountAcc.HourlyRate;
                minCount.LifetimePointCount += minCountAcc.LifetimePointCount;
                minCount.PointCount += minCountAcc.PointCount;
            }
        }
    }
}
