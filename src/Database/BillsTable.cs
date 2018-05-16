using System;
using System.Collections.Generic;
using System.Linq;
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
                //cmd.Select("configuration");
                MySqlReader r = new MySqlReader(cmd);
                if (r.Read())
                {
                    BillNO = r.ReadUInt32("ID");
                }
                else
                {
                    BillNO = 0;
                }
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
                MySqlCommand cmd = new MySqlCommand(MySqlCommandType.SELECT).Select("bills").Where("Name", Client).And("ID", BillNO);
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
