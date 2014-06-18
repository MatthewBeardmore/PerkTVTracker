namespace PerkTVTracker
{
    partial class SessionViewControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label_currentCount = new System.Windows.Forms.Label();
            this.label_hourlyRate = new System.Windows.Forms.Label();
            this.pointCount = new System.Windows.Forms.Label();
            this.hourlyRate = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label_currentCount);
            this.groupBox1.Controls.Add(this.label_hourlyRate);
            this.groupBox1.Controls.Add(this.pointCount);
            this.groupBox1.Controls.Add(this.hourlyRate);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.MaximumSize = new System.Drawing.Size(275, 128);
            this.groupBox1.MinimumSize = new System.Drawing.Size(275, 128);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(275, 128);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "email@mail.com";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.DropDownWidth = 105;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Remove",
            "Hide from Graph"});
            this.comboBox1.Location = new System.Drawing.Point(247, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(22, 24);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.SelectionChangeCommitted += new System.EventHandler(this.comboBox1_SelectionChangeCommitted);
            // 
            // label_currentCount
            // 
            this.label_currentCount.AutoSize = true;
            this.label_currentCount.ForeColor = System.Drawing.Color.Black;
            this.label_currentCount.Location = new System.Drawing.Point(6, 19);
            this.label_currentCount.Name = "label_currentCount";
            this.label_currentCount.Size = new System.Drawing.Size(100, 17);
            this.label_currentCount.TabIndex = 1;
            this.label_currentCount.Text = "Current Count:";
            // 
            // label_hourlyRate
            // 
            this.label_hourlyRate.AutoSize = true;
            this.label_hourlyRate.ForeColor = System.Drawing.Color.Black;
            this.label_hourlyRate.Location = new System.Drawing.Point(6, 72);
            this.label_hourlyRate.Name = "label_hourlyRate";
            this.label_hourlyRate.Size = new System.Drawing.Size(153, 17);
            this.label_hourlyRate.TabIndex = 4;
            this.label_hourlyRate.Text = "Estimated Hourly Rate:";
            // 
            // pointCount
            // 
            this.pointCount.AutoSize = true;
            this.pointCount.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pointCount.ForeColor = System.Drawing.Color.Black;
            this.pointCount.Location = new System.Drawing.Point(4, 34);
            this.pointCount.Margin = new System.Windows.Forms.Padding(3, 0, 3, 6);
            this.pointCount.Name = "pointCount";
            this.pointCount.Size = new System.Drawing.Size(267, 32);
            this.pointCount.TabIndex = 0;
            this.pointCount.Text = "12,345 pts (of 12,345)";
            // 
            // hourlyRate
            // 
            this.hourlyRate.AutoSize = true;
            this.hourlyRate.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hourlyRate.ForeColor = System.Drawing.Color.Black;
            this.hourlyRate.Location = new System.Drawing.Point(6, 87);
            this.hourlyRate.Margin = new System.Windows.Forms.Padding(3, 0, 3, 6);
            this.hourlyRate.Name = "hourlyRate";
            this.hourlyRate.Size = new System.Drawing.Size(164, 32);
            this.hourlyRate.TabIndex = 5;
            this.hourlyRate.Text = "321 pts/hour";
            // 
            // SessionViewControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.MaximumSize = new System.Drawing.Size(275, 128);
            this.MinimumSize = new System.Drawing.Size(275, 128);
            this.Name = "SessionViewControl";
            this.Size = new System.Drawing.Size(275, 128);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label_currentCount;
        private System.Windows.Forms.Label label_hourlyRate;
        private System.Windows.Forms.Label pointCount;
        private System.Windows.Forms.Label hourlyRate;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}
