namespace PerkTVTracker
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.nextSample = new System.Windows.Forms.Label();
            this.totalPointCount = new System.Windows.Forms.Label();
            this.totalHourlyRate = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.button_add = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioButton_week = new System.Windows.Forms.RadioButton();
            this.radioButton_lastSixHours = new System.Windows.Forms.RadioButton();
            this.radioButton_hour = new System.Windows.Forms.RadioButton();
            this.radioButton_today = new System.Windows.Forms.RadioButton();
            this.radioButton_allTime = new System.Windows.Forms.RadioButton();
            this.lineCurvesChartType = new LineCurvesChartType();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 20);
            this.label10.TabIndex = 10;
            this.label10.Text = "Total Count:";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(841, 23);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(97, 20);
            this.label11.TabIndex = 11;
            this.label11.Text = "Next Sample:";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(375, 23);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(198, 20);
            this.label12.TabIndex = 13;
            this.label12.Text = "Total Estimated Hourly Rate:";
            // 
            // nextSample
            // 
            this.nextSample.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nextSample.AutoSize = true;
            this.nextSample.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextSample.Location = new System.Drawing.Point(841, 53);
            this.nextSample.Name = "nextSample";
            this.nextSample.Size = new System.Drawing.Size(87, 20);
            this.nextSample.TabIndex = 12;
            this.nextSample.Text = "30 seconds";
            // 
            // totalPointCount
            // 
            this.totalPointCount.AutoSize = true;
            this.totalPointCount.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalPointCount.Location = new System.Drawing.Point(11, 43);
            this.totalPointCount.Margin = new System.Windows.Forms.Padding(3, 0, 3, 6);
            this.totalPointCount.Name = "totalPointCount";
            this.totalPointCount.Size = new System.Drawing.Size(171, 32);
            this.totalPointCount.TabIndex = 9;
            this.totalPointCount.Text = "12,345 points";
            // 
            // totalHourlyRate
            // 
            this.totalHourlyRate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.totalHourlyRate.AutoSize = true;
            this.totalHourlyRate.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalHourlyRate.Location = new System.Drawing.Point(373, 43);
            this.totalHourlyRate.Margin = new System.Windows.Forms.Padding(3, 0, 3, 6);
            this.totalHourlyRate.Name = "totalHourlyRate";
            this.totalHourlyRate.Size = new System.Drawing.Size(201, 32);
            this.totalHourlyRate.TabIndex = 14;
            this.totalHourlyRate.Text = "321 points/hour";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.totalHourlyRate);
            this.groupBox1.Controls.Add(this.totalPointCount);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.nextSample);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Location = new System.Drawing.Point(1, -3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(946, 82);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(281, 84);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(1, 81);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(305, 489);
            this.flowLayoutPanel1.TabIndex = 19;
            // 
            // button_add
            // 
            this.button_add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_add.Location = new System.Drawing.Point(1, 576);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(275, 28);
            this.button_add.TabIndex = 20;
            this.button_add.Text = "+";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.radioButton_week);
            this.groupBox3.Controls.Add(this.radioButton_lastSixHours);
            this.groupBox3.Controls.Add(this.radioButton_hour);
            this.groupBox3.Controls.Add(this.radioButton_today);
            this.groupBox3.Controls.Add(this.radioButton_allTime);
            this.groupBox3.Location = new System.Drawing.Point(307, 85);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(640, 56);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Graph Options";
            // 
            // radioButton_week
            // 
            this.radioButton_week.AutoSize = true;
            this.radioButton_week.Location = new System.Drawing.Point(97, 26);
            this.radioButton_week.Name = "radioButton_week";
            this.radioButton_week.Size = new System.Drawing.Size(67, 24);
            this.radioButton_week.TabIndex = 4;
            this.radioButton_week.Text = "Week";
            this.radioButton_week.UseVisualStyleBackColor = true;
            this.radioButton_week.CheckedChanged += new System.EventHandler(this.radioButton_graphDisplay_CheckedChanged);
            // 
            // radioButton_lastSixHours
            // 
            this.radioButton_lastSixHours.AutoSize = true;
            this.radioButton_lastSixHours.Location = new System.Drawing.Point(247, 26);
            this.radioButton_lastSixHours.Name = "radioButton_lastSixHours";
            this.radioButton_lastSixHours.Size = new System.Drawing.Size(108, 24);
            this.radioButton_lastSixHours.TabIndex = 3;
            this.radioButton_lastSixHours.Text = "Last 6 hours";
            this.radioButton_lastSixHours.UseVisualStyleBackColor = true;
            this.radioButton_lastSixHours.CheckedChanged += new System.EventHandler(this.radioButton_graphDisplay_CheckedChanged);
            // 
            // radioButton_hour
            // 
            this.radioButton_hour.AutoSize = true;
            this.radioButton_hour.Location = new System.Drawing.Point(361, 26);
            this.radioButton_hour.Name = "radioButton_hour";
            this.radioButton_hour.Size = new System.Drawing.Size(63, 24);
            this.radioButton_hour.TabIndex = 2;
            this.radioButton_hour.Text = "Hour";
            this.radioButton_hour.UseVisualStyleBackColor = true;
            this.radioButton_hour.CheckedChanged += new System.EventHandler(this.radioButton_graphDisplay_CheckedChanged);
            // 
            // radioButton_today
            // 
            this.radioButton_today.AutoSize = true;
            this.radioButton_today.Location = new System.Drawing.Point(170, 26);
            this.radioButton_today.Name = "radioButton_today";
            this.radioButton_today.Size = new System.Drawing.Size(71, 24);
            this.radioButton_today.TabIndex = 1;
            this.radioButton_today.Text = "Today";
            this.radioButton_today.UseVisualStyleBackColor = true;
            this.radioButton_today.CheckedChanged += new System.EventHandler(this.radioButton_graphDisplay_CheckedChanged);
            // 
            // radioButton_allTime
            // 
            this.radioButton_allTime.AutoSize = true;
            this.radioButton_allTime.Checked = true;
            this.radioButton_allTime.Location = new System.Drawing.Point(6, 26);
            this.radioButton_allTime.Name = "radioButton_allTime";
            this.radioButton_allTime.Size = new System.Drawing.Size(85, 24);
            this.radioButton_allTime.TabIndex = 0;
            this.radioButton_allTime.TabStop = true;
            this.radioButton_allTime.Text = "All Time";
            this.radioButton_allTime.UseVisualStyleBackColor = true;
            this.radioButton_allTime.CheckedChanged += new System.EventHandler(this.radioButton_graphDisplay_CheckedChanged);
            // 
            // lineCurvesChartType
            // 
            this.lineCurvesChartType.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lineCurvesChartType.BackColor = System.Drawing.Color.White;
            this.lineCurvesChartType.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lineCurvesChartType.Location = new System.Drawing.Point(307, 147);
            this.lineCurvesChartType.Name = "lineCurvesChartType";
            this.lineCurvesChartType.Size = new System.Drawing.Size(640, 457);
            this.lineCurvesChartType.TabIndex = 18;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 604);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.lineCurvesChartType);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "MainWindow";
            this.Text = "Perk TV Tracker";
            this.Shown += new System.EventHandler(this.OnFormShown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label nextSample;
        private System.Windows.Forms.Label totalPointCount;
        private System.Windows.Forms.Label totalHourlyRate;
        private System.Windows.Forms.GroupBox groupBox1;
        private LineCurvesChartType lineCurvesChartType;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioButton_hour;
        private System.Windows.Forms.RadioButton radioButton_today;
        private System.Windows.Forms.RadioButton radioButton_allTime;
        private System.Windows.Forms.RadioButton radioButton_lastSixHours;
        private System.Windows.Forms.RadioButton radioButton_week;
    }
}

