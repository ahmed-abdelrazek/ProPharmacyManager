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
    public partial class ChangePass : Form
    {
        public ChangePass()
        {
            InitializeComponent();
        }
        public void Changepass()
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand(MySqlCommandType.UPDATE);
                cmd.Update("accounts").Set("Password",Program.GetSHAHashData(NUP.Text)).Where("Username", UN.SelectedItem.ToString()).Execute();
                label3.Text = "تم تغيير كلمه المرور بنجاح.";
                label3.ForeColor = Color.Green;
                label3.Visible = true;
            }
            catch (Exception ll)
            {
                label3.Text = "ليس هناك حساب بهذا الاسم.";
                label3.ForeColor = Color.Red;
                label3.Visible = true;
                MessageBox.Show(ll.ToString());
            }
        }
        public void DeleteAcc()
        {
            try
            {
                new MySqlCommand(MySqlCommandType.DELETE).Delete("accounts", "Username", UN.SelectedItem.ToString()).Execute();
                label3.Text = "تم حذف الحساب بنجاح.";
                label3.ForeColor = Color.Blue;
                label3.Visible = true;
            }
            catch (Exception ad)
            {
                label3.Text = "ليس هناك حساب بهذا الاسم.";
                label3.ForeColor = Color.Red;
                label3.Visible = true;
                MessageBox.Show(ad.ToString());
            }
        }

        private void Change_Click(object sender, EventArgs e)
        {
            Changepass();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            DeleteAcc();
        }

        private void ChangePass_Load(object sender, EventArgs e)
        {
            MySqlCommand cmd = new MySqlCommand(MySqlCommandType.SELECT);
            cmd.Select("accounts");
            MySqlReader r = new MySqlReader(cmd);
            while (r.Read())
            {
                UN.Items.Add(r.ReadString("Username"));
            }
        }
    }
}
