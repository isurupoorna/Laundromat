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

        public driver()
        {
            InitializeComponent();
        }

        private void btn_saveDriver_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txt_driverName.Text) )
                {
                    errorProvider_name.SetError(txt_driverName, "please enter the name");
                }
                else if (string.IsNullOrEmpty(txt_driverContact.Text) && txt_driverContact.Text.Length != 10)
                {
                    errorProvider_contact.SetError(txt_driverContact, "please enter valide driver's contact number");
                }
                else if (string.IsNullOrEmpty(txt_driverNic.Text))
                {
                    errorProvider_nic.SetError(txt_driverNic, "please enter nic");
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
                }

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
