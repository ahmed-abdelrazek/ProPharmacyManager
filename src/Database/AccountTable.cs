using PharmacyProManager;
using System;
using System.Windows.Forms;

namespace PharmacyPRO.Database
{
    public class AccountTable
    {
        
        public string Username;
        public string Password;
        public string Phone;
        public DateTime LastCheck;
        
        public uint EntityID;
        public bool exists = false;
        public AccountTable(string username)
        {
            this.Username = username;
            this.Password = "";
            this.LastCheck = DateTime.Now;
            this.State = AccountState.None;
            MySqlCommand cmd = new MySqlCommand(MySqlCommandType.SELECT);
            cmd.Select("accounts").Where("Username", username);
            MySqlReader r = new MySqlReader(cmd);
            if (r.Read())
            {
                exists = true;
                this.Password = r.ReadString("Username");
                this.EntityID = r.ReadUInt32("EntityID");
                this.LastCheck = DateTime.FromBinary(r.ReadInt64("LastCheck"));
                this.State = (AccountState)r.ReadByte("State");
                this.Phone = r.ReadString("Phone");
            }
            r.Close();
        }
        public void Saveacc()
        {
            if (exists)
            {
                MySqlCommand cmd = new MySqlCommand(MySqlCommandType.UPDATE);
                cmd.Update("accounts").Set("Password", Password).Set("State", (byte)State).Set("EntityID", EntityID).Set("LastCheck", (ulong)DateTime.Now.ToBinary()).Where("Username", Username).Execute();
            }
            else
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand(MySqlCommandType.INSERT);
                    cmd.Insert("accounts").Insert("Username", Username).Insert("Password", Password).Insert("State", (byte)State).Execute();
                }
                catch (Exception e) { Program.SaveException(e); }
            }
        }
        public void LoadLog()
        {
            MySqlCommand cmd = new MySqlCommand(MySqlCommandType.SELECT);
            cmd.Select("logs");
            MySqlReader r = new MySqlReader(cmd);
            while (r.Read())
            {
                //item.ItemUID = r.ReadString("Account");
                //item.Date = DateTime.FromBinary(r.ReadInt64("LoginDate"));
                //item.Date = DateTime.FromBinary(r.ReadInt64("LogoutDate"));

            }
            r.Close();
        }
        public void SaveLog()
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand(MySqlCommandType.INSERT);
                cmd.Insert("logs")
                    .Insert("Account", Username).Insert("LoginDate", DateTime.Now.Ticks.ToString()).Insert("LogoutDate", DateTime.Now.Ticks.ToString()).Execute();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }
        public AccountState State;
        public enum AccountState : byte
        {
            Employee = 1,
            Manager = 2,
            None = 0
        }
    }
}
