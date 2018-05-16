namespace PharmacyProManager
{
    partial class AddMed
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddMed));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.PEX = new System.Windows.Forms.DateTimePicker();
            this.PSubS = new System.Windows.Forms.TextBox();
            this.PName = new System.Windows.Forms.TextBox();
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
            this.UPdateB = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.DodgerBlue;
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.PEX);
            this.groupBox2.Controls.Add(this.PSubS);
            this.groupBox2.Controls.Add(this.PName);
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
            this.groupBox2.Location = new System.Drawing.Point(0, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(463, 339);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "المعلومات المطلوبه";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "شرب",
            "اقراص",
            "حقن",
            "كريم/مرهم",
            "اخرى"});
            this.comboBox1.Location = new System.Drawing.Point(6, 96);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(272, 32);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.Text = "شرب";
            // 
            // PEX
            // 
            this.PEX.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold);
            this.PEX.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.PEX.Location = new System.Drawing.Point(6, 58);
            this.PEX.Name = "PEX";
            this.PEX.RightToLeftLayout = true;
            this.PEX.Size = new System.Drawing.Size(272, 32);
            this.PEX.TabIndex = 2;
            // 
            // PSubS
            // 
            this.PSubS.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold);
            this.PSubS.Location = new System.Drawing.Point(6, 210);
            this.PSubS.Name = "PSubS";
            this.PSubS.Size = new System.Drawing.Size(272, 32);
            this.PSubS.TabIndex = 6;
            // 
            // PName
            // 
            this.PName.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold);
            this.PName.Location = new System.Drawing.Point(6, 20);
            this.PName.Name = "PName";
            this.PName.Size = new System.Drawing.Size(272, 32);
            this.PName.TabIndex = 1;
            // 
            // Pnote
            // 
            this.Pnote.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold);
            this.Pnote.Location = new System.Drawing.Point(6, 248);
            this.Pnote.Multiline = true;
            this.Pnote.Name = "Pnote";
            this.Pnote.Size = new System.Drawing.Size(272, 85);
            this.Pnote.TabIndex = 7;
            // 
            // PTottal
            // 
            this.PTottal.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold);
            this.PTottal.Location = new System.Drawing.Point(6, 134);
            this.PTottal.Name = "PTottal";
            this.PTottal.Size = new System.Drawing.Size(272, 32);
            this.PTottal.TabIndex = 4;
            this.PTottal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PTottal_KeyPress);
            // 
            // PCost
            // 
            this.PCost.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold);
            this.PCost.Location = new System.Drawing.Point(6, 172);
            this.PCost.Name = "PCost";
            this.PCost.Size = new System.Drawing.Size(272, 32);
            this.PCost.TabIndex = 5;
            this.PCost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PCost_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(351, 220);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 17);
            this.label8.TabIndex = 9;
            this.label8.Text = "المادة الفعاله:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(379, 258);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 17);
            this.label7.TabIndex = 8;
            this.label7.Text = "ملاحظات:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(398, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "السعر:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(406, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "النوع:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(343, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "انتهاء الصلاحيه:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(398, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "الكميه:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(371, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "اسم الدواء:";
            // 
            // UPdateB
            // 
            this.UPdateB.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.UPdateB.FlatAppearance.BorderSize = 0;
            this.UPdateB.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.UPdateB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.UPdateB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UPdateB.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.UPdateB.Image = global::PharmacyProManager.Properties.Resources.Save;
            this.UPdateB.Location = new System.Drawing.Point(301, 357);
            this.UPdateB.Name = "UPdateB";
            this.UPdateB.Size = new System.Drawing.Size(150, 60);
            this.UPdateB.TabIndex = 8;
            this.UPdateB.UseVisualStyleBackColor = true;
            this.UPdateB.Click += new System.EventHandler(this.UPdateB_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label16.ForeColor = System.Drawing.Color.Green;
            this.label16.Location = new System.Drawing.Point(57, 381);
            this.label16.Name = "label16";
            this.label16.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label16.Size = new System.Drawing.Size(119, 13);
            this.label16.TabIndex = 89;
            this.label16.Text = "تم اضافه الدواء بنجاح.";
            this.label16.Visible = false;
            // 
            // AddMed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(463, 424);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.UPdateB);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AddMed";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اضافة دواء جديد";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox PSubS;
        private System.Windows.Forms.TextBox PName;
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
        private System.Windows.Forms.DateTimePicker PEX;
        private System.Windows.Forms.Button UPdateB;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label16;
    }
}