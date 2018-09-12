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
        SqlConnection con;
        
        public frm_display()
        {

            InitializeComponent();
        }

        private void timer_timeTableSystemTime_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            this.lbl_time.Text = dt.ToString();
        }

        private void frm_display_Load(object sender, EventArgs e)
        {
            Timer timer = new Timer();
            timer.Interval = (30 * 1000); // 10 secs
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();

            try
            {
                con = new SqlConnection("Data Source=DESKTOP-3V2I63M;Initial Catalog=londromat;Integrated Security=True");
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
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            dataGridView_displayOut.Refresh();
            dataGridView_displayIn.Refresh();
        }

        private void dataGridView_displayOut_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void timer_timeTable_Tick(object sender, EventArgs e)
        {
            try
            {
                int i;
                for (i = 0; i < dataGridView_displayOut.RowCount; i++)
                {
                    string sqltime = "09:00:00";
                    DateTime leaveTime = DateTime.Parse(sqltime);
                    leaveTime = Convert.ToDateTime(dataGridView_displayOut.Rows[i].Cells[2].Value.ToString());
                    int q = DateTime.Compare(DateTime.Now, leaveTime);
                    if(q>0)
                    {
                        DataGridViewRow row = dataGridView_displayOut.Rows[i];
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
