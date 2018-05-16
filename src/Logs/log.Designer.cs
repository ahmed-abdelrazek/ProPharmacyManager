namespace PharmacyProManager
{
    partial class log
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(log));
            this.logss = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // logss
            // 
            this.logss.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logss.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.logss.ForeColor = System.Drawing.Color.Red;
            this.logss.ImeMode = System.Windows.Forms.ImeMode.On;
            this.logss.Location = new System.Drawing.Point(0, 0);
            this.logss.Multiline = true;
            this.logss.Name = "logss";
            this.logss.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.logss.Size = new System.Drawing.Size(581, 374);
            this.logss.TabIndex = 1;
            // 
            // log
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 374);
            this.Controls.Add(this.logss);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "log";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "سجل الدخول";
            this.Load += new System.EventHandler(this.log_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox logss;
    }
}