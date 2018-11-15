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

        private void uc_editVehicle_Load(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                
                SqlDataAdapter sda = new SqlDataAdapter("select * from tbl_vehicle",con);
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
    }
}
