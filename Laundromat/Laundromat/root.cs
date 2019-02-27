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
                MessageBox.Show("Enter correct leave point");
            }
            else if(string.IsNullOrEmpty(txt_arrivalPoint.Text))
            {
                MessageBox.Show("Enter correct arrival point");
            }
            else if(string.IsNullOrEmpty(txt_groupId.Text))
            {
                MessageBox.Show("Enter correct Group ID");
            }
            else if(dateTimePicker_leaving.Value > dateTimePicker_arrival.Value)
            {
                MessageBox.Show("Arrival time cannot be greater than leaving time");
            }
            else if(string.IsNullOrEmpty(txt_groupName.Text))
            {
                MessageBox.Show("Enter correct group name");
            }
            else if(cmb_driver.SelectedIndex<0)
            {
                MessageBox.Show("Please select a driver");
            }
            else if(cmb_vehicle.SelectedIndex <0)
            {
                MessageBox.Show("Please select a vehicle");
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("insert into vehicle_root values('" + txt_leavePoint.Text + "', '" + dateTimePicker_leaving.Text + "', '" + txt_arrivalPoint.Text + "', '" + dateTimePicker_arrival.Text + "', '" + cmb_vehicle.Text + "',(select driver_id from tbl_driverDetails where driver_name = '" + cmb_driver.Text + "'), '" + cmb_driver + "',(select driver_contact from tbl_driverDetails where driver_name = '" + cmb_driver + "'),'p'," + txt_groupId.Text + ",'" + txt_groupName.Text + "')", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    fillGrid();
                    txt_leavePoint.Text = "";
                    txt_arrivalPoint.Text = "";
                    txt_groupId.Text = "";
                    txt_groupName.Text = "";
                    cmb_driver.Text = "";
                    cmb_vehicle.Text = "";
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
               
                    
            }
        }

        private void fillVehicle() //fill vehicle combo box
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

        private void fillDriver() // fill driver combo box
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

        private void fillGrid() //fill date grid view
        {
            try
            {
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select root_id,leave_point,leave_time,destination,arrive_time,vehicle_no,driver_name,group_id,group_name from vehicle_root", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dgv_root.DataSource = dt;
                dgv_root.AllowUserToAddRows = false;
                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
