// <copyright>
//     Copyright (C) 2013 ShababConquer Blog.
//     This program is free software; you can redistribute it and/or modify 
//     it under the terms of the GNU General Public License version 2 as 
//     published by the Free Software Foundation.
// 
//     This program is distributed in the hope that it will be useful, but 
//     WITHOUT ANY WARRANTY; without even the implied warranty of MERCHANTABILITY 
//     or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU General Public License 
//     for more details.
// 
//     You should have received a copy of the GNU General Public License along 
//     with this program; if not, write to the Free Software Foundation, Inc., 
//     51 Franklin Street, Fifth Floor, Boston, MA  02110-1301, USA.
// </copyright>

using System;
using System.Windows.Forms;
using ProPharmacyManager.Database;
using System.Runtime.InteropServices;

namespace ProPharmacyManager
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        #region movable form
        [DllImportAttribute("user32.dll")]
        /// <summary>
        ///     catch the mouse clicks
        /// </summary>
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int LPAR);
        [DllImportAttribute("user32.dll")]
        /// <summary>
        ///     make form move
        /// </summary>
        public static extern bool ReleaseCapture();
        const int WM_NCLBUTTONDOWN = 0xA1;
        const int HT_CAPTION = 0x2;  //this indicates that the action takes place on the title bar

        private void move_window(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            this.MouseDown += new MouseEventHandler(move_window);
        }
        #endregion
        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("هل انت متاكد؟", "الخروج", MessageBoxButtons.YesNo);
            switch (dialogResult)
            {
                case DialogResult.Yes:
                    Environment.Exit(0);
                    break;
                case DialogResult.No:
                    e.Cancel = true;
                    break;
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
                AccountsTable.UserPassword = Program.GetSHAHashData(UP.Text);
                if (AccountsTable.UserLogin())
                {
                    this.Hide();
                }
                else
                {
                    UP.Focus();
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

        private void CloseB_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void MinB_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

    }
}