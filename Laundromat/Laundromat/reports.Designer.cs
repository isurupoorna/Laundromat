﻿namespace Laundromat
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dateTimePicker_startDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView_report = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker_endDate = new System.Windows.Forms.DateTimePicker();
            this.btn_reportView = new System.Windows.Forms.Button();
            this.cmb_vehicle = new System.Windows.Forms.ComboBox();
            this.cmb_driver = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_late = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_report)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker_startDate
            // 
            this.dateTimePicker_startDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_startDate.Location = new System.Drawing.Point(143, 83);
            this.dateTimePicker_startDate.Name = "dateTimePicker_startDate";
            this.dateTimePicker_startDate.Size = new System.Drawing.Size(346, 30);
            this.dateTimePicker_startDate.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(586, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "To";
            // 
            // dataGridView_report
            // 
            this.dataGridView_report.AllowUserToAddRows = false;
            this.dataGridView_report.AllowUserToDeleteRows = false;
            this.dataGridView_report.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_report.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Aqua;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_report.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_report.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_report.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_report.Location = new System.Drawing.Point(21, 295);
            this.dataGridView_report.Name = "dataGridView_report";
            this.dataGridView_report.ReadOnly = true;
            this.dataGridView_report.RowHeadersVisible = false;
            this.dataGridView_report.Size = new System.Drawing.Size(1318, 442);
            this.dataGridView_report.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(53, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "From";
            // 
            // dateTimePicker_endDate
            // 
            this.dateTimePicker_endDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_endDate.Location = new System.Drawing.Point(711, 83);
            this.dateTimePicker_endDate.Name = "dateTimePicker_endDate";
            this.dateTimePicker_endDate.Size = new System.Drawing.Size(346, 30);
            this.dateTimePicker_endDate.TabIndex = 6;
            // 
            // btn_reportView
            // 
            this.btn_reportView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reportView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reportView.Location = new System.Drawing.Point(453, 208);
            this.btn_reportView.Name = "btn_reportView";
            this.btn_reportView.Size = new System.Drawing.Size(133, 46);
            this.btn_reportView.TabIndex = 7;
            this.btn_reportView.Text = "View";
            this.btn_reportView.UseVisualStyleBackColor = true;
            this.btn_reportView.Click += new System.EventHandler(this.btn_reportView_Click);
            // 
            // cmb_vehicle
            // 
            this.cmb_vehicle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_vehicle.FormattingEnabled = true;
            this.cmb_vehicle.Location = new System.Drawing.Point(143, 192);
            this.cmb_vehicle.Name = "cmb_vehicle";
            this.cmb_vehicle.Size = new System.Drawing.Size(202, 33);
            this.cmb_vehicle.TabIndex = 8;
            this.cmb_vehicle.Text = "All";
            // 
            // cmb_driver
            // 
            this.cmb_driver.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_driver.FormattingEnabled = true;
            this.cmb_driver.Location = new System.Drawing.Point(143, 140);
            this.cmb_driver.Name = "cmb_driver";
            this.cmb_driver.Size = new System.Drawing.Size(202, 33);
            this.cmb_driver.TabIndex = 9;
            this.cmb_driver.Text = "All";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(53, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "Vehicle";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(53, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 25);
            this.label5.TabIndex = 12;
            this.label5.Text = "Driver";
            // 
            // btn_late
            // 
            this.btn_late.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_late.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_late.Location = new System.Drawing.Point(658, 208);
            this.btn_late.Name = "btn_late";
            this.btn_late.Size = new System.Drawing.Size(175, 45);
            this.btn_late.TabIndex = 13;
            this.btn_late.Text = "View Late report";
            this.btn_late.UseVisualStyleBackColor = true;
            this.btn_late.Click += new System.EventHandler(this.btn_late_Click);
            // 
            // reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btn_late);
            this.Controls.Add(this.label5);
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_late;
    }
}
