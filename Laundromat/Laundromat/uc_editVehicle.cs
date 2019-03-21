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
    public partial class uc_editVehicle : UserControl
    {

        SqlConnection con = new SqlConnection(Program.server);
        public uc_editVehicle()
        {
            InitializeComponent();
        }

        private void fillDriver() //fill driver combo box
        {
            try
            {
                con.Open();
                SqlDataReader dr = new SqlCommand("select driver_name from tbl_driverDetails", con).ExecuteReader();
                while (dr.Read())
                {
                    cmb_driverName.Items.Add(dr.GetValue(0).ToString());
                }
                dr.Close();
                con.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Please check your connection");
            }

        }

        private void fillGrid() //fill the datagrid view
        {
            try
            {
                con.Open();

                SqlDataAdapter sda = new SqlDataAdapter("select vehicle_no,driver_name from tbl_vehicle,tbl_driverDetails where tbl_driverDetails.driver_id = tbl_vehicle.driver_id", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView_vehicle.DataSource = dt;
                con.Close();
                dataGridView_vehicle.AllowUserToAddRows = false;
            }
            catch(Exception)
            {
                MessageBox.Show("Please check your connection");
            }
        }

        private void uc_editVehicle_Load(object sender, EventArgs e)
        {
            try
            {
                fillDriver();
                fillGrid();
                
            }
            catch(Exception)
            {
                MessageBox.Show("Please check your connection");
            }
        }

        private void btn_addVehicle_Click(object sender, EventArgs e)
        {
            try
            {
                if(string.IsNullOrEmpty(txt_vehicleNumber.Text))
                {
                    MessageBox.Show("Please enter correct vehicle No");
                }
                else if (cmb_driverName.SelectedIndex<0)
                {
                    MessageBox.Show("Please select a driver");
                }
                else
                {
                    con.Open();
                    SqlCommand cmdi = new SqlCommand("insert into tbl_vehicle(vehicle_no,driver_id) values('" + txt_vehicleNumber.Text + "',(select driver_id from tbl_driverDetails where driver_name='" + cmb_driverName.Text + "'))", con);
                    cmdi.ExecuteNonQuery();
                    con.Close();
                    txt_vehicleNumber.Clear();
                    cmb_driverName.Text = "";
                    fillGrid();
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Please check your connection");
            }
        }

        private void dataGridView_vehicle_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView_vehicle.Rows[e.RowIndex];
                txt_vehicleNumber.Text = row.Cells[0].Value.ToString();
               
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txt_vehicleNumber.Text))
                {
                    MessageBox.Show("Please enter correct vehicle No");
                }
                else if (cmb_driverName.SelectedIndex < 0)
                {
                    MessageBox.Show("Please select a driver");
                }
                else
                {
                    con.Open();
                    SqlCommand cmdi = new SqlCommand("update tbl_vehicle set driver_id = (select driver_id from tbl_driverDetails where driver_name = '"+cmb_driverName.Text+"') where vehicle_no = '"+txt_vehicleNumber.Text+"'", con);
                    cmdi.ExecuteNonQuery();
                    con.Close();
                    txt_vehicleNumber.Clear();
                    cmb_driverName.Text = "";
                    fillGrid();
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Please check your connection");
            }
        }

        private void btn_delVehicle_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txt_vehicleNumber.Text))
                {
                    MessageBox.Show("Please Select a vehicle No from table");
                }
                else
                {
                    con.Open();
                    SqlCommand cmdi = new SqlCommand("delete from tbl_vehicle where vehicle_no = '"+txt_vehicleNumber.Text+"'", con);
                    cmdi.ExecuteNonQuery();
                    con.Close();
                    txt_vehicleNumber.Clear();
                    cmb_driverName.Text = "";
                    fillGrid();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please check your connection");
            }
        }
    }
}
