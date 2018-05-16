using PharmacyProManager.Database;
using System;
using System.Windows.Forms;

namespace PharmacyProManager.Logs
{
    public partial class InvLog : Form
    {
        public InvLog()
        {
            InitializeComponent();
        }
        decimal ff = 0;
        decimal ff1 = 0;
        decimal tt = 0;
        decimal tt1 = 0;
        private void InvLog_Load(object sender, EventArgs e)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand(MySqlCommandType.SELECT);
                cmd.Select("medics").Where("Count", 0, true);
                MySqlReader r = new MySqlReader(cmd);
                while (r.Read())
                {
                    text1.Text += "اسم الدواء : " + r.ReadString("Name") + "\r\n";
                    text1.Text += "السعر : " + r.ReadString("Price") + "\r\n";
                    text1.Text += "الكميه : " + r.ReadString("Count") + "\r\n";
                    text1.Text += "انتهاء الصلاحيه : " + r.ReadString("Expiry");
                    text1.Text += "\r\n----------------------------------------------\r\n";
                    ff = Convert.ToDecimal(r.ReadString("Price"));
                    tt = Convert.ToDecimal(r.ReadString("Count"));
                    ff1 += ff;
                    tt1 += tt;
                    ttext1.Text = "اجمالى سعر الموجود :" + Convert.ToDecimal(ff1) * Convert.ToDecimal(tt1) + "جنيه";


                }
                            }
            catch (Exception ee)
            {
                Program.SaveException(ee);
            }
        }
    }
}
