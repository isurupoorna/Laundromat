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
    public partial class frm_display : Form
    {
        SqlConnection con;
        
        public frm_display()
        {

            InitializeComponent();
        }

        private void timer_timeTableSystemTime_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            this.lbl_time.Text = dt.ToString();
        }

        private void frm_display_Load(object sender, EventArgs e)
        {
            Timer timer = new Timer();
            timer.Interval = (30 * 1000); // 10 secs
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();

            try
            {
                con = new SqlConnection("Data Source=DESKTOP-3V2I63M;Initial Catalog=londromat;Integrated Security=True");
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select * from vehicle_root ", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView_displayOut.AutoGenerateColumns = false;
                dataGridView_displayOut.DataSource = dt;

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            //refresh here...
        }

        private void dataGridView_displayOut_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void timer_timeTable_Tick(object sender, EventArgs e)
        {
            foreach(DataGridViewRow row in dataGridView_displayOut.Rows)
            {
                
            }
        }
    }
}
