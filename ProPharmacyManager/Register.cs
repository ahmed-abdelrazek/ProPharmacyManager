// <copyright>
//     Copyright (C) 2013 ShababConquer Blog.
//     This program is free software; you can redistribute it and/or modify 
//     it under the terms of the GNU General Public License version 2 as 
//     published by the Free Software Foundation.
// 
//     This program is distributed in the hope that it will be useful, but 
//     WITHOUT ANY WARRANTY; without even the implied warranty of MERCHANTABILITY 
//     or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU General Public License 
//     for more details.
// 
//     You should have received a copy of the GNU General Public License along 
//     with this program; if not, write to the Free Software Foundation, Inc., 
//     51 Franklin Street, Fifth Floor, Boston, MA  02110-1301, USA.
// </copyright>
using ProPharmacyManager.Database;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProPharmacyManager
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }
        private void button5_Click(object sender, EventArgs e)
        {

            byte state;
            switch (comboBox1.Text)
            {
                case "مدير":
                    state = 2;
                    break;
                case "موظف":
                    state = 1;
                    break;
                case "مجهول":
                    state = 0;
                    break;
                default:
                    MessageBox.Show("اختار صلاحيات المستخدم");
                    return;
            }
            if (textBox10.Text == "")
            {
                textBox10.BackColor = Color.Red;
                return;
            }
            if (textBox10.Text != "")
            {
                textBox10.BackColor = Color.White;
            }
            if (textBox9.Text == "")
            {
                textBox9.BackColor = Color.Red;
                return;
            }
            if (textBox9.Text != "")
            {
                textBox9.BackColor = Color.White;
            }
            try
            {
                MySqlCommand cmd = new MySqlCommand(MySqlCommandType.INSERT);
                cmd.Insert("accounts").Insert("Username", textBox10.Text).Insert("Password", Program.GetSHAHashData(textBox9.Text)).Insert("Phone", textBox1.Text).Insert("State", state).Execute();
                label16.ForeColor = Color.Green;
                label16.Text = ".تم اضافه المستخدم بنجاح";
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
