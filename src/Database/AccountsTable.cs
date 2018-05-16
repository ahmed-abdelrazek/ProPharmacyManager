using System;
using System.Windows.Forms;

namespace ProPharmacyManager.Database
{
    public class AccountsTable
    {

        public static string UserName;
        public static string UserPassword;

        private static States.AccountState State;
        private static void SaveLogin()
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand(MySqlCommandType.INSERT);
                cmd.Insert("logs")
                    .Insert("Account", UserName).Insert("LoginDate", DateTime.Now.ToString()).Execute();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }
        public static bool UserLogin()
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand(MySqlCommandType.SELECT);
                cmd.Select("accounts").Where("Username", UserName).And("Password", UserPassword);
                MySqlReader r = new MySqlReader(cmd);
                if (r.Read())
                {
                    State = (States.AccountState)r.ReadByte("State");
                    if (State == States.AccountState.Manager)
                    {
                        Manager ma = new Manager();
                        ma.Show();
                        SaveLogin();
                        return true;
                    }
                    else if (State == States.AccountState.Employee)
                    {
                        CPanal gui = new CPanal();
                        gui.Show();
                        SaveLogin();
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("من انت؟ هل تعمل فى هذه الصيدليه؟");
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("أسم المستخدم و/او كلمه المرور خطأ");
                    return false;
                }
                r.Close();
            }
            catch (Exception ll)
            {
                Program.SaveException(ll);
                return false;
            }
        }
    }
}
