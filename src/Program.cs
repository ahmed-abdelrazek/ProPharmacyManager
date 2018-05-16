using ProPharmacyManager.Database;
using ProPharmacyManager.Kernel;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace ProPharmacyManager
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            bool createdNew = true;
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
                    foreach (Process process2 in Process.GetProcessesByName(currentProcess.ProcessName))
                    {
                        if (process2.Id != currentProcess.Id)
                        {
                            MessageBox.Show("البرنامج يعمل بالفعل!");
                            return;
                        }
                    }
                }
            }
        }
        private static void EngineThread_Execute()
        {
            try
            {
                string str = "configuration.ini";
                IniFile file = new IniFile(str);
                if (!File.Exists(str))
                {
                    Kernel.Setup set = new Kernel.Setup();
                    set.Text = "تنصيب البرنامج";
                    set.ShowDialog();
                }
                DataHolder.CreateConnection(file.ReadString("MySql", "Username"), file.ReadString("MySql", "Password"), file.ReadString("MySql", "Database"), file.ReadString("MySql", "Host"));
                GC.Collect();
                BillsTable.LBN();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }
        }
        public static void SaveException(Exception e)
        {
            if (e.TargetSite.Name != "ThrowInvalidOperationException")
            {
                MessageBox.Show(e.ToString());
                DateTime now = DateTime.Now;
                string str = string.Concat(new object[] { now.Month, "-", now.Day, "//" });
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
                File.WriteAllLines((Application.StartupPath + @"\exceptions\" + str + e.TargetSite.Name + @"\") + string.Concat(new object[] { now.Hour, "-", now.Minute, "-", now.Ticks & 10L }) + ".txt", new List<string> { "----Exception message----", e.Message, "----End of exception message----\r\n", "----Stack trace----", e.StackTrace, "----End of stack trace----\r\n" }.ToArray());
            }
        }
        private static void Application_ThreadException(object sender, ThreadExceptionEventArgs e)
        {
            SaveException(e.Exception);
        }
    }
}
