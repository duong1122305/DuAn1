﻿namespace DuAn1.Views
{
    partial class FQuanLyChuyenBay
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
            groupBox1 = new GroupBox();
            guna2NumericUpDown1 = new Guna.UI2.WinForms.Guna2NumericUpDown();
            label10 = new Label();
            label2 = new Label();
            cmb_To = new Guna.UI2.WinForms.Guna2ComboBox();
            label5 = new Label();
            nbr_Price = new Guna.UI2.WinForms.Guna2NumericUpDown();
            btn_Update = new Guna.UI2.WinForms.Guna2Button();
            btn_Add = new Guna.UI2.WinForms.Guna2Button();
            txb_Search = new TextBox();
            label9 = new Label();
            dateTo = new Guna.UI2.WinForms.Guna2DateTimePicker();
            DateFrom = new Guna.UI2.WinForms.Guna2DateTimePicker();
            cmb_PlaneType = new Guna.UI2.WinForms.Guna2ComboBox();
            cmb_From = new Guna.UI2.WinForms.Guna2ComboBox();
            dgv_chuyenbay = new DataGridView();
            txb_codeflight = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            guna2NumericUpDown2 = new Guna.UI2.WinForms.Guna2NumericUpDown();
            guna2NumericUpDown3 = new Guna.UI2.WinForms.Guna2NumericUpDown();
            guna2NumericUpDown4 = new Guna.UI2.WinForms.Guna2NumericUpDown();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)guna2NumericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nbr_Price).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_chuyenbay).BeginInit();
            ((System.ComponentModel.ISupportInitialize)guna2NumericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)guna2NumericUpDown3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)guna2NumericUpDown4).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(guna2NumericUpDown3);
            groupBox1.Controls.Add(guna2NumericUpDown4);
            groupBox1.Controls.Add(guna2NumericUpDown2);
            groupBox1.Controls.Add(guna2NumericUpDown1);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(cmb_To);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(nbr_Price);
            groupBox1.Controls.Add(btn_Update);
            groupBox1.Controls.Add(btn_Add);
            groupBox1.Controls.Add(txb_Search);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(dateTo);
            groupBox1.Controls.Add(DateFrom);
            groupBox1.Controls.Add(cmb_PlaneType);
            groupBox1.Controls.Add(cmb_From);
            groupBox1.Controls.Add(dgv_chuyenbay);
            groupBox1.Controls.Add(txb_codeflight);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(10, 9);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(1030, 461);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // guna2NumericUpDown1
            // 
            guna2NumericUpDown1.BackColor = Color.Transparent;
            guna2NumericUpDown1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            guna2NumericUpDown1.Location = new Point(579, 34);
            guna2NumericUpDown1.Maximum = new decimal(new int[] { 24, 0, 0, 0 });
            guna2NumericUpDown1.Name = "guna2NumericUpDown1";
            guna2NumericUpDown1.Size = new Size(41, 25);
            guna2NumericUpDown1.TabIndex = 36;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(699, 12);
            label10.Name = "label10";
            label10.Size = new Size(64, 18);
            label10.TabIndex = 35;
            label10.Text = "Kết thúc";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(578, 13);
            label2.Name = "label2";
            label2.Size = new Size(79, 18);
            label2.TabIndex = 33;
            label2.Text = "Khởi hành";
            // 
            // cmb_To
            // 
            cmb_To.BackColor = Color.Transparent;
            cmb_To.DrawMode = DrawMode.OwnerDrawFixed;
            cmb_To.DropDownHeight = 175;
            cmb_To.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_To.FocusedColor = Color.FromArgb(94, 148, 255);
            cmb_To.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cmb_To.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cmb_To.ForeColor = Color.FromArgb(68, 88, 112);
            cmb_To.IntegralHeight = false;
            cmb_To.ItemHeight = 30;
            cmb_To.Location = new Point(298, 96);
            cmb_To.Name = "cmb_To";
            cmb_To.Size = new Size(242, 36);
            cmb_To.TabIndex = 32;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(298, 78);
            label5.Name = "label5";
            label5.Size = new Size(76, 18);
            label5.TabIndex = 31;
            label5.Text = "Điểm đến";
            // 
            // nbr_Price
            // 
            nbr_Price.BackColor = Color.Transparent;
            nbr_Price.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            nbr_Price.Increment = new decimal(new int[] { 100000, 0, 0, 0 });
            nbr_Price.Location = new Point(579, 96);
            nbr_Price.Maximum = new decimal(new int[] { -1981284353, -1966660860, 0, 0 });
            nbr_Price.Name = "nbr_Price";
            nbr_Price.Size = new Size(210, 36);
            nbr_Price.TabIndex = 30;
            // 
            // btn_Update
            // 
            btn_Update.BorderRadius = 10;
            btn_Update.DisabledState.BorderColor = Color.DarkGray;
            btn_Update.DisabledState.CustomBorderColor = Color.DarkGray;
            btn_Update.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btn_Update.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btn_Update.FillColor = Color.DarkCyan;
            btn_Update.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Update.ForeColor = Color.White;
            btn_Update.Location = new Point(865, 96);
            btn_Update.Name = "btn_Update";
            btn_Update.Size = new Size(128, 45);
            btn_Update.TabIndex = 29;
            btn_Update.Text = "Sửa";
            // 
            // btn_Add
            // 
            btn_Add.BorderRadius = 10;
            btn_Add.DisabledState.BorderColor = Color.DarkGray;
            btn_Add.DisabledState.CustomBorderColor = Color.DarkGray;
            btn_Add.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btn_Add.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btn_Add.FillColor = Color.DarkCyan;
            btn_Add.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Add.ForeColor = Color.White;
            btn_Add.Location = new Point(865, 147);
            btn_Add.Name = "btn_Add";
            btn_Add.Size = new Size(128, 45);
            btn_Add.TabIndex = 28;
            btn_Add.Text = "Thêm";
            // 
            // txb_Search
            // 
            txb_Search.Location = new Point(579, 153);
            txb_Search.Margin = new Padding(3, 2, 3, 2);
            txb_Search.Multiline = true;
            txb_Search.Name = "txb_Search";
            txb_Search.Size = new Size(210, 37);
            txb_Search.TabIndex = 27;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(579, 134);
            label9.Name = "label9";
            label9.Size = new Size(71, 18);
            label9.TabIndex = 26;
            label9.Text = "Tìm kiếm";
            // 
            // dateTo
            // 
            dateTo.Checked = true;
            dateTo.FillColor = Color.FromArgb(224, 224, 224);
            dateTo.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dateTo.Format = DateTimePickerFormat.Long;
            dateTo.Location = new Point(298, 154);
            dateTo.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            dateTo.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            dateTo.Name = "dateTo";
            dateTo.Size = new Size(242, 36);
            dateTo.TabIndex = 24;
            dateTo.Value = new DateTime(2023, 7, 22, 22, 13, 14, 18);
            // 
            // DateFrom
            // 
            DateFrom.Checked = true;
            DateFrom.FillColor = Color.FromArgb(224, 224, 224);
            DateFrom.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            DateFrom.Format = DateTimePickerFormat.Long;
            DateFrom.Location = new Point(26, 154);
            DateFrom.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            DateFrom.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            DateFrom.Name = "DateFrom";
            DateFrom.Size = new Size(242, 36);
            DateFrom.TabIndex = 23;
            DateFrom.Value = new DateTime(2023, 7, 22, 22, 13, 14, 18);
            // 
            // cmb_PlaneType
            // 
            cmb_PlaneType.BackColor = Color.Transparent;
            cmb_PlaneType.DrawMode = DrawMode.OwnerDrawFixed;
            cmb_PlaneType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_PlaneType.FocusedColor = Color.FromArgb(94, 148, 255);
            cmb_PlaneType.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cmb_PlaneType.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cmb_PlaneType.ForeColor = Color.FromArgb(68, 88, 112);
            cmb_PlaneType.ItemHeight = 30;
            cmb_PlaneType.Location = new Point(27, 31);
            cmb_PlaneType.Name = "cmb_PlaneType";
            cmb_PlaneType.Size = new Size(241, 36);
            cmb_PlaneType.TabIndex = 21;
            // 
            // cmb_From
            // 
            cmb_From.BackColor = Color.Transparent;
            cmb_From.DrawMode = DrawMode.OwnerDrawFixed;
            cmb_From.DropDownHeight = 175;
            cmb_From.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_From.FocusedColor = Color.FromArgb(94, 148, 255);
            cmb_From.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cmb_From.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cmb_From.ForeColor = Color.FromArgb(68, 88, 112);
            cmb_From.IntegralHeight = false;
            cmb_From.ItemHeight = 30;
            cmb_From.Location = new Point(27, 96);
            cmb_From.Name = "cmb_From";
            cmb_From.Size = new Size(241, 36);
            cmb_From.TabIndex = 19;
            // 
            // dgv_chuyenbay
            // 
            dgv_chuyenbay.AllowUserToAddRows = false;
            dgv_chuyenbay.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_chuyenbay.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_chuyenbay.Location = new Point(4, 195);
            dgv_chuyenbay.Margin = new Padding(3, 2, 3, 2);
            dgv_chuyenbay.Name = "dgv_chuyenbay";
            dgv_chuyenbay.RowTemplate.Height = 25;
            dgv_chuyenbay.Size = new Size(1020, 262);
            dgv_chuyenbay.TabIndex = 0;
            // 
            // txb_codeflight
            // 
            txb_codeflight.Location = new Point(300, 30);
            txb_codeflight.Margin = new Padding(3, 2, 3, 2);
            txb_codeflight.Multiline = true;
            txb_codeflight.Name = "txb_codeflight";
            txb_codeflight.Size = new Size(240, 37);
            txb_codeflight.TabIndex = 8;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(579, 75);
            label8.Name = "label8";
            label8.Size = new Size(62, 18);
            label8.TabIndex = 18;
            label8.Text = "Giá tiền";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(298, 133);
            label7.Name = "label7";
            label7.Size = new Size(64, 18);
            label7.TabIndex = 15;
            label7.Text = "Ngày về";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(26, 135);
            label6.Name = "label6";
            label6.Size = new Size(61, 18);
            label6.TabIndex = 13;
            label6.Text = "Ngày đi";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(26, 78);
            label4.Name = "label4";
            label4.Size = new Size(63, 18);
            label4.TabIndex = 9;
            label4.Text = "Điểm đi";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(300, 12);
            label3.Name = "label3";
            label3.Size = new Size(111, 18);
            label3.TabIndex = 7;
            label3.Text = "Mã chuyến bay";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(27, 12);
            label1.Name = "label1";
            label1.Size = new Size(101, 18);
            label1.TabIndex = 1;
            label1.Text = "Loại máy bay";
            // 
            // guna2NumericUpDown2
            // 
            guna2NumericUpDown2.BackColor = Color.Transparent;
            guna2NumericUpDown2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            guna2NumericUpDown2.Location = new Point(626, 34);
            guna2NumericUpDown2.Maximum = new decimal(new int[] { 24, 0, 0, 0 });
            guna2NumericUpDown2.Name = "guna2NumericUpDown2";
            guna2NumericUpDown2.Size = new Size(41, 25);
            guna2NumericUpDown2.TabIndex = 37;
            // 
            // guna2NumericUpDown3
            // 
            guna2NumericUpDown3.BackColor = Color.Transparent;
            guna2NumericUpDown3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            guna2NumericUpDown3.Location = new Point(744, 34);
            guna2NumericUpDown3.Maximum = new decimal(new int[] { 24, 0, 0, 0 });
            guna2NumericUpDown3.Name = "guna2NumericUpDown3";
            guna2NumericUpDown3.Size = new Size(41, 25);
            guna2NumericUpDown3.TabIndex = 39;
            // 
            // guna2NumericUpDown4
            // 
            guna2NumericUpDown4.BackColor = Color.Transparent;
            guna2NumericUpDown4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            guna2NumericUpDown4.Location = new Point(697, 34);
            guna2NumericUpDown4.Maximum = new decimal(new int[] { 24, 0, 0, 0 });
            guna2NumericUpDown4.Name = "guna2NumericUpDown4";
            guna2NumericUpDown4.Size = new Size(41, 25);
            guna2NumericUpDown4.TabIndex = 38;
            // 
            // FQuanLyChuyenBay
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1052, 481);
            Controls.Add(groupBox1);
            Name = "FQuanLyChuyenBay";
            Text = "FQuanLyChuyenBay";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)guna2NumericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)nbr_Price).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_chuyenbay).EndInit();
            ((System.ComponentModel.ISupportInitialize)guna2NumericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)guna2NumericUpDown3).EndInit();
            ((System.ComponentModel.ISupportInitialize)guna2NumericUpDown4).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label7;
        private Label label6;
        private Label label4;
        private Label label3;
        private Label label1;
        private DataGridView dgv_chuyenbay;
        private Label label8;
        private Guna.UI2.WinForms.Guna2ComboBox cmb_From;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private Guna.UI2.WinForms.Guna2Button btn_Update;
        private Guna.UI2.WinForms.Guna2Button btn_Add;
        private Guna.UI2.WinForms.Guna2DateTimePicker dateTo;
        private Guna.UI2.WinForms.Guna2DateTimePicker DateFrom;
        private TextBox txb_codeflight;
        private Guna.UI2.WinForms.Guna2ComboBox cmb_PlaneType;
        private Label label9;
        private TextBox txb_Search;
        private Guna.UI2.WinForms.Guna2NumericUpDown nbr_Price;
        private Guna.UI2.WinForms.Guna2ComboBox cmb_To;
        private Label label5;
        private Label label10;
        private Label label2;
        private Guna.UI2.WinForms.Guna2NumericUpDown guna2NumericUpDown1;
        private Guna.UI2.WinForms.Guna2NumericUpDown guna2NumericUpDown3;
        private Guna.UI2.WinForms.Guna2NumericUpDown guna2NumericUpDown4;
        private Guna.UI2.WinForms.Guna2NumericUpDown guna2NumericUpDown2;
    }
}