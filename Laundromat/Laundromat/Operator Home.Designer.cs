namespace Laundromat
{
    partial class Operator_Home
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
            this.pnl_headerOperatorHome = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_time = new System.Windows.Forms.Label();
            this.lbl_opertorTime = new System.Windows.Forms.Label();
            this.dataGridView_operatorOut = new System.Windows.Forms.DataGridView();
            this.dgv_operatorOutRoot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_operatorOutVehicleNo = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dgv_operatorOutDriverName = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dgv_operatorOutDestination = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_operatorOutTimeOut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_operatorOutTimeIn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_operatorOutDriverNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_operatorOutConfirm = new System.Windows.Forms.DataGridViewButtonColumn();
            this.timer_operatorTime = new System.Windows.Forms.Timer(this.components);
            this.dataGridView_operatorIn = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_operatorInConfirm = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.timer_operatorTimeTable = new System.Windows.Forms.Timer(this.components);
            this.timer_sound = new System.Windows.Forms.Timer(this.components);
            this.pnl_headerOperatorHome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_operatorOut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_operatorIn)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_headerOperatorHome
            // 
            this.pnl_headerOperatorHome.BackColor = System.Drawing.Color.Navy;
            this.pnl_headerOperatorHome.Controls.Add(this.label3);
            this.pnl_headerOperatorHome.Controls.Add(this.label1);
            this.pnl_headerOperatorHome.Controls.Add(this.lbl_time);
            this.pnl_headerOperatorHome.Controls.Add(this.lbl_opertorTime);
            this.pnl_headerOperatorHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_headerOperatorHome.Location = new System.Drawing.Point(0, 0);
            this.pnl_headerOperatorHome.Name = "pnl_headerOperatorHome";
            this.pnl_headerOperatorHome.Size = new System.Drawing.Size(1604, 58);
            this.pnl_headerOperatorHome.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(553, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "label3";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(25, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Out Deliveries";
            // 
            // lbl_time
            // 
            this.lbl_time.AutoSize = true;
            this.lbl_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_time.ForeColor = System.Drawing.Color.White;
            this.lbl_time.Location = new System.Drawing.Point(993, 19);
            this.lbl_time.Name = "lbl_time";
            this.lbl_time.Size = new System.Drawing.Size(82, 32);
            this.lbl_time.TabIndex = 1;
            this.lbl_time.Text = "Time";
            // 
            // lbl_opertorTime
            // 
            this.lbl_opertorTime.AutoSize = true;
            this.lbl_opertorTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_opertorTime.Location = new System.Drawing.Point(428, 9);
            this.lbl_opertorTime.Name = "lbl_opertorTime";
            this.lbl_opertorTime.Size = new System.Drawing.Size(0, 29);
            this.lbl_opertorTime.TabIndex = 0;
            // 
            // dataGridView_operatorOut
            // 
            this.dataGridView_operatorOut.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_operatorOut.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_operatorOut.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_operatorOut.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_operatorOut.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgv_operatorOutRoot,
            this.dgv_operatorOutVehicleNo,
            this.dgv_operatorOutDriverName,
            this.dgv_operatorOutDestination,
            this.dgv_operatorOutTimeOut,
            this.dgv_operatorOutTimeIn,
            this.dgv_operatorOutDriverNumber,
            this.dgv_operatorOutConfirm});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_operatorOut.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_operatorOut.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView_operatorOut.Location = new System.Drawing.Point(0, 58);
            this.dataGridView_operatorOut.Name = "dataGridView_operatorOut";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_operatorOut.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView_operatorOut.RowHeadersVisible = false;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView_operatorOut.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView_operatorOut.RowTemplate.Height = 24;
            this.dataGridView_operatorOut.Size = new System.Drawing.Size(1604, 473);
            this.dataGridView_operatorOut.TabIndex = 1;
            this.dataGridView_operatorOut.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_operatorOut_CellContentClick);
            this.dataGridView_operatorOut.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dataGridView_operatorOut_EditingControlShowing);
            // 
            // dgv_operatorOutRoot
            // 
            this.dgv_operatorOutRoot.DataPropertyName = "root_id";
            this.dgv_operatorOutRoot.HeaderText = "Root Number";
            this.dgv_operatorOutRoot.Name = "dgv_operatorOutRoot";
            // 
            // dgv_operatorOutVehicleNo
            // 
            this.dgv_operatorOutVehicleNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dgv_operatorOutVehicleNo.HeaderText = "Vehicle No";
            this.dgv_operatorOutVehicleNo.Name = "dgv_operatorOutVehicleNo";
            this.dgv_operatorOutVehicleNo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_operatorOutVehicleNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dgv_operatorOutDriverName
            // 
            this.dgv_operatorOutDriverName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dgv_operatorOutDriverName.HeaderText = "Driver";
            this.dgv_operatorOutDriverName.Name = "dgv_operatorOutDriverName";
            this.dgv_operatorOutDriverName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_operatorOutDriverName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dgv_operatorOutDestination
            // 
            this.dgv_operatorOutDestination.DataPropertyName = "destination";
            this.dgv_operatorOutDestination.HeaderText = "Destination";
            this.dgv_operatorOutDestination.Name = "dgv_operatorOutDestination";
            // 
            // dgv_operatorOutTimeOut
            // 
            this.dgv_operatorOutTimeOut.DataPropertyName = "leave_time";
            this.dgv_operatorOutTimeOut.HeaderText = "Out Time";
            this.dgv_operatorOutTimeOut.Name = "dgv_operatorOutTimeOut";
            // 
            // dgv_operatorOutTimeIn
            // 
            this.dgv_operatorOutTimeIn.DataPropertyName = "arrive_time";
            this.dgv_operatorOutTimeIn.HeaderText = "In Time";
            this.dgv_operatorOutTimeIn.Name = "dgv_operatorOutTimeIn";
            // 
            // dgv_operatorOutDriverNumber
            // 
            this.dgv_operatorOutDriverNumber.DataPropertyName = "driver_contact";
            this.dgv_operatorOutDriverNumber.HeaderText = "Driver Number";
            this.dgv_operatorOutDriverNumber.Name = "dgv_operatorOutDriverNumber";
            // 
            // dgv_operatorOutConfirm
            // 
            this.dgv_operatorOutConfirm.DataPropertyName = "dgv_operatorOutConfirm";
            this.dgv_operatorOutConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dgv_operatorOutConfirm.HeaderText = "Confirm";
            this.dgv_operatorOutConfirm.Name = "dgv_operatorOutConfirm";
            this.dgv_operatorOutConfirm.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_operatorOutConfirm.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dgv_operatorOutConfirm.Text = "Confirm";
            this.dgv_operatorOutConfirm.ToolTipText = "Confirm";
            this.dgv_operatorOutConfirm.UseColumnTextForButtonValue = true;
            // 
            // timer_operatorTime
            // 
            this.timer_operatorTime.Enabled = true;
            this.timer_operatorTime.Interval = 10;
            this.timer_operatorTime.Tick += new System.EventHandler(this.timer_operatorTime_Tick);
            // 
            // dataGridView_operatorIn
            // 
            this.dataGridView_operatorIn.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_operatorIn.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView_operatorIn.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_operatorIn.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView_operatorIn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_operatorIn.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dgv_operatorInConfirm});
            this.dataGridView_operatorIn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView_operatorIn.Location = new System.Drawing.Point(0, 514);
            this.dataGridView_operatorIn.Name = "dataGridView_operatorIn";
            this.dataGridView_operatorIn.RowHeadersVisible = false;
            this.dataGridView_operatorIn.RowTemplate.Height = 24;
            this.dataGridView_operatorIn.Size = new System.Drawing.Size(1604, 361);
            this.dataGridView_operatorIn.TabIndex = 1;
            this.dataGridView_operatorIn.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_operatorIn_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "root_id";
            this.Column1.HeaderText = "Root Number";
            this.Column1.Name = "Column1";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "vehicle_no";
            this.dataGridViewTextBoxColumn1.HeaderText = "Vehicle No";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "driver_name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Driver";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "destination";
            this.dataGridViewTextBoxColumn3.HeaderText = "Destination";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "leave_time";
            this.dataGridViewTextBoxColumn4.HeaderText = "Out Time";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "arrive_time";
            this.dataGridViewTextBoxColumn5.HeaderText = "In Time";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "driver_contact";
            this.dataGridViewTextBoxColumn6.HeaderText = "Driver Number";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dgv_operatorInConfirm
            // 
            this.dgv_operatorInConfirm.DataPropertyName = "dgv_operatorInConfirm";
            this.dgv_operatorInConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dgv_operatorInConfirm.HeaderText = "Confirm";
            this.dgv_operatorInConfirm.Name = "dgv_operatorInConfirm";
            this.dgv_operatorInConfirm.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_operatorInConfirm.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dgv_operatorInConfirm.Text = "Confirm";
            this.dgv_operatorInConfirm.ToolTipText = "Confirm";
            this.dgv_operatorInConfirm.UseColumnTextForButtonValue = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Vivaldi", 8.25F);
            this.panel1.Location = new System.Drawing.Point(0, 531);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1604, 0);
            this.panel1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(25, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "In Deleveries";
            // 
            // timer_operatorTimeTable
            // 
            this.timer_operatorTimeTable.Enabled = true;
            this.timer_operatorTimeTable.Interval = 1000;
            this.timer_operatorTimeTable.Tick += new System.EventHandler(this.timer_operatorTimeTable_Tick);
            // 
            // timer_sound
            // 
            this.timer_sound.Enabled = true;
            this.timer_sound.Interval = 1000;
            this.timer_sound.Tick += new System.EventHandler(this.timer_sound_Tick);
            // 
            // Operator_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1604, 875);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView_operatorIn);
            this.Controls.Add(this.dataGridView_operatorOut);
            this.Controls.Add(this.pnl_headerOperatorHome);
            this.Name = "Operator_Home";
            this.Text = "Operator_Home";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Operator_Home_Load);
            this.pnl_headerOperatorHome.ResumeLayout(false);
            this.pnl_headerOperatorHome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_operatorOut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_operatorIn)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_headerOperatorHome;
        private System.Windows.Forms.DataGridView dataGridView_operatorOut;
        private System.Windows.Forms.Label lbl_opertorTime;
        private System.Windows.Forms.Timer timer_operatorTime;
        private System.Windows.Forms.Label lbl_time;
        private System.Windows.Forms.DataGridView dataGridView_operatorIn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer_operatorTimeTable;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_operatorOutRoot;
        private System.Windows.Forms.DataGridViewComboBoxColumn dgv_operatorOutVehicleNo;
        private System.Windows.Forms.DataGridViewComboBoxColumn dgv_operatorOutDriverName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_operatorOutDestination;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_operatorOutTimeOut;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_operatorOutTimeIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_operatorOutDriverNumber;
        private System.Windows.Forms.DataGridViewButtonColumn dgv_operatorOutConfirm;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewButtonColumn dgv_operatorInConfirm;
        private System.Windows.Forms.Timer timer_sound;
    }
}