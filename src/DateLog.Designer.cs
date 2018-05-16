namespace PharmacyProManager
{
    partial class DateLog
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
            this.MedLog = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // MedLog
            // 
            this.MedLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MedLog.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.MedLog.ForeColor = System.Drawing.Color.Crimson;
            this.MedLog.Location = new System.Drawing.Point(0, 0);
            this.MedLog.Multiline = true;
            this.MedLog.Name = "MedLog";
            this.MedLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.MedLog.Size = new System.Drawing.Size(581, 374);
            this.MedLog.TabIndex = 0;
            // 
            // DateLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 374);
            this.Controls.Add(this.MedLog);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "DateLog";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "غير متوفر";
            this.Load += new System.EventHandler(this.DateLog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox MedLog;
    }
}