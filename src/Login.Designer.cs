﻿namespace PharmacyProManager
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.ExitB = new System.Windows.Forms.Button();
            this.LoginB = new System.Windows.Forms.Button();
            this.UNPW = new System.Windows.Forms.Label();
            this.UN = new System.Windows.Forms.TextBox();
            this.UP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ExitB
            // 
            this.ExitB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitB.ForeColor = System.Drawing.Color.ForestGreen;
            this.ExitB.Image = global::PharmacyProManager.Properties.Resources.Power___Shut_Down;
            this.ExitB.Location = new System.Drawing.Point(12, 245);
            this.ExitB.Name = "ExitB";
            this.ExitB.Size = new System.Drawing.Size(150, 60);
            this.ExitB.TabIndex = 4;
            this.ExitB.UseVisualStyleBackColor = true;
            this.ExitB.Click += new System.EventHandler(this.LoginB_Click);
            // 
            // LoginB
            // 
            this.LoginB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginB.ForeColor = System.Drawing.Color.ForestGreen;
            this.LoginB.Image = global::PharmacyProManager.Properties.Resources.login;
            this.LoginB.Location = new System.Drawing.Point(226, 245);
            this.LoginB.Name = "LoginB";
            this.LoginB.Size = new System.Drawing.Size(150, 60);
            this.LoginB.TabIndex = 3;
            this.LoginB.UseVisualStyleBackColor = true;
            this.LoginB.Click += new System.EventHandler(this.ExitB_Click);
            // 
            // UNPW
            // 
            this.UNPW.AutoSize = true;
            this.UNPW.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.UNPW.ForeColor = System.Drawing.Color.Red;
            this.UNPW.Location = new System.Drawing.Point(51, 202);
            this.UNPW.Name = "UNPW";
            this.UNPW.Size = new System.Drawing.Size(289, 19);
            this.UNPW.TabIndex = 5;
            this.UNPW.Text = "أسم المستخدم و/او كلمه المرور خطأ!";
            this.UNPW.Visible = false;
            // 
            // UN
            // 
            this.UN.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Bold);
            this.UN.ForeColor = System.Drawing.Color.MediumBlue;
            this.UN.Location = new System.Drawing.Point(12, 55);
            this.UN.Name = "UN";
            this.UN.Size = new System.Drawing.Size(364, 40);
            this.UN.TabIndex = 1;
            this.UN.TextChanged += new System.EventHandler(this.UN_TextChanged);
            // 
            // UP
            // 
            this.UP.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Bold);
            this.UP.ForeColor = System.Drawing.Color.MediumBlue;
            this.UP.Location = new System.Drawing.Point(12, 138);
            this.UP.Name = "UP";
            this.UP.PasswordChar = '*';
            this.UP.Size = new System.Drawing.Size(364, 40);
            this.UP.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(12, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 19);
            this.label1.TabIndex = 8;
            this.label1.Text = "كلمه المرور:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Snow;
            this.label2.Location = new System.Drawing.Point(12, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 19);
            this.label2.TabIndex = 9;
            this.label2.Text = "أسم المستخدم:";
            // 
            // Login
            // 
            this.AcceptButton = this.LoginB;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.ClientSize = new System.Drawing.Size(388, 317);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UP);
            this.Controls.Add(this.UN);
            this.Controls.Add(this.UNPW);
            this.Controls.Add(this.LoginB);
            this.Controls.Add(this.ExitB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Login";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تسجيل الدخول";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Login_FormClosing);
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.Login_HelpRequested);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ExitB;
        private System.Windows.Forms.Button LoginB;
        private System.Windows.Forms.Label UNPW;
        private System.Windows.Forms.TextBox UP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox UN;
    }
}

