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
using System.Windows.Forms;

namespace ProPharmacyManager.Database
{
    public class AccountsTable
    {
        public static string UserName;
        public static string UserPassword;

        private static States.AccountState State;
        /// <summary> 
        /// save who and when login
        /// </summary> 
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

        /// <summary> 
        /// login check code
        /// </summary> 
        public static bool UserLogin()
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand(MySqlCommandType.SELECT);
                cmd.Select("accounts").Where("Username", UserName).And("Password", UserPassword);
                MySqlReader r = new MySqlReader(cmd);
                if (r.Read())
                {
                    State = (States.AccountState) r.ReadByte("State");
                    switch (State)
                    {
                        case States.AccountState.Manager:
                        {
                            Manager ma = new Manager();
                            ma.Show();
                            SaveLogin();
                            return true;
                        }
                        case States.AccountState.Employee:
                        {
                            CPanal gui = new CPanal();
                            gui.Show();
                            SaveLogin();
                            return true;
                        }
                        default:
                            MessageBox.Show("من انت؟ هل تعمل فى هذه الصيدليه؟");
                            return false;
                    }
                }
                else
                {
                    MessageBox.Show("أسم المستخدم و/او كلمه المرور خطأ");
                    return false;
                }
            }
            catch (Exception ll)
            {
                Program.SaveException(ll);
                return false;
            }
        }
    }
}