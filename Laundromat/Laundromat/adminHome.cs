﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laundromat
{
    public partial class adminHome : Form
    {
        public adminHome()
        {
            InitializeComponent();
        }

        private void btn_mainEdit_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void btn_mainDriver_Click(object sender, EventArgs e)
        {
            btn_mainDriver.FlatAppearance.BorderColor = Color.Red;
            
        }

        private void btn_mainDriver_MouseHover(object sender, EventArgs e)
        {
            pnl_driver.Visible = true;
        }

        private void btn_mainDriver_MouseLeave(object sender, EventArgs e)
        {
            pnl_driver.Visible = false;
        }

        private void btn_mainVehicle_MouseHover(object sender, EventArgs e)
        {
            pnl_vehicle.Visible = true;
        }

        private void btn_mainVehicle_MouseLeave(object sender, EventArgs e)
        {
            pnl_vehicle.Visible = false;
        }

        private void btn_mainRoot_MouseHover(object sender, EventArgs e)
        {
            pnl_root.Visible = true;
        }

        private void btn_mainRoot_MouseLeave(object sender, EventArgs e)
        {
            pnl_root.Visible = false;
        }

        private void driverDetails1_Load(object sender, EventArgs e)
        {

        }

        private void btn_mainUser_Click(object sender, EventArgs e)
        {

        }

        private void btn_mainUser_MouseHover(object sender, EventArgs e)
        {
            pnl_user.Visible = true;
        }

        private void btn_mainUser_MouseLeave(object sender, EventArgs e)
        {
            pnl_user.Visible = false;
        }
    }
}
