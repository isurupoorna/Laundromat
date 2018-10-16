namespace Laundromat
{
    partial class reports
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
            this.dateTimePicker_startDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView_report = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker_endDate = new System.Windows.Forms.DateTimePicker();
            this.btn_reportView = new System.Windows.Forms.Button();
            this.cmb_vehicle = new System.Windows.Forms.ComboBox();
            this.cmb_driver = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_report)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker_startDate
            // 
            this.dateTimePicker_startDate.Location = new System.Drawing.Point(127, 83);
            this.dateTimePicker_startDate.Name = "dateTimePicker_startDate";
            this.dateTimePicker_startDate.Size = new System.Drawing.Size(240, 22);
            this.dateTimePicker_startDate.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(432, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "To";
            // 
            // dataGridView_report
            // 
            this.dataGridView_report.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_report.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_report.Location = new System.Drawing.Point(32, 274);
            this.dataGridView_report.Name = "dataGridView_report";
            this.dataGridView_report.Size = new System.Drawing.Size(1318, 442);
            this.dataGridView_report.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "From";
            // 
            // dateTimePicker_endDate
            // 
            this.dateTimePicker_endDate.Location = new System.Drawing.Point(475, 83);
            this.dateTimePicker_endDate.Name = "dateTimePicker_endDate";
            this.dateTimePicker_endDate.Size = new System.Drawing.Size(236, 22);
            this.dateTimePicker_endDate.TabIndex = 6;
            // 
            // btn_reportView
            // 
            this.btn_reportView.Location = new System.Drawing.Point(818, 179);
            this.btn_reportView.Name = "btn_reportView";
            this.btn_reportView.Size = new System.Drawing.Size(75, 23);
            this.btn_reportView.TabIndex = 7;
            this.btn_reportView.Text = "View";
            this.btn_reportView.UseVisualStyleBackColor = true;
            this.btn_reportView.Click += new System.EventHandler(this.btn_reportView_Click);
            // 
            // cmb_vehicle
            // 
            this.cmb_vehicle.FormattingEnabled = true;
            this.cmb_vehicle.Location = new System.Drawing.Point(127, 195);
            this.cmb_vehicle.Name = "cmb_vehicle";
            this.cmb_vehicle.Size = new System.Drawing.Size(121, 24);
            this.cmb_vehicle.TabIndex = 8;
            this.cmb_vehicle.Text = "All";
            // 
            // cmb_driver
            // 
            this.cmb_driver.FormattingEnabled = true;
            this.cmb_driver.Location = new System.Drawing.Point(127, 143);
            this.cmb_driver.Name = "cmb_driver";
            this.cmb_driver.Size = new System.Drawing.Size(121, 24);
            this.cmb_driver.TabIndex = 9;
            this.cmb_driver.Text = "All";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Vehicle";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1221, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(53, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Driver";
            // 
            // reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmb_driver);
            this.Controls.Add(this.cmb_vehicle);
            this.Controls.Add(this.btn_reportView);
            this.Controls.Add(this.dateTimePicker_endDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView_report);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker_startDate);
            this.Name = "reports";
            this.Size = new System.Drawing.Size(1379, 758);
            this.Load += new System.EventHandler(this.reports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_report)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker_startDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView_report;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker_endDate;
        private System.Windows.Forms.Button btn_reportView;
        private System.Windows.Forms.ComboBox cmb_vehicle;
        private System.Windows.Forms.ComboBox cmb_driver;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}
