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
using System;
using System.Drawing;
using System.Windows.Forms;
using ProPharmacyManager.Database;

namespace ProPharmacyManager
{
    public partial class AddMed : Form
    {
        public AddMed()
        {
            InitializeComponent();
        }

        private void UPdateB_Click(object sender, EventArgs e)
        {
            byte PType;
            switch (comboBox1.Text)
            {
                case "شرب":
                    PType = 1;
                    break;
                case "حقن":
                    PType = 3;
                    break;
                case "اقراص":
                    PType = 2;
                    break;
                case "كريم/مرهم":
                    PType = 4;
                    break;
                case "اخرى":
                    PType = 0;
                    break;
                default:
                    MessageBox.Show("اختار صلاحيات المستخدم");
                    return;
            }
            if (PName.Text == "")
            {
                PName.BackColor = Color.Red;
                return;
            }
            else if (PName.Text != "")
            {
                PName.BackColor = Color.White;
            }
            if (PTottal.Text == "")
            {
                PTottal.BackColor = Color.Red;
                return;
            }
            else if (PTottal.Text != "")
            {
                PTottal.BackColor = Color.White;
            }
            if (PCost.Text == "")
            {
                PCost.BackColor = Color.Red;
                return;
            }
            else if (PCost.Text != "")
            {
                PCost.BackColor = Color.White;
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
                    .Insert("Type", PType).Execute();
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