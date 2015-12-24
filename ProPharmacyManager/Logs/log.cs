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
using System.Threading;
using System.Windows.Forms;
using ProPharmacyManager.Database;

namespace ProPharmacyManager
{
    public partial class log : Form
    {
        public log()
        {
            InitializeComponent();
        }

        private void loginlog()
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand(MySqlCommandType.SELECT);
                cmd.Select("logs").Where("LoginDate", Convert.ToUInt16(DateTime.Now.Day));
                MySqlReader r = new MySqlReader(cmd);
                while (r.Read())
                {
                    logss1.Text += "اسم المستخدم : " + r.ReadString("Account") + "\r\n";
                    logss1.Text += "وقت الدخول : " + r.ReadString("LoginDate");
                    logss1.Text += "\r\n----------------------------------------------\r\n";
                }
                r.Close();
            }
            catch (Exception eee)
            {
                MessageBox.Show(eee.ToString());
            }
            try
            {
                MySqlCommand cmd = new MySqlCommand(MySqlCommandType.SELECT);
                cmd.Select("logs").Where("LoginDate", Convert.ToUInt16(DateTime.Now.Day), false);
                MySqlReader r = new MySqlReader(cmd);
                while (r.Read())
                {
                    logss2.Text += "اسم المستخدم : " + r.ReadString("Account") + "\r\n";
                    logss2.Text += "وقت الدخول : " + r.ReadString("LoginDate");
                    logss2.Text += "\r\n----------------------------------------------\r\n";
                }
                r.Close();
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }
        }

        private void log_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            Thread th = new Thread(loginlog);
            th.Start();
        }
    }
}