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
    public partial class reports : UserControl
    {
        SqlConnection con = new SqlConnection(Program.server);

        public reports()
        {
            InitializeComponent();
        }

        private void reports_Load(object sender, EventArgs e)
        {
            fillDriver();
            fillVehicle();
            //fillRoot();
        }

        private void fillDriver()
        {
            try
            {
                con.Open();
                SqlDataReader dr = new SqlCommand("select driver_name from tbl_driverDetails", con).ExecuteReader();
                while (dr.Read())
                {
                    cmb_driver.Items.Add(dr.GetValue(0).ToString());
                }
                dr.Close();
                cmb_driver.Items.Add("All");
                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        //private void fillRoot()
        //{
        //    try
        //    {
        //        con.Open();
        //        SqlDataReader sda  = new SqlCommand("select group_name from tbl_rootGroup", con).ExecuteReader();
        //        while(sda.Read())
        //        {
        //            cmb_rootName.Items.Add(sda.GetValue(0).ToString());
        //        }
        //        sda.Close();
        //        cmb_rootName.Items.Add("All");
        //        con.Close();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}

        private void fillVehicle()
        {
            try
            {
                con.Open();
                SqlDataReader dr = new SqlCommand("select vehicle_no from tbl_vehicle", con).ExecuteReader();
                while (dr.Read())
                {
                    cmb_vehicle.Items.Add(dr.GetValue(0).ToString());
                }
                dr.Close();
                cmb_vehicle.Items.Add("All");
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_reportView_Click(object sender, EventArgs e)
        {
            try
            {
                
                if(dateTimePicker_startDate.Value.Date > DateTime.Today)
                {
                    MessageBox.Show("Please select a valied date");
                }
                else if(dateTimePicker_endDate.Value.Date > DateTime.Today)
                {
                    MessageBox.Show("Please select a valied date");
                }
                else if(dateTimePicker_startDate.Value.Date > dateTimePicker_endDate.Value.Date)
                {
                    MessageBox.Show("Please select a valied date");
                }
                else
                {
                    if(cmb_driver.Text == "All" )
                    {
                        if(cmb_vehicle.Text=="All")
                        {
                            con.Open();
                            SqlDataAdapter asd = new SqlDataAdapter("select  driver_name,vehicle_no,leave_point,leave_time,destination,arrive_time from tbl_timeTable where date between '"+dateTimePicker_startDate.Value.Date+"' and '"+dateTimePicker_endDate.Value.Date+"'", con);
                            DataTable dt = new DataTable();
                            asd.Fill(dt);
                            con.Close();
                            dataGridView_report.DataSource = dt;
                        }
                        else
                        {
                            con.Open();
                            SqlDataAdapter sda = new SqlDataAdapter("select  driver_name,vehicle_no,leave_point,leave_time,destination,arrive_time from tbl_timeTable where date between '" + dateTimePicker_startDate.Value.Date + "' and '" + dateTimePicker_endDate.Value.Date + "' and  vehicle_no = '" + cmb_vehicle.Text+"' ", con);
                            DataTable dt = new DataTable();
                            sda.Fill(dt);
                            con.Close();
                            dataGridView_report.DataSource = dt;
                        }
                        
                    }
                    else
                    {
                        if(cmb_vehicle.Text=="All")
                        {
                            con.Open();
                            SqlDataAdapter sda = new SqlDataAdapter("select  driver_name,vehicle_no,leave_point,leave_time,destination,arrive_time from tbl_timeTable where date between '" + dateTimePicker_startDate.Value.Date + "' and '" + dateTimePicker_endDate.Value.Date + "' and driver_name = '" + cmb_driver.Text+"'", con);
                            DataTable dt = new DataTable();
                            sda.Fill(dt);
                            con.Close();
                            dataGridView_report.DataSource = dt;
                        }
                        else
                        {
                            con.Open();
                            SqlDataAdapter sda = new SqlDataAdapter("select  driver_name,vehicle_no,leave_point,leave_time,destination,arrive_time from tbl_timeTable where date between '" + dateTimePicker_startDate.Value.Date + "' and '" + dateTimePicker_endDate.Value.Date + "' and driver_name = '" + cmb_driver.Text+"' and vehicle_no = '"+cmb_vehicle.Text+"'", con);
                            DataTable dt = new DataTable();
                            sda.Fill(dt);
                            con.Close();
                            dataGridView_report.DataSource = dt;
                        }
                        
                    }

                   
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_late_Click(object sender, EventArgs e)
        {
            try
            {

                if (dateTimePicker_startDate.Value.Date > DateTime.Today)
                {
                    MessageBox.Show("Please select a valied date");
                }
                else if (dateTimePicker_endDate.Value.Date > DateTime.Today)
                {
                    MessageBox.Show("Please select a valied date");
                }
                else if (dateTimePicker_startDate.Value.Date > dateTimePicker_endDate.Value.Date)
                {
                    MessageBox.Show("Please select a valied date");
                }
                else
                {
                    if (cmb_driver.Text == "All")
                    {
                        if (cmb_vehicle.Text == "All")
                        {
                            con.Open();
                            SqlDataAdapter asd = new SqlDataAdapter("select tbl_timeTable.date as Date,tbl_timeTable.leave_point,tbl_timeTable.destination ,vehicle_root.leave_time as Expected,tbl_timeTable.leave_time as Leaved,tbl_timeTable.driver_name,tbl_timeTable.vehicle_no from tbl_timeTable,vehicle_root where vehicle_root.leave_time < tbl_timeTable.leave_time and vehicle_root.root_id = tbl_timeTable.root_id and tbl_timeTable.date between '" + dateTimePicker_startDate.Value.Date+"' and '"+dateTimePicker_endDate.Value.Date+"' ", con);
                            DataTable dt = new DataTable();
                            asd.Fill(dt);
                            con.Close();
                            dataGridView_report.DataSource = dt;
                        }
                        else
                        {
                            con.Open();
                            SqlDataAdapter sda = new SqlDataAdapter("select tbl_timeTable.date as Date,tbl_timeTable.leave_point,tbl_timeTable.destination ,vehicle_root.leave_time as Expected,tbl_timeTable.leave_time as Leaved,tbl_timeTable.driver_name,tbl_timeTable.vehicle_no from tbl_timeTable,vehicle_root where vehicle_root.leave_time < tbl_timeTable.leave_time and vehicle_root.root_id = tbl_timeTable.root_id and tbl_timeTable.date between '" + dateTimePicker_startDate.Value.Date + "' and '" + dateTimePicker_endDate.Value.Date + "' and tbl_timeTable.vehicle_no = '"+cmb_vehicle.Text+"'", con);
                            DataTable dt = new DataTable();
                            sda.Fill(dt);
                            con.Close();
                            dataGridView_report.DataSource = dt;
                        }

                    }
                    else
                    {
                        if (cmb_vehicle.Text == "All")
                        {
                            con.Open();
                            SqlDataAdapter sda = new SqlDataAdapter("select tbl_timeTable.date as Date,tbl_timeTable.leave_point,tbl_timeTable.destination ,vehicle_root.leave_time as Expected,tbl_timeTable.leave_time as Leaved,tbl_timeTable.driver_name,tbl_timeTable.vehicle_no from tbl_timeTable,vehicle_root where vehicle_root.leave_time < tbl_timeTable.leave_time and vehicle_root.root_id = tbl_timeTable.root_id and tbl_timeTable.date between '" + dateTimePicker_startDate.Value.Date + "' and '" + dateTimePicker_endDate.Value.Date + "' and tbl_timeTable.driver_name = '"+cmb_driver.Text+"' ", con);
                            DataTable dt = new DataTable();
                            sda.Fill(dt);
                            con.Close();
                            dataGridView_report.DataSource = dt;
                        }
                        else
                        {
                            con.Open();
                            SqlDataAdapter sda = new SqlDataAdapter("select tbl_timeTable.date as Date,tbl_timeTable.leave_point,tbl_timeTable.destination ,vehicle_root.leave_time as Expected,tbl_timeTable.leave_time as Leaved,tbl_timeTable.driver_name,tbl_timeTable.vehicle_no from tbl_timeTable,vehicle_root where vehicle_root.leave_time < tbl_timeTable.leave_time and vehicle_root.root_id = tbl_timeTable.root_id and tbl_timeTable.date between '" + dateTimePicker_startDate.Value.Date + "' and '" + dateTimePicker_endDate.Value.Date + "' and tbl_timeTable.driver_name = '"+cmb_driver.Text+"' and tbl_timeTable.vehicle_no = '"+cmb_vehicle.Text+"'", con);
                            DataTable dt = new DataTable();
                            sda.Fill(dt);
                            con.Close();
                            dataGridView_report.DataSource = dt;
                        }

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
