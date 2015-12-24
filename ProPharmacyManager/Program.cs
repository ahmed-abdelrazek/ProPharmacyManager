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
//uncomment to debug the app without any checks         
#if DEBUG
            //Application.SetCompatibleTextRenderingDefault(false);
            //EngineThread_Execute();
            //Application.EnableVisualStyles();
            //Application.Run(new Login());
#endif
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
        public static bool IsUpgrading;
        static readonly string PasswordHash = "SHC@HAM&ABRZ";
        static readonly string SaltKey = "P@FAMK!TRP";
        static readonly string VIKey = "@Gjg9!b8tf&T6jl4k1b";
        private static void EngineThread_Execute()
        {
            try
            {
                IniFile file = new IniFile(Constants.SetupConfigPath);
                if (!File.Exists(Constants.SetupConfigPath))
                {
                    Setup set = new Setup { Text = "تنصيب البرنامج" };
                    set.ShowDialog();
                }
                DataHolder.CreateConnection(INIDecrypt(file.ReadString("MySql", "Username")), INIDecrypt(file.ReadString("MySql", "Password")),
                    INIDecrypt(file.ReadString("MySql", "Database")), INIDecrypt(file.ReadString("MySql", "Host")));
                GC.Collect();
                BillsTable.LBN();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
                File.Delete(Constants.SetupConfigPath);
            }
        }
        /// <summary> 
        /// save Exception to exceptions folder with the app
        /// </summary> 
        /// <param name="e">exception string</param>
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
        /// <summary> 
        /// passwords hash
        /// </summary> 
        /// <param name="data">string password before hassing</param>
        /// <returns>string password after hashing</returns>
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
        /// <summary> 
        /// ini info encryptor
        /// </summary> 
        /// <param name="plainText">string to encrypt</param>
        /// <returns>encrypted string</returns>
        public static string INIEncrypt(string plainText)
        {
            byte[] plainTextBytes = Encoding.UTF8.GetBytes(plainText);
            byte[] keyBytes = new Rfc2898DeriveBytes(PasswordHash, Encoding.ASCII.GetBytes(SaltKey)).GetBytes(256 / 8);
            var symmetricKey = new RijndaelManaged() { Mode = CipherMode.CBC, Padding = PaddingMode.Zeros };
            var encryptor = symmetricKey.CreateEncryptor(keyBytes, Encoding.ASCII.GetBytes(VIKey));
            byte[] cipherTextBytes;
            using (var memoryStream = new MemoryStream())
            {
                using (var cryptoStream = new CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write))
                {
                    cryptoStream.Write(plainTextBytes, 0, plainTextBytes.Length);
                    cryptoStream.FlushFinalBlock();
                    cipherTextBytes = memoryStream.ToArray();
                    cryptoStream.Close();
                }
                memoryStream.Close();
            }
            return Convert.ToBase64String(cipherTextBytes);
        }
        /// <summary> 
        /// ini info decryptor
        /// </summary> 
        /// <param name="encryptedText">encryptstring to decrypt </param>
        /// <returns>decrypted string</returns>
        public static string INIDecrypt(string encryptedText)
        {
            byte[] cipherTextBytes = Convert.FromBase64String(encryptedText);
            byte[] keyBytes = new Rfc2898DeriveBytes(PasswordHash, Encoding.ASCII.GetBytes(SaltKey)).GetBytes(256 / 8);
            var symmetricKey = new RijndaelManaged() { Mode = CipherMode.CBC, Padding = PaddingMode.None };
            var decryptor = symmetricKey.CreateDecryptor(keyBytes, Encoding.ASCII.GetBytes(VIKey));
            var memoryStream = new MemoryStream(cipherTextBytes);
            var cryptoStream = new CryptoStream(memoryStream, decryptor, CryptoStreamMode.Read);
            byte[] plainTextBytes = new byte[cipherTextBytes.Length];
            int decryptedByteCount = cryptoStream.Read(plainTextBytes, 0, plainTextBytes.Length);
            memoryStream.Close();
            cryptoStream.Close();
            return Encoding.UTF8.GetString(plainTextBytes, 0, decryptedByteCount).TrimEnd("\0".ToCharArray());
        }

    }
}