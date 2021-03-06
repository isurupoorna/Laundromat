﻿namespace Laundromat
{
    partial class frm_display
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_display));
            this.pnl_displayOut = new System.Windows.Forms.Panel();
            this.dataGridView_displayOut = new System.Windows.Forms.DataGridView();
            this.dgv_outVehicleNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_outDriverName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_outDestination = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_outGroupLeaveTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_outTimeOut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_outInTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_outDriverNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnl_headerTimeTable = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_time = new System.Windows.Forms.Label();
            this.lbl_timeTableTime = new System.Windows.Forms.Label();
            this.dataGridView_displayIn = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_inGroupArrivalTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timer_timeTableSystemTime = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.timer_timeTable = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_displayOut)).BeginInit();
            this.pnl_headerTimeTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_displayIn)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_displayOut
            // 
            this.pnl_displayOut.AutoSize = true;
            this.pnl_displayOut.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_displayOut.Location = new System.Drawing.Point(0, 89);
            this.pnl_displayOut.Name = "pnl_displayOut";
            this.pnl_displayOut.Size = new System.Drawing.Size(1104, 0);
            this.pnl_displayOut.TabIndex = 1;
            // 
            // dataGridView_displayOut
            // 
            this.dataGridView_displayOut.AccessibleDescription = "";
            this.dataGridView_displayOut.AccessibleName = "";
            this.dataGridView_displayOut.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_displayOut.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_displayOut.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView_displayOut.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_displayOut.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView_displayOut.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView_displayOut.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_displayOut.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_displayOut.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_displayOut.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgv_outVehicleNo,
            this.dgv_outDriverName,
            this.dgv_outDestination,
            this.dgv_outGroupLeaveTime,
            this.dgv_outTimeOut,
            this.dgv_outInTime,
            this.dgv_outDriverNumber});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_displayOut.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_displayOut.EnableHeadersVisualStyles = false;
            this.dataGridView_displayOut.GridColor = System.Drawing.Color.White;
            this.dataGridView_displayOut.Location = new System.Drawing.Point(0, 89);
            this.dataGridView_displayOut.Name = "dataGridView_displayOut";
            this.dataGridView_displayOut.ReadOnly = true;
            this.dataGridView_displayOut.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_displayOut.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView_displayOut.RowHeadersVisible = false;
            this.dataGridView_displayOut.RowTemplate.Height = 24;
            this.dataGridView_displayOut.Size = new System.Drawing.Size(1104, 332);
            this.dataGridView_displayOut.TabIndex = 0;
            this.dataGridView_displayOut.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_displayOut_CellContentClick);
            // 
            // dgv_outVehicleNo
            // 
            this.dgv_outVehicleNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgv_outVehicleNo.DataPropertyName = "vehicle_no";
            this.dgv_outVehicleNo.HeaderText = "Vehicle No";
            this.dgv_outVehicleNo.Name = "dgv_outVehicleNo";
            this.dgv_outVehicleNo.ReadOnly = true;
            // 
            // dgv_outDriverName
            // 
            this.dgv_outDriverName.DataPropertyName = "driver_name";
            this.dgv_outDriverName.HeaderText = "Driver Name";
            this.dgv_outDriverName.Name = "dgv_outDriverName";
            this.dgv_outDriverName.ReadOnly = true;
            // 
            // dgv_outDestination
            // 
            this.dgv_outDestination.DataPropertyName = "destination";
            this.dgv_outDestination.HeaderText = "Destination";
            this.dgv_outDestination.Name = "dgv_outDestination";
            this.dgv_outDestination.ReadOnly = true;
            // 
            // dgv_outGroupLeaveTime
            // 
            this.dgv_outGroupLeaveTime.DataPropertyName = "gLeave_time";
            this.dgv_outGroupLeaveTime.HeaderText = "Lmat Leave Time";
            this.dgv_outGroupLeaveTime.Name = "dgv_outGroupLeaveTime";
            this.dgv_outGroupLeaveTime.ReadOnly = true;
            // 
            // dgv_outTimeOut
            // 
            this.dgv_outTimeOut.DataPropertyName = "leave_time";
            this.dgv_outTimeOut.HeaderText = "Expected Time";
            this.dgv_outTimeOut.Name = "dgv_outTimeOut";
            this.dgv_outTimeOut.ReadOnly = true;
            // 
            // dgv_outInTime
            // 
            this.dgv_outInTime.DataPropertyName = "arrive_time";
            this.dgv_outInTime.HeaderText = "In Time";
            this.dgv_outInTime.Name = "dgv_outInTime";
            this.dgv_outInTime.ReadOnly = true;
            // 
            // dgv_outDriverNumber
            // 
            this.dgv_outDriverNumber.DataPropertyName = "driver_contact";
            this.dgv_outDriverNumber.HeaderText = "Driver Number";
            this.dgv_outDriverNumber.Name = "dgv_outDriverNumber";
            this.dgv_outDriverNumber.ReadOnly = true;
            // 
            // pnl_headerTimeTable
            // 
            this.pnl_headerTimeTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.pnl_headerTimeTable.Controls.Add(this.label2);
            this.pnl_headerTimeTable.Controls.Add(this.lbl_time);
            this.pnl_headerTimeTable.Controls.Add(this.lbl_timeTableTime);
            this.pnl_headerTimeTable.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_headerTimeTable.Location = new System.Drawing.Point(0, 0);
            this.pnl_headerTimeTable.Name = "pnl_headerTimeTable";
            this.pnl_headerTimeTable.Size = new System.Drawing.Size(1104, 89);
            this.pnl_headerTimeTable.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(79, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(239, 55);
            this.label2.TabIndex = 0;
            this.label2.Text = "Departure";
            // 
            // lbl_time
            // 
            this.lbl_time.AutoSize = true;
            this.lbl_time.BackColor = System.Drawing.Color.Transparent;
            this.lbl_time.Font = new System.Drawing.Font("Arial Narrow", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_time.ForeColor = System.Drawing.Color.Yellow;
            this.lbl_time.Location = new System.Drawing.Point(852, 17);
            this.lbl_time.Name = "lbl_time";
            this.lbl_time.Size = new System.Drawing.Size(106, 52);
            this.lbl_time.TabIndex = 1;
            this.lbl_time.Text = "Time";
            // 
            // lbl_timeTableTime
            // 
            this.lbl_timeTableTime.AutoSize = true;
            this.lbl_timeTableTime.Location = new System.Drawing.Point(501, 17);
            this.lbl_timeTableTime.Name = "lbl_timeTableTime";
            this.lbl_timeTableTime.Size = new System.Drawing.Size(0, 17);
            this.lbl_timeTableTime.TabIndex = 0;
            // 
            // dataGridView_displayIn
            // 
            this.dataGridView_displayIn.AccessibleDescription = "";
            this.dataGridView_displayIn.AccessibleName = "";
            this.dataGridView_displayIn.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_displayIn.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView_displayIn.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_displayIn.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView_displayIn.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView_displayIn.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_displayIn.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView_displayIn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_displayIn.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dgv_inGroupArrivalTime,
            this.dataGridViewTextBoxColumn6});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_displayIn.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView_displayIn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView_displayIn.EnableHeadersVisualStyles = false;
            this.dataGridView_displayIn.GridColor = System.Drawing.Color.White;
            this.dataGridView_displayIn.Location = new System.Drawing.Point(0, 486);
            this.dataGridView_displayIn.Name = "dataGridView_displayIn";
            this.dataGridView_displayIn.ReadOnly = true;
            this.dataGridView_displayIn.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_displayIn.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView_displayIn.RowHeadersVisible = false;
            this.dataGridView_displayIn.RowTemplate.Height = 24;
            this.dataGridView_displayIn.Size = new System.Drawing.Size(1104, 389);
            this.dataGridView_displayIn.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "vehicle_no";
            this.dataGridViewTextBoxColumn1.HeaderText = "Vehicle No";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "driver_name";
            this.dataGridViewTextBoxColumn5.HeaderText = "Driver Name";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "destination";
            this.dataGridViewTextBoxColumn2.HeaderText = "Destination";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "leave_time";
            this.dataGridViewTextBoxColumn3.HeaderText = "Left Time";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dgv_inGroupArrivalTime
            // 
            this.dgv_inGroupArrivalTime.DataPropertyName = "gArrival_time";
            this.dgv_inGroupArrivalTime.HeaderText = "Arrival Time";
            this.dgv_inGroupArrivalTime.Name = "dgv_inGroupArrivalTime";
            this.dgv_inGroupArrivalTime.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "driver_contact";
            this.dataGridViewTextBoxColumn6.HeaderText = "Driver Number";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // timer_timeTableSystemTime
            // 
            this.timer_timeTableSystemTime.Enabled = true;
            this.timer_timeTableSystemTime.Interval = 10;
            this.timer_timeTableSystemTime.Tick += new System.EventHandler(this.timer_timeTableSystemTime_Tick);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 412);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1104, 84);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(79, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Arrivel";
            // 
            // timer_timeTable
            // 
            this.timer_timeTable.Enabled = true;
            this.timer_timeTable.Interval = 20000;
            this.timer_timeTable.Tick += new System.EventHandler(this.timer_timeTable_Tick);
            // 
            // frm_display
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1104, 875);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView_displayIn);
            this.Controls.Add(this.dataGridView_displayOut);
            this.Controls.Add(this.pnl_displayOut);
            this.Controls.Add(this.pnl_headerTimeTable);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_display";
            this.Text = "LOMDROMAT";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_display_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_displayOut)).EndInit();
            this.pnl_headerTimeTable.ResumeLayout(false);
            this.pnl_headerTimeTable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_displayIn)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnl_displayOut;
        private System.Windows.Forms.DataGridView dataGridView_displayOut;
        private System.Windows.Forms.Panel pnl_headerTimeTable;
        private System.Windows.Forms.DataGridView dataGridView_displayIn;
        private System.Windows.Forms.Label lbl_timeTableTime;
        private System.Windows.Forms.Timer timer_timeTableSystemTime;
        private System.Windows.Forms.Label lbl_time;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer_timeTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_outVehicleNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_outDriverName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_outDestination;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_outGroupLeaveTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_outTimeOut;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_outInTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_outDriverNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_inGroupArrivalTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}

