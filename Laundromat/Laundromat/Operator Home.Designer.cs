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
            this.pnl_headerOperatorHome = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lbl_opertorTime = new System.Windows.Forms.Label();
            this.timer_operatorTime = new System.Windows.Forms.Timer(this.components);
            this.dgv_operatorOutVehicleNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_operatorOutDriverName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_operatorOutDestination = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_operatorOutTimeOut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_operatorOutTimeIn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_operatorOutDriverNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_operatorOutConfirm = new System.Windows.Forms.DataGridViewButtonColumn();
            this.lbl_time = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewButtonColumn1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.pnl_headerOperatorHome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_headerOperatorHome
            // 
            this.pnl_headerOperatorHome.Controls.Add(this.lbl_time);
            this.pnl_headerOperatorHome.Controls.Add(this.lbl_opertorTime);
            this.pnl_headerOperatorHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_headerOperatorHome.Location = new System.Drawing.Point(0, 0);
            this.pnl_headerOperatorHome.Name = "pnl_headerOperatorHome";
            this.pnl_headerOperatorHome.Size = new System.Drawing.Size(1117, 58);
            this.pnl_headerOperatorHome.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgv_operatorOutVehicleNo,
            this.dgv_operatorOutDriverName,
            this.dgv_operatorOutDestination,
            this.dgv_operatorOutTimeOut,
            this.dgv_operatorOutTimeIn,
            this.dgv_operatorOutDriverNumber,
            this.dgv_operatorOutConfirm});
            this.dataGridView1.Location = new System.Drawing.Point(0, 65);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1117, 380);
            this.dataGridView1.TabIndex = 1;
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
            // timer_operatorTime
            // 
            this.timer_operatorTime.Enabled = true;
            this.timer_operatorTime.Interval = 10;
            this.timer_operatorTime.Tick += new System.EventHandler(this.timer_operatorTime_Tick);
            // 
            // dgv_operatorOutVehicleNo
            // 
            this.dgv_operatorOutVehicleNo.HeaderText = "Vehicle No";
            this.dgv_operatorOutVehicleNo.Name = "dgv_operatorOutVehicleNo";
            // 
            // dgv_operatorOutDriverName
            // 
            this.dgv_operatorOutDriverName.HeaderText = "Driver";
            this.dgv_operatorOutDriverName.Name = "dgv_operatorOutDriverName";
            // 
            // dgv_operatorOutDestination
            // 
            this.dgv_operatorOutDestination.HeaderText = "Destination";
            this.dgv_operatorOutDestination.Name = "dgv_operatorOutDestination";
            // 
            // dgv_operatorOutTimeOut
            // 
            this.dgv_operatorOutTimeOut.HeaderText = "Out Time";
            this.dgv_operatorOutTimeOut.Name = "dgv_operatorOutTimeOut";
            // 
            // dgv_operatorOutTimeIn
            // 
            this.dgv_operatorOutTimeIn.HeaderText = "In Time";
            this.dgv_operatorOutTimeIn.Name = "dgv_operatorOutTimeIn";
            // 
            // dgv_operatorOutDriverNumber
            // 
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
            // lbl_time
            // 
            this.lbl_time.AutoSize = true;
            this.lbl_time.Location = new System.Drawing.Point(490, 19);
            this.lbl_time.Name = "lbl_time";
            this.lbl_time.Size = new System.Drawing.Size(39, 17);
            this.lbl_time.TabIndex = 1;
            this.lbl_time.Text = "Time";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewButtonColumn1});
            this.dataGridView2.Location = new System.Drawing.Point(0, 451);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(1117, 380);
            this.dataGridView2.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Vehicle No";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Driver";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Destination";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Out Time";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "In Time";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Driver Number";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewButtonColumn1
            // 
            this.dataGridViewButtonColumn1.DataPropertyName = "dgv_operatorOutConfirm";
            this.dataGridViewButtonColumn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dataGridViewButtonColumn1.HeaderText = "Confirm";
            this.dataGridViewButtonColumn1.Name = "dataGridViewButtonColumn1";
            this.dataGridViewButtonColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewButtonColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewButtonColumn1.Text = "Confirm";
            this.dataGridViewButtonColumn1.ToolTipText = "Confirm";
            this.dataGridViewButtonColumn1.UseColumnTextForButtonValue = true;
            // 
            // Operator_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1117, 829);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pnl_headerOperatorHome);
            this.Name = "Operator_Home";
            this.Text = "Operator_Home";
            this.pnl_headerOperatorHome.ResumeLayout(false);
            this.pnl_headerOperatorHome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_headerOperatorHome;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbl_opertorTime;
        private System.Windows.Forms.Timer timer_operatorTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_operatorOutVehicleNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_operatorOutDriverName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_operatorOutDestination;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_operatorOutTimeOut;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_operatorOutTimeIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_operatorOutDriverNumber;
        private System.Windows.Forms.DataGridViewButtonColumn dgv_operatorOutConfirm;
        private System.Windows.Forms.Label lbl_time;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn1;
    }
}