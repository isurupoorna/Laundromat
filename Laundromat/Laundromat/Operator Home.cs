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
using System.Media;

namespace Laundromat
{
    public partial class Operator_Home : Form
    {
        SqlConnection con = new SqlConnection(Program.server); 
        
        DateTime nowTime;
        DataTable dt;
        DataTable dtInDelevers;
        string checkDate = "";
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

        private void checkDay()
        {  try
            {
                string mySqlTimestamp = "2003-12-31";
                DateTime chk = DateTime.Parse(mySqlTimestamp);
                con.Open();
                SqlDataAdapter sd = new SqlDataAdapter("select date from tbl_timeTable order by date DESC", con);
                DataTable t = new DataTable();
                sd.Fill(t);
                foreach(DataRow dr in t.Rows)
                {
                    mySqlTimestamp = dr[0].ToString();
                }
                
                    if (mySqlTimestamp == DateTime.Now.ToShortDateString())
                    {
                        checkDate = "false";

                    }
                    else
                    {
                        checkDate = "true";
                    }
                
                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public void fillDatabase()
        {
            try
            {               
                if(checkDate== "true")
                {
                    con.Open();
                    SqlCommand cmd1 = new SqlCommand();
                    SqlCommand cmd2 = new SqlCommand();
                    SqlCommand restoreTable = new SqlCommand("update vehicle_root SET status = 'p'",con);
                    restoreTable.ExecuteNonQuery();
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
                        string today = DateTime.Now.ToShortDateString();
                        cmd2 = new SqlCommand("insert into tbl_timeTable(root_id,leave_point,leave_time,destination,arrive_time,vehicle_no,driver_id,driver_name,driver_contact,status,date) values ('" + rootId + "','" + leavePoint + "','" + gg1 + "','" + destination + "','" + gg2 + "','" + vehicle + "','" + driveris + "','" + drivername + "','" + drivertp + "','" + stsus + "','" + today + "')", con);
                        cmd2.ExecuteNonQuery();
                    }
                    con.Close();
                    dTable.Dispose();
                    sda.Dispose();

                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            

        }

        private void fillTable()
        {
            con.Open();
            SqlDataAdapter sdaOut = new SqlDataAdapter("select * from vehicle_root where status = 'p' order by leave_time", con);
            SqlDataAdapter sdaIn = new SqlDataAdapter("select * from tbl_timeTable where status = 'g' and date = (SELECT CONVERT (date, GETDATE())) ", con);
            dt = new DataTable();
            dtInDelevers = new DataTable();
            sdaOut.Fill(dt);
            sdaIn.Fill(dtInDelevers);
            dataGridView_operatorOut.AutoGenerateColumns = false;
            dataGridView_operatorIn.AutoGenerateColumns = false;
            dataGridView_operatorOut.AllowUserToAddRows = false;
            dataGridView_operatorIn.AllowUserToAddRows = false;
            dataGridView_operatorOut.DataSource = dt;
            dataGridView_operatorIn.DataSource = dtInDelevers;
            con.Close();
            fillcombo();
            

        }
        private void openForm()
        {
            Form timeTable = new frm_display();
            timeTable.Show();
        }

        private void Operator_Home_Load(object sender, EventArgs e)
        {
            try
            {
                checkDay();
                fillDatabase();
                fillTable();
                openForm();
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
                    con.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE tbl_timeTable SET status = 'g' where root_id = '" + id+"'",con);
                    SqlCommand cmd1 = new SqlCommand("update vehicle_root SET status = 'g' where root_id = '" + id + "'", con);
                    cmd.ExecuteNonQuery();
                    cmd1.ExecuteNonQuery();
                    con.Close();
                    dataGridView_operatorOut.Rows.RemoveAt(index);
                    fillTable();
                    
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
            con.Open();


            //load data for vehicle combo
            SqlDataAdapter sdaV = new SqlDataAdapter("select vehicle_no from tbl_vehicle", con);
            DataTable veh = new DataTable();
            sdaV.Fill(veh);
            foreach (DataRow dr in veh.Rows)
            {
                vehiclecol.Add(dr["vehicle_no"]).ToString();
            }


            //load data for driver combo
            SqlDataAdapter sdaD = new SqlDataAdapter("select driver_name from tbl_driverDetails", con);
            DataTable dri = new DataTable();
            sdaD.Fill(dri);
            foreach(DataRow dr1 in dri.Rows)
            {
                drivercol.Add(dr1["driver_name"].ToString());
            }



            con.Close();
                     
            dgv_operatorOutDriverName.Items.AddRange(drivercol.ToArray());
            dgv_operatorOutVehicleNo.Items.AddRange(vehiclecol.ToArray());
           
        }

        private void dataGridView_operatorIn_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridView_operatorIn.Columns[e.ColumnIndex].Name == "dgv_operatorInConfirm")
                {
                    int index = e.RowIndex;
                    DataGridViewRow selectedRow = dataGridView_operatorIn.Rows[index];
                    string id = selectedRow.Cells[0].Value.ToString();
                    con.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE tbl_timeTable SET status = 'f' where root_id = '" + id + "'", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    dataGridView_operatorIn.Rows.RemoveAt(index);

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
                        row.DefaultCellStyle.BackColor = Color.Cyan;                      
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }   
        }

        private void dataGridView_operatorOut_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            try
            {
                if (this.dataGridView_operatorOut.CurrentCell.ColumnIndex == 2)
                {
                    int x = dataGridView_operatorOut.CurrentCell.RowIndex;
                    DataGridViewRow selectedRow = dataGridView_operatorOut.Rows[x];
                    string id = selectedRow.Cells[0].Value.ToString();
                    string vehicleNo = dataGridView_operatorOut.Rows[x].Cells[1].Value.ToString();
                    con.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE tbl_timeTable SET vehicle_no = '" + vehicleNo + "' where root_id = '" + id + "'", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                if(this.dataGridView_operatorOut.CurrentCell.ColumnIndex == 3)
                {
                    int x = dataGridView_operatorOut.CurrentCell.RowIndex;
                    DataGridViewRow selectedRow = dataGridView_operatorOut.Rows[x];
                    string id = selectedRow.Cells[0].Value.ToString();
                    string driverName = dataGridView_operatorOut.Rows[x].Cells[2].Value.ToString();
                    con.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE tbl_timeTable SET vehicle_no = '" + driverName + "' where root_id = '" + id + "'", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void timer_sound_Tick(object sender, EventArgs e)
        {
            /*int i;
            for (i = 0; i < dataGridView_operatorOut.RowCount; i++)
            {
                string sqltime = "09:00:00";
                DateTime gg1 = DateTime.Parse(sqltime);
                gg1 = Convert.ToDateTime(dataGridView_operatorOut.Rows[i].Cells[4].Value.ToString());

                int q = DateTime.Compare(DateTime.Now, gg1);
                if (q > 0)
                {
                    SoundPlayer player = new SoundPlayer(Properties.Resources.beep);
                    player.Load();
                    player.Play();
                    break;
                
                }
            }
            */
            }
    }
}
