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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnl_displayOut = new System.Windows.Forms.Panel();
            this.dgv_outDriverNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_outDriverName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_outInTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_outTimeOut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_outDestination = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_outVehicleNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView_displayOut = new System.Windows.Forms.DataGridView();
            this.pnl_header = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_displayOut)).BeginInit();
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_displayOut.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_displayOut.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_displayOut.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgv_outVehicleNo,
            this.dgv_outDestination,
            this.dgv_outTimeOut,
            this.dgv_outInTime,
            this.dgv_outDriverName,
            this.dgv_outDriverNumber});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_displayOut.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_displayOut.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView_displayOut.EnableHeadersVisualStyles = false;
            this.dataGridView_displayOut.GridColor = System.Drawing.Color.White;
            this.dataGridView_displayOut.Location = new System.Drawing.Point(0, 58);
            this.dataGridView_displayOut.Name = "dataGridView_displayOut";
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
            this.dataGridView_displayOut.Size = new System.Drawing.Size(1104, 291);
            this.dataGridView_displayOut.TabIndex = 0;
            // 
            // pnl_header
            // 
            this.pnl_header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.pnl_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_header.Location = new System.Drawing.Point(0, 0);
            this.pnl_header.Name = "pnl_header";
            this.pnl_header.Size = new System.Drawing.Size(1104, 58);
            this.pnl_header.TabIndex = 0;
            // 
            // frm_display
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1104, 620);
            this.Controls.Add(this.dataGridView_displayOut);
            this.Controls.Add(this.pnl_displayOut);
            this.Controls.Add(this.pnl_header);
            this.Name = "frm_display";
            this.Text = "LOMDROMAT";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_displayOut)).EndInit();
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
        private System.Windows.Forms.Panel pnl_header;
    }
}

