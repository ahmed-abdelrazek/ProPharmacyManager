namespace PharmacyProManager
{
    partial class CPanal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CPanal));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.FP = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SearchB = new System.Windows.Forms.Button();
            this.SearchT = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.UPdateB = new System.Windows.Forms.Button();
            this.LogOutB = new System.Windows.Forms.Button();
            this.SellB = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.PSubS = new System.Windows.Forms.TextBox();
            this.PName = new System.Windows.Forms.TextBox();
            this.PEXP = new System.Windows.Forms.TextBox();
            this.PType = new System.Windows.Forms.TextBox();
            this.Pnote = new System.Windows.Forms.TextBox();
            this.PTottal = new System.Windows.Forms.TextBox();
            this.PCost = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::PharmacyProManager.Properties.Resources.cpwapp;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(681, 438);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.groupBox1.Controls.Add(this.FP);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.SearchB);
            this.groupBox1.Controls.Add(this.SearchT);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.OrangeRed;
            this.groupBox1.Location = new System.Drawing.Point(12, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(235, 196);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "البحث";
            // 
            // FP
            // 
            this.FP.AutoSize = true;
            this.FP.ForeColor = System.Drawing.Color.Green;
            this.FP.Location = new System.Drawing.Point(83, 105);
            this.FP.Name = "FP";
            this.FP.Size = new System.Drawing.Size(72, 17);
            this.FP.TabIndex = 3;
            this.FP.Text = "وجد الدواء";
            this.FP.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(148, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "اسم الدواء:";
            // 
            // SearchB
            // 
            this.SearchB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchB.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.SearchB.Image = global::PharmacyProManager.Properties.Resources.Search;
            this.SearchB.Location = new System.Drawing.Point(47, 131);
            this.SearchB.Name = "SearchB";
            this.SearchB.Size = new System.Drawing.Size(150, 60);
            this.SearchB.TabIndex = 2;
            this.SearchB.UseVisualStyleBackColor = true;
            this.SearchB.Click += new System.EventHandler(this.button1_Click);
            // 
            // SearchT
            // 
            this.SearchT.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold);
            this.SearchT.Location = new System.Drawing.Point(6, 49);
            this.SearchT.Name = "SearchT";
            this.SearchT.Size = new System.Drawing.Size(219, 32);
            this.SearchT.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.UPdateB);
            this.panel1.Controls.Add(this.LogOutB);
            this.panel1.Controls.Add(this.SellB);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Location = new System.Drawing.Point(0, 358);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(681, 80);
            this.panel1.TabIndex = 2;
            // 
            // UPdateB
            // 
            this.UPdateB.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.UPdateB.FlatAppearance.BorderSize = 0;
            this.UPdateB.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.UPdateB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.UPdateB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UPdateB.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.UPdateB.Image = global::PharmacyProManager.Properties.Resources.Update;
            this.UPdateB.Location = new System.Drawing.Point(264, 9);
            this.UPdateB.Name = "UPdateB";
            this.UPdateB.Size = new System.Drawing.Size(150, 60);
            this.UPdateB.TabIndex = 5;
            this.UPdateB.UseVisualStyleBackColor = true;
            this.UPdateB.Click += new System.EventHandler(this.UPdateB_Click);
            // 
            // LogOutB
            // 
            this.LogOutB.FlatAppearance.BorderColor = System.Drawing.Color.DarkCyan;
            this.LogOutB.FlatAppearance.BorderSize = 0;
            this.LogOutB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogOutB.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LogOutB.Image = global::PharmacyProManager.Properties.Resources.Power___Log_Off;
            this.LogOutB.Location = new System.Drawing.Point(462, 7);
            this.LogOutB.Name = "LogOutB";
            this.LogOutB.Size = new System.Drawing.Size(150, 60);
            this.LogOutB.TabIndex = 6;
            this.LogOutB.UseVisualStyleBackColor = true;
            this.LogOutB.Click += new System.EventHandler(this.button4_Click);
            // 
            // SellB
            // 
            this.SellB.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.SellB.FlatAppearance.BorderSize = 0;
            this.SellB.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.SellB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.SellB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SellB.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SellB.Image = global::PharmacyProManager.Properties.Resources.Windows_Marketplace;
            this.SellB.Location = new System.Drawing.Point(68, 7);
            this.SellB.Name = "SellB";
            this.SellB.Size = new System.Drawing.Size(150, 60);
            this.SellB.TabIndex = 4;
            this.SellB.UseVisualStyleBackColor = true;
            this.SellB.Click += new System.EventHandler(this.SellB_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.DodgerBlue;
            this.groupBox2.Controls.Add(this.PSubS);
            this.groupBox2.Controls.Add(this.PName);
            this.groupBox2.Controls.Add(this.PEXP);
            this.groupBox2.Controls.Add(this.PType);
            this.groupBox2.Controls.Add(this.Pnote);
            this.groupBox2.Controls.Add(this.PTottal);
            this.groupBox2.Controls.Add(this.PCost);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.groupBox2.ForeColor = System.Drawing.Color.Snow;
            this.groupBox2.Location = new System.Drawing.Point(253, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(416, 339);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "النتيجه";
            // 
            // PSubS
            // 
            this.PSubS.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold);
            this.PSubS.Location = new System.Drawing.Point(6, 210);
            this.PSubS.Name = "PSubS";
            this.PSubS.ReadOnly = true;
            this.PSubS.Size = new System.Drawing.Size(272, 32);
            this.PSubS.TabIndex = 16;
            this.PSubS.TabStop = false;
            // 
            // PName
            // 
            this.PName.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold);
            this.PName.Location = new System.Drawing.Point(6, 20);
            this.PName.Name = "PName";
            this.PName.ReadOnly = true;
            this.PName.Size = new System.Drawing.Size(272, 32);
            this.PName.TabIndex = 7;
            this.PName.TabStop = false;
            // 
            // PEXP
            // 
            this.PEXP.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold);
            this.PEXP.Location = new System.Drawing.Point(6, 58);
            this.PEXP.Name = "PEXP";
            this.PEXP.ReadOnly = true;
            this.PEXP.Size = new System.Drawing.Size(272, 32);
            this.PEXP.TabIndex = 14;
            this.PEXP.TabStop = false;
            // 
            // PType
            // 
            this.PType.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold);
            this.PType.Location = new System.Drawing.Point(6, 96);
            this.PType.Name = "PType";
            this.PType.ReadOnly = true;
            this.PType.Size = new System.Drawing.Size(272, 32);
            this.PType.TabIndex = 13;
            this.PType.TabStop = false;
            // 
            // Pnote
            // 
            this.Pnote.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold);
            this.Pnote.Location = new System.Drawing.Point(6, 248);
            this.Pnote.Multiline = true;
            this.Pnote.Name = "Pnote";
            this.Pnote.Size = new System.Drawing.Size(272, 85);
            this.Pnote.TabIndex = 3;
            // 
            // PTottal
            // 
            this.PTottal.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold);
            this.PTottal.Location = new System.Drawing.Point(6, 134);
            this.PTottal.Name = "PTottal";
            this.PTottal.ReadOnly = true;
            this.PTottal.Size = new System.Drawing.Size(272, 32);
            this.PTottal.TabIndex = 11;
            this.PTottal.TabStop = false;
            // 
            // PCost
            // 
            this.PCost.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold);
            this.PCost.Location = new System.Drawing.Point(6, 172);
            this.PCost.Name = "PCost";
            this.PCost.ReadOnly = true;
            this.PCost.Size = new System.Drawing.Size(272, 32);
            this.PCost.TabIndex = 10;
            this.PCost.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(298, 220);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 17);
            this.label8.TabIndex = 9;
            this.label8.Text = "المادة الفعاله:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(326, 258);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 17);
            this.label7.TabIndex = 8;
            this.label7.Text = "ملاحظات:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(345, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "السعر:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(353, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "النوع:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(299, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "مده الصلاحيه:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(345, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "الكميه:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(318, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "اسم الدواء:";
            // 
            // CPanal
            // 
            this.AcceptButton = this.SearchB;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(681, 438);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CPanal";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "مدير الصيدليه";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CPanal_FormClosing);
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.CPanal_HelpRequested);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox SearchT;
        private System.Windows.Forms.Button SearchB;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button LogOutB;
        private System.Windows.Forms.Button SellB;
        private System.Windows.Forms.TextBox PSubS;
        private System.Windows.Forms.TextBox PName;
        private System.Windows.Forms.TextBox PEXP;
        private System.Windows.Forms.TextBox PType;
        private System.Windows.Forms.TextBox Pnote;
        private System.Windows.Forms.TextBox PTottal;
        private System.Windows.Forms.TextBox PCost;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button UPdateB;
        private System.Windows.Forms.Label FP;
    }
}