using PharmacyProManager.Database;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace PharmacyProManager
{
    public partial class AddMed : Form
    {
        public AddMed()
        {
            InitializeComponent();
        }

        private void UPdateB_Click(object sender, EventArgs e)
        {

            byte PType = 0;
            if (comboBox1.Text == "شرب")
            {
                PType = 1;
            }
            else if (comboBox1.Text == "حقن")
            {
                PType = 3;
            }
            else if (comboBox1.Text == "اقراص")
            {
                PType = 2;
            }
            else if (comboBox1.Text == "كريم/مرهم")
            {
                PType = 4;
            }
            else if (comboBox1.Text == "اخرى")
            {
                PType = 0;
            }
            else
            {
                MessageBox.Show("اختار صلاحيات المستخدم");
                return;
            }
            if (PName.Text == "")
            {
                PName.BackColor = System.Drawing.Color.Red;
                return;
            }
            else if (PName.Text != "")
            {
                PName.BackColor = System.Drawing.Color.White;
            }
            if (PTottal.Text == "")
            {
                PTottal.BackColor = System.Drawing.Color.Red;
                return;
            }
            else if (PTottal.Text != "")
            {
                PTottal.BackColor = System.Drawing.Color.White;
            }
            if (PCost.Text == "")
            {
                PCost.BackColor = System.Drawing.Color.Red;
                return;
            }
            else if (PCost.Text != "")
            {
                PCost.BackColor = System.Drawing.Color.White;
            }
            try
            {
                MySqlCommand cmd = new MySqlCommand(MySqlCommandType.INSERT);
                cmd.Insert("medics")
                    .Insert("Name", PName.Text)
                    .Insert("Count", PTottal.Text)
                    .Insert("Substance", PSubS.Text)
                    .Insert("Expiry", PEX.Text)
                    .Insert("Note", Pnote.Text)
                    .Insert("Price", PCost.Text)
                    .Insert("Type", (byte)PType).Execute();
                label16.ForeColor = Color.Green;
                label16.Text = "تم اضافه الدواء بنجاح.";
                label16.Visible = true;
            }
            catch
            {
                label16.ForeColor = Color.Red;
                label16.Text = "الدواء موجود بالفعل.";
                label16.Visible = true;
            }
        }

        private void PTottal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            // only allow one decimal point
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void PCost_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            // only allow one decimal point
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }
    }
}
