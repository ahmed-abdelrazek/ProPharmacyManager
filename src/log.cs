using PharmacyPRO.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PharmacyPRO
{
    public partial class log : Form
    {
        public log()
        {
            InitializeComponent();
        }

        private void log_Load(object sender, EventArgs e)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand(MySqlCommandType.SELECT);
                cmd.Select("logs");
                MySqlReader r = new MySqlReader(cmd);
                while (r.Read())
                {
                    logss.Text += "اسم المستخدم " + r.ReadString("Account") + "\r\n";
                    logss.Text += "وقت الدخول " + DateTime.FromBinary(r.ReadInt64("LoginDate"));
                    logss.Text += "\r\n----------------------------------------\r\n";
                }
            }
            catch (Exception eee)
            {
                MessageBox.Show(eee.ToString());
            }
        }
    }
}
