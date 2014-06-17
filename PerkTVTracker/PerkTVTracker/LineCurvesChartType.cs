using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Collections.Generic;

namespace WinFormsChartSamples
{
	/// <summary>
	/// Summary description for LineCurvesChartType.
	/// </summary>
	public class LineCurvesChartType : System.Windows.Forms.UserControl
	{
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;

		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public LineCurvesChartType()
		{
			// This call is required by the Windows.Forms Form Designer.
			InitializeComponent();
		}

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Component Designer generated code
		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            this.chart1.BackImageTransparentColor = System.Drawing.Color.Transparent;
            this.chart1.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            this.chart1.BorderlineWidth = 2;
            this.chart1.BorderSkin.SkinStyle = System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle.Emboss;
            chartArea1.Area3DStyle.Inclination = 40;
            chartArea1.Area3DStyle.IsClustered = true;
            chartArea1.Area3DStyle.IsRightAngleAxes = false;
            chartArea1.Area3DStyle.LightStyle = System.Windows.Forms.DataVisualization.Charting.LightStyle.Realistic;
            chartArea1.Area3DStyle.Perspective = 9;
            chartArea1.Area3DStyle.Rotation = 25;
            chartArea1.Area3DStyle.WallWidth = 3;
            chartArea1.AxisX.ScaleView.Zoomable = true;
            chartArea1.AxisX.ScrollBar.Enabled = true;
            chartArea1.AxisX.ScrollBar.ButtonStyle = ScrollBarButtonStyles.All;
            chartArea1.AxisX.ScaleView.SizeType = DateTimeIntervalType.Hours;
            chartArea1.AxisX.ScaleView.MinSizeType = DateTimeIntervalType.Minutes;
            chartArea1.AxisX.ScaleView.SmallScrollMinSizeType = DateTimeIntervalType.Minutes;
            chartArea1.AxisX.ScaleView.SmallScrollSizeType = DateTimeIntervalType.Minutes;
            chartArea1.AxisX.LabelStyle.Format = "MMM d, hh:mm tt";
            chartArea1.AxisX.IntervalType = DateTimeIntervalType.Hours;
            chartArea1.AxisX.MajorTickMark.IntervalType = DateTimeIntervalType.Hours;
            chartArea1.AxisX.MinorTickMark.IntervalType = DateTimeIntervalType.Hours;
            chartArea1.AxisX.LabelStyle.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisX.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY.LabelStyle.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.BackColor = System.Drawing.Color.White;
            chartArea1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            chartArea1.BackSecondaryColor = System.Drawing.Color.White;
            chartArea1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea1.CursorX.IsUserEnabled = true;
            chartArea1.CursorX.IsUserSelectionEnabled = true;
            chartArea1.CursorX.SelectionColor = System.Drawing.SystemColors.Highlight;
            chartArea1.CursorX.IntervalType = DateTimeIntervalType.Minutes;
            chartArea1.Name = "Default";
            chartArea1.ShadowColor = System.Drawing.Color.Transparent;
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(0, 0);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(413, 297);
            this.chart1.TabIndex = 1;
            // 
            // LineCurvesChartType
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.chart1);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "LineCurvesChartType";
            this.Size = new System.Drawing.Size(413, 297);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

        public void SetSeries(List<Series> series)
        {
            Dictionary<double, double> totalPoints = new Dictionary<double, double>();
            chart1.Series.Clear();
            foreach(Series s in series)
            {
                foreach(DataPoint point in s.Points)
                {
                    if (totalPoints.ContainsKey(point.XValue))
                    {
                        totalPoints[point.XValue] += point.YValues[0];
                    }
                    else
                        totalPoints.Add(point.XValue, point.YValues[0]);
                }
                chart1.Series.Add(s);
            }

            if(chart1.Series.Count > 1)
            {
                Series totalSeries = new Series();
                totalSeries.BorderWidth = 3;
                totalSeries.ChartArea = "Default";
                totalSeries.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
                totalSeries.MarkerBorderWidth = 2;
                totalSeries.MarkerSize = 10;
                totalSeries.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
                totalSeries.Name = "Total";
                totalSeries.IsValueShownAsLabel = false;
                totalSeries.XValueType = ChartValueType.DateTime;
                foreach (KeyValuePair<double, double> kvp in totalPoints)
                {
                    totalSeries.Points.AddXY(kvp.Key, kvp.Value);
                }
                chart1.Series.Add(totalSeries);
            }
        }
    }
}
