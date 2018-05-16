using PharmacyPRO.Database;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace PharmacyPRO
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }
        private void button5_Click(object sender, EventArgs e)
        {

            byte state = 0;
            if (comboBox1.Text == "مدير")
            {
                state = 2;
            }
            else if (comboBox1.Text == "موظف")
            {
                state = 1;
            }
            else if (comboBox1.Text == "مجهول")
            {
                state = 0;
            }
            else
            {
                MessageBox.Show("اختار صلاحيات المستخدم");
                return;
            }
            if (textBox10.Text == "")
            {
                textBox10.BackColor = System.Drawing.Color.Red;
                return;
            }
            if (textBox10.Text != "")
            {
                textBox10.BackColor = System.Drawing.Color.White;
            }
            if (textBox9.Text == "")
            {
                textBox9.BackColor = System.Drawing.Color.Red;
                return;
            }
            if (textBox9.Text != "")
            {
                textBox9.BackColor = System.Drawing.Color.White;
            }
            try
            {
                MySqlCommand cmd = new MySqlCommand(MySqlCommandType.INSERT);
                cmd.Insert("accounts").Insert("Username", textBox10.Text).Insert("Password", textBox9.Text).Insert("Phone", textBox1.Text).Insert("State", (byte)state).Execute();
                label16.Visible = true;
            }
            catch
            {
                label16.ForeColor = Color.Red;
                label16.Text = ".المستخدم موجود بالفعل";
                label16.Visible = true;
            }

        }
    }
}
