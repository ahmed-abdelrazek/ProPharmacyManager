using PharmacyProManager.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
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
                    EXPLog.Text += "الاسم : " + r.ReadString("Name") + "\r\n";
                    EXPLog.Text += "الكميه الموجودة : " + r.ReadString("Count") + "\r\n";
                    EXPLog.Text += "تاريخ انتهاء الصلاحيه : " + r.ReadString("Expiry") + "\r\n";
                    EXPLog.Text += "--------------------------------------------------------\r\n";
                }
            }
            catch (Exception eee)
            {
                MessageBox.Show(eee.ToString());
            }
        }

        private void EXPEnd_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            Thread th = new Thread(() =>
            {
            endexp();
            });
            th.Start();
        }
    }
}
