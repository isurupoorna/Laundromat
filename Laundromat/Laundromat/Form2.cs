using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laundromat
{
    public partial class adminLogin : Form
    {
        SqlConnection con = new SqlConnection(Program.server);
        public adminLogin()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_loginAdmin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_adminUserName.Text))
            {
                errorProvider_userName.SetError(txt_adminUserName, "User Name Required");
            }
            else if (string.IsNullOrEmpty(txt_adminPassword.Text))
            {
                errorProvider_password.SetError(txt_adminPassword, "Password Required");
            }
            else
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select user_name,password from tbl_logIn where user_name = '" + txt_adminUserName.Text + "' and password = '" + txt_adminPassword.Text + "' and user_type = 'admin'", con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    adminHome ah = new adminHome();
                    this.Close();
                    ah.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Invalid User Name or Password");
                }
                con.Close();
            }
        }
    }
}
