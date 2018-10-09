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

        private void timer_timeTableSystemTime_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            this.lbl_time.Text = dt.ToString();
        }

        private void setData()
        {
            try
            {              
                con.Open();
                SqlDataAdapter sdaOut = new SqlDataAdapter("select * from tbl_timeTable where status = 'p' and date = (SELECT CONVERT (date, GETDATE())) order by leave_time ", con);
                SqlDataAdapter sdaIn = new SqlDataAdapter("select * from tbl_timeTable where status = 'g' and date = (SELECT CONVERT (date, GETDATE())) order by arrive_time ", con);
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
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frm_display_Load(object sender, EventArgs e)
        {
            Timer timer = new Timer();
            timer.Interval = (30 * 1000); // 10 secs
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();

            try
            {
                setData();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            
        }

        private void dataGridView_displayOut_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void timer_timeTable_Tick(object sender, EventArgs e)
        {
            try
            {
                setData();
                string sqltime = "09:00:00";
                int i,j;
                for (i = 0; i < dataGridView_displayOut.RowCount; i++)
                {
                    
                    DateTime leaveTime = DateTime.Parse(sqltime);
                    leaveTime = Convert.ToDateTime(dataGridView_displayOut.Rows[i].Cells[2].Value.ToString());
                    int q = DateTime.Compare(DateTime.Now, leaveTime);
                    if(q>0)
                    {
                        DataGridViewRow row = dataGridView_displayOut.Rows[i];
                        row.DefaultCellStyle.BackColor = Color.Red;
                    }
                }
                for(j=0;j< dataGridView_displayIn.RowCount;j++)
                {
                    DateTime arivalTime = DateTime.Parse(sqltime);
                    arivalTime = Convert.ToDateTime(dataGridView_displayIn.Rows[j].Cells[3].Value.ToString());
                    int q = DateTime.Compare(DateTime.Now, arivalTime);
                    if(q>0)
                    {
                        DataGridViewRow row = dataGridView_displayIn.Rows[j];
                        row.DefaultCellStyle.BackColor = Color.Red;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
