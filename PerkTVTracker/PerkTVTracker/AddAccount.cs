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
                return new Account() { Email = textBox_email.Text, Password = textBox_password.Text };
            }
        }

        public AddAccount()
        {
            InitializeComponent();
        }

        private void button_done_Click(object sender, EventArgs e)
        {
            if (textBox_email.Text == "")
            {
                MessageBox.Show("Fuck off");
                return;
            }
            if(textBox_password.Text == "")
            {
                MessageBox.Show("Youse a dumbass");
                return;
            }
            DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        private void textBox_password_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Return)
            {
                e.Handled = true;
                button_done_Click(sender, e);
            }
        }
    }
}
