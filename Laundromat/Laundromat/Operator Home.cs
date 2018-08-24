using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Laundromat
{
    public partial class Operator_Home : Form
    {
        SqlConnection con;
        string start_time, end_time;
        DateTime nowTime;
        public Operator_Home()
        {
            InitializeComponent();
        }

        private void timer_operatorTime_Tick(object sender, EventArgs e)
        {
            nowTime = DateTime.Now;
            this.lbl_time.Text = nowTime.ToString();
            start_time = nowTime.ToShortTimeString();
            end_time = nowTime.AddHours(+2).ToShortTimeString();
        }

        private void Operator_Home_Load(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection("Data Source=DESKTOP-3V2I63M;Initial Catalog=londromat;Integrated Security=True");
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select * from vehicle_root " , con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView_operatorOut.AutoGenerateColumns = false;
                dataGridView_operatorOut.AllowUserToAddRows = false;


                dataGridView_operatorOut.DataSource = dt;
                con.Close();
                int i;
                for (i = 0; i < dataGridView_operatorOut.RowCount; i++)
                {
                    string sqltime = "09:00:00";
                    DateTime gg1 = DateTime.Parse(sqltime);
                    gg1 = Convert.ToDateTime(dataGridView_operatorOut.Rows[i].Cells[3].Value.ToString());
                   
                    int q = DateTime.Compare(DateTime.Now,gg1);
                    if (q<0)
                    {
                        DataGridViewRow row = dataGridView_operatorOut.Rows[i];
                        row.DefaultCellStyle.BackColor = Color.Green;

                       
                    }
                   // n++;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }
           
        }

        private void timer_operatorTimeTable_Tick(object sender, EventArgs e)
        {
            try
            {   
                //dataGridView_operatorOut.Refresh();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            

            
        }
    }
}
