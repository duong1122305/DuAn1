﻿using _1_DAL.Models;
using _2_BUS.IService;
using _2_BUS.Service;
using _2_BUS.Validate;
using FirebaseAdmin.Auth;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DuAn1.Views
{
    public partial class fDky : Form
    {

        bool _check_information = true;
        ICustomerServices _dangKyService;
        IStaffServices _staffServices;
        Validate _validate;
        public fDky()
        {
            _staffServices = new StaffServices();
            _validate = new Validate();
            _dangKyService = new CustomerServices();
            InitializeComponent();
            cbx_gender.Items.Add("Nam");
            cbx_gender.Items.Add("Nữ");
            cbx_gender.SelectedIndex = 0;
            this.MaximizeBox = false;
            btn_sign.Enabled = false;
        }

        void reset() // clean oo nhaap
        {
            txb_address.Text = "";
            txb_email.Text = "";
            txb_name.Text = "";
            tbx_pass1.Text = "";
            tbx_pass2.Text = "";
            tbx_phone.Text = "";
            cbx_gender.Text = "";
            lb_ErrorEmail.Visible = false;
            lb_ErrorName.Visible = false;
            lb_ErrorPhoneNumber.Visible = false;
            lb_ErrorPassAgain.Visible = false;
            lb_ErrorOtp.Visible = false;
        }
        private bool check_duplicate_mail(string email)
        {
            foreach (var item in _staffServices.list_staff())
            {
                if (item.Email == email)
                {
                    return true;
                }
            }
            foreach (var item in _dangKyService.GetCustomers())
            {
                if (item.Email == email)
                {
                    return true;
                }
            }
            return false;
        }
        private void btn_sign_Click(object sender, EventArgs e)
        {
            if (txb_name.Text == "" || txb_address.Text == "" || txb_email.Text == "" || tbx_phone.Text == "" || tbx_pass1.Text == "" || tbx_pass2.Text == "") _check_information = false;
            if (_check_information)
            {
                Customer customer = new Customer();
                string[] fullname = _validate.cutName(txb_name.Text);
                customer.FirstName = fullname[0].Trim();
                customer.MiddleName = fullname[1].Trim();
                customer.LastName = fullname[2].Trim();
                customer.Email = txb_email.Text;
                customer.Address = txb_address.Text;
                customer.Dob = Date.Value;
                customer.Phone = tbx_phone.Text;
                customer.Gender = cbx_gender.Text;
                customer.Password = _validate.ReversePass(tbx_pass2.Text);
                if (check_duplicate_mail(customer.Email))
                {
                    MessageBox.Show("Email bạn nhập đã được sử dụng đăng ký cho tài khoản khác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (MessageBox.Show(_dangKyService.Create(customer), "Thông báo", MessageBoxButtons.OK) == DialogResult.OK)
                    {
                        reset();
                        this.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Thông tin điền đúng thông tin yêu cầu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_sign_MouseHover(object sender, EventArgs e)
        {
            btn_sign.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
        }

        private void btn_sign_MouseLeave(object sender, EventArgs e)
        {
            btn_sign.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular);
        }

        private void btn_sign_MouseMove(object sender, MouseEventArgs e)
        {
            btn_sign.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
        }

        private void txb_email_TextChanged(object sender, EventArgs e)
        {
            if (_validate.checkEmail(txb_email.Text))
            {
                lb_ErrorEmail.Text = "";
                lb_ErrorEmail.Visible = false;
                _check_information = true;
            }
            else
            {
                _check_information = false;
                lb_ErrorEmail.Text = "Không đúng định dạng email";
                lb_ErrorEmail.Visible = true;
                lb_ErrorEmail.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular);
                lb_ErrorEmail.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void tbx_phone_TextChanged(object sender, EventArgs e)
        {
            if (_validate.checkPhoneNumber(tbx_phone.Text))
            {
                lb_ErrorPhoneNumber.Text = "";
                lb_ErrorPhoneNumber.Visible = false;
                _check_information = true;
            }
            else
            {
                _check_information = false;
                lb_ErrorPhoneNumber.Text = "Không đúng định dạng số điện thoại";
                lb_ErrorPhoneNumber.Visible = true;
                lb_ErrorPhoneNumber.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular);
                lb_ErrorPhoneNumber.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void tbx_pass2_TextChanged(object sender, EventArgs e)
        {
            string pass1 = tbx_pass1.Text;
            string pass2 = tbx_pass2.Text;
            if (pass1 == pass2)
            {
                lb_ErrorPassAgain.Text = "";
                lb_ErrorPassAgain.Visible = false;
                _check_information = true;
            }
            else
            {
                _check_information = false;
                lb_ErrorPassAgain.Text = "Mật khẩu phải trùng mật khẩu đã nhập";
                lb_ErrorPassAgain.Visible = true;
                lb_ErrorPassAgain.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular);
                lb_ErrorPassAgain.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void txb_name_TextChanged(object sender, EventArgs e)
        {
            if (_validate.checkName(txb_name.Text))
            {
                lb_ErrorName.Text = "";
                lb_ErrorName.Visible = false;
                _check_information = true;
            }
            else
            {
                _check_information = false;
                lb_ErrorName.Text = "Không đúng định dạng tên";
                lb_ErrorName.Visible = true;
                lb_ErrorName.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular);
                lb_ErrorName.ForeColor = System.Drawing.Color.Red;
            }
        }
        int minutes = 5;
        int seconds = 60;
        string code_otp = "";
        private async void btn_SendCode_Click(object sender, EventArgs e)
        {
            bool check = true;
            foreach (var item in _dangKyService.GetCustomers())
            {
                if (item.Email == txb_email.Text)
                {
                    check = false;
                }
            }
            try
            {
                if (txb_email.Text != "" && check)
                {
                    CountDown.Interval = 1000;
                    CountDown.Start();
                    minutes = 5;
                    seconds = 60;
                    string email = txb_email.Text;
                    string subject = "Chào mừng bạn đến với bán vé máy bay";
                    string body = "Mã xác thực để xác minh tài khoản đăng ký của bạn là: ";
                    int role_id = 99;
                    code_otp = _validate.randomCode();
                    if (await _validate.SendEmail(email, subject, body, code_otp, role_id))
                    {
                        time.Visible = true;
                        MessageBox.Show("Mã xác thực đã được gửi đến email của bạn!");
                        btn_SendCode.Enabled = false;
                        btn_sign.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Không thể gửi mã đến email!");
                    }
                }
                else
                {
                    MessageBox.Show("Email đã được sử dụng để đăng ký");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Email đã được được sử dụng để đăng ký");
            }
        }

        private void CountDown_Tick(object sender, EventArgs e)
        {
            btn_SendCode.Enabled = false;
            if (minutes > -2)
            {
                seconds--;
                lb_Minutes.Text = "0" + minutes.ToString();
                lb_Seconds.Text = seconds.ToString();
                if (minutes == 5)
                {
                    minutes--;
                    lb_Minutes.Text = "0" + minutes.ToString();
                }
                if (seconds == 0)
                {
                    minutes--;
                    if (minutes == -1)
                    {
                        minutes = -2;
                        minutes = 0;
                        seconds = 0;
                        lb_Minutes.Text = "00";
                        lb_Seconds.Text = "00";
                        btn_SendCode.Enabled = true;
                        code_otp = _validate.randomCode();
                        CountDown.Stop();
                    }
                    lb_Minutes.Text = "0" + minutes.ToString();
                    seconds = 60;
                }
            }
        }

        private void txb_Otp_TextChanged(object sender, EventArgs e)
        {
            if (txb_Otp.Text == code_otp)
            {
                lb_ErrorOtp.Text = "";
                lb_ErrorOtp.Visible = false;
                _check_information = true;
            }
            else
            {
                _check_information = false;
                lb_ErrorOtp.Text = "Mã bạn nhập ko trùng mã xác thực được cấp";
                lb_ErrorOtp.Visible = true;
                lb_ErrorOtp.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular);
                lb_ErrorOtp.ForeColor = System.Drawing.Color.Red;
            }
        }

    }
}
