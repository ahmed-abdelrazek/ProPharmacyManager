using ProPharmacyManager.Database;
using System;
using System.Windows.Forms;
using System.Threading;

namespace ProPharmacyManager
{
    public partial class log : Form
    {
        public log()
        {
            InitializeComponent();
        }
        private void loginlog()
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand(MySqlCommandType.SELECT);
                cmd.Select("logs").Where("LoginDate", Convert.ToUInt16(DateTime.Now.Day));
                MySqlReader r = new MySqlReader(cmd);
                while (r.Read())
                {
                    logss1.Text += "اسم المستخدم : " + r.ReadString("Account") + "\r\n";
                    logss1.Text += "وقت الدخول : " + r.ReadString("LoginDate");
                    logss1.Text += "\r\n----------------------------------------------\r\n";
                }
                r.Close();
            }
            catch (Exception eee)
            {
                MessageBox.Show(eee.ToString());
            }
            try
            {
                MySqlCommand cmd = new MySqlCommand(MySqlCommandType.SELECT);
                cmd.Select("logs").Where("LoginDate", Convert.ToUInt16(DateTime.Now.Day), false);
                MySqlReader r = new MySqlReader(cmd);
                while (r.Read())
                {
                    logss2.Text += "اسم المستخدم : " + r.ReadString("Account") + "\r\n";
                    logss2.Text += "وقت الدخول : " + r.ReadString("LoginDate");
                    logss2.Text += "\r\n----------------------------------------------\r\n";
                }
                r.Close();
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }
        }
        private void log_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            Thread th = new Thread(() =>
            {
                loginlog();
            });
            th.Start();
        }
    }
}
