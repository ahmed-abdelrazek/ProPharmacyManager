namespace PharmacyProManager.Logs
{
    partial class InvLog
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
            this.text1 = new System.Windows.Forms.TextBox();
            this.ttext1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // text1
            // 
            this.text1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.text1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.text1.Location = new System.Drawing.Point(0, 0);
            this.text1.Multiline = true;
            this.text1.Name = "text1";
            this.text1.ReadOnly = true;
            this.text1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.text1.Size = new System.Drawing.Size(581, 370);
            this.text1.TabIndex = 0;
            // 
            // ttext1
            // 
            this.ttext1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ttext1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.ttext1.ForeColor = System.Drawing.Color.Red;
            this.ttext1.Location = new System.Drawing.Point(0, 346);
            this.ttext1.MaxLength = 0;
            this.ttext1.Name = "ttext1";
            this.ttext1.ReadOnly = true;
            this.ttext1.Size = new System.Drawing.Size(581, 24);
            this.ttext1.TabIndex = 1;
            // 
            // InvLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 370);
            this.Controls.Add(this.ttext1);
            this.Controls.Add(this.text1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "InvLog";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "سجل الادويه";
            this.Load += new System.EventHandler(this.InvLog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox text1;
        private System.Windows.Forms.TextBox ttext1;
    }
}