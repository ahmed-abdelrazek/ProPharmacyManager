using PharmacyPRO.Database;
using System;
using System.Windows.Forms;

namespace PharmacyProManager
{
    public partial class DateLog : Form
    {
        public DateLog()
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
            }
            catch (Exception eee)
            {
                MessageBox.Show(eee.ToString());
            }
        }

        private void DateLog_Load(object sender, EventArgs e)
        {
            end();
        }
    }
}
