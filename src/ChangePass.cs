using ProPharmacyManager.Database;
using System;
using System.Drawing;
using System.Windows.Forms;

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
                cmd.Update("accounts").Set("Password", NUP.Text).Where("Username", UN.Text).Execute();
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
                new MySqlCommand(MySqlCommandType.DELETE).Delete("accounts", "Username", UN.Text).Execute();
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
    }
}
