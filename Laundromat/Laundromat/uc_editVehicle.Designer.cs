namespace Laundromat
{
    partial class uc_editVehicle
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_vehicleNumber = new System.Windows.Forms.TextBox();
            this.dataGridView_vehicle = new System.Windows.Forms.DataGridView();
            this.cmb_driverName = new System.Windows.Forms.ComboBox();
            this.btn_delVehicle = new System.Windows.Forms.Button();
            this.btn_addVehicle = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_vehicle)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(58, 208);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Driver Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(58, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Vehicle Number";
            // 
            // txt_vehicleNumber
            // 
            this.txt_vehicleNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_vehicleNumber.Location = new System.Drawing.Point(237, 118);
            this.txt_vehicleNumber.Name = "txt_vehicleNumber";
            this.txt_vehicleNumber.Size = new System.Drawing.Size(163, 28);
            this.txt_vehicleNumber.TabIndex = 3;
            // 
            // dataGridView_vehicle
            // 
            this.dataGridView_vehicle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_vehicle.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_vehicle.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView_vehicle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_vehicle.Location = new System.Drawing.Point(467, 118);
            this.dataGridView_vehicle.Name = "dataGridView_vehicle";
            this.dataGridView_vehicle.RowTemplate.Height = 24;
            this.dataGridView_vehicle.Size = new System.Drawing.Size(695, 535);
            this.dataGridView_vehicle.TabIndex = 4;
            this.dataGridView_vehicle.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_vehicle_CellClick);
            // 
            // cmb_driverName
            // 
            this.cmb_driverName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_driverName.FormattingEnabled = true;
            this.cmb_driverName.Location = new System.Drawing.Point(237, 208);
            this.cmb_driverName.Name = "cmb_driverName";
            this.cmb_driverName.Size = new System.Drawing.Size(163, 33);
            this.cmb_driverName.TabIndex = 5;
            // 
            // btn_delVehicle
            // 
            this.btn_delVehicle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delVehicle.ForeColor = System.Drawing.Color.Blue;
            this.btn_delVehicle.Location = new System.Drawing.Point(312, 386);
            this.btn_delVehicle.Name = "btn_delVehicle";
            this.btn_delVehicle.Size = new System.Drawing.Size(106, 44);
            this.btn_delVehicle.TabIndex = 6;
            this.btn_delVehicle.Text = "Delete";
            this.btn_delVehicle.UseVisualStyleBackColor = true;
            this.btn_delVehicle.Click += new System.EventHandler(this.btn_delVehicle_Click);
            // 
            // btn_addVehicle
            // 
            this.btn_addVehicle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addVehicle.ForeColor = System.Drawing.Color.Blue;
            this.btn_addVehicle.Location = new System.Drawing.Point(38, 386);
            this.btn_addVehicle.Name = "btn_addVehicle";
            this.btn_addVehicle.Size = new System.Drawing.Size(114, 44);
            this.btn_addVehicle.TabIndex = 7;
            this.btn_addVehicle.Text = "Add";
            this.btn_addVehicle.UseVisualStyleBackColor = true;
            this.btn_addVehicle.Click += new System.EventHandler(this.btn_addVehicle_Click);
            // 
            // btn_update
            // 
            this.btn_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.ForeColor = System.Drawing.Color.Blue;
            this.btn_update.Location = new System.Drawing.Point(174, 386);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(114, 44);
            this.btn_update.TabIndex = 8;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // uc_editVehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_addVehicle);
            this.Controls.Add(this.btn_delVehicle);
            this.Controls.Add(this.cmb_driverName);
            this.Controls.Add(this.dataGridView_vehicle);
            this.Controls.Add(this.txt_vehicleNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "uc_editVehicle";
            this.Size = new System.Drawing.Size(1175, 723);
            this.Load += new System.EventHandler(this.uc_editVehicle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_vehicle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_vehicleNumber;
        private System.Windows.Forms.DataGridView dataGridView_vehicle;
        private System.Windows.Forms.ComboBox cmb_driverName;
        private System.Windows.Forms.Button btn_delVehicle;
        private System.Windows.Forms.Button btn_addVehicle;
        private System.Windows.Forms.Button btn_update;
    }
}
