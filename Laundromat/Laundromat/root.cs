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
                SqlDataAdapter sda = new SqlDataAdapter("select * from vehicle_root", con);
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
