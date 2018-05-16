using ProPharmacyManager.Database;
using System;
using System.Threading;
using System.Windows.Forms;

namespace ProPharmacyManager
{
    public partial class countLog : Form
    {
        public countLog()
        {
            InitializeComponent();
        }
        public void end()
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand(MySqlCommandType.SELECT);
                cmd.Select("medics").Where("Count","0");
                MySqlReader r = new MySqlReader(cmd);
                while (r.Read())
                {
                    MedLog.Text += r.ReadString("Name") + "\r\n";
                    MedLog.Text += "----------------------------------------\r\n";
                }
                r.Close();
            }
            catch (Exception eee)
            {
                MessageBox.Show(eee.ToString());
            }
        }

        private void DateLog_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            Thread th = new Thread(() =>
            {
            end();
            });
            th.Start();
        }
    }
}
