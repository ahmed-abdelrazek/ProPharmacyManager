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
using MySql.Data.MySqlClient;
using System;
using System.IO;
using System.Windows.Forms;

namespace ProPharmacyManager.Database
{
    public class BackUp
    {
        public static void Backup(string EnK)
        {
            try
            {
                string DTime = string.Format("{0}-{1}-{2} {3}.{4}.{5}.{6}", DateTime.Now.Day,
                    DateTime.Now.Month, DateTime.Now.Year, DateTime.Now.Hour,
                    DateTime.Now.Minute, DateTime.Now.Second, DateTime.Now.Millisecond);
                string file = "BackUp\\PHDB " + DTime + ".sql";
                DirectoryInfo dir1 = new DirectoryInfo("BackUp\\");
                using (var conn = DataHolder.MySqlConnection)
                {
                    MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand();
                    using (MySqlBackup mb = new MySqlBackup(cmd))
                    {
                        if (!dir1.Exists)
                        {
                            dir1.Create();
                        }
                        cmd.Connection = conn;
                        conn.Open();
                        mb.ExportInfo.EnableEncryption = true;
                        mb.ExportInfo.EncryptionPassword = EnK;
                        mb.ExportToFile(file);
                        conn.Close();
                    }
                    MessageBox.Show("تم اخذ نسخه احتياطيه من قاعدة البيانات بنجاح");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }       
        public static void Restore(string RBU, string Dek)
        {
            try
            {
                DirectoryInfo dir1 = new DirectoryInfo("BackUp\\");
                using (var conn = DataHolder.MySqlConnection)
                {
                    MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand();
                    using (MySqlBackup mb = new MySqlBackup(cmd))
                    {
                        if (!dir1.Exists)
                        {
                            MessageBox.Show("مجلد النسخ الاحتياطيه غير موجود");
                            return;
                        }
                        if (!File.Exists(RBU))
                        {
                            MessageBox.Show("النسخة الاحتياطيه غير موجودة");
                            return;
                        }
                        cmd.Connection = conn;
                        conn.Open();
                        mb.ImportInfo.EnableEncryption = true;
                        mb.ImportInfo.EncryptionPassword = Dek;
                        mb.ImportFromFile(RBU);
                        conn.Close();
                    }
                    MessageBox.Show("تم استعاده النسخة الاحتياطيه بنجاح");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("مفتاح التشفير خطأ\n"+ex.ToString());
            }
        }
        public static void NewDbBackup()
        {
            try
            {
                const string file = "BackUp\\PHDBNewDBBackup.sql";
                DirectoryInfo dir1 = new DirectoryInfo("BackUp\\");
                using (var conn = DataHolder.MySqlConnection)
                {
                    MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand();
                    using (MySqlBackup mb = new MySqlBackup(cmd))
                    {
                        if (!dir1.Exists)
                        {
                            dir1.Create();
                        }
                        if (!File.Exists(file))
                        {
                            FileInfo f = new FileInfo(file);
                            FileStream fs = f.Create();
                            fs.Close();
                        }
                        cmd.Connection = conn;
                        conn.Open();
                        mb.ExportInfo.EnableEncryption = true;
                        mb.ExportInfo.EncryptionPassword = "PROFelixSHCO";
                        mb.ExportToFile(file);
                        conn.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public static void NewDbRestore()
        {
            try
            {
                const string file = "BackUp\\PHDBNewDBBackup.sql";
                DirectoryInfo dir1 = new DirectoryInfo("BackUp\\");
                using (var conn = DataHolder.MySqlConnection)
                {
                    MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand();
                    using (MySqlBackup mb = new MySqlBackup(cmd))
                    {
                        if (!dir1.Exists)
                        {
                            MessageBox.Show("مجلد النسخ الاحتياطيه غير موجود");
                        }
                        else if (!File.Exists(file))
                        {
                            MessageBox.Show("النسخة الاحتياطيه غير موجودة");
                        }
                        else
                        {
                            cmd.Connection = conn;
                            conn.Open();
                            mb.ImportInfo.EnableEncryption = true;
                            mb.ImportInfo.EncryptionPassword = "PROFelixSHCO";
                            mb.ImportFromFile(file);
                            conn.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}