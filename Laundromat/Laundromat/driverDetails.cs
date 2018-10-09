using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using System.Data.SqlClient;

namespace Laundromat
{
    public partial class driverDetails : UserControl
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-3V2I63M;Initial Catalog=londromat;Integrated Security=True");

        public driverDetails()
        {
          
            InitializeComponent();
            filldata();
        }
        public void filldata()
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select * from tbl_driverDetails", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView_showDriverDetails.AutoGenerateColumns = false;
            dataGridView_showDriverDetails.DataSource = dt;
            
            con.Close();
        }

        private void driverDetails_Load(object sender, EventArgs e)
        {

        }

        private void btn_editDriver_Click(object sender, EventArgs e)
        {
            btn_driverSearch.Visible = true;
            btn_driverDelete.Visible = true;
        }

        private void btn_newDriver_Click(object sender, EventArgs e)
        {
            btn_driverSearch.Visible = false;
            btn_driverDelete.Visible = false;
        }

        private void btn_driverSearch_Click(object sender, EventArgs e)
        {

        }

        private void btn_driverSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txt_driverName.Text))
                {
                    errorProvider_name.SetError(txt_driverName, "please enter the name");
                }
                else if (string.IsNullOrEmpty(txt_driverContact.Text))
                {
                    errorProvider_contact.SetError(txt_driverContact, "please enter driver's contact number");
                }
                else if (string.IsNullOrEmpty(txt_driverNic.Text))
                {
                    errorProvider_nic.SetError(txt_driverNic, "please enter nic");
                }
                else
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("insert into tbl_driverDetails(driver_name,driver_contact,driver_NIC) values ('" + txt_driverName.Text + "','" + txt_driverContact.Text + "','" + txt_driverNic.Text + "')",con);
                    int x = cmd.ExecuteNonQuery();
                    if(x>0)
                    {
                        MessageBox.Show("New Driver added successfully");
                    }
                    con.Close();
                }
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
