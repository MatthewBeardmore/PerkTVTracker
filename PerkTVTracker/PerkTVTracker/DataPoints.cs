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

        public Series ConstructSeries(Account account)
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

            foreach(DataSummary summary in Points)
            {
                series.Points.AddXY(summary.LastSampleTimestamp, summary.HourlyRate);
            }

            return series;
        }
    }
}
