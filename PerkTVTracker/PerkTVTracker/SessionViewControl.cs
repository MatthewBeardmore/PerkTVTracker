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

        public SessionViewControl(Account account, Action<Account, SessionViewControl> removeAccount)
        {
            InitializeComponent();
            _account = account;
            _removeAccount = removeAccount;

            groupBox1.Text = _account.Email;
        }

        public void UpdateDisplay(DataSummary summary)
        {
            pointCount.Text = summary.PointCount.ToString("#,##0 points");

            int hourlyRate = (int)Math.Round(summary.HourlyRate);
            string formattedHourly = hourlyRate.ToString("#,##0");
            this.hourlyRate.Text = string.Format("{0} {1}/hour", formattedHourly, hourlyRate != 1 ? "points" : "point");
        }

        private void button_remove_Click(object sender, EventArgs e)
        {
            _removeAccount(_account, this);
        }
    }
}
