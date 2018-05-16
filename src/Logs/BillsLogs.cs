using PharmacyProManager.Database;
using System;
using System.Threading;
using System.Windows.Forms;

namespace PharmacyProManager.Logs
{
    public partial class BillsLogs : Form
    {
        public BillsLogs()
        {
            InitializeComponent();
        }
        private void lb()
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand(MySqlCommandType.SELECT).Select("bills");
                MySqlReader r = new MySqlReader(cmd);
                string AllSkills = "";
                while (r.Read())
                {
                    AllSkills = r.ReadString("Medic");
                    textBox1.Text += "رقم الفاتورة : " + r.ReadString("ID") + "\r\n";
                    textBox1.Text += "الموظف : " + r.ReadString("User") + "\r\n";
                    textBox1.Text += "المشترى : " + r.ReadString("Name") + "\r\n";
                    textBox1.Text += "وقت البيع : " + r.ReadString("BillDate") + "\r\n";
                    string[] skills = AllSkills.Split('#');
                    foreach (string skill in skills)
                    {
                        if (skill.Length < 2)
                            break;
                        string[] skillInfo = skill.Split('~');
                        textBox1.Text += "الاسم : " + Convert.ToString(skillInfo[0]) + " ";
                        textBox1.Text += "السعر : " + Convert.ToDecimal(skillInfo[1]) + "\r\n";
                    }
                    textBox1.Text += "-----------------------------------------\r\n";
                }
                r.Close();
            }
            catch (Exception ee)
            {
                Program.SaveException(ee);
            }
        }
        private void nb()
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand(MySqlCommandType.SELECT).Select("bills");
                MySqlReader r = new MySqlReader(cmd);
                while (r.Read())
                {
                    listBox1.Items.Add(r.ReadString("ID")/* + " || " + r.ReadString("Name")*/);
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
            Thread th = new Thread(() =>
            {
                //lb();
                nb();
            });
            th.Start();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MySqlCommand cmd = new MySqlCommand(MySqlCommandType.SELECT).Select("bills").Where("ID", listBox1.GetItemText(listBox1.SelectedItem));
            MySqlReader r = new MySqlReader(cmd);
            string AllSkills = "";
            while (r.Read())
            {
                textBox1.Clear();
                AllSkills = r.ReadString("Medic");
                textBox1.Text += "رقم الفاتورة : " + r.ReadString("ID") + "\r\n";
                textBox1.Text += "الموظف : " + r.ReadString("User") + "\r\n";
                textBox1.Text += "المشترى : " + r.ReadString("Name") + "\r\n";
                textBox1.Text += "وقت البيع : " + r.ReadString("BillDate") + "\r\n";
                textBox1.Text += "----الادويه---------------------------------\r\n";
                string[] skills = AllSkills.Split('#');
                foreach (string skill in skills)
                {
                    if (skill.Length < 2)
                        break;
                    string[] skillInfo = skill.Split('~');
                    textBox1.Text += "الاسم : " + Convert.ToString(skillInfo[0]) + "  ";
                    textBox1.Text += "السعر : " + Convert.ToDecimal(skillInfo[1]) + "\r\n";
                }
                textBox1.Text += "--------------------------------------------\r\n";
            }
            r.Close();
        }
    }
}