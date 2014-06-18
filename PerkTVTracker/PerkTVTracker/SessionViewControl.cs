using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PerkTVTracker
{
    public partial class SessionViewControl : UserControl
    {
        private Account _account;
        private Action<Account, SessionViewControl> _removeAccount;
        private Action _rebuildGraph;
        private bool _initialized = false;

        public SessionViewControl()
        {
            InitializeComponent();
            comboBox1.Visible = false;
            groupBox1.Text = "Total";
            label_hourlyRate.Text = "Total Estimated Hourly Rate";
            label_currentCount.Text = "Total Count";
        }

        public SessionViewControl(Account account, Action<Account, SessionViewControl> removeAccount, Action rebuildGraph)
        {
            InitializeComponent();
            _account = account;
            _removeAccount = removeAccount;
            _rebuildGraph = rebuildGraph;

            groupBox1.Text = _account.Email;

            comboBox1.Items[1] = _account.ShowOnGraph ? "Hide on graph" : "Show on graph";
            comboBox1.SelectedIndex = 0;

            _initialized = true;
        }

        public void UpdateDisplay(DataSummary summary)
        {
            pointCount.Text = summary.PointCount.ToString("#,##0 pts");
            if (summary.LifetimePointCount > 0 && !Program.Settings.HideLifetimePoints)
            {
                pointCount.Text += summary.LifetimePointCount.ToString(" (of #,##0)");
            }

            int hourlyRate = (int)Math.Round(summary.HourlyRate);
            string formattedHourly = hourlyRate.ToString("#,##0");
            this.hourlyRate.Text = string.Format("{0} {1}/hour", formattedHourly, hourlyRate != 1 ? "pts" : "pt");
        }

        private void button_remove_Click(object sender, EventArgs e)
        {
            _removeAccount(_account, this);
        }

        private void button_hideOnGraph_Click(object sender, EventArgs e)
        {
            _account.ShowOnGraph = !_account.ShowOnGraph;
            comboBox1.Items[1] = _account.ShowOnGraph ? "Hide on graph" : "Show on graph";
            _rebuildGraph();
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
                button_remove_Click(sender, e);
            else
                button_hideOnGraph_Click(sender, e);
            comboBox1.SelectedIndex = 0;
        }
    }
}
