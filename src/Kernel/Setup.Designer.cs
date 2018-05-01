﻿// <copyright>
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
namespace ProPharmacyManager.Kernel
{
    partial class Setup
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Setup));
            this.DBUser = new System.Windows.Forms.TextBox();
            this.DBPass = new System.Windows.Forms.TextBox();
            this.DBName = new System.Windows.Forms.TextBox();
            this.DBHost = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Install = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Upgrade = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // DBUser
            // 
            this.DBUser.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.DBUser.Location = new System.Drawing.Point(277, 114);
            this.DBUser.Multiline = true;
            this.DBUser.Name = "DBUser";
            this.DBUser.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DBUser.Size = new System.Drawing.Size(190, 45);
            this.DBUser.TabIndex = 3;
            this.DBUser.Text = "root";
            this.toolTip1.SetToolTip(this.DBUser, "اسم المستخدم لبرنامج السيرفر اذا لم يسالك عنه اتركه كما هو");
            // 
            // DBPass
            // 
            this.DBPass.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.DBPass.Location = new System.Drawing.Point(277, 165);
            this.DBPass.Multiline = true;
            this.DBPass.Name = "DBPass";
            this.DBPass.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DBPass.Size = new System.Drawing.Size(190, 44);
            this.DBPass.TabIndex = 4;
            this.DBPass.Text = "1234";
            this.toolTip1.SetToolTip(this.DBPass, "كلمه مرور برنامج السيرفر اذا لم يسالك عنه اجعله فارغ");
            // 
            // DBName
            // 
            this.DBName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.DBName.Location = new System.Drawing.Point(277, 68);
            this.DBName.Multiline = true;
            this.DBName.Name = "DBName";
            this.DBName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DBName.Size = new System.Drawing.Size(190, 40);
            this.DBName.TabIndex = 2;
            this.DBName.Text = "phdb";
            this.toolTip1.SetToolTip(this.DBName, "اسم قاعده البيانات التى ستسجل كل شئ");
            // 
            // DBHost
            // 
            this.DBHost.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.DBHost.Location = new System.Drawing.Point(277, 22);
            this.DBHost.Multiline = true;
            this.DBHost.Name = "DBHost";
            this.DBHost.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DBHost.Size = new System.Drawing.Size(190, 37);
            this.DBHost.TabIndex = 1;
            this.DBHost.Text = "localhost";
            this.toolTip1.SetToolTip(this.DBHost, "اتركها كما هى او استخدم الاستاتك ايبى الخاص بشبكتك");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(37, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "المضيف";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(37, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "اسم قاعده البيانات";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(37, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "اسم المستخدم";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(37, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "كلمه مرور المستخدم";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(134, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(230, 19);
            this.label5.TabIndex = 8;
            this.label5.Text = "لا تقوم بتغيير اى من الاعدادات";
            // 
            // Install
            // 
            this.Install.BackColor = System.Drawing.Color.ForestGreen;
            this.Install.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Install.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.Install.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Install.Location = new System.Drawing.Point(317, 319);
            this.Install.Name = "Install";
            this.Install.Size = new System.Drawing.Size(150, 60);
            this.Install.TabIndex = 5;
            this.Install.Text = "حفظ";
            this.Install.UseVisualStyleBackColor = false;
            this.Install.Click += new System.EventHandler(this.Install_Click);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.DarkOrange;
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.Exit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Exit.Location = new System.Drawing.Point(5, 319);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(150, 60);
            this.Exit.TabIndex = 6;
            this.Exit.Text = "خروج";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label6.Location = new System.Drawing.Point(150, 256);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(196, 19);
            this.label6.TabIndex = 11;
            this.label6.Text = "لو لم تكن تعرف ماذا تفعل";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label7.Location = new System.Drawing.Point(134, 284);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(246, 19);
            this.label7.TabIndex = 12;
            this.label7.Text = "سوف تتسبب فى توقف البرنامج";
            // 
            // Upgrade
            // 
            this.Upgrade.BackColor = System.Drawing.Color.MediumBlue;
            this.Upgrade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Upgrade.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.Upgrade.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Upgrade.Location = new System.Drawing.Point(161, 319);
            this.Upgrade.Name = "Upgrade";
            this.Upgrade.Size = new System.Drawing.Size(150, 60);
            this.Upgrade.TabIndex = 13;
            this.Upgrade.Text = "ترقيه";
            this.toolTip1.SetToolTip(this.Upgrade, "اذا كنت تستخدم البرنامج من قبل استخدم الترقيه");
            this.Upgrade.UseVisualStyleBackColor = false;
            this.Upgrade.Visible = false;
            this.Upgrade.Click += new System.EventHandler(this.Upgrade_Click);
            // 
            // Setup
            // 
            this.AcceptButton = this.Install;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(479, 388);
            this.Controls.Add(this.Upgrade);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Install);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DBHost);
            this.Controls.Add(this.DBName);
            this.Controls.Add(this.DBPass);
            this.Controls.Add(this.DBUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Setup";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اعدادات البرنامج";
            this.Load += new System.EventHandler(this.Setup_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox DBUser;
        private System.Windows.Forms.TextBox DBPass;
        private System.Windows.Forms.TextBox DBName;
        private System.Windows.Forms.TextBox DBHost;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Install;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button Upgrade;
    }
}