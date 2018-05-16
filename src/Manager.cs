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
                    PType.Text = r.ReadUInt32("Type").ToString();
                    PTottal.Text = r.ReadUInt32("Count").ToString();
                    PCost.Text = r.ReadUInt32("Price").ToString();
                    PEXP.Text = r.ReadString("Expiry").ToString();
                    Pnote.Text = r.ReadString("Note");
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
                    .Set("Name", PName.Text)
                .Set("Substance", PSubS.Text)
                //.Set("Expiry", PEXP.Text)
                .Set("Type", PType.Text)
                .Set("Count", PTottal.Text)
                .Set("Price", PCost.Text)
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

        private void سجلالدخولToolStripMenuItem_Click(object sender, EventArgs e)
        {
            log log = new log();
            log.Show();
        }

        private void اضافهدواءجديدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddMed amd = new AddMed();
            amd.Show();
        }
    }
}
