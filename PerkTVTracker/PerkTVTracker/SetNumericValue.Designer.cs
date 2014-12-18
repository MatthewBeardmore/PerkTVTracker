namespace PerkTVTracker
{
    partial class SetNumericValue
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SetNumericValue));
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.numericUpDown_threshold = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_amtTime = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox_enableAlert = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_threshold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_amtTime)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Points Dropped:";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(116, 149);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 5;
            this.buttonAdd.Text = "Set";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.OnAddClick);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(197, 149);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 6;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.OnCancelClick);
            // 
            // numericUpDown_threshold
            // 
            this.numericUpDown_threshold.Enabled = false;
            this.numericUpDown_threshold.Location = new System.Drawing.Point(32, 52);
            this.numericUpDown_threshold.Name = "numericUpDown_threshold";
            this.numericUpDown_threshold.Size = new System.Drawing.Size(201, 23);
            this.numericUpDown_threshold.TabIndex = 7;
            // 
            // numericUpDown_amtTime
            // 
            this.numericUpDown_amtTime.Enabled = false;
            this.numericUpDown_amtTime.Location = new System.Drawing.Point(32, 96);
            this.numericUpDown_amtTime.Name = "numericUpDown_amtTime";
            this.numericUpDown_amtTime.Size = new System.Drawing.Size(201, 23);
            this.numericUpDown_amtTime.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Amount of Time:";
            // 
            // checkBox_enableAlert
            // 
            this.checkBox_enableAlert.AutoSize = true;
            this.checkBox_enableAlert.Location = new System.Drawing.Point(12, 12);
            this.checkBox_enableAlert.Name = "checkBox_enableAlert";
            this.checkBox_enableAlert.Size = new System.Drawing.Size(89, 19);
            this.checkBox_enableAlert.TabIndex = 10;
            this.checkBox_enableAlert.Text = "Enable Alert";
            this.checkBox_enableAlert.UseVisualStyleBackColor = true;
            this.checkBox_enableAlert.CheckedChanged += new System.EventHandler(this.checkBox_enableAlert_CheckedChanged);
            // 
            // SetNumericValue
            // 
            this.AcceptButton = this.buttonAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(284, 184);
            this.Controls.Add(this.checkBox_enableAlert);
            this.Controls.Add(this.numericUpDown_amtTime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDown_threshold);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SetNumericValue";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Alert Threshold";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_threshold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_amtTime)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.NumericUpDown numericUpDown_threshold;
        private System.Windows.Forms.NumericUpDown numericUpDown_amtTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox_enableAlert;
    }
}