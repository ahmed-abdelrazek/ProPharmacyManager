namespace ProPharmacyManager.Logs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InvLog));
            this.DGV = new System.Windows.Forms.DataGridView();
            this.medicn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.totalprice = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGV
            // 
            this.DGV.AllowUserToDeleteRows = false;
            this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.medicn,
            this.price,
            this.count,
            this.exp});
            this.DGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV.Location = new System.Drawing.Point(0, 0);
            this.DGV.Name = "DGV";
            this.DGV.ReadOnly = true;
            this.DGV.Size = new System.Drawing.Size(581, 374);
            this.DGV.TabIndex = 1;
            // 
            // medicn
            // 
            this.medicn.HeaderText = "الاسم";
            this.medicn.Name = "medicn";
            this.medicn.ReadOnly = true;
            // 
            // price
            // 
            this.price.HeaderText = "السعر";
            this.price.Name = "price";
            this.price.ReadOnly = true;
            // 
            // count
            // 
            this.count.HeaderText = "الكميه";
            this.count.Name = "count";
            this.count.ReadOnly = true;
            // 
            // exp
            // 
            this.exp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.exp.HeaderText = "مده انتهاء الصلاحيه";
            this.exp.Name = "exp";
            this.exp.ReadOnly = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.totalprice});
            this.statusStrip1.Location = new System.Drawing.Point(0, 348);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(581, 26);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // totalprice
            // 
            this.totalprice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.totalprice.Name = "totalprice";
            this.totalprice.RightToLeftAutoMirrorImage = true;
            this.totalprice.Size = new System.Drawing.Size(566, 21);
            this.totalprice.Spring = true;
            this.totalprice.Text = "toolStripStatusLabel1";
            // 
            // InvLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 374);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.DGV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InvLog";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "سجل الادويه";
            this.Load += new System.EventHandler(this.InvLog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel totalprice;
        private System.Windows.Forms.DataGridViewTextBoxColumn medicn;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn count;
        private System.Windows.Forms.DataGridViewTextBoxColumn exp;


    }
}