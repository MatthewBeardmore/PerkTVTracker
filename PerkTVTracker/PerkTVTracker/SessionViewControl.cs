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

        public SessionViewControl(Account account, Action<Account, SessionViewControl> removeAccount, Action rebuildGraph)
        {
            InitializeComponent();
            _account = account;
            _removeAccount = removeAccount;
            _rebuildGraph = rebuildGraph;

            groupBox1.Text = _account.Email;

            button_hideOnGraph.Text = _account.ShowOnGraph ? "Hide on graph" : "Show on graph";
        }

        public void UpdateDisplay(DataSummary summary)
        {
            pointCount.Text = summary.PointCount.ToString("#,##0 points");
            label_lifetimePointCount.Text = summary.LifetimePointCount.ToString("#,##0 points");

            int hourlyRate = (int)Math.Round(summary.HourlyRate);
            string formattedHourly = hourlyRate.ToString("#,##0");
            this.hourlyRate.Text = string.Format("{0} {1}/hour", formattedHourly, hourlyRate != 1 ? "points" : "point");
        }

        private void button_remove_Click(object sender, EventArgs e)
        {
            _removeAccount(_account, this);
        }

        private void button_hideOnGraph_Click(object sender, EventArgs e)
        {
            _account.ShowOnGraph = !_account.ShowOnGraph;
            button_hideOnGraph.Text = _account.ShowOnGraph ? "Hide on graph" : "Show on graph";
            _rebuildGraph();
        }
    }
}
