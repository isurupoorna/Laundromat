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
            this.pnl_headerOperatorHome = new System.Windows.Forms.Panel();
            this.lbl_time = new System.Windows.Forms.Label();
            this.lbl_opertorTime = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.timer_operatorTime = new System.Windows.Forms.Timer(this.components);
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewButtonColumn1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv_operatorOutVehicleNo = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dgv_operatorOutDriverName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_operatorOutDestination = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_operatorOutTimeOut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_operatorOutTimeIn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_operatorOutDriverNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_operatorOutConfirm = new System.Windows.Forms.DataGridViewButtonColumn();
            this.pnl_headerOperatorHome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_headerOperatorHome
            // 
            this.pnl_headerOperatorHome.BackColor = System.Drawing.Color.Navy;
            this.pnl_headerOperatorHome.Controls.Add(this.label1);
            this.pnl_headerOperatorHome.Controls.Add(this.lbl_time);
            this.pnl_headerOperatorHome.Controls.Add(this.lbl_opertorTime);
            this.pnl_headerOperatorHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_headerOperatorHome.Location = new System.Drawing.Point(0, 0);
            this.pnl_headerOperatorHome.Name = "pnl_headerOperatorHome";
            this.pnl_headerOperatorHome.Size = new System.Drawing.Size(1650, 58);
            this.pnl_headerOperatorHome.TabIndex = 0;
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
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgv_operatorOutVehicleNo,
            this.dgv_operatorOutDriverName,
            this.dgv_operatorOutDestination,
            this.dgv_operatorOutTimeOut,
            this.dgv_operatorOutTimeIn,
            this.dgv_operatorOutDriverNumber,
            this.dgv_operatorOutConfirm});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 58);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1650, 436);
            this.dataGridView1.TabIndex = 1;
            // 
            // timer_operatorTime
            // 
            this.timer_operatorTime.Enabled = true;
            this.timer_operatorTime.Interval = 10;
            this.timer_operatorTime.Tick += new System.EventHandler(this.timer_operatorTime_Tick);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewButtonColumn1});
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView2.Location = new System.Drawing.Point(0, 620);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(1650, 435);
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Vivaldi", 8.25F);
            this.panel1.Location = new System.Drawing.Point(0, 494);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1650, 126);
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
            // Operator_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1650, 1055);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pnl_headerOperatorHome);
            this.Name = "Operator_Home";
            this.Text = "Operator_Home";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnl_headerOperatorHome.ResumeLayout(false);
            this.pnl_headerOperatorHome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_headerOperatorHome;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbl_opertorTime;
        private System.Windows.Forms.Timer timer_operatorTime;
        private System.Windows.Forms.Label lbl_time;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewComboBoxColumn dgv_operatorOutVehicleNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_operatorOutDriverName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_operatorOutDestination;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_operatorOutTimeOut;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_operatorOutTimeIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_operatorOutDriverNumber;
        private System.Windows.Forms.DataGridViewButtonColumn dgv_operatorOutConfirm;
    }
}