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
    public partial class driver : UserControl
    {
        SqlConnection con = new SqlConnection(Program.server);
        int id;

        public driver()
        {
            InitializeComponent();
            loadData();
        }

        private void loadData()
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select * from tbl_driverDetails", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dgv_driverDetails.DataSource = dt;
            con.Close();
            dgv_driverDetails.AllowUserToAddRows = false;
        }

        private void btn_saveDriver_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txt_driverName.Text) )
                {
                    errorProvider_name.SetError(txt_driverName, "Please enter the name");
                }
                else if (string.IsNullOrEmpty(txt_driverContact.Text) || txt_driverContact.Text.Length != 10)
                {
                    errorProvider_contact.SetError(txt_driverContact, "Please enter valide driver's contact number");
                }
                else if (string.IsNullOrEmpty(txt_driverNic.Text) || txt_driverNic.TextLength !=10)
                {
                    errorProvider_nic.SetError(txt_driverNic, "Please enter valid nic");
                }
                else
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("insert into tbl_driverDetails(driver_name,driver_contact,driver_NIC) values ('" + txt_driverName.Text + "','" + txt_driverContact.Text + "','" + txt_driverNic.Text + "')", con);
                    int x = cmd.ExecuteNonQuery();
                    if (x > 0)
                    {
                        MessageBox.Show("New Driver added successfully");
                    }
                    con.Close();
                    loadData();
                }

            }catch(Exception)
            {
                MessageBox.Show("Please check your connection");
            }
        }

        private void dgv_driverDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgv_driverDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.dgv_driverDetails.Rows[e.RowIndex];
                    id = Convert.ToInt32(row.Cells[0].Value.ToString());
                    txt_driverName.Text = row.Cells[1].Value.ToString();
                    txt_driverContact.Text = row.Cells[2].Value.ToString();
                    txt_driverNic.Text = row.Cells[3].Value.ToString();
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Please check your connection");
            }
        }

        private void btn_updateDriver_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txt_driverName.Text))
                {
                    errorProvider_name.SetError(txt_driverName, "Please enter the name");
                }
                else if (string.IsNullOrEmpty(txt_driverContact.Text) || txt_driverContact.Text.Length != 10)
                {
                    errorProvider_contact.SetError(txt_driverContact, "Please enter valid driver's contact number");
                }
                else if (string.IsNullOrEmpty(txt_driverNic.Text) || txt_driverNic.TextLength != 10)
                {
                    errorProvider_nic.SetError(txt_driverNic, "Please enter valid NIC");
                }
                else
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("update tbl_driverDetails set driver_name = '" + txt_driverName.Text + "' , driver_contact = '" + txt_driverContact.Text + "', driver_NIC = '" + txt_driverNic.Text + "' where driver_id = '" + id + "'", con);
                    int x = cmd.ExecuteNonQuery();
                    con.Close();
                    if (x > 0)
                    {
                        MessageBox.Show("Driver has Successfully Updated");
                        loadData();
                    }
                    else
                    {
                        MessageBox.Show("Please try again");
                    }
                                       
                }
                
            }
            catch(Exception)
            {
                MessageBox.Show("Enter a valid mobile number");
            }
            
        }

        private void btn_delDriver_Click(object sender, EventArgs e)
        {
            try
            {

                con.Open();

                SqlCommand cmd = new SqlCommand("delete from tbl_driverDetails where driver_NIC = '"+txt_driverNic.Text+"' ", con);
                int x = cmd.ExecuteNonQuery();
                con.Close();
                if (x > 0)
                {
                    MessageBox.Show("Driver Has Successfully Deleted");
                }
                loadData();

            }
            catch (Exception)
            {
                MessageBox.Show("Please check your connection");
            }
        }
    }
}
