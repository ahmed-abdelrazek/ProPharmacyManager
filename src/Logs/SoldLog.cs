using PharmacyProManager.Database;
using System;
using System.Threading;
using System.Windows.Forms;

namespace PharmacyProManager.Logs
{
    public partial class SoldLog : Form
    {
        public SoldLog()
        {
            InitializeComponent();
        }
        decimal ff = 0;
        decimal ff1 = 0;
        decimal ss = 0;
        decimal ss1 = 0;
        private void SL1()
        {
            MySqlCommand cmd = new MySqlCommand(MySqlCommandType.SELECT);
            cmd.Select("medlog").Where("SellDate", Convert.ToUInt16(DateTime.Now.Day));
            MySqlReader r = new MySqlReader(cmd);
            while (r.Read())
            {
                Sold1.Text += "اسم الدواء : " + r.ReadString("Name") + "\r\n";
                Sold1.Text += "وقت البيع : " + r.ReadString("SellDate");
                Sold1.Text += "\r\n----------------------------------------------\r\n";
                ff = Convert.ToDecimal(r.ReadString("Cost"));
                ff1 += ff;
            }
        }
        private void SL2()
        {
            MySqlCommand cmd = new MySqlCommand(MySqlCommandType.SELECT);
            cmd.Select("medlog").Where("SellDate", Convert.ToUInt16(DateTime.Now.Day), false);
            MySqlReader r = new MySqlReader(cmd);
            while (r.Read())
            {
                Sold2.Text += "اسم الدواء : " + r.ReadString("Name") + "\r\n";
                Sold2.Text += "وقت البيع : " + r.ReadString("SellDate");
                Sold2.Text += "\r\n----------------------------------------------\r\n";
                ss = Convert.ToDecimal(r.ReadString("Cost"));
                ss1 += ss;
            }
        }
        private void SoldLog_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            Thread th = new Thread(() =>
            {
            SL1();
            SL2();
            tottal1.Text += "الاجمالى :" + ff1;
            tottal2.Text += "الاجمالى :" + ss1;
            });
            th.Start();
        }
    }
}
