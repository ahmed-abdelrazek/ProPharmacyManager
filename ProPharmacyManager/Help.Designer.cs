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
namespace ProPharmacyManager
{
    partial class Help
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Help));
            this.Blogger = new ProPharmacyManager.ImageButton();
            this.Yahoo = new ProPharmacyManager.ImageButton();
            this.Twitter = new ProPharmacyManager.ImageButton();
            this.Face = new ProPharmacyManager.ImageButton();
            this.SuspendLayout();
            // 
            // Blogger
            // 
            this.Blogger.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Blogger.ButtonImage = global::ProPharmacyManager.Properties.Resources.Google_Blogger;
            this.Blogger.ButtonImageOffset = new System.Drawing.Point(0, 0);
            this.Blogger.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Blogger.Location = new System.Drawing.Point(45, 58);
            this.Blogger.Name = "Blogger";
            this.Blogger.Size = new System.Drawing.Size(50, 50);
            this.Blogger.TabIndex = 3;
            this.Blogger.Text = "imageButton4";
            this.Blogger.UseVisualStyleBackColor = false;
            this.Blogger.Click += new System.EventHandler(this.Blogger_Click);
            // 
            // Yahoo
            // 
            this.Yahoo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Yahoo.ButtonImage = global::ProPharmacyManager.Properties.Resources.Yahoo__alt_2;
            this.Yahoo.ButtonImageOffset = new System.Drawing.Point(0, 0);
            this.Yahoo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Yahoo.Location = new System.Drawing.Point(142, 58);
            this.Yahoo.Name = "Yahoo";
            this.Yahoo.Size = new System.Drawing.Size(50, 50);
            this.Yahoo.TabIndex = 2;
            this.Yahoo.Text = "imageButton3";
            this.Yahoo.UseVisualStyleBackColor = false;
            this.Yahoo.Click += new System.EventHandler(this.Yahoo_Click);
            // 
            // Twitter
            // 
            this.Twitter.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Twitter.ButtonImage = global::ProPharmacyManager.Properties.Resources.Twitter_alt_4;
            this.Twitter.ButtonImageOffset = new System.Drawing.Point(0, 0);
            this.Twitter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Twitter.Location = new System.Drawing.Point(237, 58);
            this.Twitter.Name = "Twitter";
            this.Twitter.Size = new System.Drawing.Size(50, 50);
            this.Twitter.TabIndex = 1;
            this.Twitter.Text = "imageButton2";
            this.Twitter.UseVisualStyleBackColor = false;
            this.Twitter.Click += new System.EventHandler(this.Twitter_Click);
            // 
            // Face
            // 
            this.Face.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Face.ButtonImage = global::ProPharmacyManager.Properties.Resources.Facebook_alt_1;
            this.Face.ButtonImageOffset = new System.Drawing.Point(0, 0);
            this.Face.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Face.Location = new System.Drawing.Point(332, 58);
            this.Face.Name = "Face";
            this.Face.Size = new System.Drawing.Size(50, 50);
            this.Face.TabIndex = 0;
            this.Face.Text = "imageButton1";
            this.Face.UseVisualStyleBackColor = false;
            this.Face.Click += new System.EventHandler(this.Face_Click);
            // 
            // Help
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(426, 157);
            this.Controls.Add(this.Blogger);
            this.Controls.Add(this.Yahoo);
            this.Controls.Add(this.Twitter);
            this.Controls.Add(this.Face);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Help";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "روابط المساعده";
            this.ResumeLayout(false);

        }

        #endregion

        private ImageButton Face;
        private ImageButton Twitter;
        private ImageButton Yahoo;
        private ImageButton Blogger;


    }
}