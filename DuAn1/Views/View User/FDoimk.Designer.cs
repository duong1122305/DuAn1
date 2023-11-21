namespace GUI.Views.View_User
{
    partial class FDoimk
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FDoimk));
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            tbx_passOld = new TextBox();
            tbx_passNew = new TextBox();
            tbx_passReNew = new TextBox();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            lbl_email = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lbl_passOld = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lbl_passNew = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lbl_passReNew = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lblWell = new Guna.UI2.WinForms.Guna2HtmlLabel();
            SuspendLayout();
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            guna2HtmlLabel1.Location = new Point(169, 46);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(120, 21);
            guna2HtmlLabel1.TabIndex = 0;
            guna2HtmlLabel1.Text = "ĐỔI MẬT KHẨU";
            // 
            // guna2HtmlLabel3
            // 
            guna2HtmlLabel3.BackColor = Color.Transparent;
            guna2HtmlLabel3.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            guna2HtmlLabel3.Location = new Point(17, 134);
            guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            guna2HtmlLabel3.Size = new Size(90, 20);
            guna2HtmlLabel3.TabIndex = 2;
            guna2HtmlLabel3.Text = "Mật khẩu cũ:";
            // 
            // guna2HtmlLabel4
            // 
            guna2HtmlLabel4.BackColor = Color.Transparent;
            guna2HtmlLabel4.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            guna2HtmlLabel4.Location = new Point(17, 203);
            guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            guna2HtmlLabel4.Size = new Size(98, 20);
            guna2HtmlLabel4.TabIndex = 3;
            guna2HtmlLabel4.Text = "Mật khẩu mới";
            // 
            // guna2HtmlLabel5
            // 
            guna2HtmlLabel5.BackColor = Color.Transparent;
            guna2HtmlLabel5.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            guna2HtmlLabel5.Location = new Point(17, 272);
            guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            guna2HtmlLabel5.Size = new Size(159, 20);
            guna2HtmlLabel5.TabIndex = 4;
            guna2HtmlLabel5.Text = "Nhập lại mật khẩu mới";
            // 
            // tbx_passOld
            // 
            tbx_passOld.Location = new Point(200, 117);
            tbx_passOld.Multiline = true;
            tbx_passOld.Name = "tbx_passOld";
            tbx_passOld.PasswordChar = '*';
            tbx_passOld.Size = new Size(222, 37);
            tbx_passOld.TabIndex = 1;
            // 
            // tbx_passNew
            // 
            tbx_passNew.Location = new Point(200, 186);
            tbx_passNew.Multiline = true;
            tbx_passNew.Name = "tbx_passNew";
            tbx_passNew.PasswordChar = '*';
            tbx_passNew.Size = new Size(222, 37);
            tbx_passNew.TabIndex = 2;
            tbx_passNew.TextChanged += tbx_passNew_TextChanged;
            // 
            // tbx_passReNew
            // 
            tbx_passReNew.Location = new Point(200, 255);
            tbx_passReNew.Multiline = true;
            tbx_passReNew.Name = "tbx_passReNew";
            tbx_passReNew.PasswordChar = '*';
            tbx_passReNew.Size = new Size(222, 37);
            tbx_passReNew.TabIndex = 3;
            tbx_passReNew.TextChanged += tbx_passReNew_TextChanged;
            // 
            // guna2Button1
            // 
            guna2Button1.BorderRadius = 10;
            guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button1.FillColor = Color.DarkCyan;
            guna2Button1.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            guna2Button1.ForeColor = Color.White;
            guna2Button1.Location = new Point(200, 337);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.Size = new Size(108, 38);
            guna2Button1.TabIndex = 9;
            guna2Button1.Text = "Đổi mật khẩu";
            guna2Button1.Click += guna2Button1_Click;
            // 
            // guna2Button2
            // 
            guna2Button2.BorderRadius = 10;
            guna2Button2.DisabledState.BorderColor = Color.DarkGray;
            guna2Button2.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button2.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button2.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button2.FillColor = Color.DarkCyan;
            guna2Button2.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            guna2Button2.ForeColor = Color.White;
            guna2Button2.Location = new Point(314, 337);
            guna2Button2.Name = "guna2Button2";
            guna2Button2.Size = new Size(108, 38);
            guna2Button2.TabIndex = 10;
            guna2Button2.Text = "Thoát";
            guna2Button2.Click += guna2Button2_Click;
            // 
            // lbl_email
            // 
            lbl_email.BackColor = Color.Transparent;
            lbl_email.Location = new Point(200, 91);
            lbl_email.Name = "lbl_email";
            lbl_email.Size = new Size(3, 2);
            lbl_email.TabIndex = 11;
            lbl_email.Text = null;
            // 
            // lbl_passOld
            // 
            lbl_passOld.BackColor = Color.Transparent;
            lbl_passOld.Location = new Point(200, 160);
            lbl_passOld.Name = "lbl_passOld";
            lbl_passOld.Size = new Size(3, 2);
            lbl_passOld.TabIndex = 12;
            lbl_passOld.Text = null;
            // 
            // lbl_passNew
            // 
            lbl_passNew.BackColor = Color.Transparent;
            lbl_passNew.Location = new Point(200, 229);
            lbl_passNew.Name = "lbl_passNew";
            lbl_passNew.Size = new Size(3, 2);
            lbl_passNew.TabIndex = 13;
            lbl_passNew.Text = null;
            // 
            // lbl_passReNew
            // 
            lbl_passReNew.BackColor = Color.Transparent;
            lbl_passReNew.Location = new Point(200, 298);
            lbl_passReNew.Name = "lbl_passReNew";
            lbl_passReNew.Size = new Size(3, 2);
            lbl_passReNew.TabIndex = 14;
            lbl_passReNew.Text = null;
            // 
            // lblWell
            // 
            lblWell.BackColor = Color.Transparent;
            lblWell.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblWell.Location = new Point(17, 12);
            lblWell.Name = "lblWell";
            lblWell.Size = new Size(30, 20);
            lblWell.TabIndex = 15;
            lblWell.Text = "123";
            lblWell.Visible = false;
            // 
            // FDoimk
            // 
            AccessibleRole = AccessibleRole.Sound;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(464, 411);
            Controls.Add(lblWell);
            Controls.Add(lbl_passReNew);
            Controls.Add(lbl_passNew);
            Controls.Add(lbl_passOld);
            Controls.Add(lbl_email);
            Controls.Add(guna2Button2);
            Controls.Add(guna2Button1);
            Controls.Add(tbx_passReNew);
            Controls.Add(tbx_passNew);
            Controls.Add(tbx_passOld);
            Controls.Add(guna2HtmlLabel5);
            Controls.Add(guna2HtmlLabel4);
            Controls.Add(guna2HtmlLabel3);
            Controls.Add(guna2HtmlLabel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FDoimk";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Đổi mật khẩu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_email;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_passOld;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_passNew;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_passReNew;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblWell;
        public TextBox tbx_passOld;
        public TextBox tbx_passNew;
        public TextBox tbx_passReNew;
        public Guna.UI2.WinForms.Guna2Button guna2Button1;
        public Guna.UI2.WinForms.Guna2Button guna2Button2;
    }
}