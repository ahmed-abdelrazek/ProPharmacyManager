using System;
using System.IO;
using System.Windows.Forms;

namespace PharmacyProManager.Kernel
{
    public partial class Setup : Form
    {
        public Setup()
        {
            InitializeComponent();
        }
        string str = "configuration.ini";
        private void Setup_Load(object sender, EventArgs e)
        {
            try
            {
                IniFile file = new IniFile(str);
                if (File.Exists(str))
                {
                    DBHost.Text = file.ReadString("MySql", "Host");
                    DBName.Text = file.ReadString("MySql", "Database");
                    DBUser.Text = file.ReadString("MySql", "Username");
                    DBPass.Text = file.ReadString("MySql", "Password");
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                IniFile file = new IniFile(str);
                if (!File.Exists(str))
                {
                    string[] lines = { "[MySql]", "Host=" + DBHost.Text, "Username=" + DBUser.Text, "Password=" + DBPass.Text, "Database=" + DBName.Text };
                    File.WriteAllLines(str, lines);
                    MessageBox.Show("تم تنصيب الاعدادات");
                    this.Close();
                }
                else if (File.Exists(str))
                {
                    File.Delete(str);
                    string[] lines = { "[MySql]", "Host=" + DBHost.Text, "Username=" + DBUser.Text, "Password=" + DBPass.Text, "Database=" + DBName.Text };
                    File.WriteAllLines(str, lines);
                    MessageBox.Show("تم تغيير الاعدادات");
                }
            }
            catch (Exception ee)
            {
                Program.SaveException(ee);
            }
        }
    }
}
