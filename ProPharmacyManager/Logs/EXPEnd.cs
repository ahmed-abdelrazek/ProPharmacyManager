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
    public partial class EXPEnd : Form
    {
        public EXPEnd()
        {
            InitializeComponent();
        }

        private void endexp()
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand(MySqlCommandType.SELECT);
                cmd.Select("medics").Where("Expiry", Convert.ToUInt16(DateTime.Now.Month), false);
                MySqlReader r = new MySqlReader(cmd);
                while (r.Read())
                {
                    dataGridView1.Rows.Add(r.ReadString("Name"), r.ReadString("Expiry"), r.ReadString("Count"));
                }
                r.Close();
            }
            catch (Exception eee)
            {
                MessageBox.Show(eee.ToString());
            }
        }

        private void EXPEnd_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            Thread th = new Thread(endexp);
            th.Start();
        }
    }
}