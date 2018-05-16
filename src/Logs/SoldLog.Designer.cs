namespace PharmacyProManager.Logs
{
    partial class SoldLog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SoldLog));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tottal1 = new System.Windows.Forms.TextBox();
            this.Sold1 = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tottal2 = new System.Windows.Forms.TextBox();
            this.Sold2 = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.RightToLeftLayout = true;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(581, 374);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tottal1);
            this.tabPage1.Controls.Add(this.Sold1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(573, 348);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "اليوم";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tottal1
            // 
            this.tottal1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tottal1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.tottal1.Location = new System.Drawing.Point(3, 321);
            this.tottal1.Name = "tottal1";
            this.tottal1.ReadOnly = true;
            this.tottal1.Size = new System.Drawing.Size(567, 24);
            this.tottal1.TabIndex = 1;
            // 
            // Sold1
            // 
            this.Sold1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Sold1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.Sold1.Location = new System.Drawing.Point(3, 3);
            this.Sold1.Multiline = true;
            this.Sold1.Name = "Sold1";
            this.Sold1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.Sold1.Size = new System.Drawing.Size(567, 342);
            this.Sold1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tottal2);
            this.tabPage2.Controls.Add(this.Sold2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(573, 348);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "سابقا";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tottal2
            // 
            this.tottal2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tottal2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.tottal2.Location = new System.Drawing.Point(3, 321);
            this.tottal2.Name = "tottal2";
            this.tottal2.ReadOnly = true;
            this.tottal2.Size = new System.Drawing.Size(567, 24);
            this.tottal2.TabIndex = 1;
            // 
            // Sold2
            // 
            this.Sold2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Sold2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.Sold2.Location = new System.Drawing.Point(3, 3);
            this.Sold2.Multiline = true;
            this.Sold2.Name = "Sold2";
            this.Sold2.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.Sold2.Size = new System.Drawing.Size(567, 342);
            this.Sold2.TabIndex = 0;
            // 
            // SoldLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 374);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SoldLog";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "سجل المبيعات";
            this.Load += new System.EventHandler(this.SoldLog_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox Sold2;
        private System.Windows.Forms.TextBox Sold1;
        private System.Windows.Forms.TextBox tottal1;
        private System.Windows.Forms.TextBox tottal2;
    }
}