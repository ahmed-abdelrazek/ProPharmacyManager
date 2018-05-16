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
using System.Drawing;
using System.Windows.Forms;
using ProPharmacyManager.Database;
using ProPharmacyManager.Kernel;
using ProPharmacyManager.Logs;
using System.Diagnostics;
using System.Runtime.InteropServices;


namespace ProPharmacyManager
{
    public partial class Manager : Form
    {
        public Manager()
        {
            InitializeComponent();
        }
        #region movable form
        [DllImportAttribute("user32.dll")]
        /// <summary>
        ///     catch the mouse clicks
        /// </summary>
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int LPAR);
        [DllImportAttribute("user32.dll")]
        /// <summary>
        ///     make form move
        /// </summary>
        public static extern bool ReleaseCapture();
        const int WM_NCLBUTTONDOWN = 0xA1;
        const int HT_CAPTION = 0x2;  //this indicates that the action takes place on the title bar

        private void move_window(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        private void Manager_MouseDown(object sender, MouseEventArgs e)
        {
            this.MouseDown += new MouseEventHandler(move_window);
        }
        #endregion
        private void clear()
        {
            PName.Clear();
            PEXP.Clear();
            PTottal.Clear();
            PCost.Clear();
            PSubS.Clear();
            Pnote.Clear();
        }

        private bool SellCom = false;
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
                    SellCom = true;
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

        private void اضافهموظفجديدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Register reg = new Register();
            reg.ShowDialog();
        }

        private void Manager_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("هل انت متاكد؟", "تسجيل الخروج", MessageBoxButtons.YesNo);
            switch (dialogResult)
            {
                case DialogResult.Yes:
                    {
                        Login lg = new Login();
                        lg.Show();
                        Hide();
                    }
                    break;
                case DialogResult.No:
                    e.Cancel = true;
                    break;
            }
        }

        private void عنالبرنامجToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About ab = new About();
            ab.ShowDialog();
        }

        private void LogOutB_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("هل انت متاكد؟", "تسجيل الخروج", MessageBoxButtons.YesNo);
            switch (dialogResult)
            {
                case DialogResult.Yes:
                    {
                        Login lg = new Login();
                        lg.Show();
                        Hide();
                    }
                    break;
                case DialogResult.No:
                    break;
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
                Program.SaveException(ef);
            }
        }

        private void UPdateB_Click(object sender, EventArgs e)
        {
            try
            {
                switch (comboBox1.Text)
                {
                    case "شرب":
                        Ptype = 1;
                        break;
                    case "اقراص":
                        Ptype = 2;
                        break;
                    case "حقن":
                        Ptype = 3;
                        break;
                    case "كريم/مرهم":
                        Ptype = 4;
                        break;
                    case "اخرى":
                        Ptype = 0;
                        break;
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
                if (SellCom != true) return;
                BillsTable.newbill();
                try
                {
                    MySqlCommand cmd = new MySqlCommand(MySqlCommandType.SELECT).Select("bills").Order("ID");
                    MySqlReader r = new MySqlReader(cmd);
                    if (r.Read())
                    {
                        BillNO.Text = r.ReadString("ID");
                    }
                    r.Close();
                    SellCom = false;
                }
                catch (Exception el)
                {
                    Program.SaveException(el);
                }
            }
            else if (PName.Text != "" && Client.Text != "" && !NewBill.Checked)
            {
                SellMedic();
                if (SellCom == false) return;
                BillsTable.updatebill();
                SellCom = false;
            }
            else if (PName.Text == "" || PCost.Text == "")
            {
                MessageBox.Show("لا يوجد دواء");
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

        private void اضافهدواءجديدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddMed amd = new AddMed();
            amd.Show();
        }

        private void تغييركلمهالمرورToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePass cp = new ChangePass();
            cp.ShowDialog();
        }

        private void DelMed_Click(object sender, EventArgs e)
        {
            try
            {
                new MySqlCommand(MySqlCommandType.DELETE).Delete("medics", "Name", PName.Text).Execute();
                clear();
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
            log.ShowDialog();
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
            countLog dl = new countLog();
            dl.ShowDialog();
        }

        private void منتهىالصلاحيهToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EXPEnd ee = new EXPEnd();
            ee.ShowDialog();
        }

        private void PTottal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            // only allow one decimal point
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void PCost_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            // only allow one decimal point
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void فتحToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SoldLog sl = new SoldLog();
            sl.ShowDialog();
        }

        private void حذفToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new MySqlCommand(MySqlCommandType.CLEAR).Clear("medlog").Execute();
            MessageBox.Show("تم حذف سجل المبيعات");
        }

        private void قاعدهالبياناتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Setup set = new Setup();
            Program.IsUpgrading = false;
            set.ShowDialog();
        }

        private void الدواءالمتوفرToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InvLog il = new InvLog();
            il.ShowDialog();
        }

        private void فتحToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            BillsLogs bl = new BillsLogs();
            bl.ShowDialog();
        }

        private void حذفToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            new MySqlCommand(MySqlCommandType.CLEAR).Clear("bills").Execute();
            MessageBox.Show("تم حذف الفواتير");
        }

        private void BillNO_TextChanged(object sender, EventArgs e)
        {
            BillNO.Text = BillsTable.BillNO.ToString();
        }

        private void Manager_Load(object sender, EventArgs e)
        {
            BillNO.Text = BillsTable.BillNO.ToString();
        }

        private void المساعدهToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help help = new Help();
            help.ShowDialog();
        }

        private void Manager_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            About ab = new About();
            ab.ShowDialog();
        }

        private void نسخاحتياطىToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BAR backrest = new BAR();
            backrest.ShowDialog();
        }

        private void comboBox2_TextChanged(object sender, EventArgs e)
        {
            if (SearchT.DroppedDown == false)
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
            else if (SearchT.Text == "" && SearchT.DroppedDown == true)
            {
                this.Focus();
            }
        }

        private void Minim_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void OUT_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ماالجديدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("New.txt");
        }

        /// <summary>
        ///     make background image show with right to left layout
        /// </summary>
        protected override void OnPaintBackground(PaintEventArgs e)
        {
            Rectangle rc = new Rectangle(Point.Empty, this.ClientSize);
            e.Graphics.DrawImage(ProPharmacyManager.Properties.Resources.PHBack, rc);
        }
        /// <summary>
        ///     type welcome massage
        /// </summary>
        protected override void OnPaint(PaintEventArgs e)
        {
            SolidBrush penco = new SolidBrush(Color.Honeydew);
            Font font = new Font("Arial", 15);
            Graphics g = e.Graphics;
            string welcome = ("أهلا بك يا");
            PointF point1 = new PointF(710, 88);
            g.DrawString(welcome, font, penco, point1);
            string welcomeuser = AccountsTable.UserName;
            PointF point2 = new PointF(710, 110);
            g.DrawString(welcomeuser, font, penco, point2);

        }

    }
}