namespace Laundromat
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnl_displayOut = new System.Windows.Forms.Panel();
            this.dgv_outDriverNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_outDriverName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_outInTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_outTimeOut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_outDestination = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_outVehicleNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView_displayOut = new System.Windows.Forms.DataGridView();
            this.pnl_headerTimeTable = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_timeTableTime = new System.Windows.Forms.Label();
            this.timer_timeTableSystemTime = new System.Windows.Forms.Timer(this.components);
            this.lbl_time = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_displayOut)).BeginInit();
            this.pnl_headerTimeTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_displayOut
            // 
            this.pnl_displayOut.AutoSize = true;
            this.pnl_displayOut.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_displayOut.Location = new System.Drawing.Point(0, 58);
            this.pnl_displayOut.Name = "pnl_displayOut";
            this.pnl_displayOut.Size = new System.Drawing.Size(1104, 0);
            this.pnl_displayOut.TabIndex = 1;
            // 
            // dgv_outDriverNumber
            // 
            this.dgv_outDriverNumber.HeaderText = "Driver Number";
            this.dgv_outDriverNumber.Name = "dgv_outDriverNumber";
            // 
            // dgv_outDriverName
            // 
            this.dgv_outDriverName.HeaderText = "Driver Name";
            this.dgv_outDriverName.Name = "dgv_outDriverName";
            // 
            // dgv_outInTime
            // 
            this.dgv_outInTime.HeaderText = "In Time";
            this.dgv_outInTime.Name = "dgv_outInTime";
            // 
            // dgv_outTimeOut
            // 
            this.dgv_outTimeOut.HeaderText = "Out Time";
            this.dgv_outTimeOut.Name = "dgv_outTimeOut";
            // 
            // dgv_outDestination
            // 
            this.dgv_outDestination.HeaderText = "Destination";
            this.dgv_outDestination.Name = "dgv_outDestination";
            // 
            // dgv_outVehicleNo
            // 
            this.dgv_outVehicleNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgv_outVehicleNo.HeaderText = "Vehicle No";
            this.dgv_outVehicleNo.Name = "dgv_outVehicleNo";
            // 
            // dataGridView_displayOut
            // 
            this.dataGridView_displayOut.AccessibleDescription = "";
            this.dataGridView_displayOut.AccessibleName = "";
            this.dataGridView_displayOut.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_displayOut.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView_displayOut.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_displayOut.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView_displayOut.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView_displayOut.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle25.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle25.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle25.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle25.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle25.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle25.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_displayOut.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle25;
            this.dataGridView_displayOut.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_displayOut.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgv_outVehicleNo,
            this.dgv_outDestination,
            this.dgv_outTimeOut,
            this.dgv_outInTime,
            this.dgv_outDriverName,
            this.dgv_outDriverNumber});
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle26.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle26.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle26.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle26.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle26.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_displayOut.DefaultCellStyle = dataGridViewCellStyle26;
            this.dataGridView_displayOut.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView_displayOut.EnableHeadersVisualStyles = false;
            this.dataGridView_displayOut.GridColor = System.Drawing.Color.White;
            this.dataGridView_displayOut.Location = new System.Drawing.Point(0, 58);
            this.dataGridView_displayOut.Name = "dataGridView_displayOut";
            this.dataGridView_displayOut.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle27.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle27.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_displayOut.RowHeadersDefaultCellStyle = dataGridViewCellStyle27;
            this.dataGridView_displayOut.RowHeadersVisible = false;
            this.dataGridView_displayOut.RowTemplate.Height = 24;
            this.dataGridView_displayOut.Size = new System.Drawing.Size(1104, 467);
            this.dataGridView_displayOut.TabIndex = 0;
            // 
            // pnl_headerTimeTable
            // 
            this.pnl_headerTimeTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.pnl_headerTimeTable.Controls.Add(this.lbl_time);
            this.pnl_headerTimeTable.Controls.Add(this.lbl_timeTableTime);
            this.pnl_headerTimeTable.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_headerTimeTable.Location = new System.Drawing.Point(0, 0);
            this.pnl_headerTimeTable.Name = "pnl_headerTimeTable";
            this.pnl_headerTimeTable.Size = new System.Drawing.Size(1104, 58);
            this.pnl_headerTimeTable.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AccessibleDescription = "";
            this.dataGridView1.AccessibleName = "";
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle28.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle28.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle28.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle28.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle28.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle28.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle28;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle29.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle29.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle29.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle29.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle29.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle29.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle29;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(0, 519);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle30.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle30.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle30.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle30.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle30.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle30.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle30;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1104, 411);
            this.dataGridView1.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.HeaderText = "Vehicle No";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Destination";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Out Time";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "In Time";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Driver Name";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Driver Number";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // lbl_timeTableTime
            // 
            this.lbl_timeTableTime.AutoSize = true;
            this.lbl_timeTableTime.Location = new System.Drawing.Point(501, 17);
            this.lbl_timeTableTime.Name = "lbl_timeTableTime";
            this.lbl_timeTableTime.Size = new System.Drawing.Size(0, 17);
            this.lbl_timeTableTime.TabIndex = 0;
            // 
            // timer_timeTableSystemTime
            // 
            this.timer_timeTableSystemTime.Enabled = true;
            this.timer_timeTableSystemTime.Interval = 10;
            this.timer_timeTableSystemTime.Tick += new System.EventHandler(this.timer_timeTableSystemTime_Tick);
            // 
            // lbl_time
            // 
            this.lbl_time.AutoSize = true;
            this.lbl_time.BackColor = System.Drawing.Color.Transparent;
            this.lbl_time.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_time.ForeColor = System.Drawing.Color.Yellow;
            this.lbl_time.Location = new System.Drawing.Point(828, 17);
            this.lbl_time.Name = "lbl_time";
            this.lbl_time.Size = new System.Drawing.Size(59, 29);
            this.lbl_time.TabIndex = 1;
            this.lbl_time.Text = "Time";
            // 
            // frm_display
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1104, 930);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dataGridView_displayOut);
            this.Controls.Add(this.pnl_displayOut);
            this.Controls.Add(this.pnl_headerTimeTable);
            this.Name = "frm_display";
            this.Text = "LOMDROMAT";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_display_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_displayOut)).EndInit();
            this.pnl_headerTimeTable.ResumeLayout(false);
            this.pnl_headerTimeTable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnl_displayOut;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_outDriverNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_outDriverName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_outInTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_outTimeOut;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_outDestination;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_outVehicleNo;
        private System.Windows.Forms.DataGridView dataGridView_displayOut;
        private System.Windows.Forms.Panel pnl_headerTimeTable;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Label lbl_timeTableTime;
        private System.Windows.Forms.Timer timer_timeTableSystemTime;
        private System.Windows.Forms.Label lbl_time;
    }
}

