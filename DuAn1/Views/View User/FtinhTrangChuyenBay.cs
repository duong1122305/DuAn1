﻿using _2_BUS.IService;
using _2_BUS.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.Views.View_User
{
    public partial class FtinhTrangChuyenBay : Form
    {
        IFlightServices _flightServices;
        ILocationServices _locationServices;
        bool check_date = false;
        public FtinhTrangChuyenBay()
        {
            _locationServices = new LocationService();
            _flightServices = new FlightServices();
            InitializeComponent();
            load();
        }
        void load()
        {
            guna2Button1.FillColor = Color.DarkCyan;
            txt_CodeFlight.Visible = false;
            lb_ErrorDate.Visible = false;
            lb_ErrorFrom1.Visible = false;
            lb_ErrorTo1.Visible = false;
            lb_ErrorNum.Visible = false;
            guna2HtmlLabel9.Visible = false;

            cbb_From.DataSource = _locationServices.get_list();
            cbb_From.DisplayMember = "locationFly";

            cbb_To.DataSource = _locationServices.get_list();
            cbb_To.DisplayMember = "locationFly";

        }
        bool check()
        {
            if (cbb_From.Text != cbb_To.Text)
            {
                return true;
            }
            return false;
        }
        private void guna2Button1_Click(object sender, EventArgs e) // dđây là button hành trình
        {
            guna2Button2.FillColor = Color.White;
            guna2Button1.FillColor = Color.DarkCyan;
            txt_CodeFlight.Visible = false;
            cbb_From.Visible = true;
            cbb_To.Visible = true;
            guna2HtmlLabel3.Visible = true;
            guna2HtmlLabel2.Visible = true;

        }

        private void guna2Button2_Click(object sender, EventArgs e)//đây là button số hiệu chuyến bay
        {
            guna2Button1.FillColor = Color.White;
            guna2Button2.FillColor = Color.DarkCyan;
            txt_CodeFlight.Visible = true;
            guna2HtmlLabel3.Visible = false;
            cbb_To.Visible = false;
            cbb_From.Visible = false;
        }

        private void HienThiSoHieuChuyenBay() // HIỂN THỊ các nút trong số hiệu chuuyến bay
        {

        }

        private void HienThiHanhTrinh() //Hiển thị các nút trong hành trình
        {


        }

        private void cbb_From_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (check())
            {
                lb_ErrorTo1.Visible = false;
                lb_ErrorFrom1.Visible = false;
            }
            else
            {

                lb_ErrorTo1.Visible = true;
                lb_ErrorTo1.Text = "Vui lòng thay đổi điểm đến khác!!!";
                lb_ErrorTo1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular);
                lb_ErrorTo1.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void cbb_To_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (check())
            {
                lb_ErrorTo1.Visible = false;
                lb_ErrorFrom1.Visible = false;
            }
            else
            {
                lb_ErrorFrom1.Visible = true;
                lb_ErrorFrom1.Text = "Vui lòng thay đổi điểm đến khác!!!";
                lb_ErrorFrom1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular);
                lb_ErrorFrom1.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void date_Start_ValueChanged(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now;
            if (date_Start.Value <= date)
            {
                check_date = false;
                lb_ErrorDate.Visible = true;
                lb_ErrorDate.Text = "Vui lòng chọn ngày bay lớn hơn ngày hiện tại!!";
                lb_ErrorDate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular);
                lb_ErrorDate.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                check_date = true;
                lb_ErrorDate.Visible = false;
            }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            if (check())
            {
                if (check_date)
                {
                    try
                    {
                        var list_search = _flightServices.get_list().Where(c => c.GoFrom == cbb_From.Text && c.GoTo == cbb_To.Text && c.DateFlight >= date_Start.Value).ToList();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Không có chuyến bay nào trùng với những thông tin bạn tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Ngày bay bạn chọn không phù hợp yêu cầu!");
                }
            }
        }
    }
}

