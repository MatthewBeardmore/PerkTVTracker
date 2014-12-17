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
    public partial class AddAccount : Form
    {
        public Account Account
        {
            get
            {
                return new Account { Email = textboxEmail.Text, Password = textboxPassword.Text };
            }
        }

        public AddAccount()
        {
            InitializeComponent();
        }

        private void OnAddClick(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textboxEmail.Text))
            {
                MessageBox.Show("Please enter a valid email.",
                                "Invalid information",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(textboxPassword.Text))
            {
                MessageBox.Show("Please enter a valid password.",
                                "Invalid information",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void OnCancelClick(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }        
    }
}
