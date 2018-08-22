﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Laundromat
{
    public partial class Operator_Home : Form
    {
        SqlConnection con;
        string start_time, end_time;
        public Operator_Home()
        {
            InitializeComponent();
        }

        private void timer_operatorTime_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            this.lbl_time.Text = dt.ToString();
            start_time = dt.ToShortTimeString();
            end_time = dt.AddHours(-2).ToShortTimeString();
        }

        private void Operator_Home_Load(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection("Data Source=DESKTOP-3V2I63M;Initial Catalog=londromat;Integrated Security=True");
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select * from vehicle_root" , con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView_operatorOut.AutoGenerateColumns = false;
                dataGridView_operatorOut.DataSource = dt;
                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }
           
        }

        private void timer_operatorTimeTable_Tick(object sender, EventArgs e)
        {
            try
            {
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            

            
        }
    }
}
