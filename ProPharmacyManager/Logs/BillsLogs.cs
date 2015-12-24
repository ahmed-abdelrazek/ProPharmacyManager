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
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using ProPharmacyManager.Database;

namespace ProPharmacyManager.Logs
{
    public partial class BillsLogs : Form
    {
        public BillsLogs()
        {
            InitializeComponent();
        }

        private void nb()
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand(MySqlCommandType.SELECT).Select("bills").Order("ID", true);
                MySqlReader r = new MySqlReader(cmd);
                while (r.Read())
                {
                    listBox1.Items.Add(r.ReadString("ID") /* + " || " + r.ReadString("Name")*/);
                }
                r.Close();
            }
            catch (Exception ee)
            {
                Program.SaveException(ee);
            }
        }

        private void BillsLogs_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            Thread th = new Thread(nb);
            th.Start();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            decimal TP = 0;
            MySqlCommand cmd = new MySqlCommand(MySqlCommandType.SELECT).Select("bills")
                .Where("ID", listBox1.GetItemText(listBox1.SelectedItem));
            MySqlReader r = new MySqlReader(cmd);
            while (r.Read())
            {
                textBox1.Clear();
                string AllBills = r.ReadString("Medic");
                textBox1.Text += "رقم الفاتورة : " + r.ReadString("ID") + "\r\n";
                textBox1.Text += "الموظف : " + r.ReadString("User") + "\r\n";
                textBox1.Text += "المشترى : " + r.ReadString("Name") + "\r\n";
                textBox1.Text += "وقت البيع : " + r.ReadString("BillDate") + "\r\n";
                textBox1.Text += "----الادويه---------------------------------\r\n";
                string[] bills = AllBills.Split('#');
                foreach (string[] BillInfo in bills.TakeWhile(bill => bill.Length >= 2).Select(bill => bill.Split('~')))
                {
                    textBox1.Text += "الاسم : " + Convert.ToString(BillInfo[0]) + "  \t";
                    textBox1.Text += "السعر : " + Convert.ToDecimal(BillInfo[1]) + "\r\n";
                    TP += Convert.ToDecimal(BillInfo[1]);
                }
                textBox1.Text += "--------------------------------------------\r\n";
                textBox1.Text += "الاجمالى = " + TP;
                textBox1.Text += "\r\n--------------------------------------------\r\n";
            }
            r.Close();
        }
    }
}