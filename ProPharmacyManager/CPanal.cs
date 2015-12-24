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
using ProPharmacyManager.Database;
using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace ProPharmacyManager
{
    public partial class CPanal : Form
    {
        public CPanal()
        {
            InitializeComponent();
        }

        private void SellMedic()
        {
            uint tottal = 0;
            try
            {
                MySqlCommand cmd = new MySqlCommand(MySqlCommandType.SELECT);
                cmd.Select("medics").Where("Name", PName.Text).Execute();
                MySqlReader r = new MySqlReader(cmd);
                if (r.Read())
                {
                    tottal = r.ReadUInt32("Count");
                }
                if (tottal > 0)
                {
                    tottal = --tottal;
                    PTottal.Clear();
                    PTottal.Text = tottal.ToString();
                    MySqlCommand CMD = new MySqlCommand(MySqlCommandType.UPDATE);
                    CMD.Update("medics")
                        .Set("Count", tottal);
                    CMD.Where("Name", PName.Text).Execute();
                    MessageBox.Show("تم بيع واحد");
                    SaveSold();
                }
                else
                {
                    MessageBox.Show("الدواء غير متوفر");
                }

            }
            catch (Exception ep)
            {
                MessageBox.Show(ep.ToString());
            }
        }

        private void SaveSold()
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand(MySqlCommandType.INSERT);
                cmd.Insert("medlog")
                    .Insert("Name", PName.Text) /*.Insert("Total", "1")*/
                    .Insert("Cost", PCost.Text)
                    .Insert("SellDate", DateTime.Now.ToString())
                    .Execute();
            }
            catch (Exception e)
            {
                Program.SaveException(e);
            }
        }

        private void clear()
        {
            PName.Clear();
            PEXP.Clear();
            PType.Clear();
            PTottal.Clear();
            PCost.Clear();
            PSubS.Clear();
            Pnote.Clear();
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
                    dataGridView1.Rows.Add(r.ReadString("Name"), r.ReadString("Price"), r.ReadString("Expiry"),
                        r.ReadString("Count"), r.ReadString("Substance"), r.ReadString("Note"));
                    pp += ff * tt;
                }
                r.Close();
                totalprice.Text = "اجمالى سعر الموجود :" + Convert.ToDecimal(pp) + " جنيه";
            }
            catch (Exception ee)
            {
                Program.SaveException(ee);
            }
        }

        private void CPanal_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("هل انت متاكد؟", "تسجيل الخروج", MessageBoxButtons.YesNo);
            switch (dialogResult)
            {
                case DialogResult.Yes:
                {
                    Login lg = new Login();
                    lg.Show();
                    this.Hide();
                }
                    break;
                case DialogResult.No:
                    e.Cancel = true;
                    break;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("هل انت متاكد؟", "تسجيل الخروج", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Login lg = new Login();
                lg.Show();
                this.Hide();
            }
            else if (dialogResult == DialogResult.No)
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clear();
            try
            {
                MySqlCommand cmd = new MySqlCommand(MySqlCommandType.SELECT);
                cmd.Select("medics").Where("Name", SearchT.Text).Execute();
                MySqlReader r = new MySqlReader(cmd);
                if (r.Read())
                {
                    PName.Text = r.ReadString("Name");
                    PSubS.Text = r.ReadString("Substance");
                    Ptype = r.ReadByte("Type");
                    PTottal.Text = r.ReadUInt32("Count").ToString();
                    PCost.Text = r.ReadString("Price");
                    PEXP.Text = r.ReadString("Expiry");
                    Pnote.Text = r.ReadString("Note");
                    ptype();
                    FP.ForeColor = Color.Green;
                    FP.Text = "وجد الدواء";
                    FP.Visible = true;
                }
                else
                {
                    FP.ForeColor = Color.Red;
                    FP.Text = "لم يعثر على شئ";
                    FP.Visible = true;
                }
            }
            catch (Exception ef)
            {
                MessageBox.Show(ef.ToString());
                Program.SaveException(ef);
            }
        }

        private void UPdateB_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand(MySqlCommandType.UPDATE);
                cmd.Update("medics")
                    .Set("Note", Pnote.Text);
                cmd.Where("Name", PName.Text).Execute();
            }
            catch (Exception el)
            {
                MessageBox.Show(el.ToString());
                Program.SaveException(el);
            }
        }

        private void SellB_Click(object sender, EventArgs e)
        {
            BillsTable.Client = Client.Text;
            BillsTable.MName = PName.Text;
            BillsTable.MCost = Convert.ToDecimal(PCost.Text);
            if (PName.Text != "" && Client.Text != "" && NewBill.Checked)
            {
                SellMedic();
                BillsTable.newbill();
                BillNO.Text = BillsTable.BillNO.ToString();
            }
            else if (PName.Text != "" && Client.Text != "" && !NewBill.Checked)
            {
                SellMedic();
                BillsTable.updatebill();
            }
            else if (Client.Text == "")
            {
                MessageBox.Show("ادخل اسم المشترى");
            }
            else
            {
                MessageBox.Show("الدواء غير متوفر");
            }
        }

        private void CPanal_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            About ab = new About();
            ab.ShowDialog();
        }

        private void CPanal_Load(object sender, EventArgs e)
        {
            label11.Text = AccountsTable.UserName;
            BillNO.Text = BillsTable.BillNO.ToString();
            CheckForIllegalCrossThreadCalls = false;
            Thread th = new Thread(IL);
            th.Start();
        }

        private void BillNO_TextChanged(object sender, EventArgs e)
        {
            BillNO.Text = BillsTable.BillNO.ToString();
        }

        private void SearchT_TextChanged(object sender, EventArgs e)
        {
            if (SearchT.DroppedDown == false && SearchT.Text != "")
            {
                SearchT.DroppedDown = true;

                try
                {
                    MySqlCommand cmd = new MySqlCommand(MySqlCommandType.SELECT)
                    {
                        Command = "select * from medics WHERE Name LIKE '%" + SearchT.Text + "%'"
                    };
                    MySqlReader r = new MySqlReader(cmd);
                    while (r.Read())
                    {
                        SearchT.Items.Add(r.ReadString("Name"));
                    }
                }
                catch (Exception ef)
                {
                    Program.SaveException(ef);
                }
            }
            else
            {
                SearchT.DroppedDown = false;
            }
        }
    }
}
