﻿using _1_DAL.Models;
using _2_BUS.IService;
using _2_BUS.Service;
using _2_BUS.Validate;
using DuAn1.Views;
using GUI.Properties;
using GUI.Views;
using GUI.Views.View_User;

namespace DuAn1
{

    public partial class Form1 : Form
    {
    
        Validate _validate;
        CheckAccountType _checkAccountType;
        QlykhachHang _f;
        fDky _fdky;
        FforGotPass _fForgot;
        ICustomerServices _customerServices;
        IStaffServices _staffServices;
        ISeatDetailServices _seatDetailServices;
        IPlaneTypeServices _PlaneType;
        IClassServices _classServices;
        int _role;
        public Form1()
        {
            
            InitializeComponent();
            load();
            timer1.Enabled = true;
        }
        void load()
        {
            _classServices = new ClassServices();
            _PlaneType = new PlaneTypeServices();
            _seatDetailServices = new SeatDetailServices();
            _customerServices = new CustomerServices();
            _staffServices = new StaffServices();
            _validate = new Validate();
            _checkAccountType = new();
            _f = new();
            _fdky = new fDky();
            _fForgot = new FforGotPass();
            if (Settings.Default.isRemember)
            {
                tb_user.Text = Settings.Default.username;
                tb_pass.Text = Settings.Default.password;
            }
            else
            {
                tb_user.Text = "";
                tb_pass.Text = "";
            }
            cb_reme.Checked = Settings.Default.isRemember;
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (_checkAccountType.CheckType(tb_user.Text, _validate.ReversePass(tb_pass.Text)) == 1)
            {

                _role = 0;
                fStaff _fst = new fStaff(_role);

                this.Hide();
                MessageBox.Show("Đăng nhập admin thành công", "Thông báo!");
                _fst.ShowDialog();
                this.Show();
            }
            else if (_checkAccountType.CheckType(tb_user.Text, _validate.ReversePass(tb_pass.Text)) == 2)
            {
                _role = 1;
                fStaff _fst = new fStaff(_role);
                this.Hide();
                MessageBox.Show("Đăng nhập nhân viên thành công", "Thông báo!");
                _fst.ShowDialog();
                this.Show();
            }
            else if (_checkAccountType.CheckType(tb_user.Text, _validate.ReversePass(tb_pass.Text)) == 3)
            {
                this.Hide();
                MessageBox.Show("Đăng nhập thành công", "Thông báo!");
                FHomeUser fHomeUser = new FHomeUser(tb_user.Text);
                fHomeUser.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại", "Thông báo!");
            }
            if (cb_reme.Checked)
            {
                cb_reme_CheckedChanged(sender, e);
            }
            else
            {
                cb_reme_CheckedChanged(sender, e);
            }
            load();
        }

        private void llb_dki_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            _fdky.ShowDialog();
            this.Show();
        }

        private void llb_forgot_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            _fForgot.ShowDialog();
            this.Show();
        }

        private void llb_dki_MouseHover(object sender, EventArgs e)
        {
            llb_dki.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
        }

        private void llb_dki_MouseMove(object sender, MouseEventArgs e)
        {
            llb_dki.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
        }

        private void llb_dki_MouseLeave(object sender, EventArgs e)
        {
            llb_dki.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular);
        }

        private void llb_forgot_MouseHover(object sender, EventArgs e)
        {
            llb_forgot.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
        }

        private void llb_forgot_MouseMove(object sender, MouseEventArgs e)
        {
            llb_forgot.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
        }

        private void llb_forgot_MouseLeave(object sender, EventArgs e)
        {
            llb_forgot.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular);
        }

        private void btn_login_MouseHover(object sender, EventArgs e)
        {
            btn_login.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
        }

        private void btn_login_MouseLeave(object sender, EventArgs e)
        {
            btn_login.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular);
        }

        private void btn_login_MouseMove(object sender, MouseEventArgs e)
        {
            btn_login.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc là muốn thoát không?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void cb_reme_CheckedChanged(object sender, EventArgs e)
        {
            Settings.Default.isRemember = cb_reme.Checked;
            if (cb_reme.Checked)
            {
                Settings.Default.username = tb_user.Text;
                Settings.Default.password = tb_pass.Text;
                Settings.Default.Save();
                Settings.Default.Upgrade();
            }
            else
            {
                Settings.Default.username = "";
                Settings.Default.password = "";
                Settings.Default.Save();
                Settings.Default.Upgrade();
            }
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            label4.Left -= 3;// Left là chạy từ bên trái. Bạn có thể thay = right
        }
    }
}