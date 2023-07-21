﻿using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.Views
{
    public partial class FwatchFlight : Form
    {
        public FwatchFlight()
        {
            InitializeComponent();
        }
        private void ChildForm(Form child)
        {
            guna2Panel1.Controls.Clear();
            child.TopLevel = false;
            child.FormBorderStyle = FormBorderStyle.None;
            child.Dock = DockStyle.Fill;
            guna2Panel1.Controls.Add(child);
            child.Show();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            FwatchFilght_2 child = new();
            ChildForm(child);
        }
    }
}
