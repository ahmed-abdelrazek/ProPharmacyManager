﻿namespace PharmacyProManager
{
    partial class EXPEnd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EXPEnd));
            this.EXPLog = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // EXPLog
            // 
            this.EXPLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EXPLog.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.EXPLog.ForeColor = System.Drawing.Color.Coral;
            this.EXPLog.Location = new System.Drawing.Point(0, 0);
            this.EXPLog.Multiline = true;
            this.EXPLog.Name = "EXPLog";
            this.EXPLog.ReadOnly = true;
            this.EXPLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.EXPLog.Size = new System.Drawing.Size(581, 374);
            this.EXPLog.TabIndex = 0;
            // 
            // EXPEnd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 374);
            this.Controls.Add(this.EXPLog);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EXPEnd";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "الادويه منتهيه الصلاحيه";
            this.Load += new System.EventHandler(this.EXPEnd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox EXPLog;
    }
}