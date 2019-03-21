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
    public partial class frm_display : Form
    {
        SqlConnection con = new SqlConnection(Program.server);
        
        public frm_display()
        {

            InitializeComponent();
        }

        private void timer_timeTableSystemTime_Tick(object sender, EventArgs e)//display the currunt time
        {
            DateTime dt = DateTime.Now;
            this.lbl_time.Text = dt.ToString();
        }

        private void setData() // retrive date from database and display on datagrid view
        {
            try
            {              
                con.Open();
                SqlDataAdapter sdaOut = new SqlDataAdapter("select root_id,leave_point,leave_time,destination,arrive_time,vehicle_no,driver_name,driver_contact , gLeave_time , date from tbl_timeTable , tbl_rootGroup where status = 'p' and date = (SELECT CONVERT (date, GETDATE())) and tbl_timeTable.group_id = tbl_rootGroup.group_id order by leave_time ", con);
                SqlDataAdapter sdaIn = new SqlDataAdapter("select root_id,leave_point,leave_time,destination,arrive_time,vehicle_no,driver_name,driver_contact , gArrival_time , date from tbl_timeTable , tbl_rootGroup where status = 'g' and date = (SELECT CONVERT (date, GETDATE())) and tbl_timeTable.group_id = tbl_rootGroup.group_id order by gArrival_time", con);
                DataTable dt = new DataTable();
                DataTable dtIn = new DataTable();
                sdaOut.Fill(dt);
                sdaIn.Fill(dtIn);
                dataGridView_displayOut.AutoGenerateColumns = false;
                dataGridView_displayOut.AllowUserToAddRows = false;
                dataGridView_displayIn.AutoGenerateColumns = false;
                dataGridView_displayIn.AllowUserToAddRows = false;
                dataGridView_displayOut.DataSource = dt;
                dataGridView_displayIn.DataSource = dtIn;
                con.Close();
            }
            catch(Exception)
            {
                MessageBox.Show("Please check your connection");
            }
        }

        private void frm_display_Load(object sender, EventArgs e) //refresh the display
        {           
            try
            {
                setData();
            }
            catch(Exception)
            {
                MessageBox.Show("Please check your connection");
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            
        }

        private void dataGridView_displayOut_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void timer_timeTable_Tick(object sender, EventArgs e) //change column colour
        {
            try
            {
                setData();
                string sqltime = "00:00:00";
                int i,j;
                for (i = 0; i < dataGridView_displayOut.RowCount; i++)
                {
                    
                    DateTime leaveTime = DateTime.Parse(sqltime);
                    leaveTime = Convert.ToDateTime(dataGridView_displayOut.Rows[i].Cells[4].Value.ToString());

                    TimeSpan timeDef = DateTime.Now - leaveTime ;
                    double tsm = timeDef.TotalMinutes;
                    
                    if(tsm> -10 && tsm < 0)
                    {
                        DataGridViewRow row = dataGridView_displayOut.Rows[i];
                        row.DefaultCellStyle.BackColor = Color.Chartreuse;
                        row.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 30 ,FontStyle.Bold);
                    }
                    else if(tsm >= 0)
                    {
                        DataGridViewRow row = dataGridView_displayOut.Rows[i];
                        row.DefaultCellStyle.BackColor = Color.Coral;
                        row.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 26);
                    }

                }
                for(j=0;j< dataGridView_displayIn.RowCount;j++)
                {
                    DateTime arivalTime = DateTime.Parse(sqltime);
                    arivalTime = Convert.ToDateTime(dataGridView_displayIn.Rows[j].Cells[4].Value.ToString());

                    int q = DateTime.Compare(DateTime.Now, arivalTime);
                    if(q>0)
                    {
                        DataGridViewRow row = dataGridView_displayIn.Rows[j];
                        row.DefaultCellStyle.BackColor = Color.Coral;
                    }
                    
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please check your connection");
            }
            
        }
    }
}
