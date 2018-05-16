using PharmacyProManager.Database;
using System;
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
                cmd.Select("medics").Where("Expiry", Convert.ToUInt16(DateTime.Now.Month), false);
                MySqlReader r = new MySqlReader(cmd);
                while (r.Read())
                {
                    dataGridView1.Rows.Add(r.ReadString("Name"), r.ReadString("Expiry"), r.ReadString("Count"));
                }
                r.Close();
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
