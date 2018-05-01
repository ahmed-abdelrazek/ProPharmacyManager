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
namespace ProPharmacyManager.Kernel
{
    partial class BAR
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BAR));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Exit = new ProPharmacyManager.ImageButton();
            this.DeleteBackUpB = new ProPharmacyManager.ImageButton();
            this.RestoreB = new ProPharmacyManager.ImageButton();
            this.BackUpB = new ProPharmacyManager.ImageButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.EncryptionKey = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BBrowser = new System.Windows.Forms.Button();
            this.BPath = new System.Windows.Forms.TextBox();
            this.BackUpList = new System.Windows.Forms.ListBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel1.Controls.Add(this.Exit);
            this.panel1.Controls.Add(this.DeleteBackUpB);
            this.panel1.Controls.Add(this.RestoreB);
            this.panel1.Controls.Add(this.BackUpB);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 373);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(774, 78);
            this.panel1.TabIndex = 0;
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Exit.ButtonImage = global::ProPharmacyManager.Properties.Resources.Power___Log_Off;
            this.Exit.ButtonImageOffset = new System.Drawing.Point(0, 0);
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.Exit.Location = new System.Drawing.Point(601, 9);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(150, 60);
            this.Exit.TabIndex = 3;
            this.toolTip1.SetToolTip(this.Exit, "للعودة للوحه الادارة");
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // DeleteBackUpB
            // 
            this.DeleteBackUpB.BackColor = System.Drawing.Color.WhiteSmoke;
            this.DeleteBackUpB.ButtonImage = global::ProPharmacyManager.Properties.Resources.DBackup;
            this.DeleteBackUpB.ButtonImageOffset = new System.Drawing.Point(0, 0);
            this.DeleteBackUpB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteBackUpB.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.DeleteBackUpB.Location = new System.Drawing.Point(404, 9);
            this.DeleteBackUpB.Name = "DeleteBackUpB";
            this.DeleteBackUpB.Size = new System.Drawing.Size(150, 60);
            this.DeleteBackUpB.TabIndex = 2;
            this.toolTip1.SetToolTip(this.DeleteBackUpB, "لحذف احد النسخ الاحتياطيه من الاعلى");
            this.DeleteBackUpB.UseVisualStyleBackColor = true;
            this.DeleteBackUpB.Click += new System.EventHandler(this.DeleteBackUpB_Click);
            // 
            // RestoreB
            // 
            this.RestoreB.BackColor = System.Drawing.Color.WhiteSmoke;
            this.RestoreB.ButtonImage = global::ProPharmacyManager.Properties.Resources.Restore;
            this.RestoreB.ButtonImageOffset = new System.Drawing.Point(0, 0);
            this.RestoreB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RestoreB.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.RestoreB.Location = new System.Drawing.Point(208, 9);
            this.RestoreB.Name = "RestoreB";
            this.RestoreB.Size = new System.Drawing.Size(150, 60);
            this.RestoreB.TabIndex = 1;
            this.toolTip1.SetToolTip(this.RestoreB, "لاسترجاع واحدة من النسخ الاحتياطيه فى الاعلى");
            this.RestoreB.UseVisualStyleBackColor = true;
            this.RestoreB.Click += new System.EventHandler(this.RestoreB_Click);
            // 
            // BackUpB
            // 
            this.BackUpB.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackUpB.ButtonImage = global::ProPharmacyManager.Properties.Resources.Backup;
            this.BackUpB.ButtonImageOffset = new System.Drawing.Point(0, 0);
            this.BackUpB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackUpB.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.BackUpB.Location = new System.Drawing.Point(12, 6);
            this.BackUpB.Name = "BackUpB";
            this.BackUpB.Size = new System.Drawing.Size(150, 60);
            this.BackUpB.TabIndex = 0;
            this.toolTip1.SetToolTip(this.BackUpB, "لاخذ نسخة احتياطيه من قاعدة البيانات");
            this.BackUpB.UseVisualStyleBackColor = true;
            this.BackUpB.Click += new System.EventHandler(this.BackUpB_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.EncryptionKey);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.BBrowser);
            this.panel2.Controls.Add(this.BPath);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(774, 106);
            this.panel2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(559, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "مفتاح التشفير*";
            this.toolTip1.SetToolTip(this.label2, "كلمه سر لتشفير النسخ الاحتياطيه لعدم تمكين الغير من العبث بها");
            // 
            // EncryptionKey
            // 
            this.EncryptionKey.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.EncryptionKey.Location = new System.Drawing.Point(208, 60);
            this.EncryptionKey.Name = "EncryptionKey";
            this.EncryptionKey.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.EncryptionKey.Size = new System.Drawing.Size(346, 27);
            this.EncryptionKey.TabIndex = 3;
            this.EncryptionKey.Tag = "";
            this.toolTip1.SetToolTip(this.EncryptionKey, "احرف انكليزيه فقط");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(669, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "مكان النسخ";
            // 
            // BBrowser
            // 
            this.BBrowser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BBrowser.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.BBrowser.ForeColor = System.Drawing.Color.White;
            this.BBrowser.Location = new System.Drawing.Point(12, 22);
            this.BBrowser.Name = "BBrowser";
            this.BBrowser.Size = new System.Drawing.Size(79, 27);
            this.BBrowser.TabIndex = 1;
            this.BBrowser.Text = "استعرض";
            this.toolTip1.SetToolTip(this.BBrowser, "لاستعراض النسخ الاحتياطيه فى المجلد حتى يمكنك تعدلها نقلها ..الخ");
            this.BBrowser.UseVisualStyleBackColor = true;
            this.BBrowser.Click += new System.EventHandler(this.BBrowser_Click);
            // 
            // BPath
            // 
            this.BPath.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.BPath.Location = new System.Drawing.Point(97, 22);
            this.BPath.Name = "BPath";
            this.BPath.ReadOnly = true;
            this.BPath.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BPath.Size = new System.Drawing.Size(566, 27);
            this.BPath.TabIndex = 0;
            this.toolTip1.SetToolTip(this.BPath, "مكان النسخ الاحتياطيه");
            // 
            // BackUpList
            // 
            this.BackUpList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BackUpList.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.BackUpList.FormattingEnabled = true;
            this.BackUpList.ItemHeight = 19;
            this.BackUpList.Location = new System.Drawing.Point(0, 106);
            this.BackUpList.Name = "BackUpList";
            this.BackUpList.Size = new System.Drawing.Size(774, 267);
            this.BackUpList.TabIndex = 2;
            // 
            // BAR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(774, 451);
            this.Controls.Add(this.BackUpList);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "BAR";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "النسخ الاحتياطيه";
            this.Load += new System.EventHandler(this.BAR_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private ImageButton DeleteBackUpB;
        private ImageButton RestoreB;
        private ImageButton BackUpB;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BBrowser;
        private System.Windows.Forms.TextBox BPath;
        private System.Windows.Forms.ListBox BackUpList;
        private ImageButton Exit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox EncryptionKey;
    }
}