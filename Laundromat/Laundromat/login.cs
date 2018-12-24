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
    public partial class login : Form
    {
        SqlConnection con = new SqlConnection(Program.server);

        public login()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txt_userName.Text))
            {
                errorProvider_userName.SetError(txt_userName, "User Name Required");
            }
            else if(string.IsNullOrEmpty(txt_password.Text))
            {
                errorProvider_password.SetError(txt_password, "Password Required");
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("select user_name,password,user_type from tbl_logIn where user_name = '" + txt_userName.Text + "' and password = '" + txt_password.Text + "' and user_type = 'user'", con);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    con.Close();
                    if (dt.Rows.Count > 0)
                    {
                        Program.logedUser = txt_userName.Text;
                        string sqltime = "09:00:00";
                        DateTime click = DateTime.Parse(sqltime);
                        click = Convert.ToDateTime(DateTime.Now.ToString());
                        Program.login = click;
                        con.Open();
                        SqlCommand cmdl = new SqlCommand("insert into tbl_logedUsers (user_name,login_time,loged_date) values('" + Program.logedUser + "','" + click + "',SYSDATETIME ( ))",con);
                        cmdl.ExecuteNonQuery();
                        con.Close();
                        this.Hide();
                        Operator_Home oh = new Operator_Home();
                        oh.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Invalid User Name or Password");
                    }
                    
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
            }
        }

        private void btn_admin_Click(object sender, EventArgs e)
        {
            this.Hide();
            adminLogin ad = new adminLogin();
            ad.ShowDialog();
            
        }
    }
}
