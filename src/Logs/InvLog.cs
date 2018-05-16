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

namespace ProPharmacyManager.Logs
{
    public partial class InvLog : Form
    {

        public InvLog()
        {
            InitializeComponent();
        }

        private decimal pp = 0;
        private void IL()
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand(MySqlCommandType.SELECT);
                cmd.Select("medics").Where("Count", 0, true);
                MySqlReader r = new MySqlReader(cmd);
                while (r.Read())
                {
                    decimal tt, ff = 0;
                    ff = Convert.ToDecimal(r.ReadString("Price"));
                    tt = Convert.ToDecimal(r.ReadString("Count"));                  
                    DGV.Rows.Add(r.ReadString("Name"), r.ReadString("Price"), r.ReadString("Count"), r.ReadString("Expiry"));
                    pp += ff * tt;
                }
                totalprice.Text = "اجمالى سعر الموجود :" + Convert.ToDecimal(pp) + "جنيه";
                r.Close();
            }
            catch (Exception ee)
            {
                Program.SaveException(ee);
            }
        }

        private void InvLog_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            Thread th = new Thread(IL);
            th.Start();
        }
    }
}