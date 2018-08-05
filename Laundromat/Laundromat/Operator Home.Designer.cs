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
            this.pnl_headerOperatorHome = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dgv_operatorOutVehicleNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_headerOperatorHome
            // 
            this.pnl_headerOperatorHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_headerOperatorHome.Location = new System.Drawing.Point(0, 0);
            this.pnl_headerOperatorHome.Name = "pnl_headerOperatorHome";
            this.pnl_headerOperatorHome.Size = new System.Drawing.Size(1117, 58);
            this.pnl_headerOperatorHome.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgv_operatorOutVehicleNo});
            this.dataGridView1.Location = new System.Drawing.Point(0, 65);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1117, 387);
            this.dataGridView1.TabIndex = 1;
            // 
            // dgv_operatorOutVehicleNo
            // 
            this.dgv_operatorOutVehicleNo.HeaderText = "Vehicle No";
            this.dgv_operatorOutVehicleNo.Name = "dgv_operatorOutVehicleNo";
            // 
            // Operator_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1117, 829);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pnl_headerOperatorHome);
            this.Name = "Operator_Home";
            this.Text = "Operator_Home";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_headerOperatorHome;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_operatorOutVehicleNo;
    }
}