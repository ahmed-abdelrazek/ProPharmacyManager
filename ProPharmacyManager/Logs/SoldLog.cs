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
using System.ComponentModel;
using System.Threading;
using System.Windows.Forms;
using ProPharmacyManager.Database;

namespace ProPharmacyManager.Logs
{
    public partial class SoldLog : Form
    {
        private decimal ff;
        private decimal ff1;

        public SoldLog()
        {
            InitializeComponent();
        }

        private void SL1()
        {
            MySqlCommand cmd = new MySqlCommand(MySqlCommandType.SELECT);
            cmd.Select("medlog"); //.Where("SellDate", Convert.ToUInt16(DateTime.Now.Day));
            MySqlReader r = new MySqlReader(cmd);
            while (r.Read())
            {
                dd1.Rows.Add(r.ReadString("Name"), r.ReadString("SellDate"), r.ReadString("Cost"));
                ff = Convert.ToDecimal(r.ReadString("Cost"));
                ff1 += ff;
            }
            r.Close();
        }

        private void SoldLog_Load(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            Thread th = new Thread(() =>
            {
                SL1();
                tottal1.Text = "الاجمالى :" + ff1;
            });
            th.Start();
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            toolStripProgressBar1.Value = e.ProgressPercentage;
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            toolStripStatusLabel1.Text = "تم تحميل جميع الادويه المباعه";
        }
    }
}