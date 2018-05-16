// <copyright name="ProPharmacyManager" description="you can run, manage, watch your pharmacy easily">
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
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Security.Principal;
using System.Threading;
using System.Windows.Forms;
using ProPharmacyManager.Database;
using ProPharmacyManager.Kernel;
using System.Security.Cryptography;
using System.Text;

namespace ProPharmacyManager
{
    internal static class Program
    {
        /// <summary>
        ///     The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            WindowsIdentity identity = WindowsIdentity.GetCurrent();
            WindowsPrincipal principal = identity != null ? new WindowsPrincipal(identity) : null;
            if (principal == null || !principal.IsInRole(WindowsBuiltInRole.Administrator))
            {
                MessageBox.Show("يجب تشغيل البرنامج كمدير, من فضلك اعد التشغيل كمدير\nThis application requires Administrator privileges.");
                return;
            }
            bool createdNew;
            using (new Mutex(true, "ProPharmacyManager", out createdNew))
            {
                if (createdNew)
                {
                    Application.SetCompatibleTextRenderingDefault(false);
                    EngineThread_Execute();
                    Application.EnableVisualStyles();
                    Application.Run(new Login());
                }
                else
                {
                    Process currentProcess = Process.GetCurrentProcess();
                    if (Process.GetProcessesByName(currentProcess.ProcessName)
                        .All(process2 => process2.Id == currentProcess.Id)) return;
                    MessageBox.Show("البرنامج يعمل بالفعل");
                }
            }
        }

        private static void EngineThread_Execute()
        {
            try
            {
                IniFile file = new IniFile(Constants.SetupConfigPath);
                if (!File.Exists(Constants.SetupConfigPath))
                {
                    Setup set = new Setup {Text = "تنصيب البرنامج"};
                    set.ShowDialog();
                }
                DataHolder.CreateConnection(file.ReadString("MySql", "Username"), file.ReadString("MySql", "Password"),
                    file.ReadString("MySql", "Database"), file.ReadString("MySql", "Host"));
                GC.Collect();
                BillsTable.LBN();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
                File.Delete(Constants.SetupConfigPath);
            }
        }

        public static void SaveException(Exception e)
        {
            if (e.TargetSite.Name == "ThrowInvalidOperationException") return;
            MessageBox.Show(e.ToString());
            DateTime now = DateTime.Now;
            string str = string.Concat(new object[] {now.Month, "-", now.Day, "//"});
            if (!Directory.Exists(Application.StartupPath + @"exceptions\"))
            {
                Directory.CreateDirectory(Application.StartupPath + @"\exceptions\");
            }
            if (!Directory.Exists(Application.StartupPath + @"\exceptions\" + str))
            {
                Directory.CreateDirectory(Application.StartupPath + @"\exceptions\" + str);
            }
            if (!Directory.Exists(Application.StartupPath + @"\exceptions\" + str + e.TargetSite.Name))
            {
                Directory.CreateDirectory(Application.StartupPath + @"\exceptions\" + str + e.TargetSite.Name);
            }
            File.WriteAllLines(
                (Application.StartupPath + @"\exceptions\" + str + e.TargetSite.Name + @"\") +
                string.Concat(new object[] {now.Hour, "-", now.Minute, "-", now.Ticks & 10L}) + ".txt",
                new List<string>
                {
                    "----Exception message----",
                    e.Message,
                    "----End of exception message----\r\n",
                    "----Stack trace----",
                    e.StackTrace,
                    "----End of stack trace----\r\n"
                }.ToArray());
        }
        public static string GetSHAHashData(string data)
        {
            SHA512 sha1 = SHA512.Create();
            byte[] hashData = sha1.ComputeHash(Encoding.UTF8.GetBytes(data));
            StringBuilder returnValue = new StringBuilder();
            for (int i = 0; i < hashData.Length; i++)
            {
                returnValue.Append(hashData[i].ToString());
            }
            return returnValue.ToString();
        }
    }
}