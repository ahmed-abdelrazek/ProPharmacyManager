using ProPharmacyManager.Database;
using System;
using System.Threading;
using System.Windows.Forms;

namespace ProPharmacyManager.Logs
{
    public partial class SoldLog : Form
    {
        public SoldLog()
        {
            InitializeComponent();
        }
        decimal ff = 0;
        decimal ff1 = 0;
        private void SL1()
        {
            MySqlCommand cmd = new MySqlCommand(MySqlCommandType.SELECT);
            cmd.Select("medlog");//.Where("SellDate", Convert.ToUInt16(DateTime.Now.Day));
            MySqlReader r = new MySqlReader(cmd);
            while (r.Read())
            {
                dd1.Rows.Add(r.ReadString("Name"), r.ReadString("SellDate"), r.ReadString("Cost"));
                ff = Convert.ToDecimal(r.ReadString("Cost"));
                ff1 += ff;
            }
            r.Close();
        }
        private void SoldLog_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            Thread th = new Thread(() =>
            {
                SL1();
                tottal1.Text = "الاجمالى :" + ff1;
            });
            th.Start();
        }
    }
}
