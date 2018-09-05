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
using System.Collections;

namespace Laundromat
{
    public partial class Operator_Home : Form
    {
        SqlConnection con;
        //string start_time, end_time;
        DateTime nowTime;
        DataTable dt;
        DataTable dtInDelevers;
        public Operator_Home()
        {
            InitializeComponent();
        }

        private void timer_operatorTime_Tick(object sender, EventArgs e)
        {
            nowTime = DateTime.Now;
            this.lbl_time.Text = nowTime.ToString();
            string sqltime = "09:00:00";
            DateTime start_time = DateTime.Parse(sqltime);
            start_time = start_time.AddHours(2);
            
        }

        public void fillDatabase()
        {
            try
            {
                con = new SqlConnection("Data Source=DESKTOP-3V2I63M;Initial Catalog=londromat;Integrated Security=True");
                con.Open();
                SqlCommand cmd1 = new SqlCommand();
                SqlCommand cmd2 = new SqlCommand();
                SqlDataAdapter sda = new SqlDataAdapter("select root_id,leave_point,leave_time,destination,arrive_time,vehicle_no,driver_id,driver_name,driver_contact,status from vehicle_root", con);
                DataTable dTable = new DataTable();
                sda.Fill(dTable);
               
                foreach (DataRow dr in dTable.Rows)
                {
                    
                    string sqltime = "09:00:00";
                    DateTime gg1 = DateTime.Parse(sqltime);
                    DateTime gg2 = DateTime.Parse(sqltime);
                    int rootId = Convert.ToInt32(dr[0]);
                    string leavePoint = dr[1].ToString();
                    string destination = dr[3].ToString();
                    string vehicle = dr[5].ToString();
                    int driveris = Convert.ToInt32(dr[6]);
                    string drivername = dr[7].ToString();
                    string drivertp = dr[8].ToString();
                    string stsus = dr[9].ToString();
                    gg1 = Convert.ToDateTime(dr[2].ToString());
                    gg2 = Convert.ToDateTime(dr[4].ToString());
                    cmd2 = new SqlCommand("insert into tbl_timeTable(root_id,leave_point,destination,vehicle_no,driver_id) values ('" + rootId + "','"+leavePoint+"','"+destination+"','"+vehicle+"','"+driveris+"')", con);
                    cmd2.ExecuteNonQuery();
                }
                con.Close();
                dTable.Dispose();
                sda.Dispose();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            

        }

        private void fillTable()
        {
            con = new SqlConnection("Data Source=DESKTOP-3V2I63M;Initial Catalog=londromat;Integrated Security=True");
            con.Open();
            SqlDataAdapter sdaOut = new SqlDataAdapter("select * from vehicle_root where leave_time>'09:30' and leave_time<'13:00' and status = 'p' order by leave_time", con);
            SqlDataAdapter sdaIn = new SqlDataAdapter("select * from vehicle_root where status = 'g' ", con);
            dt = new DataTable();
            dtInDelevers = new DataTable();
            sdaOut.Fill(dt);
            sdaIn.Fill(dtInDelevers);
            
        }

        private void Operator_Home_Load(object sender, EventArgs e)
        {
            try
            {
                fillDatabase();
                fillTable();
                dataGridView_operatorOut.AutoGenerateColumns = false;
                dataGridView_operatorIn.AutoGenerateColumns = false;
                dataGridView_operatorOut.AllowUserToAddRows = false;
                dataGridView_operatorIn.AllowUserToAddRows = false;
                dataGridView_operatorOut.DataSource = dt;
                dataGridView_operatorIn.DataSource = dtInDelevers;
                fillcombo();
                con.Close();
                
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }
           
        }

        private void dataGridView_operatorOut_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                if (dataGridView_operatorOut.Columns[e.ColumnIndex].Name == "dgv_operatorOutConfirm")
                {
                    int index = e.RowIndex;
                    DataGridViewRow selectedRow = dataGridView_operatorOut.Rows[index];
                    string id = selectedRow.Cells[0].Value.ToString();
                    MessageBox.Show(id);
                    con = new SqlConnection("Data Source=DESKTOP-3V2I63M;Initial Catalog=londromat;Integrated Security=True");
                    con.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE vehicle_root SET status = 'g' where root_id = '"+id+"'",con);
                    cmd.ExecuteNonQuery();

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
        private void fillcombo()
        {
            ArrayList drivercol = new ArrayList();
            ArrayList vehiclecol = new ArrayList();
            foreach(DataRow dr in dt.Rows)
            {
                drivercol.Add(dr["driver_name"].ToString());
                vehiclecol.Add(dr["vehicle_no"]).ToString();
            }
            dgv_operatorOutDriverName.Items.AddRange(drivercol.ToArray());
            dgv_operatorOutVehicleNo.Items.AddRange(vehiclecol.ToArray());
        }

        private void dataGridView_operatorIn_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

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
                int i;
                for (i = 0; i < dataGridView_operatorOut.RowCount; i++)
                {
                    string sqltime = "09:00:00";
                    DateTime gg1 = DateTime.Parse(sqltime);
                    gg1 = Convert.ToDateTime(dataGridView_operatorOut.Rows[i].Cells[4].Value.ToString());

                    int q = DateTime.Compare(DateTime.Now, gg1);
                    if (q > 0)
                    {
                        DataGridViewRow row = dataGridView_operatorOut.Rows[i];
                        row.DefaultCellStyle.BackColor = Color.Green;
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }   
        }
    }
}
