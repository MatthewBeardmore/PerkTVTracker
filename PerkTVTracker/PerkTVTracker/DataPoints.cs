using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace PerkTVTracker
{
    [Serializable]
    public class DataPoints
    {
        public List<DataSummary> Points = new List<DataSummary>();

        public void AddPoint(DataSummary summary)
        {
            Points.Add(summary);
        }

        public Series ConstructSeries(Account account, GraphType graphType)
        {
            Series series = new Series();
            series.BorderWidth = 3;
            series.ChartArea = "Default";
            series.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series.MarkerBorderWidth = 2;
            series.MarkerSize = 10;
            series.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series.Name = account.Email;
            series.IsValueShownAsLabel = false;
            series.XValueType = ChartValueType.DateTime;

            DateTime now = DateTime.Now;
            foreach(DataSummary summary in Points)
            {
                TimeSpan diff = now - summary.LastSampleTimestamp;
                if (graphType == GraphType.AllTime ||
                    (graphType == GraphType.Week && diff.TotalHours < (24.0 * 7)) ||
                    (graphType == GraphType.Today && diff.TotalHours < 24.0) ||
                    (graphType == GraphType.LastSixHours && diff.TotalHours < 6) ||
                    (graphType == GraphType.LastHour && diff.TotalHours < 1.0))
                {
                    series.Points.AddXY(summary.LastSampleTimestamp, summary.HourlyRate);
                }
            }

            return series;
        }
    }
}
