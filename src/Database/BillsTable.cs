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
using System.Text;

namespace ProPharmacyManager.Database
{
    public class BillsTable
    {
        public static ulong BillNO = 0;
        public static string MName;
        public static decimal MCost = 0;
        public static string Client;
        private static string MList;

        public static void LBN()
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand(MySqlCommandType.SELECT).Select("bills").Order("ID", true);
                MySqlReader r = new MySqlReader(cmd);
                BillNO = r.Read() ? r.ReadUInt32("ID") : 0;
                r.Close();
            }
            catch (Exception ee)
            {
                Program.SaveException(ee);
            }
        }

        private static void LoadBill()
        {
            try
            {
                MySqlCommand cmd =
                    new MySqlCommand(MySqlCommandType.SELECT).Select("bills").Where("Name", Client).And("ID", BillNO);
                MySqlReader r = new MySqlReader(cmd);
                if (r.Read())
                {
                    MList = r.ReadString("Medic");
                }
                r.Close();
            }
            catch (Exception ee)
            {
                Program.SaveException(ee);
            }
        }

        public static void newbill()
        {
            try
            {
                LoadBill();
                ++BillNO;
                StringBuilder Command1 = new StringBuilder();
                Command1.Append(MName + "~");
                Command1.Append(MCost + "#");
                MySqlCommand cmd = new MySqlCommand(MySqlCommandType.INSERT);
                cmd.Insert("bills")
                    .Insert("Name", Client)
                    .Insert("User", AccountsTable.UserName)
                    .Insert("Medic", Command1.ToString())
                    .Insert("BillDate", DateTime.Now.ToString())
                    .Execute();
            }
            catch (Exception ee)
            {
                Program.SaveException(ee);
            }
        }

        public static void updatebill()
        {
            LoadBill();
            try
            {
                StringBuilder Command = new StringBuilder();
                Command.Append(MName + "~");
                Command.Append(MCost + "#");
                MList += Command;
                MySqlCommand Cmd = new MySqlCommand(MySqlCommandType.UPDATE);
                Cmd.Update("bills")
                    .Set("Medic", MList)
                    .Where("ID", BillNO).And("Name", Client);
                Cmd.Execute();
            }
            catch (Exception ee)
            {
                Program.SaveException(ee);
            }
        }
    }
}