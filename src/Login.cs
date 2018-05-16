using ProPharmacyManager.Database;
using System;
using System.Windows.Forms;
using System.Globalization;
using System.Resources;

namespace ProPharmacyManager
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        
        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("هل انت متاكد؟", "الخروج", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Environment.Exit(0);
            }
            else if (dialogResult == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void Login_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            About ab = new About();
            ab.ShowDialog();
        }

        private void LoginB_Click_1(object sender, EventArgs e)
        {
            if (UN.Text == "")
            {
                MessageBox.Show("لم تدخل اسم المستخدم");
            }
            else if (UP.Text == "")
            {
                MessageBox.Show("لم تدخل كلمه المرور");
            }
            else
            {
                AccountsTable.UserName = UN.Text;
                AccountsTable.UserPassword = UP.Text;
                if (AccountsTable.UserLogin() == true)
                {
                    this.Hide();
                }
            }
        }

        private void ExitB_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("هل انت متاكد؟", "الخروج", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Environment.Exit(0);
            }
        }

    }
}
