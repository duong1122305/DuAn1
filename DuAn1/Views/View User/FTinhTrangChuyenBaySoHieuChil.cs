﻿using _1_DAL.Models;
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
    public partial class FTinhTrangChuyenBaySoHieuChil : Form
    {
        public FTinhTrangChuyenBaySoHieuChil()
        {
            InitializeComponent();
        }
        public FTinhTrangChuyenBaySoHieuChil(List<Flight> flights):this()
        {

        }
    }
}
