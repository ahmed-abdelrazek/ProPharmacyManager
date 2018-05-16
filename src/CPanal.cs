using PharmacyProManager.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PharmacyProManager
{
    public partial class CPanal : Form
    {
        public CPanal()
        {
            InitializeComponent();
        }

        byte Ptype = 0;
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
        private void ptype()
        {
            if (Ptype == 1)
            {

                PType.Text = "شرب";
            }
            else if (Ptype == 3)
            {
                
                PType.Text = "حقن";
            }
            else if (Ptype == 2)
            {
                
                PType.Text = "اقراص";
            }
            else if (Ptype == 4)
            {
                
                PType.Text = "كريم/مرهم";
            }
            else if (Ptype == 0)
            {

                PType.Text = "اخرى";
            }
            else
            {
                PType.Text = "غير معروف";
            }
        }
        private void CPanal_FormClosing(object sender, FormClosingEventArgs e)
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
                e.Cancel = true;
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
                    PCost.Text = r.ReadUInt32("Price").ToString();
                    PEXP.Text = r.ReadString("Expiry").ToString();
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

        private void CPanal_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            About ab = new About();
            ab.ShowDialog();
        }
    }
}
