using PharmacyPRO;
using PharmacyPRO.Database;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace PharmacyProManager
{
    public partial class Manager : Form
    {
        public Manager()
        {
            InitializeComponent();
        }
        byte Ptype = 0;
        decimal TTprice = 0; 
        private void clear()
        {
            PName.Clear();
            PEXP.Clear();
            PTottal.Clear();
            PCost.Clear();
            PSubS.Clear();
            Pnote.Clear();
        }
        private void ptype()
        {
            if (Ptype == 1)
            {
                comboBox1.Text = "شرب";
            }
            else if (Ptype == 3)
            {
                comboBox1.Text = "حقن";
            }
            else if (Ptype == 2)
            {
                comboBox1.Text = "اقراص";
            }
            else if (Ptype == 4)
            {
                comboBox1.Text = "كريم/مرهم";
            }
            else if (Ptype == 0)
            {
                comboBox1.Text = "اخرى";
            }
            else
            {
                comboBox1.Text = "غير معروف";
            }
        }
        private void tp()
        {
            decimal Tprice = 0;
            Tprice = Convert.ToDecimal(PCost.Text);
            MySqlCommand cmd = new MySqlCommand(MySqlCommandType.SELECT);
            cmd.Select("medlog").Where("Username", PName.Text);
                MySqlReader r = new MySqlReader(cmd);
                if (r.Read())
                {
                    Tprice = r.ReadUInt16("TPrice");
                }
                TTprice += Tprice;
        }
        private void Sell()
        {
            try
            {
                MySqlCommand CMD = new MySqlCommand(MySqlCommandType.INSERT);
                CMD.Insert("medlog")
                    .Insert("Name", PName.Text)
                    .Insert("Count", PTottal.Text)
                    .Insert("SellDate", DateTime.Now.Ticks.ToString())
                    .Insert("TPrice", PCost.Text);
            }
            catch (Exception am)
            {
                MySqlCommand cmd = new MySqlCommand(MySqlCommandType.UPDATE);
                cmd.Update("medics")
                    .Set("Name", PName.Text)
                .Set("Count", Convert.ToInt64(TTprice))
                .Set("TPrice", PCost.Text)
                    .Set("Note", Pnote.Text);
                cmd.Where("Name", PName.Text).Execute();
                Program.SaveException(am);
            }
        }
        private void اضافهموظفجديدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Register reg = new Register();
            reg.Show();
        }

        private void Manager_FormClosing(object sender, FormClosingEventArgs e)
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

        private void عنالبرنامجToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About ab = new About();
            ab.Show();
        }

        private void LogOutB_Click(object sender, EventArgs e)
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

        private void SearchB_Click(object sender, EventArgs e)
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
                if (comboBox1.Text == "شرب")
                {
                    Ptype = 1;
                }
                else if (comboBox1.Text == "اقراص")
                {
                    Ptype = 2;
                }
                else if (comboBox1.Text == "حقن")
                {
                    Ptype = 3;
                }
                else if (comboBox1.Text == "كريم/مرهم")
                {
                    Ptype = 4;
                }
                else if (comboBox1.Text == "اخرى")
                {
                    Ptype = 0;
                }
                MySqlCommand cmd = new MySqlCommand(MySqlCommandType.UPDATE);
                cmd.Update("medics")
                    .Set("Name", PName.Text)
                .Set("Substance", PSubS.Text)
                .Set("Expiry", PEXP.Text)
                .Set("Type", Ptype)
                .Set("Count", PTottal.Text)
                .Set("Price", PCost.Text)
                    .Set("Note", Pnote.Text);
                cmd.Where("Name", PName.Text).Execute();
                MessageBox.Show("تم التحديث");
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
        
        private void اضافهدواءجديدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddMed amd = new AddMed();
            amd.Show();
        }

        private void تغييركلمهالمرورToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePass cp = new ChangePass();
            cp.Show();
        }

        private void DelMed_Click(object sender, EventArgs e)
        {
            try
            {
                new MySqlCommand(MySqlCommandType.DELETE).Delete("medics", "Name", PName.Text).Execute();
                MessageBox.Show("تم حذف الدواء");
            }
            catch (Exception ad)
            {
                MessageBox.Show(ad.ToString());
            }
        }

        private void فتحToolStripMenuItem_Click(object sender, EventArgs e)
        {
            log log = new log();
            log.Show();
        }

        private void حذفToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                new MySqlCommand(MySqlCommandType.CLEAR).Clear("logs").Execute();
                MessageBox.Show("تم حذف سجل الدخول");
            }
            catch (Exception dl)
            {
                Program.SaveException(dl);
            }
        }

        private void غيرمتوفرToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DateLog dl = new DateLog();
            dl.Show();
        }

        private void منتهىالصلاحيهToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EXPEnd ee = new EXPEnd();
            ee.Show();
        }
    }
}
