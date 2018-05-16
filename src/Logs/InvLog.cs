using ProPharmacyManager.Database;
using System;
using System.Threading;
using System.Windows.Forms;

namespace ProPharmacyManager.Logs
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
        private void IL()
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand(MySqlCommandType.SELECT);
                cmd.Select("medics").Where("Count", 0, true);
                MySqlReader r = new MySqlReader(cmd);
                while (r.Read())
                {
                    ff = Convert.ToDecimal(r.ReadString("Price"));
                    tt = Convert.ToDecimal(r.ReadString("Count"));
                    ff1 += ff;
                    tt1 += tt;
                    totalprice.Text = "اجمالى سعر الموجود :" + Convert.ToDecimal(ff1) * Convert.ToDecimal(tt1) + "جنيه";
                    DGV.Rows.Add(r.ReadString("Name"), r.ReadString("Price"), r.ReadString("Count"), r.ReadString("Expiry"));

                }
                r.Close();
            }
            catch (Exception ee)
            {
                Program.SaveException(ee);
            }
        }
        private void InvLog_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            Thread th = new Thread(() =>
            {
            IL();
            });
            th.Start();
        }
    }
}
