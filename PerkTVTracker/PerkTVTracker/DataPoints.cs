﻿using System;
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

        public List<Series> ConstructSeries(Account account, GraphType graphType)
        {
            List<Series> allSeries = new List<Series>();

            Series series = CreateDefaultSeries(account.Email);

            DateTime now = DateTime.Now;
            DateTime lastDataPoint = DateTime.MinValue;
            foreach(DataSummary summary in Points)
            {
                TimeSpan diff = now - summary.LastSampleTimestamp;
                if (graphType == GraphType.AllTime ||
                    (graphType == GraphType.Week && diff.TotalHours < (24.0 * 7)) ||
                    (graphType == GraphType.Today && diff.TotalHours < 24.0) ||
                    (graphType == GraphType.LastSixHours && diff.TotalHours < 6) ||
                    (graphType == GraphType.LastHour && diff.TotalHours < 1.0))
                {
                    TimeSpan diffFromLastPoint = summary.LastSampleTimestamp - lastDataPoint;

                    if (lastDataPoint != DateTime.MinValue && diffFromLastPoint.TotalMinutes > 5)
                    {
                        //Start a new series so that we don't get a massive line connecting points 
                        //  that are not next to each other
                        allSeries.Add(series);
                        series = CreateDefaultSeries(account.Email, allSeries.Count, false);
                    }
                    lastDataPoint = summary.LastSampleTimestamp;

                    series.Points.AddXY(summary.LastSampleTimestamp, summary.HourlyRate);
                }
            }

            allSeries.Add(series);
            return allSeries;
        }

        public static Series CreateDefaultSeries(string name, int? cntr = null, bool displayOnLegend = true)
        {
            Series series = new Series();
            series.BorderWidth = 3;
            series.ChartArea = "Default";
            series.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series.MarkerBorderWidth = 2;
            series.MarkerSize = 10;
            series.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series.Name = name + (cntr == null ? "" : cntr.ToString());
            series.Tag = name;
            series.IsValueShownAsLabel = false;
            series.XValueType = ChartValueType.DateTime;
            series.IsVisibleInLegend = displayOnLegend;

            return series;
        }
    }
}