using PharmacyProManager.Database;
using System;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace PharmacyProManager
{
    public partial class CPanal : Form
    {
        public CPanal(string UserName)
        {
            InitializeComponent();
            label11.Text = UserName;
        }

        decimal ff = 0;
        decimal ff1 = 0;
        decimal tt = 0;
        decimal tt1 = 0;
        byte Ptype = 0;

        private void newbill()
        {
            try
            {
                ulong nb = 0;
                nb = Convert.ToUInt64(BillNO.Text);
                nb = ++nb;
                BillNO.Text = nb.ToString();
                StringBuilder Command = new StringBuilder();
                Command.Append(PName.Text + "~");
                Command.Append(PCost.Text + "#");
                MySqlCommand Cmd = new MySqlCommand(MySqlCommandType.INSERT);
                Cmd.Insert("bills").Insert("ID", BillNO.Text).Insert("Name", Client.Text).Insert("User", label11.Text).Insert("Medic", Command.ToString()).Insert("BillDate", DateTime.Now.ToString()).Execute();
            }
            catch (Exception ee)
            {
                Program.SaveException(ee);
            }
        }
        private void LoadBill()
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand(MySqlCommandType.SELECT).Select("bills").Where("Name", Client.Text).And("ID", BillNO.Text);
                MySqlReader r = new MySqlReader(cmd);
                if (r.Read())
                {
                    bu.Text = r.ReadString("Medic");
                }
                r.Close();
            }
            catch (Exception ee)
            {
                Program.SaveException(ee);
            }
        }
        private void updatebill()
        {
            LoadBill();
            try
            {
                StringBuilder Command = new StringBuilder();
                Command.Append(PName.Text + "~");
                Command.Append(PCost.Text + "#");
                bu.Text += Command;
                MySqlCommand Cmd = new MySqlCommand(MySqlCommandType.UPDATE);
                Cmd.Update("bills").Set("Medic", bu.Text).Where("ID", BillNO.Text).And("Name", Client.Text);
                Cmd.Execute();
            }
            catch (Exception ee)
            {
                Program.SaveException(ee);
            }
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
                if (tottal > 0 )
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
                    .Insert("Name", PName.Text)/*.Insert("Total", "1")*/.Insert("Cost", PCost.Text).Insert("SellDate", DateTime.Now.ToString()).Execute();
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
        private void IL()
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand(MySqlCommandType.SELECT);
                cmd.Select("medics").Where("Count", 0, true);
                MySqlReader r = new MySqlReader(cmd);
                while (r.Read())
                {
                    ff = Convert.ToDecimal(r.ReadString("Price"));
                    tt = Convert.ToDecimal(r.ReadString("Count"));
                    ff1 += ff;
                    tt1 += tt;
                    totalprice.Text = "اجمالى سعر الموجود :" + Convert.ToDecimal(ff1) * Convert.ToDecimal(tt1) + "جنيه";
                    dataGridView1.Rows.Add(r.ReadString("Name"), r.ReadString("Price"), r.ReadString("Expiry"), r.ReadString("Count"), r.ReadString("Substance"), r.ReadString("Note"));
                }
                r.Close();
            }
            catch (Exception ee)
            {
                Program.SaveException(ee);
            }
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

            if (PName.Text != "" && Client.Text != "" && NewBill.Checked)
            {
                SellMedic();
                newbill();
            }
            else if (PName.Text != "" && Client.Text != "" && !NewBill.Checked)
            {
                SellMedic();
                updatebill();
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
            MySqlCommand cmd = new MySqlCommand(MySqlCommandType.SELECT);
            cmd.Select("configuration");
            MySqlReader r = new MySqlReader(cmd);
            if (r.Read())
            {
                BillNO.Text = r.ReadUInt32("ID").ToString();
            }
            r.Close();
            CheckForIllegalCrossThreadCalls = false;
            Thread th = new Thread(() =>
            {
                IL();
            });
            th.Start();
        }

        private void BillNO_TextChanged(object sender, EventArgs e)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand(MySqlCommandType.UPDATE);
                cmd.Update("configuration")
                    .Set("ID", BillNO.Text).Execute();
            }
            catch (Exception el)
            {
                Program.SaveException(el);
            }
        }
    }
}
