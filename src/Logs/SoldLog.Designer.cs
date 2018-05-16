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
            this.dd1 = new System.Windows.Forms.DataGridView();
            this.mn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tottal1 = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dd1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dd1
            // 
            this.dd1.AllowUserToDeleteRows = false;
            this.dd1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dd1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dd1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mn,
            this.sd,
            this.mp});
            this.dd1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dd1.Location = new System.Drawing.Point(0, 0);
            this.dd1.Name = "dd1";
            this.dd1.ReadOnly = true;
            this.dd1.Size = new System.Drawing.Size(581, 374);
            this.dd1.TabIndex = 0;
            // 
            // mn
            // 
            this.mn.FillWeight = 150F;
            this.mn.HeaderText = "الاسم";
            this.mn.Name = "mn";
            this.mn.ReadOnly = true;
            this.mn.Width = 150;
            // 
            // sd
            // 
            this.sd.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sd.FillWeight = 150F;
            this.sd.HeaderText = "وقت البيع";
            this.sd.Name = "sd";
            this.sd.ReadOnly = true;
            // 
            // mp
            // 
            this.mp.HeaderText = "السعر";
            this.mp.Name = "mp";
            this.mp.ReadOnly = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tottal1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 348);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(581, 26);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tottal1
            // 
            this.tottal1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.tottal1.ForeColor = System.Drawing.Color.OrangeRed;
            this.tottal1.Name = "tottal1";
            this.tottal1.Size = new System.Drawing.Size(174, 21);
            this.tottal1.Text = "toolStripStatusLabel1";
            // 
            // SoldLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 374);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.dd1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SoldLog";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "سجل المبيعات";
            this.Load += new System.EventHandler(this.SoldLog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dd1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dd1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tottal1;
        private System.Windows.Forms.DataGridViewTextBoxColumn mn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sd;
        private System.Windows.Forms.DataGridViewTextBoxColumn mp;


    }
}