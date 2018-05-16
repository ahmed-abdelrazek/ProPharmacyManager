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
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using ProPharmacyManager.Database;

namespace ProPharmacyManager.Kernel
{
    public partial class BAR : Form
    {
        public BAR()
        {
            InitializeComponent();
        }
        /// <summary> 
        /// refresh backup list
        /// </summary> 
        private void Reload()
        {
            BackUpList.Items.Clear();
            DirectoryInfo dinfo = new DirectoryInfo(BPath.Text);
            FileInfo[] Files = dinfo.GetFiles("*.sql");
            foreach (FileInfo file in Files)
            {
                BackUpList.Items.Add(file.Name);
            }
        }
        
        private void BAR_Load(object sender, EventArgs e)
        {
            IniFile file = new IniFile(Constants.BackupConfigPath);
            if (File.Exists(Constants.BackupConfigPath))
            {
                BPath.Text = file.ReadString("BackUp", "Path");
            }
            else if (!File.Exists(Constants.BackupConfigPath))
            {
                DirectoryInfo dir1 = new DirectoryInfo("BackUp\\");
                string[] lines = {"[BackUp]", "Path=" + dir1.FullName};
                File.WriteAllLines(Constants.BackupConfigPath, lines);
                BPath.Text = file.ReadString("BackUp", "Path");
            }
            if (!Directory.Exists(Application.StartupPath + @"BackUp\"))
            {
                Directory.CreateDirectory(Application.StartupPath + @"\BackUp\");
            }
            DirectoryInfo dinfo = new DirectoryInfo(BPath.Text);
            FileInfo[] Files = dinfo.GetFiles("*.sql");
            foreach (FileInfo file1 in Files)
            {
                BackUpList.Items.Add(file1.Name);
            }
        }

        private void BBrowser_Click(object sender, EventArgs e)
        {
            Process.Start(BPath.Text);
        }

        private void DeleteBackUpB_Click(object sender, EventArgs e)
        {
            File.Delete(BPath.Text+BackUpList.SelectedItem);
            Reload();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Hide();
        }
        private void BackUpB_Click(object sender, EventArgs e)
        {
            if (EncryptionKey.Text != "")
            {
                CheckForIllegalCrossThreadCalls = false;
                Thread th2 = new Thread(() => BackUp.Backup(EncryptionKey.Text));
                th2.Start();
            }
            else
            {
                MessageBox.Show("اختر مفتاح تشفير بالانجلزيه و احفظه جيدا لانك ستحتاجه فى كل مرة تحفظ او تسترجع نسخة احتياطيه");
            }
            Reload();
        }
        private void RestoreB_Click(object sender, EventArgs e)
        {
            if (EncryptionKey.Text != "")
            {
                CheckForIllegalCrossThreadCalls = false;
                Thread th2 = new Thread(() => BackUp.Restore(BPath.Text + BackUpList.SelectedItem, EncryptionKey.Text));
                th2.Start();
            }
            else
            {
                MessageBox.Show("اختر مفتاح تشفير بالانجلزيه و احفظه جيدا لانك ستحتاجه فى كل مرة تحفظ او تسترجع نسخة احتياطيه");
            }
        }

    }
}
