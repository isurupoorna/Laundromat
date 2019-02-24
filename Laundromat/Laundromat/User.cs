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
    public partial class User : UserControl
    {
        SqlConnection con = new SqlConnection(Program.server);
        int id;
       

        public User()
        {
            InitializeComponent();
        }

        private void User_Load(object sender, EventArgs e)
        {
            loadUser();
        }

        private void loadUser()
        {
            try
            {
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select * from tbl_logIn", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dgv_userDetails.DataSource = dt;
                dgv_userDetails.AllowUserToAddRows = false;
                con.Close();
            }
            catch(Exception)
            {
                MessageBox.Show("Please check your connection");
            }
            

        }

        private void addUser()
        {
            try

            {
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into tbl_logIn (user_name,password,user_type) values('" + txt_user.Text + "','" + txt_pass.Text + "','" + cmb_type.Text + "')", con);
                cmd.ExecuteNonQuery();
                con.Close();
                txt_pass.Text = "";
                txt_user.Text = "";
                loadUser();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txt_user.Text))
            {
                MessageBox.Show(" Please Enter Valied User Name ");
            }
            else if(string.IsNullOrEmpty(txt_pass.Text))
            {
                MessageBox.Show("Please Enter Valied Password");
            }
            else if(cmb_type.SelectedIndex<0)
            {
                MessageBox.Show("Please Select User Type");
            }
            else
            {
                try
                {
                    int i;
                    string r;
                    
                    string name = txt_user.Text;
                    for(i=0; i<dgv_userDetails.RowCount; i++)
                    {
                        r = dgv_userDetails.Rows[i].Cells[1].Value.ToString();
                        if(r==name)
                        {
                            MessageBox.Show("nop");
                        
                        }
                        else
                        {
                            
                            addUser();
                            break;
                        }
                    }
                    
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
            }
        }

        private void dgv_userDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.dgv_userDetails.Rows[e.RowIndex];
                    id = Convert.ToInt32(row.Cells[0].Value);
                    txt_user.Text = row.Cells[1].Value.ToString();
                    txt_pass.Text = row.Cells[2].Value.ToString();
                    cmb_type.Text = row.Cells[3].Value.ToString();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                
                SqlCommand cmd = new SqlCommand("delete from tbl_logIn where user_id = '" + id + "'", con);
                int x = cmd.ExecuteNonQuery();
                con.Close();
                if (x > 0)
                {
                    MessageBox.Show("User Has Successfuly Deleted");
                    txt_pass.Text = "";
                    txt_user.Text = "";
                    cmb_type.Text = "";
                    loadUser();
                }
               
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void dgv_userDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                id = e.RowIndex;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void User_Click(object sender, EventArgs e)
        {
            txt_pass.Text = "";
            txt_user.Text = "";
            cmb_type.Text = "";
        }
    }
}
