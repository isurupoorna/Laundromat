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

        //to check if it is first run of the day
        private void checkDay()
        {  try
            {
                string mySqlTimestamp = "2003-12-31";
                DateTime tm = System.DateTime.Now.Date;
                DateTime chk = DateTime.Parse(mySqlTimestamp);
                con.Open();
                SqlCommand com = new SqlCommand("select date from tbl_timeTable where date = '"+ tm.ToString("yyyy-MM-dd") +"' order by date DESC", con);
                SqlDataReader dr1;
                dr1 = com.ExecuteReader();
                    if (dr1.Read())
                    {
                        checkDate = "false";

                    }
                    else
                    {
                        checkDate = "true";
                    }
                
                con.Close();
            }
            catch(Exception)
            {
                MessageBox.Show("Please check your connection");
            }

        }



        //copy data from vehicle_root to tbl_time table
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
                    SqlDataAdapter sda = new SqlDataAdapter("select root_id,leave_point,leave_time,destination,arrive_time,vehicle_no,driver_id,driver_name,driver_contact,status,group_id,group_name from vehicle_root", con);
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
                        int groupId = Convert.ToInt32(dr[10]);
                        string groupName = dr[11].ToString();
                        gg1 = Convert.ToDateTime(dr[2].ToString());
                        gg2 = Convert.ToDateTime(dr[4].ToString());
                        string today = DateTime.Now.ToShortDateString();
                        cmd2 = new SqlCommand("insert into tbl_timeTable(root_id,leave_point,leave_time,destination,arrive_time,vehicle_no,driver_id,driver_name,driver_contact,status,date,group_id,group_name) values ('" + rootId + "','" + leavePoint + "','" + gg1 + "','" + destination + "','" + gg2 + "','" + vehicle + "','" + driveris + "','" + drivername + "','" + drivertp + "','" + stsus + "','" + today + "','"+groupId+"','"+groupName+"')", con);
                        cmd2.ExecuteNonQuery();
                    }
                    con.Close();
                    dTable.Dispose();
                    sda.Dispose();

                }

            }
            catch(Exception)
            {
                MessageBox.Show("Please check your connection");
            }
            

        }

        //fill tha display data grid viwe
        private void fillTable()
        {
            try
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
            }
            catch(Exception)
            {
                MessageBox.Show("Please check your connection");
            }
            
            
            

        }
        private void openForm()//open the display form 
        {
            Form timeTable = new frm_display();
            timeTable.Show();
        }

        private void checkParliment() //check parliment dates
        {
            try
            {
                DayOfWeek today = DateTime.Now.DayOfWeek;
                if (today == DayOfWeek.Thursday || today == DayOfWeek.Tuesday || today == DayOfWeek.Saturday || today == DayOfWeek.Sunday)
                {
                    int i;
                    for (i = 0; i < dataGridView_operatorOut.RowCount; i++)
                    {
                        int pId = Convert.ToInt32(dataGridView_operatorOut.Rows[i].Cells[0].Value);
                        if (pId == 42)
                        {
                            con.Open();
                            SqlCommand cmd = new SqlCommand("update vehicle_root set status = 'n' where root_id = 42", con);
                            SqlCommand cmd1 = new SqlCommand("update tbl_timeTable set status = 'n' where root_id = 42 and date = (SELECT CONVERT (date, GETDATE()))", con);
                            cmd.ExecuteNonQuery();
                            cmd1.ExecuteNonQuery();
                            con.Close();
                        }
                    }
                    fillTable();
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Please check your connection");
            }
            
            
        }

        private void Operator_Home_Load(object sender, EventArgs e)
        {
            try
            {
                checkDay();
                fillDatabase();
                fillTable();
                checkParliment();
                fillcombo();
                openForm();
            }
            catch(Exception)
            {
                MessageBox.Show("Please check your connection");
                
            }
           
        }

        private void dataGridView_operatorOut_CellContentClick(object sender, DataGridViewCellEventArgs e) //conform button 
        {

            try
            {
                if (dataGridView_operatorOut.Columns[e.ColumnIndex].Name == "dgv_operatorOutConfirm")
                {
                    int index = e.RowIndex;

                    if (string.IsNullOrEmpty(dataGridView_operatorOut.Rows[index].Cells[1].Value as string))
                    {
                        MessageBox.Show("Please Select a Vehicle");
                    }
                    else if(string.IsNullOrEmpty(dataGridView_operatorOut.Rows[index].Cells[2].Value as string))
                    {
                        MessageBox.Show("Please Select a driver");
                    }
                    else
                    {
                        string sqltime = "09:00:00";
                        DateTime click = DateTime.Parse(sqltime);
                        click = Convert.ToDateTime(DateTime.Now.ToString());
                        DataGridViewRow selectedRow = dataGridView_operatorOut.Rows[index];

                        string id = selectedRow.Cells[0].Value.ToString();
                        string vehicleNo = dataGridView_operatorOut.Rows[index].Cells[1].Value.ToString();
                        string driverName = dataGridView_operatorOut.Rows[index].Cells[2].Value.ToString();

                        con.Open();

                        SqlCommand cmd = new SqlCommand("UPDATE tbl_timeTable SET status = 'g' , leave_time = '" + click + "', vehicle_no = '" + vehicleNo + "', driver_name = '" + driverName + "' where root_id = '" + id + "' and date = (SELECT CONVERT (date, GETDATE())) ", con);
                        SqlCommand cmd1 = new SqlCommand("update vehicle_root SET status = 'g' where root_id = '" + id + "'", con);
                       // SqlCommand cmd2 = new SqlCommand("UPDATE tbl_timeTable SET vehicle_no = '" + vehicleNo + "' where root_id = '" + id + "'", con);
                       // SqlCommand cmd3 = new SqlCommand("UPDATE tbl_timeTable SET driver_name = '" + driverName + "' where root_id = '" + id + "'", con);

                        cmd.ExecuteNonQuery();
                        cmd1.ExecuteNonQuery();
                       // cmd2.ExecuteNonQuery();
                       // cmd3.ExecuteNonQuery();

                        con.Close();
                        dataGridView_operatorOut.Rows.RemoveAt(index);
                        fillTable();
                    }
                    
                    
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Please check your connection");
            }
            
        }
        private void fillcombo() //fill vehicle no combo box
        {
            try
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
                foreach (DataRow dr1 in dri.Rows)
                {
                    drivercol.Add(dr1["driver_name"].ToString());
                }

                con.Close();

                dgv_operatorOutDriverName.Items.AddRange(drivercol.ToArray());
                dgv_operatorOutVehicleNo.Items.AddRange(vehiclecol.ToArray());
            }
            catch(Exception)
            {
                MessageBox.Show("Please check your connection");
            }
            
           
        }

        private void dataGridView_operatorIn_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridView_operatorIn.Columns[e.ColumnIndex].Name == "dgv_operatorInConfirm")
                {
                    int index = e.RowIndex;
                    string sqltime = "09:00:00";
                    DateTime click = DateTime.Parse(sqltime);
                    click = Convert.ToDateTime(DateTime.Now.ToString());
                    DataGridViewRow selectedRow = dataGridView_operatorIn.Rows[index];
                    string id = selectedRow.Cells[0].Value.ToString();
                    
                    con.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE tbl_timeTable SET status = 'f' , arrive_time = '"+click+"' where root_id = '" + id + "' and date = (SELECT CONVERT (date, GETDATE())) ", con);
                    
                    cmd.ExecuteNonQuery();
                    
                    con.Close();
                    dataGridView_operatorIn.Rows.RemoveAt(index);

                }
            }
            catch(Exception)
            {
                MessageBox.Show("Please check your connection");
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
            catch(Exception)
            {
                MessageBox.Show("Please check your connection");
            }   
        }

        private void dataGridView_operatorOut_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            try
            {

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void timer_sound_Tick(object sender, EventArgs e)
        {

        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            try
            {
                string userName = Program.logedUser;
                string sqltime = "09:00:00";
                DateTime click = DateTime.Parse(sqltime);
                click = Convert.ToDateTime(DateTime.Now.ToString());
                con.Open();

                SqlCommand cmdl = new SqlCommand("update tbl_logedUsers set logout_time = '"+click+"' where user_name = '"+Program.logedUser+"' and login_time = '"+Program.login+"'", con);

                cmdl.ExecuteNonQuery();
                
                con.Close();
                this.Hide();
                login log = new login();
                log.ShowDialog();
            }
            catch(Exception)
            {
                MessageBox.Show("Please check your connection");
            }
        }
    }
}
