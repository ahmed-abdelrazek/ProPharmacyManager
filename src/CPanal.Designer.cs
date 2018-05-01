// <copyright>
//     Copyright (C) 2013 ShababConquer Blog.
//     This program is free software; you can redistribute it and/or modify 
//     it under the terms of the GNU General Public License version 2 as 
//     published by the Free Software Foundation.
// 
//     This program is distributed in the hope that it will be useful, but 
//     WITHOUT ANY WARRANTY; without even the implied warranty of MERCHANTABILITY 
//     or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU General Public License 
//     for more details.
// 
//     You should have received a copy of the GNU General Public License along 
//     with this program; if not, write to the Free Software Foundation, Inc., 
//     51 Franklin Street, Fifth Floor, Boston, MA  02110-1301, USA.
// </copyright>
namespace ProPharmacyManager
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CPanal));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SearchT = new System.Windows.Forms.ComboBox();
            this.FP = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SearchB = new ProPharmacyManager.ImageButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.UPdateB = new ProPharmacyManager.ImageButton();
            this.LogOutB = new ProPharmacyManager.ImageButton();
            this.SellB = new ProPharmacyManager.ImageButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Client = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.BillNO = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.NewBill = new System.Windows.Forms.CheckBox();
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
            this.Note1 = new System.Windows.Forms.ToolTip(this.components);
            this.totalprice = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.bu = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.medic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pricem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalcm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noteem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::ProPharmacyManager.Properties.Resources.BG;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(712, 597);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.groupBox1.Controls.Add(this.SearchT);
            this.groupBox1.Controls.Add(this.FP);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.SearchB);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.OrangeRed;
            this.groupBox1.Location = new System.Drawing.Point(455, 155);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(235, 196);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "البحث";
            // 
            // SearchT
            // 
            this.SearchT.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.SearchT.DropDownHeight = 100;
            this.SearchT.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.SearchT.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold);
            this.SearchT.FormattingEnabled = true;
            this.SearchT.IntegralHeight = false;
            this.SearchT.ItemHeight = 24;
            this.SearchT.Location = new System.Drawing.Point(11, 49);
            this.SearchT.MaxDropDownItems = 5;
            this.SearchT.Name = "SearchT";
            this.SearchT.Size = new System.Drawing.Size(218, 32);
            this.SearchT.TabIndex = 4;
            this.SearchT.TextChanged += new System.EventHandler(this.SearchT_TextChanged);
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
            this.SearchB.BackColor = System.Drawing.Color.WhiteSmoke;
            this.SearchB.ButtonImage = global::ProPharmacyManager.Properties.Resources.Search;
            this.SearchB.ButtonImageOffset = new System.Drawing.Point(0, 0);
            this.SearchB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchB.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.SearchB.Location = new System.Drawing.Point(47, 131);
            this.SearchB.Name = "SearchB";
            this.SearchB.Size = new System.Drawing.Size(150, 60);
            this.SearchB.TabIndex = 2;
            this.SearchB.UseVisualStyleBackColor = true;
            this.SearchB.Click += new System.EventHandler(this.button1_Click);
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
            this.panel1.Location = new System.Drawing.Point(0, 517);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(712, 80);
            this.panel1.TabIndex = 2;
            // 
            // UPdateB
            // 
            this.UPdateB.BackColor = System.Drawing.Color.WhiteSmoke;
            this.UPdateB.ButtonImage = global::ProPharmacyManager.Properties.Resources.Update;
            this.UPdateB.ButtonImageOffset = new System.Drawing.Point(0, 0);
            this.UPdateB.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.UPdateB.FlatAppearance.BorderSize = 0;
            this.UPdateB.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.UPdateB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.UPdateB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UPdateB.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.UPdateB.Location = new System.Drawing.Point(264, 9);
            this.UPdateB.Name = "UPdateB";
            this.UPdateB.Size = new System.Drawing.Size(150, 60);
            this.UPdateB.TabIndex = 6;
            this.Note1.SetToolTip(this.UPdateB, "يقوم بحفظ ما قمت بكتابته او تعديله فى الملاحظات");
            this.UPdateB.UseVisualStyleBackColor = true;
            this.UPdateB.Click += new System.EventHandler(this.UPdateB_Click);
            // 
            // LogOutB
            // 
            this.LogOutB.BackColor = System.Drawing.Color.WhiteSmoke;
            this.LogOutB.ButtonImage = global::ProPharmacyManager.Properties.Resources.Power___Log_Off;
            this.LogOutB.ButtonImageOffset = new System.Drawing.Point(0, 0);
            this.LogOutB.FlatAppearance.BorderColor = System.Drawing.Color.DarkCyan;
            this.LogOutB.FlatAppearance.BorderSize = 0;
            this.LogOutB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogOutB.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LogOutB.Location = new System.Drawing.Point(462, 7);
            this.LogOutB.Name = "LogOutB";
            this.LogOutB.Size = new System.Drawing.Size(150, 60);
            this.LogOutB.TabIndex = 7;
            this.Note1.SetToolTip(this.LogOutB, "لتسجيل الخروج من الحساب الخاص بك");
            this.LogOutB.UseVisualStyleBackColor = true;
            this.LogOutB.Click += new System.EventHandler(this.button4_Click);
            // 
            // SellB
            // 
            this.SellB.BackColor = System.Drawing.Color.WhiteSmoke;
            this.SellB.ButtonImage = global::ProPharmacyManager.Properties.Resources.Windows_Marketplace;
            this.SellB.ButtonImageOffset = new System.Drawing.Point(0, 0);
            this.SellB.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.SellB.FlatAppearance.BorderSize = 0;
            this.SellB.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.SellB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.SellB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SellB.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SellB.Location = new System.Drawing.Point(68, 7);
            this.SellB.Name = "SellB";
            this.SellB.Size = new System.Drawing.Size(150, 60);
            this.SellB.TabIndex = 5;
            this.SellB.UseVisualStyleBackColor = true;
            this.SellB.Click += new System.EventHandler(this.SellB_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.DodgerBlue;
            this.groupBox2.Controls.Add(this.Client);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.BillNO);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.NewBill);
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
            this.groupBox2.Location = new System.Drawing.Point(6, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(416, 457);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "النتيجه";
            // 
            // Client
            // 
            this.Client.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold);
            this.Client.Location = new System.Drawing.Point(6, 412);
            this.Client.Name = "Client";
            this.Client.Size = new System.Drawing.Size(272, 32);
            this.Client.TabIndex = 20;
            this.Client.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(292, 422);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(106, 17);
            this.label10.TabIndex = 19;
            this.label10.Text = "اسم المشترى:";
            // 
            // BillNO
            // 
            this.BillNO.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold);
            this.BillNO.Location = new System.Drawing.Point(6, 375);
            this.BillNO.Name = "BillNO";
            this.BillNO.ReadOnly = true;
            this.BillNO.Size = new System.Drawing.Size(272, 32);
            this.BillNO.TabIndex = 18;
            this.BillNO.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(308, 385);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 17);
            this.label9.TabIndex = 17;
            this.label9.Text = "رقم الفاتورة:";
            // 
            // NewBill
            // 
            this.NewBill.AutoSize = true;
            this.NewBill.Location = new System.Drawing.Point(167, 348);
            this.NewBill.Name = "NewBill";
            this.NewBill.Size = new System.Drawing.Size(111, 21);
            this.NewBill.TabIndex = 4;
            this.NewBill.Text = "فاتورة جديدة";
            this.Note1.SetToolTip(this.NewBill, "علم عليها لانشاء فاتورة جديدة او اتركها كما هى لاضافه الدواء الى الفاتورة الحاليه" +
        "");
            this.NewBill.UseVisualStyleBackColor = true;
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
            this.Pnote.ForeColor = System.Drawing.Color.Red;
            this.Pnote.Location = new System.Drawing.Point(6, 248);
            this.Pnote.MaxLength = 500;
            this.Pnote.Multiline = true;
            this.Pnote.Name = "Pnote";
            this.Pnote.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Pnote.Size = new System.Drawing.Size(272, 85);
            this.Pnote.TabIndex = 3;
            this.Note1.SetToolTip(this.Pnote, "اكتب اى شئ لا يزيد عن 500 حرف");
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
            // totalprice
            // 
            this.totalprice.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Bold);
            this.totalprice.Location = new System.Drawing.Point(0, 457);
            this.totalprice.Name = "totalprice";
            this.totalprice.ReadOnly = true;
            this.totalprice.Size = new System.Drawing.Size(704, 40);
            this.totalprice.TabIndex = 1;
            this.Note1.SetToolTip(this.totalprice, "سعر اجمالى الادويه فى الصيدليه");
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.flowLayoutPanel1.Controls.Add(this.label11);
            this.flowLayoutPanel1.ForeColor = System.Drawing.Color.Honeydew;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(440, 79);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(250, 43);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label11.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(139, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(108, 17);
            this.label11.TabIndex = 0;
            this.label11.Text = "اسم المستخدم";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.Color.Honeydew;
            this.label12.Location = new System.Drawing.Point(624, 56);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 17);
            this.label12.TabIndex = 5;
            this.label12.Text = "اهلا بك يا";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.RightToLeftLayout = true;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(712, 597);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.tabPage1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage1.BackgroundImage")));
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage1.Controls.Add(this.bu);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.flowLayoutPanel1);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(704, 568);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "بحث";
            // 
            // bu
            // 
            this.bu.Location = new System.Drawing.Point(440, 373);
            this.bu.Multiline = true;
            this.bu.Name = "bu";
            this.bu.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.bu.Size = new System.Drawing.Size(225, 50);
            this.bu.TabIndex = 6;
            this.bu.Visible = false;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.MediumBlue;
            this.tabPage2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage2.BackgroundImage")));
            this.tabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage2.Controls.Add(this.totalprice);
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(704, 568);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "الادوية";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.medic,
            this.pricem,
            this.expme,
            this.totalcm,
            this.subme,
            this.noteem});
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.Location = new System.Drawing.Point(-4, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(712, 460);
            this.dataGridView1.TabIndex = 0;
            // 
            // medic
            // 
            this.medic.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.medic.HeaderText = "الاسم";
            this.medic.Name = "medic";
            this.medic.ReadOnly = true;
            // 
            // pricem
            // 
            this.pricem.HeaderText = "السعر";
            this.pricem.Name = "pricem";
            this.pricem.ReadOnly = true;
            this.pricem.Width = 60;
            // 
            // expme
            // 
            this.expme.HeaderText = "تاريخ انتهاء الصلاحيه";
            this.expme.Name = "expme";
            this.expme.ReadOnly = true;
            // 
            // totalcm
            // 
            this.totalcm.HeaderText = "الموجود";
            this.totalcm.Name = "totalcm";
            this.totalcm.ReadOnly = true;
            this.totalcm.Width = 70;
            // 
            // subme
            // 
            this.subme.HeaderText = "المادة الفعاله";
            this.subme.Name = "subme";
            this.subme.ReadOnly = true;
            // 
            // noteem
            // 
            this.noteem.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.noteem.HeaderText = "ملاحظات";
            this.noteem.Name = "noteem";
            this.noteem.ReadOnly = true;
            // 
            // CPanal
            // 
            this.AcceptButton = this.SearchB;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(712, 597);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.Color.SeaGreen;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CPanal";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "مدير الصيدليه";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CPanal_FormClosing);
            this.Load += new System.EventHandler(this.CPanal_Load);
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.CPanal_HelpRequested);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private ImageButton SearchB;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private ImageButton LogOutB;
        private ImageButton SellB;
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
        private ImageButton UPdateB;
        private System.Windows.Forms.Label FP;
        private System.Windows.Forms.CheckBox NewBill;
        private System.Windows.Forms.ToolTip Note1;
        private System.Windows.Forms.TextBox Client;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox BillNO;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox totalprice;
        private System.Windows.Forms.DataGridViewTextBoxColumn medic;
        private System.Windows.Forms.DataGridViewTextBoxColumn pricem;
        private System.Windows.Forms.DataGridViewTextBoxColumn expme;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalcm;
        private System.Windows.Forms.DataGridViewTextBoxColumn subme;
        private System.Windows.Forms.DataGridViewTextBoxColumn noteem;
        private System.Windows.Forms.TextBox bu;
        private System.Windows.Forms.ComboBox SearchT;
        private byte Ptype = 0;

        private void ptype()
        {
            switch (Ptype)
            {
                case 1:
                    PType.Text = "شرب";
                    break;
                case 3:
                    PType.Text = "حقن";
                    break;
                case 2:
                    PType.Text = "اقراص";
                    break;
                case 4:
                    PType.Text = "كريم/مرهم";
                    break;
                case 0:
                    PType.Text = "اخرى";
                    break;
                default:
                    PType.Text = "غير معروف";
                    break;
            }
        }
    }
}