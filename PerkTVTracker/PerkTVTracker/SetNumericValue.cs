using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PerkTVTracker
{
    public partial class SetNumericValue : Form
    {
        public KeyValuePair<int, int> Value
        {
            get
            {
                if (checkBox_enableAlert.Checked)
                    return new KeyValuePair<int, int>((int)numericUpDown_threshold.Value, (int)numericUpDown_amtTime.Value);
                return new KeyValuePair<int, int>(0, 0);
            }
        }

        public SetNumericValue(int threshold, int time)
        {
            InitializeComponent();
            checkBox_enableAlert.Checked = threshold != 0 && time != 0;
            numericUpDown_threshold.Value = threshold;
            numericUpDown_amtTime.Value = time;
        }

        private void OnAddClick(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void OnCancelClick(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void checkBox_enableAlert_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDown_amtTime.Enabled = numericUpDown_threshold.Enabled = checkBox_enableAlert.Checked;
        }      
    }
}
