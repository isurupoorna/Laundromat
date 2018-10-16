namespace Laundromat
{
    partial class uc_editRoot
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dgv_editRootOutTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_editRootInTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_editRootStartPoint = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_editRootEndPoint = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_editRootVehicle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_editRootDriver = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgv_editRootOutTime,
            this.dgv_editRootInTime,
            this.dgv_editRootStartPoint,
            this.dgv_editRootEndPoint,
            this.dgv_editRootVehicle,
            this.dgv_editRootDriver});
            this.dataGridView1.Location = new System.Drawing.Point(12, 152);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(837, 318);
            this.dataGridView1.TabIndex = 0;
            // 
            // dgv_editRootOutTime
            // 
            this.dgv_editRootOutTime.HeaderText = "Out Time";
            this.dgv_editRootOutTime.Name = "dgv_editRootOutTime";
            this.dgv_editRootOutTime.ReadOnly = true;
            // 
            // dgv_editRootInTime
            // 
            this.dgv_editRootInTime.HeaderText = "In Time";
            this.dgv_editRootInTime.Name = "dgv_editRootInTime";
            this.dgv_editRootInTime.ReadOnly = true;
            // 
            // dgv_editRootStartPoint
            // 
            this.dgv_editRootStartPoint.HeaderText = "Starting Point";
            this.dgv_editRootStartPoint.Name = "dgv_editRootStartPoint";
            this.dgv_editRootStartPoint.ReadOnly = true;
            // 
            // dgv_editRootEndPoint
            // 
            this.dgv_editRootEndPoint.HeaderText = "Destination";
            this.dgv_editRootEndPoint.Name = "dgv_editRootEndPoint";
            this.dgv_editRootEndPoint.ReadOnly = true;
            // 
            // dgv_editRootVehicle
            // 
            this.dgv_editRootVehicle.HeaderText = "Vehicle";
            this.dgv_editRootVehicle.Name = "dgv_editRootVehicle";
            this.dgv_editRootVehicle.ReadOnly = true;
            // 
            // dgv_editRootDriver
            // 
            this.dgv_editRootDriver.HeaderText = "Driver";
            this.dgv_editRootDriver.Name = "dgv_editRootDriver";
            this.dgv_editRootDriver.ReadOnly = true;
            // 
            // uc_editRoot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Name = "uc_editRoot";
            this.Size = new System.Drawing.Size(908, 568);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_editRootOutTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_editRootInTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_editRootStartPoint;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_editRootEndPoint;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_editRootVehicle;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_editRootDriver;
    }
}
