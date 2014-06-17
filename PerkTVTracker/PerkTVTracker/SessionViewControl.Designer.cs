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
            this.button_hideOnGraph = new System.Windows.Forms.Button();
            this.button_remove = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pointCount = new System.Windows.Forms.Label();
            this.hourlyRate = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_lifetimePointCount = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label_lifetimePointCount);
            this.groupBox1.Controls.Add(this.button_hideOnGraph);
            this.groupBox1.Controls.Add(this.button_remove);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.pointCount);
            this.groupBox1.Controls.Add(this.hourlyRate);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(275, 212);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "email@mail.com";
            // 
            // button_hideOnGraph
            // 
            this.button_hideOnGraph.BackColor = System.Drawing.SystemColors.Control;
            this.button_hideOnGraph.ForeColor = System.Drawing.Color.Black;
            this.button_hideOnGraph.Location = new System.Drawing.Point(9, 181);
            this.button_hideOnGraph.Name = "button_hideOnGraph";
            this.button_hideOnGraph.Size = new System.Drawing.Size(119, 23);
            this.button_hideOnGraph.TabIndex = 7;
            this.button_hideOnGraph.Text = "Hide on graph";
            this.button_hideOnGraph.UseVisualStyleBackColor = false;
            this.button_hideOnGraph.Click += new System.EventHandler(this.button_hideOnGraph_Click);
            // 
            // button_remove
            // 
            this.button_remove.BackColor = System.Drawing.SystemColors.Control;
            this.button_remove.ForeColor = System.Drawing.Color.Black;
            this.button_remove.Location = new System.Drawing.Point(246, 13);
            this.button_remove.Name = "button_remove";
            this.button_remove.Size = new System.Drawing.Size(23, 23);
            this.button_remove.TabIndex = 6;
            this.button_remove.Text = "X";
            this.button_remove.UseVisualStyleBackColor = false;
            this.button_remove.Click += new System.EventHandler(this.button_remove_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Current Count:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(6, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Estimated Hourly Rate:";
            // 
            // pointCount
            // 
            this.pointCount.AutoSize = true;
            this.pointCount.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pointCount.ForeColor = System.Drawing.Color.Black;
            this.pointCount.Location = new System.Drawing.Point(4, 34);
            this.pointCount.Margin = new System.Windows.Forms.Padding(3, 0, 3, 6);
            this.pointCount.Name = "pointCount";
            this.pointCount.Size = new System.Drawing.Size(171, 32);
            this.pointCount.TabIndex = 0;
            this.pointCount.Text = "12,345 points";
            // 
            // hourlyRate
            // 
            this.hourlyRate.AutoSize = true;
            this.hourlyRate.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hourlyRate.ForeColor = System.Drawing.Color.Black;
            this.hourlyRate.Location = new System.Drawing.Point(6, 140);
            this.hourlyRate.Margin = new System.Windows.Forms.Padding(3, 0, 3, 6);
            this.hourlyRate.Name = "hourlyRate";
            this.hourlyRate.Size = new System.Drawing.Size(201, 32);
            this.hourlyRate.TabIndex = 5;
            this.hourlyRate.Text = "321 points/hour";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(7, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Lifetime Point Count:";
            // 
            // label_lifetimePointCount
            // 
            this.label_lifetimePointCount.AutoSize = true;
            this.label_lifetimePointCount.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_lifetimePointCount.ForeColor = System.Drawing.Color.Black;
            this.label_lifetimePointCount.Location = new System.Drawing.Point(5, 87);
            this.label_lifetimePointCount.Margin = new System.Windows.Forms.Padding(3, 0, 3, 6);
            this.label_lifetimePointCount.Name = "label_lifetimePointCount";
            this.label_lifetimePointCount.Size = new System.Drawing.Size(171, 32);
            this.label_lifetimePointCount.TabIndex = 8;
            this.label_lifetimePointCount.Text = "12,345 points";
            // 
            // SessionViewControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "SessionViewControl";
            this.Size = new System.Drawing.Size(275, 212);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label pointCount;
        private System.Windows.Forms.Label hourlyRate;
        private System.Windows.Forms.Button button_remove;
        private System.Windows.Forms.Button button_hideOnGraph;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_lifetimePointCount;
    }
}