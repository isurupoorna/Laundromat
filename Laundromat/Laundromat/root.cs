using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Laundromat
{
    public partial class root : UserControl
    {

        SqlConnection con = new SqlConnection(Program.server);
        public root()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txt_leavePoint.Text))
            {

            }
            else if(string.IsNullOrEmpty(txt_arrivalPoint.Text))
            {

            }
            else if(string.IsNullOrEmpty(txt_groupId.Text))
            {

            }
            else if(dateTimePicker_leaving.Value < dateTimePicker_arrival.Value)
            {

            }
            else if(string.IsNullOrEmpty(txt_groupName.Text))
            {

            }
            else if(cmb_driver.SelectedIndex<0)
            {

            }
            else if(cmb_vehicle.SelectedIndex <0)
            {

            }
            else
            {
                con.Open();


                con.Close();
                    
            }
        }

        private void fillVehicle()
        {
            try
            {
                con.Open();
                SqlDataReader dr = new SqlCommand("select vehicle_no from tbl_vehicle", con).ExecuteReader();
                while (dr.Read())
                {
                    cmb_vehicle.Items.Add(dr.GetValue(0).ToString());
                }
                dr.Close();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void fillDriver()
        {
            try
            {
                con.Open();
                SqlDataReader dr = new SqlCommand("select driver_name from tbl_driverDetails", con).ExecuteReader();
                while (dr.Read())
                {
                    cmb_driver.Items.Add(dr.GetValue(0).ToString());
                }
                dr.Close();
                
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void root_Load(object sender, EventArgs e)
        {
            fillVehicle();
            fillDriver();
            fillGrid();
        }

        private void fillGrid()
        {
            try
            {
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select root_id,leave_point,leave_time,destination,arrive_time,vehicle_no,driver_name,group_id,group_name from vehicle_root", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dgv_root.DataSource = dt;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
