using PharmacyPRO.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PharmacyProManager
{
    public partial class EXPEnd : Form
    {
        public EXPEnd()
        {
            InitializeComponent();
        }
        private void endexp()
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand(MySqlCommandType.SELECT);
                cmd.Select("medics").Where("Expiry", Convert.ToUInt16(DateTime.Now.Day), false);//.And("Expiry", Convert.ToUInt16(DateTime.Now.Month),true);
                MySqlReader r = new MySqlReader(cmd);
                while (r.Read())
                {
                    EXPLog.Text += r.ReadString("Name") + "\r\n";
                    EXPLog.Text += "----------------------------------------\r\n";
                }
            }
            catch (Exception eee)
            {
                MessageBox.Show(eee.ToString());
            }
        }

        private void EXPEnd_Load(object sender, EventArgs e)
        {
            endexp();
        }
    }
}
