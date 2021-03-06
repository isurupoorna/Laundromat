﻿namespace Laundromat
{
    partial class root
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
            this.txt_leavePoint = new System.Windows.Forms.TextBox();
            this.txt_arrivalPoint = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgv_root = new System.Windows.Forms.DataGridView();
            this.btn_add = new System.Windows.Forms.Button();
            this.dateTimePicker_arrival = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_leaving = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_groupId = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_groupName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmb_vehicle = new System.Windows.Forms.ComboBox();
            this.cmb_driver = new System.Windows.Forms.ComboBox();
            this.btn_update = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_root)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_leavePoint
            // 
            this.txt_leavePoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_leavePoint.Location = new System.Drawing.Point(284, 75);
            this.txt_leavePoint.Name = "txt_leavePoint";
            this.txt_leavePoint.Size = new System.Drawing.Size(200, 27);
            this.txt_leavePoint.TabIndex = 0;
            // 
            // txt_arrivalPoint
            // 
            this.txt_arrivalPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_arrivalPoint.Location = new System.Drawing.Point(284, 195);
            this.txt_arrivalPoint.Name = "txt_arrivalPoint";
            this.txt_arrivalPoint.Size = new System.Drawing.Size(200, 27);
            this.txt_arrivalPoint.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(77, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Leaving Point";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(77, 251);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Arrival Time";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(77, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Arrival Point ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(77, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Leaving Time";
            // 
            // dgv_root
            // 
            this.dgv_root.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_root.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_root.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_root.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_root.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_root.Location = new System.Drawing.Point(21, 390);
            this.dgv_root.Name = "dgv_root";
            this.dgv_root.ReadOnly = true;
            this.dgv_root.RowHeadersVisible = false;
            this.dgv_root.RowTemplate.Height = 24;
            this.dgv_root.Size = new System.Drawing.Size(1355, 351);
            this.dgv_root.TabIndex = 9;
            this.dgv_root.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_root_CellClick);
            // 
            // btn_add
            // 
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.ForeColor = System.Drawing.Color.Blue;
            this.btn_add.Location = new System.Drawing.Point(328, 328);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(156, 40);
            this.btn_add.TabIndex = 10;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // dateTimePicker_arrival
            // 
            this.dateTimePicker_arrival.CustomFormat = "HH:mm:ss";
            this.dateTimePicker_arrival.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_arrival.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_arrival.Location = new System.Drawing.Point(284, 251);
            this.dateTimePicker_arrival.Name = "dateTimePicker_arrival";
            this.dateTimePicker_arrival.ShowUpDown = true;
            this.dateTimePicker_arrival.Size = new System.Drawing.Size(200, 27);
            this.dateTimePicker_arrival.TabIndex = 11;
            // 
            // dateTimePicker_leaving
            // 
            this.dateTimePicker_leaving.CustomFormat = "HH:mm:ss";
            this.dateTimePicker_leaving.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_leaving.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_leaving.Location = new System.Drawing.Point(284, 134);
            this.dateTimePicker_leaving.Name = "dateTimePicker_leaving";
            this.dateTimePicker_leaving.ShowUpDown = true;
            this.dateTimePicker_leaving.Size = new System.Drawing.Size(200, 27);
            this.dateTimePicker_leaving.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(596, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Group ID";
            // 
            // txt_groupId
            // 
            this.txt_groupId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_groupId.Location = new System.Drawing.Point(801, 75);
            this.txt_groupId.Name = "txt_groupId";
            this.txt_groupId.Size = new System.Drawing.Size(200, 27);
            this.txt_groupId.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(596, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Group Name";
            // 
            // txt_groupName
            // 
            this.txt_groupName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_groupName.Location = new System.Drawing.Point(801, 131);
            this.txt_groupName.Name = "txt_groupName";
            this.txt_groupName.Size = new System.Drawing.Size(200, 27);
            this.txt_groupName.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(596, 256);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "Vehicle No";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(596, 191);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 20);
            this.label8.TabIndex = 18;
            this.label8.Text = "Driver";
            // 
            // cmb_vehicle
            // 
            this.cmb_vehicle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_vehicle.FormattingEnabled = true;
            this.cmb_vehicle.Location = new System.Drawing.Point(801, 248);
            this.cmb_vehicle.Name = "cmb_vehicle";
            this.cmb_vehicle.Size = new System.Drawing.Size(200, 28);
            this.cmb_vehicle.TabIndex = 19;
            // 
            // cmb_driver
            // 
            this.cmb_driver.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_driver.FormattingEnabled = true;
            this.cmb_driver.Location = new System.Drawing.Point(801, 188);
            this.cmb_driver.Name = "cmb_driver";
            this.cmb_driver.Size = new System.Drawing.Size(200, 28);
            this.cmb_driver.TabIndex = 20;
            // 
            // btn_update
            // 
            this.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.ForeColor = System.Drawing.Color.Blue;
            this.btn_update.Location = new System.Drawing.Point(569, 328);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(156, 40);
            this.btn_update.TabIndex = 21;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // root
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.cmb_driver);
            this.Controls.Add(this.cmb_vehicle);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_groupName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_groupId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimePicker_leaving);
            this.Controls.Add(this.dateTimePicker_arrival);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.dgv_root);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_arrivalPoint);
            this.Controls.Add(this.txt_leavePoint);
            this.Name = "root";
            this.Size = new System.Drawing.Size(1466, 758);
            this.Load += new System.EventHandler(this.root_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_root)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_leavePoint;
        private System.Windows.Forms.TextBox txt_arrivalPoint;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgv_root;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.DateTimePicker dateTimePicker_arrival;
        private System.Windows.Forms.DateTimePicker dateTimePicker_leaving;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_groupId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_groupName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmb_vehicle;
        private System.Windows.Forms.ComboBox cmb_driver;
        private System.Windows.Forms.Button btn_update;
    }
}
