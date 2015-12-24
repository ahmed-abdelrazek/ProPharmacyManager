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
using System.IO;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace ProPharmacyManager.Kernel
{
    public partial class Setup : Form
    {
        public Setup()
        {
            InitializeComponent();
        }
        private void Setup_Load(object sender, EventArgs e)
        {
            IniFile file = new IniFile(Constants.SetupConfigPath);
            if (this.Text == "تنصيب البرنامج")
            {
                Install.Text = "اعداد";
                Upgrade.Visible = true;
            }
            try
            {
                if (File.Exists(Constants.SetupConfigPath))
                {
                    DBHost.Text = Program.INIDecrypt(file.ReadString("MySql", "Host"));
                    DBName.Text = Program.INIDecrypt(file.ReadString("MySql", "Database"));
                    DBUser.Text = Program.INIDecrypt(file.ReadString("MySql", "Username"));
                    DBPass.Text = Program.INIDecrypt(file.ReadString("MySql", "Password"));
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            if (this.Text == "تنصيب البرنامج")
            {
                Environment.Exit(0);
            }
            else
            {
                this.Close();
            }
        }

        private void Install_Click(object sender, EventArgs e)
        {
            try
            {
                IniFile file = new IniFile(Constants.SetupConfigPath);
                if (this.Text == "تنصيب البرنامج")
                {
                    if (!File.Exists(Constants.SetupConfigPath))
                    {
                        file.Write("MySql", "Host", DBHost.Text);
                        file.Write("MySql", "Username", DBUser.Text);
                        file.Write("MySql", "Password", DBPass.Text);
                        file.Write("MySql", "Database", DBName.Text);
                        file.Write("Upgrade", "Version", System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString().Replace(".", ""));
                        if (!Directory.Exists(Application.StartupPath + @"BackUp\"))
                        {
                            Directory.CreateDirectory(Application.StartupPath + @"\BackUp\");
                        }
                        DataHolder.CreateConnection(Program.INIDecrypt(file.ReadString("MySql", "Username")), Program.INIDecrypt(file.ReadString("MySql", "Password")), Program.INIDecrypt(file.ReadString("MySql", "Host")));
                        CreateDB.Createdb(DBName.Text);
                        DataHolder.CreateConnection(Program.INIDecrypt(file.ReadString("MySql", "Username")), Program.INIDecrypt(file.ReadString("MySql", "Password")), Program.INIDecrypt(file.ReadString("MySql", "Database")), Program.INIDecrypt(file.ReadString("MySql", "Host")));
                        CreateDB.CreateTables();
                        MessageBox.Show("تم تنصيب الاعدادات\nمن فضلك انشاء حساب جديد لتتمكن من الدخول");
                        Register reg = new Register();
                        reg.ShowDialog();
                        this.Close();
                    }
                }
                else if (this.Text == "اعدادات البرنامج")
                {
                    if (File.Exists(Constants.SetupConfigPath))
                    {
                        BackUp.NewDbBackup();
                        DataHolder.CreateConnection(Program.INIDecrypt(file.ReadString("MySql", "Username")), Program.INIDecrypt(file.ReadString("MySql", "Password")), Program.INIDecrypt(file.ReadString("MySql", "Host")));
                        CreateDB.Createdb(file.ReadString("MySql", "Database"), DBName.Text);
                        file.Write("MySql", "Host", DBHost.Text);
                        file.Write("MySql", "Username", DBUser.Text);
                        file.Write("MySql", "Password", DBPass.Text);
                        file.Write("MySql", "Database", DBName.Text);
                        DataHolder.CreateConnection(Program.INIDecrypt(file.ReadString("MySql", "Username")), Program.INIDecrypt(file.ReadString("MySql", "Password")), Program.INIDecrypt(file.ReadString("MySql", "Database")), Program.INIDecrypt(file.ReadString("MySql", "Host")));
                        BackUp.NewDbRestore();
                        BillsTable.LBN();
                        MessageBox.Show("تم تغيير الاعدادات");
                    }
                }
            }
            catch (Exception ee)
            {
                Program.SaveException(ee);
            }
        }

        private void Upgrade_Click(object sender, EventArgs e)
        {
            IniFile file = new IniFile(Constants.SetupConfigPath);
            if (this.Text == "تنصيب البرنامج")
            {
                if (!File.Exists(Constants.SetupConfigPath))
                {
                    file.Write("MySql", "Host", DBHost.Text);
                    file.Write("MySql", "Username", DBUser.Text);
                    file.Write("MySql", "Password", DBPass.Text);
                    file.Write("MySql", "Database", DBName.Text);
                    file.Write("Upgrade", "Version", System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString().Replace(".", ""));
                    if (!Directory.Exists(Application.StartupPath + @"BackUp\"))
                    {
                        Directory.CreateDirectory(Application.StartupPath + @"\BackUp\");
                    }
                    DataHolder.CreateConnection(Program.INIDecrypt(file.ReadString("MySql", "Username")), Program.INIDecrypt(file.ReadString("MySql", "Password")), Program.INIDecrypt(file.ReadString("MySql", "Host")));
                    DataHolder.CreateConnection(Program.INIDecrypt(file.ReadString("MySql", "Username")), Program.INIDecrypt(file.ReadString("MySql", "Password")), Program.INIDecrypt(file.ReadString("MySql", "Database")), Program.INIDecrypt(file.ReadString("MySql", "Host")));
                    CreateDB.UpgradeTables();
                    MessageBox.Show("تم الترقية بنجاح\nمن فضلك انشاء حساب جديد لتتمكن من الدخول");
                    Register reg = new Register();
                    reg.ShowDialog();
                    this.Close();
                }
            }
            else if (this.Text == "اعدادات البرنامج")
            {
                Upgrade.Enabled = false;
            }
        }

    }
}
