using FinalCNPM_Winform.Database;
using System;
using System.Collections.Generic;

namespace FinalCNPM_Winform
{
    partial class MainMenu
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
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tpReport = new System.Windows.Forms.TabPage();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.listView6 = new System.Windows.Forms.ListView();
            this.tbYear = new System.Windows.Forms.TextBox();
            this.listView5 = new System.Windows.Forms.ListView();
            this.label10 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.cbbDelivery_Receive = new System.Windows.Forms.ComboBox();
            this.btnReport = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cbbMonth = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.tpDelivery = new System.Windows.Forms.TabPage();
            this.listView2 = new System.Windows.Forms.ListView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnDelivery = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.tpReceive = new System.Windows.Forms.TabPage();
            this.listView3 = new System.Windows.Forms.ListView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cbbProductId = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbQuantity = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpReport.SuspendLayout();
            this.panel5.SuspendLayout();
            this.tpDelivery.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tpReceive.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã sản phẩm";
            // 
            // tpReport
            // 
            this.tpReport.Controls.Add(this.panel5);
            this.tpReport.Location = new System.Drawing.Point(4, 22);
            this.tpReport.Name = "tpReport";
            this.tpReport.Size = new System.Drawing.Size(873, 549);
            this.tpReport.TabIndex = 2;
            this.tpReport.Text = "Thống kê";
            this.tpReport.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label13);
            this.panel5.Controls.Add(this.label12);
            this.panel5.Controls.Add(this.comboBox1);
            this.panel5.Controls.Add(this.listView6);
            this.panel5.Controls.Add(this.tbYear);
            this.panel5.Controls.Add(this.listView5);
            this.panel5.Controls.Add(this.label10);
            this.panel5.Controls.Add(this.label16);
            this.panel5.Controls.Add(this.label18);
            this.panel5.Controls.Add(this.cbbDelivery_Receive);
            this.panel5.Controls.Add(this.btnReport);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.cbbMonth);
            this.panel5.Controls.Add(this.label17);
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(873, 549);
            this.panel5.TabIndex = 0;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label13.Location = new System.Drawing.Point(565, 294);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(35, 15);
            this.label13.TabIndex = 38;
            this.label13.Text = "Tổng";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label12.Location = new System.Drawing.Point(293, 294);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(81, 15);
            this.label12.TabIndex = 37;
            this.label12.Text = "Ngày/ Tên SP";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Ngày",
            "Tên sản phẩm"});
            this.comboBox1.Location = new System.Drawing.Point(380, 291);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 36;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // listView6
            // 
            this.listView6.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.listView6.GridLines = true;
            this.listView6.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView6.HideSelection = false;
            this.listView6.HoverSelection = true;
            this.listView6.Location = new System.Drawing.Point(288, 72);
            this.listView6.Name = "listView6";
            this.listView6.Size = new System.Drawing.Size(565, 196);
            this.listView6.TabIndex = 35;
            this.listView6.UseCompatibleStateImageBehavior = false;
            this.listView6.View = System.Windows.Forms.View.Details;
            this.listView6.SelectedIndexChanged += new System.EventHandler(this.listView6_SelectedIndexChanged_1);
            // 
            // tbYear
            // 
            this.tbYear.Location = new System.Drawing.Point(88, 112);
            this.tbYear.Name = "tbYear";
            this.tbYear.Size = new System.Drawing.Size(176, 20);
            this.tbYear.TabIndex = 31;
            // 
            // listView5
            // 
            this.listView5.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.listView5.GridLines = true;
            this.listView5.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView5.HideSelection = false;
            this.listView5.HoverSelection = true;
            this.listView5.Location = new System.Drawing.Point(19, 327);
            this.listView5.Name = "listView5";
            this.listView5.Size = new System.Drawing.Size(834, 211);
            this.listView5.TabIndex = 34;
            this.listView5.UseCompatibleStateImageBehavior = false;
            this.listView5.View = System.Windows.Forms.View.Details;
            this.listView5.SelectedIndexChanged += new System.EventHandler(this.listView5_SelectedIndexChanged_1);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label10.Location = new System.Drawing.Point(34, 294);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 15);
            this.label10.TabIndex = 32;
            this.label10.Text = "Hàng ra/ vào";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label16.Location = new System.Drawing.Point(39, 199);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(35, 15);
            this.label16.TabIndex = 17;
            this.label16.Text = "Tổng";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label18.Location = new System.Drawing.Point(38, 113);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(34, 15);
            this.label18.TabIndex = 30;
            this.label18.Text = "Năm";
            this.label18.Click += new System.EventHandler(this.label18_Click);
            // 
            // cbbDelivery_Receive
            // 
            this.cbbDelivery_Receive.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbbDelivery_Receive.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbDelivery_Receive.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cbbDelivery_Receive.FormattingEnabled = true;
            this.cbbDelivery_Receive.Items.AddRange(new object[] {
            "Hàng ra",
            "Hàng vào"});
            this.cbbDelivery_Receive.Location = new System.Drawing.Point(116, 291);
            this.cbbDelivery_Receive.Name = "cbbDelivery_Receive";
            this.cbbDelivery_Receive.Size = new System.Drawing.Size(121, 23);
            this.cbbDelivery_Receive.TabIndex = 28;
            this.cbbDelivery_Receive.SelectedIndexChanged += new System.EventHandler(this.cbbDelivery_Receive_SelectedIndexChanged);
            // 
            // btnReport
            // 
            this.btnReport.Location = new System.Drawing.Point(108, 148);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(100, 30);
            this.btnReport.TabIndex = 16;
            this.btnReport.Text = "Thống kê";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(351, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 31);
            this.label5.TabIndex = 27;
            this.label5.Text = "THỐNG KÊ";
            // 
            // cbbMonth
            // 
            this.cbbMonth.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbbMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbMonth.FormattingEnabled = true;
            this.cbbMonth.Items.AddRange(new object[] {
            "Tháng 1",
            "Tháng 2",
            "Tháng 3",
            "Tháng 4",
            "Tháng 5",
            "Tháng 6",
            "Tháng 7",
            "Tháng 8",
            "Tháng 9",
            "Tháng 10",
            "Tháng 11",
            "Tháng 12"});
            this.cbbMonth.Location = new System.Drawing.Point(88, 72);
            this.cbbMonth.Name = "cbbMonth";
            this.cbbMonth.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbbMonth.Size = new System.Drawing.Size(176, 21);
            this.cbbMonth.TabIndex = 29;
            this.cbbMonth.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label17.Location = new System.Drawing.Point(39, 78);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(42, 15);
            this.label17.TabIndex = 20;
            this.label17.Text = "Tháng";
            this.label17.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.label17.Click += new System.EventHandler(this.label17_Click);
            // 
            // tpDelivery
            // 
            this.tpDelivery.Controls.Add(this.listView2);
            this.tpDelivery.Controls.Add(this.panel3);
            this.tpDelivery.Controls.Add(this.panel4);
            this.tpDelivery.Location = new System.Drawing.Point(4, 22);
            this.tpDelivery.Name = "tpDelivery";
            this.tpDelivery.Padding = new System.Windows.Forms.Padding(3);
            this.tpDelivery.Size = new System.Drawing.Size(873, 549);
            this.tpDelivery.TabIndex = 1;
            this.tpDelivery.Text = "Xuất kho";
            this.tpDelivery.UseVisualStyleBackColor = true;
            // 
            // listView2
            // 
            this.listView2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.listView2.GridLines = true;
            this.listView2.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView2.HideSelection = false;
            this.listView2.HoverSelection = true;
            this.listView2.Location = new System.Drawing.Point(17, 274);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(835, 181);
            this.listView2.TabIndex = 32;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            this.listView2.SelectedIndexChanged += new System.EventHandler(this.listView2_SelectedIndexChanged_1);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.listView1);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(873, 268);
            this.panel3.TabIndex = 29;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(34, 248);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(160, 20);
            this.label8.TabIndex = 32;
            this.label8.Text = "Danh sách sản phẩm";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(34, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(184, 20);
            this.label6.TabIndex = 31;
            this.label6.Text = "Danh sách đơn đặt hàng";
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(17, 75);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(835, 144);
            this.listView1.TabIndex = 27;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(351, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(161, 31);
            this.label9.TabIndex = 26;
            this.label9.Text = "XUẤT KHO";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label11.Location = new System.Drawing.Point(66, 93);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 15);
            this.label11.TabIndex = 23;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnPrint);
            this.panel4.Controls.Add(this.btnDelivery);
            this.panel4.Controls.Add(this.label14);
            this.panel4.Location = new System.Drawing.Point(0, 453);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(873, 96);
            this.panel4.TabIndex = 31;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(327, 32);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(100, 40);
            this.btnPrint.TabIndex = 16;
            this.btnPrint.Text = "In phiếu";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnDelivery
            // 
            this.btnDelivery.Location = new System.Drawing.Point(436, 32);
            this.btnDelivery.Name = "btnDelivery";
            this.btnDelivery.Size = new System.Drawing.Size(100, 40);
            this.btnDelivery.TabIndex = 15;
            this.btnDelivery.Text = "Xuất kho";
            this.btnDelivery.UseVisualStyleBackColor = true;
            this.btnDelivery.Click += new System.EventHandler(this.btnDelivery_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label14.Location = new System.Drawing.Point(707, 21);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(35, 15);
            this.label14.TabIndex = 12;
            this.label14.Text = "Tổng";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // tpReceive
            // 
            this.tpReceive.Controls.Add(this.listView3);
            this.tpReceive.Controls.Add(this.panel1);
            this.tpReceive.Location = new System.Drawing.Point(4, 22);
            this.tpReceive.Name = "tpReceive";
            this.tpReceive.Padding = new System.Windows.Forms.Padding(3);
            this.tpReceive.Size = new System.Drawing.Size(873, 549);
            this.tpReceive.TabIndex = 0;
            this.tpReceive.Text = "Nhập kho";
            this.tpReceive.UseVisualStyleBackColor = true;
            // 
            // listView3
            // 
            this.listView3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.listView3.GridLines = true;
            this.listView3.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView3.HideSelection = false;
            this.listView3.HoverSelection = true;
            this.listView3.Location = new System.Drawing.Point(18, 194);
            this.listView3.Name = "listView3";
            this.listView3.Size = new System.Drawing.Size(833, 266);
            this.listView3.TabIndex = 32;
            this.listView3.UseCompatibleStateImageBehavior = false;
            this.listView3.View = System.Windows.Forms.View.Details;
            this.listView3.SelectedIndexChanged += new System.EventHandler(this.listView3_SelectedIndexChanged_1);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cbbProductId);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.tbQuantity);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(873, 549);
            this.panel1.TabIndex = 0;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label15.Location = new System.Drawing.Point(609, 485);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(35, 15);
            this.label15.TabIndex = 18;
            this.label15.Text = "Tổng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 20);
            this.label3.TabIndex = 30;
            this.label3.Text = "Danh sách sản phẩm";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(385, 485);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 36);
            this.button1.TabIndex = 0;
            this.button1.Text = "Tạo đơn";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(609, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Số lượng trong kho: 0";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // cbbProductId
            // 
            this.cbbProductId.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbbProductId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbProductId.FormattingEnabled = true;
            this.cbbProductId.Location = new System.Drawing.Point(171, 76);
            this.cbbProductId.Name = "cbbProductId";
            this.cbbProductId.Size = new System.Drawing.Size(356, 21);
            this.cbbProductId.TabIndex = 28;
            this.cbbProductId.SelectedIndexChanged += new System.EventHandler(this.cbbProductId_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(351, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(164, 31);
            this.label7.TabIndex = 26;
            this.label7.Text = "NHẬP KHO";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(713, 106);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 33);
            this.btnDelete.TabIndex = 21;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(612, 107);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 33);
            this.btnAdd.TabIndex = 20;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbQuantity
            // 
            this.tbQuantity.Location = new System.Drawing.Point(171, 114);
            this.tbQuantity.Name = "tbQuantity";
            this.tbQuantity.Size = new System.Drawing.Size(196, 20);
            this.tbQuantity.TabIndex = 19;
            this.tbQuantity.TextChanged += new System.EventHandler(this.tbQuantity_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label2.Location = new System.Drawing.Point(66, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 15);
            this.label2.TabIndex = 18;
            this.label2.Text = "Số lượng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label1.Location = new System.Drawing.Point(66, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 15);
            this.label1.TabIndex = 17;
            this.label1.Text = "Tên sản phẩm";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpReceive);
            this.tabControl1.Controls.Add(this.tpDelivery);
            this.tabControl1.Controls.Add(this.tpReport);
            this.tabControl1.Location = new System.Drawing.Point(0, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(881, 575);
            this.tabControl1.TabIndex = 0;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 579);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainMenu";
            this.Text = "Công ty";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.tpReport.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.tpDelivery.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.tpReceive.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private void listView6_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void listView5_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
        #endregion
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.TabPage tpReport;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ListView listView6;
        private System.Windows.Forms.ListView listView5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cbbDelivery_Receive;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbbMonth;
        private System.Windows.Forms.TabPage tpDelivery;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnDelivery;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TabPage tpReceive;
        private System.Windows.Forms.ListView listView3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbbProductId;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox tbQuantity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox tbYear;
        private System.Windows.Forms.Label label18;
    }
}

