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
    public partial class SetSampleAgeLimitDialog : Form
    {
        public SetSampleAgeLimitDialog()
        {
            InitializeComponent();
        }

        public TimeSpan SampleAgeLimit
        {
            get { return new TimeSpan(0, int.Parse(textBox1.Text), 0); }
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
