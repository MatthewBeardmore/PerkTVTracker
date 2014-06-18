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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.graphToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timeSpanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allTimeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.weekToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.todayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.last6HoursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lastHourToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hideSidebarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hideGraphToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.nextSampletoolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.showLifetimeCountsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lineCurvesChartType = new PerkTVTracker.LineCurvesChartType();
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
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(285, 552);
            this.flowLayoutPanel1.TabIndex = 19;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.graphToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(952, 24);
            this.menuStrip1.TabIndex = 22;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewAccountToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // addNewAccountToolStripMenuItem
            // 
            this.addNewAccountToolStripMenuItem.Name = "addNewAccountToolStripMenuItem";
            this.addNewAccountToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.addNewAccountToolStripMenuItem.Text = "Add New Account";
            this.addNewAccountToolStripMenuItem.Click += new System.EventHandler(this.button_add_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // graphToolStripMenuItem
            // 
            this.graphToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.timeSpanToolStripMenuItem});
            this.graphToolStripMenuItem.Name = "graphToolStripMenuItem";
            this.graphToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.graphToolStripMenuItem.Text = "Graph";
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
            this.timeSpanToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.timeSpanToolStripMenuItem.Text = "Time Span";
            // 
            // allTimeToolStripMenuItem
            // 
            this.allTimeToolStripMenuItem.Checked = true;
            this.allTimeToolStripMenuItem.CheckOnClick = true;
            this.allTimeToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.allTimeToolStripMenuItem.Name = "allTimeToolStripMenuItem";
            this.allTimeToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.allTimeToolStripMenuItem.Text = "All Time";
            this.allTimeToolStripMenuItem.Click += new System.EventHandler(this.graphDisplayToolStripMenuItem_Click);
            // 
            // weekToolStripMenuItem
            // 
            this.weekToolStripMenuItem.CheckOnClick = true;
            this.weekToolStripMenuItem.Name = "weekToolStripMenuItem";
            this.weekToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.weekToolStripMenuItem.Text = "Week";
            this.weekToolStripMenuItem.Click += new System.EventHandler(this.graphDisplayToolStripMenuItem_Click);
            // 
            // todayToolStripMenuItem
            // 
            this.todayToolStripMenuItem.CheckOnClick = true;
            this.todayToolStripMenuItem.Name = "todayToolStripMenuItem";
            this.todayToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.todayToolStripMenuItem.Text = "Today";
            this.todayToolStripMenuItem.Click += new System.EventHandler(this.graphDisplayToolStripMenuItem_Click);
            // 
            // last6HoursToolStripMenuItem
            // 
            this.last6HoursToolStripMenuItem.CheckOnClick = true;
            this.last6HoursToolStripMenuItem.Name = "last6HoursToolStripMenuItem";
            this.last6HoursToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.last6HoursToolStripMenuItem.Text = "Last 6 Hours";
            this.last6HoursToolStripMenuItem.Click += new System.EventHandler(this.graphDisplayToolStripMenuItem_Click);
            // 
            // lastHourToolStripMenuItem
            // 
            this.lastHourToolStripMenuItem.CheckOnClick = true;
            this.lastHourToolStripMenuItem.Name = "lastHourToolStripMenuItem";
            this.lastHourToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.lastHourToolStripMenuItem.Text = "Last Hour";
            this.lastHourToolStripMenuItem.Click += new System.EventHandler(this.graphDisplayToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Checked = true;
            this.viewToolStripMenuItem.CheckOnClick = true;
            this.viewToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hideSidebarToolStripMenuItem,
            this.hideGraphToolStripMenuItem,
            this.showLifetimeCountsToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // hideSidebarToolStripMenuItem
            // 
            this.hideSidebarToolStripMenuItem.Checked = true;
            this.hideSidebarToolStripMenuItem.CheckOnClick = true;
            this.hideSidebarToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.hideSidebarToolStripMenuItem.Name = "hideSidebarToolStripMenuItem";
            this.hideSidebarToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.hideSidebarToolStripMenuItem.Text = "Show Sidebar";
            this.hideSidebarToolStripMenuItem.Click += new System.EventHandler(this.hideSidebarToolStripMenuItem_Click);
            // 
            // hideGraphToolStripMenuItem
            // 
            this.hideGraphToolStripMenuItem.Checked = true;
            this.hideGraphToolStripMenuItem.CheckOnClick = true;
            this.hideGraphToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.hideGraphToolStripMenuItem.Name = "hideGraphToolStripMenuItem";
            this.hideGraphToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.hideGraphToolStripMenuItem.Text = "Show Graph";
            this.hideGraphToolStripMenuItem.Click += new System.EventHandler(this.hideGraphToolStripMenuItem_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
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
            this.splitContainer1.Size = new System.Drawing.Size(952, 580);
            this.splitContainer1.SplitterDistance = 283;
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 23;
            this.splitContainer1.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitContainer1_SplitterMoved);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.nextSampletoolStripStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 582);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(952, 22);
            this.statusStrip1.TabIndex = 24;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(76, 17);
            this.toolStripStatusLabel1.Text = "Next Sample:";
            // 
            // nextSampletoolStripStatusLabel
            // 
            this.nextSampletoolStripStatusLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextSampletoolStripStatusLabel.Name = "nextSampletoolStripStatusLabel";
            this.nextSampletoolStripStatusLabel.Size = new System.Drawing.Size(68, 17);
            this.nextSampletoolStripStatusLabel.Text = "60 seconds";
            // 
            // showLifetimeCountsToolStripMenuItem
            // 
            this.showLifetimeCountsToolStripMenuItem.CheckOnClick = true;
            this.showLifetimeCountsToolStripMenuItem.Name = "showLifetimeCountsToolStripMenuItem";
            this.showLifetimeCountsToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.showLifetimeCountsToolStripMenuItem.Text = "Show Lifetime Counts";
            this.showLifetimeCountsToolStripMenuItem.Click += new System.EventHandler(this.showLifetimeCountsToolStripMenuItem_Click);
            // 
            // lineCurvesChartType
            // 
            this.lineCurvesChartType.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lineCurvesChartType.BackColor = System.Drawing.Color.White;
            this.lineCurvesChartType.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lineCurvesChartType.Location = new System.Drawing.Point(3, 0);
            this.lineCurvesChartType.Name = "lineCurvesChartType";
            this.lineCurvesChartType.Size = new System.Drawing.Size(668, 577);
            this.lineCurvesChartType.TabIndex = 18;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
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
        private System.Windows.Forms.ToolStripMenuItem graphToolStripMenuItem;
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
        private System.Windows.Forms.ToolStripMenuItem showLifetimeCountsToolStripMenuItem;
    }
}

