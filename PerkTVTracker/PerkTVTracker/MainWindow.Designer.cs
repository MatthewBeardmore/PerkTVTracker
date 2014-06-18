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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.sessionViewControl1 = new PerkTVTracker.SessionViewControl();
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
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.hideSidebarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hideGraphToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showLifetimePointsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pointsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeTop10OfDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lineCurvesChartType = new PerkTVTracker.LineCurvesChartType();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.nextSampletoolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.persistDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flowLayoutPanel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.sessionViewControl1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(255, 552);
            this.flowLayoutPanel1.TabIndex = 19;
            // 
            // sessionViewControl1
            // 
            this.sessionViewControl1.Location = new System.Drawing.Point(3, 4);
            this.sessionViewControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.sessionViewControl1.MaximumSize = new System.Drawing.Size(275, 160);
            this.sessionViewControl1.MinimumSize = new System.Drawing.Size(275, 160);
            this.sessionViewControl1.Name = "sessionViewControl1";
            this.sessionViewControl1.Size = new System.Drawing.Size(275, 160);
            this.sessionViewControl1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.pointsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(952, 28);
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
            this.toolStripSeparator1,
            this.hideSidebarToolStripMenuItem,
            this.hideGraphToolStripMenuItem,
            this.showLifetimePointsToolStripMenuItem});
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
            this.timeSpanToolStripMenuItem.Size = new System.Drawing.Size(216, 24);
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
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(213, 6);
            // 
            // hideSidebarToolStripMenuItem
            // 
            this.hideSidebarToolStripMenuItem.Checked = true;
            this.hideSidebarToolStripMenuItem.CheckOnClick = true;
            this.hideSidebarToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.hideSidebarToolStripMenuItem.Name = "hideSidebarToolStripMenuItem";
            this.hideSidebarToolStripMenuItem.Size = new System.Drawing.Size(216, 24);
            this.hideSidebarToolStripMenuItem.Text = "Show Sidebar";
            this.hideSidebarToolStripMenuItem.Click += new System.EventHandler(this.hideSidebarToolStripMenuItem_Click);
            // 
            // hideGraphToolStripMenuItem
            // 
            this.hideGraphToolStripMenuItem.Checked = true;
            this.hideGraphToolStripMenuItem.CheckOnClick = true;
            this.hideGraphToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.hideGraphToolStripMenuItem.Name = "hideGraphToolStripMenuItem";
            this.hideGraphToolStripMenuItem.Size = new System.Drawing.Size(216, 24);
            this.hideGraphToolStripMenuItem.Text = "Show Graph";
            this.hideGraphToolStripMenuItem.Click += new System.EventHandler(this.hideGraphToolStripMenuItem_Click);
            // 
            // showLifetimePointsToolStripMenuItem
            // 
            this.showLifetimePointsToolStripMenuItem.Checked = true;
            this.showLifetimePointsToolStripMenuItem.CheckOnClick = true;
            this.showLifetimePointsToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showLifetimePointsToolStripMenuItem.Name = "showLifetimePointsToolStripMenuItem";
            this.showLifetimePointsToolStripMenuItem.Size = new System.Drawing.Size(216, 24);
            this.showLifetimePointsToolStripMenuItem.Text = "Show Lifetime Points";
            this.showLifetimePointsToolStripMenuItem.Click += new System.EventHandler(this.showLifetimePointsToolStripMenuItem_Click);
            // 
            // pointsToolStripMenuItem
            // 
            this.pointsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearDataToolStripMenuItem,
            this.removeTop10OfDataToolStripMenuItem,
            this.persistDataToolStripMenuItem});
            this.pointsToolStripMenuItem.Name = "pointsToolStripMenuItem";
            this.pointsToolStripMenuItem.Size = new System.Drawing.Size(61, 24);
            this.pointsToolStripMenuItem.Text = "Points";
            // 
            // clearDataToolStripMenuItem
            // 
            this.clearDataToolStripMenuItem.Name = "clearDataToolStripMenuItem";
            this.clearDataToolStripMenuItem.Size = new System.Drawing.Size(246, 24);
            this.clearDataToolStripMenuItem.Text = "Clear Data";
            this.clearDataToolStripMenuItem.Click += new System.EventHandler(this.clearDataToolStripMenuItem_Click);
            // 
            // removeTop10OfDataToolStripMenuItem
            // 
            this.removeTop10OfDataToolStripMenuItem.Name = "removeTop10OfDataToolStripMenuItem";
            this.removeTop10OfDataToolStripMenuItem.Size = new System.Drawing.Size(246, 24);
            this.removeTop10OfDataToolStripMenuItem.Text = "Remove Top 10% of data";
            this.removeTop10OfDataToolStripMenuItem.Click += new System.EventHandler(this.removeTop10OfDataToolStripMenuItem_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(12, 27);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.flowLayoutPanel1);
            this.splitContainer1.Panel1.ClientSizeChanged += new System.EventHandler(this.splitContainer1_Panel2_ClientSizeChanged);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lineCurvesChartType);
            this.splitContainer1.Panel2.ClientSizeChanged += new System.EventHandler(this.splitContainer1_Panel2_ClientSizeChanged);
            this.splitContainer1.Size = new System.Drawing.Size(928, 552);
            this.splitContainer1.SplitterDistance = 255;
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 23;
            // 
            // lineCurvesChartType
            // 
            this.lineCurvesChartType.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lineCurvesChartType.BackColor = System.Drawing.Color.White;
            this.lineCurvesChartType.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lineCurvesChartType.Location = new System.Drawing.Point(0, 0);
            this.lineCurvesChartType.Name = "lineCurvesChartType";
            this.lineCurvesChartType.Size = new System.Drawing.Size(681, 552);
            this.lineCurvesChartType.TabIndex = 18;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.nextSampletoolStripStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 579);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(952, 25);
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
            // persistDataToolStripMenuItem
            // 
            this.persistDataToolStripMenuItem.Checked = true;
            this.persistDataToolStripMenuItem.CheckOnClick = true;
            this.persistDataToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.persistDataToolStripMenuItem.Name = "persistDataToolStripMenuItem";
            this.persistDataToolStripMenuItem.Size = new System.Drawing.Size(246, 24);
            this.persistDataToolStripMenuItem.Text = "Persist Data";
            this.persistDataToolStripMenuItem.Click += new System.EventHandler(this.persistDataToolStripMenuItem_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 604);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.Text = "Perk TV Tracker";
            this.Shown += new System.EventHandler(this.OnFormShown);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LineCurvesChartType lineCurvesChartType;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
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
        private System.Windows.Forms.ToolStripMenuItem removeTop10OfDataToolStripMenuItem;
        private SessionViewControl sessionViewControl1;
        private System.Windows.Forms.ToolStripMenuItem persistDataToolStripMenuItem;
    }
}

