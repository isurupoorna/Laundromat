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

        private void fillDriver()
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void fillGrid()
        {
            try
            {
                con.Open();

                SqlDataAdapter sda = new SqlDataAdapter("select * from tbl_vehicle", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView_vehicle.DataSource = dt;
                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void uc_editVehicle_Load(object sender, EventArgs e)
        {
            try
            {
                fillDriver();
                fillGrid();
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_addVehicle_Click(object sender, EventArgs e)
        {
            try
            {
                if(string.IsNullOrEmpty(txt_vehicleNumber.Text))
                {
                    MessageBox.Show("sss");
                }
                if (cmb_driverName.SelectedIndex<0)
                {
                    MessageBox.Show("sss");
                }
                else
                {
                    int id=0;
                    con.Open();
                    SqlCommand cmd = new SqlCommand("select driver_id from tbl_driverDetails where driver_name='"+cmb_driverName.Text+"'", con);
                    SqlDataReader sda;
                    sda = cmd.ExecuteReader();
                    while (sda.Read())
                    {
                        id = Convert.ToInt32(sda["driver_id"]);
                    }
                    
                    sda.Close();
                    SqlCommand cmdi = new SqlCommand("insert into tbl_vehicle(vehicle_no,driver_id) values('" + txt_vehicleNumber.Text + "','" + id + "')", con);
                    cmdi.ExecuteNonQuery();
                    con.Close();
                    txt_vehicleNumber.Clear();
                    cmb_driverName.Text = "";
                    fillGrid();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
