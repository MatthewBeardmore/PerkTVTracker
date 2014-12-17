﻿namespace PerkTVTracker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timeSpanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allTimeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.weekToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.todayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.last6HoursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lastHourToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showMoreStatisticsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.hideSidebarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hideGraphToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showLifetimePointsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showTotalInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.minimizeToTrayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pointsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearSamplesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.persistDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.setSampleAgeLimitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.totalInfoBox = new PerkTVTracker.SessionViewControl();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lineCurvesChartType = new PerkTVTracker.LineCurvesChartType();
            this.button_removeData = new System.Windows.Forms.Button();
            this.button_nextTime = new System.Windows.Forms.Button();
            this.comboBox_timeSpan = new System.Windows.Forms.ComboBox();
            this.button_previousTime = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.nextSampletoolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.pointsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1190, 28);
            this.menuStrip1.TabIndex = 22;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewAccountToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // addNewAccountToolStripMenuItem
            // 
            this.addNewAccountToolStripMenuItem.Name = "addNewAccountToolStripMenuItem";
            this.addNewAccountToolStripMenuItem.Size = new System.Drawing.Size(198, 24);
            this.addNewAccountToolStripMenuItem.Text = "Add New Account";
            this.addNewAccountToolStripMenuItem.Click += new System.EventHandler(this.button_add_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(195, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(198, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Checked = true;
            this.viewToolStripMenuItem.CheckOnClick = true;
            this.viewToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.timeSpanToolStripMenuItem,
            this.showMoreStatisticsToolStripMenuItem,
            this.toolStripSeparator1,
            this.hideSidebarToolStripMenuItem,
            this.hideGraphToolStripMenuItem,
            this.showLifetimePointsToolStripMenuItem,
            this.showTotalInformationToolStripMenuItem,
            this.toolStripSeparator3,
            this.minimizeToTrayToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // timeSpanToolStripMenuItem
            // 
            this.timeSpanToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.allTimeToolStripMenuItem,
            this.weekToolStripMenuItem,
            this.todayToolStripMenuItem,
            this.last6HoursToolStripMenuItem,
            this.lastHourToolStripMenuItem});
            this.timeSpanToolStripMenuItem.Name = "timeSpanToolStripMenuItem";
            this.timeSpanToolStripMenuItem.Size = new System.Drawing.Size(234, 24);
            this.timeSpanToolStripMenuItem.Text = "Time Span";
            // 
            // allTimeToolStripMenuItem
            // 
            this.allTimeToolStripMenuItem.Checked = true;
            this.allTimeToolStripMenuItem.CheckOnClick = true;
            this.allTimeToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.allTimeToolStripMenuItem.Name = "allTimeToolStripMenuItem";
            this.allTimeToolStripMenuItem.Size = new System.Drawing.Size(159, 24);
            this.allTimeToolStripMenuItem.Text = "All Time";
            this.allTimeToolStripMenuItem.Click += new System.EventHandler(this.graphDisplayToolStripMenuItem_Click);
            // 
            // weekToolStripMenuItem
            // 
            this.weekToolStripMenuItem.CheckOnClick = true;
            this.weekToolStripMenuItem.Name = "weekToolStripMenuItem";
            this.weekToolStripMenuItem.Size = new System.Drawing.Size(159, 24);
            this.weekToolStripMenuItem.Text = "Week";
            this.weekToolStripMenuItem.Click += new System.EventHandler(this.graphDisplayToolStripMenuItem_Click);
            // 
            // todayToolStripMenuItem
            // 
            this.todayToolStripMenuItem.CheckOnClick = true;
            this.todayToolStripMenuItem.Name = "todayToolStripMenuItem";
            this.todayToolStripMenuItem.Size = new System.Drawing.Size(159, 24);
            this.todayToolStripMenuItem.Text = "Today";
            this.todayToolStripMenuItem.Click += new System.EventHandler(this.graphDisplayToolStripMenuItem_Click);
            // 
            // last6HoursToolStripMenuItem
            // 
            this.last6HoursToolStripMenuItem.CheckOnClick = true;
            this.last6HoursToolStripMenuItem.Name = "last6HoursToolStripMenuItem";
            this.last6HoursToolStripMenuItem.Size = new System.Drawing.Size(159, 24);
            this.last6HoursToolStripMenuItem.Text = "Last 6 Hours";
            this.last6HoursToolStripMenuItem.Click += new System.EventHandler(this.graphDisplayToolStripMenuItem_Click);
            // 
            // lastHourToolStripMenuItem
            // 
            this.lastHourToolStripMenuItem.CheckOnClick = true;
            this.lastHourToolStripMenuItem.Name = "lastHourToolStripMenuItem";
            this.lastHourToolStripMenuItem.Size = new System.Drawing.Size(159, 24);
            this.lastHourToolStripMenuItem.Text = "Last Hour";
            this.lastHourToolStripMenuItem.Click += new System.EventHandler(this.graphDisplayToolStripMenuItem_Click);
            // 
            // showMoreStatisticsToolStripMenuItem
            // 
            this.showMoreStatisticsToolStripMenuItem.Name = "showMoreStatisticsToolStripMenuItem";
            this.showMoreStatisticsToolStripMenuItem.Size = new System.Drawing.Size(234, 24);
            this.showMoreStatisticsToolStripMenuItem.Text = "Show More Statistics";
            this.showMoreStatisticsToolStripMenuItem.Click += new System.EventHandler(this.showMoreStatisticsToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(231, 6);
            // 
            // hideSidebarToolStripMenuItem
            // 
            this.hideSidebarToolStripMenuItem.Checked = true;
            this.hideSidebarToolStripMenuItem.CheckOnClick = true;
            this.hideSidebarToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.hideSidebarToolStripMenuItem.Name = "hideSidebarToolStripMenuItem";
            this.hideSidebarToolStripMenuItem.Size = new System.Drawing.Size(234, 24);
            this.hideSidebarToolStripMenuItem.Text = "Show Sidebar";
            this.hideSidebarToolStripMenuItem.Click += new System.EventHandler(this.hideSidebarToolStripMenuItem_Click);
            // 
            // hideGraphToolStripMenuItem
            // 
            this.hideGraphToolStripMenuItem.Checked = true;
            this.hideGraphToolStripMenuItem.CheckOnClick = true;
            this.hideGraphToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.hideGraphToolStripMenuItem.Name = "hideGraphToolStripMenuItem";
            this.hideGraphToolStripMenuItem.Size = new System.Drawing.Size(234, 24);
            this.hideGraphToolStripMenuItem.Text = "Show Graph";
            this.hideGraphToolStripMenuItem.Click += new System.EventHandler(this.hideGraphToolStripMenuItem_Click);
            // 
            // showLifetimePointsToolStripMenuItem
            // 
            this.showLifetimePointsToolStripMenuItem.Checked = true;
            this.showLifetimePointsToolStripMenuItem.CheckOnClick = true;
            this.showLifetimePointsToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showLifetimePointsToolStripMenuItem.Name = "showLifetimePointsToolStripMenuItem";
            this.showLifetimePointsToolStripMenuItem.Size = new System.Drawing.Size(234, 24);
            this.showLifetimePointsToolStripMenuItem.Text = "Show Lifetime Points";
            this.showLifetimePointsToolStripMenuItem.Click += new System.EventHandler(this.showLifetimePointsToolStripMenuItem_Click);
            // 
            // showTotalInformationToolStripMenuItem
            // 
            this.showTotalInformationToolStripMenuItem.Checked = true;
            this.showTotalInformationToolStripMenuItem.CheckOnClick = true;
            this.showTotalInformationToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showTotalInformationToolStripMenuItem.Name = "showTotalInformationToolStripMenuItem";
            this.showTotalInformationToolStripMenuItem.Size = new System.Drawing.Size(234, 24);
            this.showTotalInformationToolStripMenuItem.Text = "Show Total Information";
            this.showTotalInformationToolStripMenuItem.Click += new System.EventHandler(this.showTotalInformationToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(231, 6);
            // 
            // minimizeToTrayToolStripMenuItem
            // 
            this.minimizeToTrayToolStripMenuItem.Checked = true;
            this.minimizeToTrayToolStripMenuItem.CheckOnClick = true;
            this.minimizeToTrayToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.minimizeToTrayToolStripMenuItem.Name = "minimizeToTrayToolStripMenuItem";
            this.minimizeToTrayToolStripMenuItem.Size = new System.Drawing.Size(234, 24);
            this.minimizeToTrayToolStripMenuItem.Text = "Minimize to Tray";
            this.minimizeToTrayToolStripMenuItem.Click += new System.EventHandler(this.minimizeToTrayToolStripMenuItem_Click);
            // 
            // pointsToolStripMenuItem
            // 
            this.pointsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearDataToolStripMenuItem,
            this.clearSamplesToolStripMenuItem,
            this.persistDataToolStripMenuItem,
            this.toolStripSeparator4,
            this.setSampleAgeLimitToolStripMenuItem});
            this.pointsToolStripMenuItem.Name = "pointsToolStripMenuItem";
            this.pointsToolStripMenuItem.Size = new System.Drawing.Size(61, 24);
            this.pointsToolStripMenuItem.Text = "Points";
            // 
            // clearDataToolStripMenuItem
            // 
            this.clearDataToolStripMenuItem.Name = "clearDataToolStripMenuItem";
            this.clearDataToolStripMenuItem.Size = new System.Drawing.Size(221, 24);
            this.clearDataToolStripMenuItem.Text = "Clear Data";
            this.clearDataToolStripMenuItem.Click += new System.EventHandler(this.clearDataToolStripMenuItem_Click);
            // 
            // clearSamplesToolStripMenuItem
            // 
            this.clearSamplesToolStripMenuItem.Name = "clearSamplesToolStripMenuItem";
            this.clearSamplesToolStripMenuItem.Size = new System.Drawing.Size(221, 24);
            this.clearSamplesToolStripMenuItem.Text = "Clear Samples";
            this.clearSamplesToolStripMenuItem.Click += new System.EventHandler(this.clearSamplesToolStripMenuItem_Click);
            // 
            // persistDataToolStripMenuItem
            // 
            this.persistDataToolStripMenuItem.Checked = true;
            this.persistDataToolStripMenuItem.CheckOnClick = true;
            this.persistDataToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.persistDataToolStripMenuItem.Name = "persistDataToolStripMenuItem";
            this.persistDataToolStripMenuItem.Size = new System.Drawing.Size(221, 24);
            this.persistDataToolStripMenuItem.Text = "Persist Data";
            this.persistDataToolStripMenuItem.Click += new System.EventHandler(this.persistDataToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(218, 6);
            // 
            // setSampleAgeLimitToolStripMenuItem
            // 
            this.setSampleAgeLimitToolStripMenuItem.Name = "setSampleAgeLimitToolStripMenuItem";
            this.setSampleAgeLimitToolStripMenuItem.Size = new System.Drawing.Size(221, 24);
            this.setSampleAgeLimitToolStripMenuItem.Text = "Set Sample Age Limit";
            this.setSampleAgeLimitToolStripMenuItem.Click += new System.EventHandler(this.setSampleAgeLimitToolStripMenuItem_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(15, 34);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.AutoScroll = true;
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer1.Panel1.ClientSizeChanged += new System.EventHandler(this.splitContainer1_Panel2_ClientSizeChanged);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel2);
            this.splitContainer1.Panel2.ClientSizeChanged += new System.EventHandler(this.splitContainer1_Panel2_ClientSizeChanged);
            this.splitContainer1.Size = new System.Drawing.Size(1160, 690);
            this.splitContainer1.SplitterDistance = 318;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 23;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.totalInfoBox, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(318, 204);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // totalInfoBox
            // 
            this.totalInfoBox.AutoSize = true;
            this.totalInfoBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.totalInfoBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.totalInfoBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalInfoBox.Location = new System.Drawing.Point(2, 2);
            this.totalInfoBox.Margin = new System.Windows.Forms.Padding(2);
            this.totalInfoBox.MaximumSize = new System.Drawing.Size(344, 200);
            this.totalInfoBox.MinimumSize = new System.Drawing.Size(344, 200);
            this.totalInfoBox.Name = "totalInfoBox";
            this.totalInfoBox.Size = new System.Drawing.Size(344, 200);
            this.totalInfoBox.TabIndex = 0;
            this.totalInfoBox.Visible = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.lineCurvesChartType, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.button_removeData, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.button_nextTime, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.comboBox_timeSpan, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.button_previousTime, 2, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(837, 690);
            this.tableLayoutPanel2.TabIndex = 23;
            // 
            // lineCurvesChartType
            // 
            this.lineCurvesChartType.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lineCurvesChartType.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel2.SetColumnSpan(this.lineCurvesChartType, 4);
            this.lineCurvesChartType.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lineCurvesChartType.Location = new System.Drawing.Point(4, 4);
            this.lineCurvesChartType.Margin = new System.Windows.Forms.Padding(4);
            this.lineCurvesChartType.Name = "lineCurvesChartType";
            this.lineCurvesChartType.Size = new System.Drawing.Size(829, 645);
            this.lineCurvesChartType.TabIndex = 18;
            // 
            // button_removeData
            // 
            this.button_removeData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_removeData.Location = new System.Drawing.Point(4, 657);
            this.button_removeData.Margin = new System.Windows.Forms.Padding(4);
            this.button_removeData.Name = "button_removeData";
            this.button_removeData.Size = new System.Drawing.Size(136, 29);
            this.button_removeData.TabIndex = 22;
            this.button_removeData.Text = "Remove Data";
            this.button_removeData.UseVisualStyleBackColor = true;
            this.button_removeData.Click += new System.EventHandler(this.button_removeData_Click);
            // 
            // button_nextTime
            // 
            this.button_nextTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_nextTime.Location = new System.Drawing.Point(798, 657);
            this.button_nextTime.Margin = new System.Windows.Forms.Padding(4);
            this.button_nextTime.Name = "button_nextTime";
            this.button_nextTime.Size = new System.Drawing.Size(35, 29);
            this.button_nextTime.TabIndex = 20;
            this.button_nextTime.Text = ">";
            this.button_nextTime.UseVisualStyleBackColor = true;
            this.button_nextTime.Click += new System.EventHandler(this.button_nextTime_Click);
            // 
            // comboBox_timeSpan
            // 
            this.comboBox_timeSpan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_timeSpan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_timeSpan.FormattingEnabled = true;
            this.comboBox_timeSpan.Items.AddRange(new object[] {
            "30 Minutes",
            "Hour",
            "6 Hours",
            "Day"});
            this.comboBox_timeSpan.Location = new System.Drawing.Point(597, 661);
            this.comboBox_timeSpan.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_timeSpan.Name = "comboBox_timeSpan";
            this.comboBox_timeSpan.Size = new System.Drawing.Size(150, 28);
            this.comboBox_timeSpan.TabIndex = 21;
            // 
            // button_previousTime
            // 
            this.button_previousTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_previousTime.Location = new System.Drawing.Point(755, 657);
            this.button_previousTime.Margin = new System.Windows.Forms.Padding(4);
            this.button_previousTime.Name = "button_previousTime";
            this.button_previousTime.Size = new System.Drawing.Size(35, 29);
            this.button_previousTime.TabIndex = 19;
            this.button_previousTime.Text = "<";
            this.button_previousTime.UseVisualStyleBackColor = true;
            this.button_previousTime.Click += new System.EventHandler(this.button_previousTime_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.nextSampletoolStripStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 730);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 18, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1190, 25);
            this.statusStrip1.TabIndex = 24;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(97, 20);
            this.toolStripStatusLabel1.Text = "Next Sample:";
            // 
            // nextSampletoolStripStatusLabel
            // 
            this.nextSampletoolStripStatusLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextSampletoolStripStatusLabel.Name = "nextSampletoolStripStatusLabel";
            this.nextSampletoolStripStatusLabel.Size = new System.Drawing.Size(87, 20);
            this.nextSampletoolStripStatusLabel.Text = "60 seconds";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1190, 755);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainWindow";
            this.Text = "Perk TV Tracker";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.Shown += new System.EventHandler(this.OnFormShown);
            this.LocationChanged += new System.EventHandler(this.MainWindow_Resize);
            this.Resize += new System.EventHandler(this.MainWindow_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LineCurvesChartType lineCurvesChartType;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem timeSpanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allTimeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem weekToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem todayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem last6HoursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lastHourToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewAccountToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hideSidebarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hideGraphToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel nextSampletoolStripStatusLabel;
        private System.Windows.Forms.ToolStripMenuItem showLifetimePointsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem pointsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearDataToolStripMenuItem;
        private SessionViewControl totalInfoBox;
        private System.Windows.Forms.ToolStripMenuItem persistDataToolStripMenuItem;
        private System.Windows.Forms.Button button_nextTime;
        private System.Windows.Forms.Button button_previousTime;
        private System.Windows.Forms.ComboBox comboBox_timeSpan;
        private System.Windows.Forms.Button button_removeData;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem minimizeToTrayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearSamplesToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ToolStripMenuItem showMoreStatisticsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showTotalInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem setSampleAgeLimitToolStripMenuItem;
    }
}

