﻿namespace PerkTVTracker
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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label_currentCount = new System.Windows.Forms.Label();
            this.hourlyRate = new System.Windows.Forms.Label();
            this.label_hourlyRate = new System.Windows.Forms.Label();
            this.pointCount = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(this.tableLayoutPanel2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(237, 112);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "email@mail.com";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.label_currentCount, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.hourlyRate, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.label_hourlyRate, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.pointCount, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.comboBox1, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(2, 18);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(233, 92);
            this.tableLayoutPanel2.TabIndex = 8;
            // 
            // label_currentCount
            // 
            this.label_currentCount.AutoSize = true;
            this.label_currentCount.ForeColor = System.Drawing.Color.Black;
            this.label_currentCount.Location = new System.Drawing.Point(2, 0);
            this.label_currentCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_currentCount.Name = "label_currentCount";
            this.label_currentCount.Size = new System.Drawing.Size(86, 15);
            this.label_currentCount.TabIndex = 1;
            this.label_currentCount.Text = "Current Count:";
            // 
            // hourlyRate
            // 
            this.hourlyRate.AutoSize = true;
            this.hourlyRate.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hourlyRate.ForeColor = System.Drawing.Color.Black;
            this.hourlyRate.Location = new System.Drawing.Point(2, 61);
            this.hourlyRate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 6);
            this.hourlyRate.Name = "hourlyRate";
            this.hourlyRate.Size = new System.Drawing.Size(128, 25);
            this.hourlyRate.TabIndex = 5;
            this.hourlyRate.Text = "321 pts/hour";
            // 
            // label_hourlyRate
            // 
            this.label_hourlyRate.AutoSize = true;
            this.label_hourlyRate.ForeColor = System.Drawing.Color.Black;
            this.label_hourlyRate.Location = new System.Drawing.Point(2, 46);
            this.label_hourlyRate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_hourlyRate.Name = "label_hourlyRate";
            this.label_hourlyRate.Size = new System.Drawing.Size(127, 15);
            this.label_hourlyRate.TabIndex = 4;
            this.label_hourlyRate.Text = "Estimated Hourly Rate:";
            // 
            // pointCount
            // 
            this.pointCount.AutoSize = true;
            this.pointCount.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pointCount.ForeColor = System.Drawing.Color.Black;
            this.pointCount.Location = new System.Drawing.Point(2, 15);
            this.pointCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 6);
            this.pointCount.Name = "pointCount";
            this.pointCount.Size = new System.Drawing.Size(207, 25);
            this.pointCount.TabIndex = 0;
            this.pointCount.Text = "12,345 pts (of 12,345)";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.DropDownWidth = 105;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Remove",
            "Hide from Graph"});
            this.comboBox1.Location = new System.Drawing.Point(213, 2);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.tableLayoutPanel2.SetRowSpan(this.comboBox1, 2);
            this.comboBox1.Size = new System.Drawing.Size(18, 23);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.SelectionChangeCommitted += new System.EventHandler(this.comboBox1_SelectionChangeCommitted);
            // 
            // SessionViewControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SessionViewControl";
            this.Size = new System.Drawing.Size(237, 112);
            this.SizeChanged += new System.EventHandler(this.SessionViewControl_SizeChanged);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label_currentCount;
        private System.Windows.Forms.Label label_hourlyRate;
        private System.Windows.Forms.Label hourlyRate;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label pointCount;
    }
}
