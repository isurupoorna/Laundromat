namespace Laundromat
{
    partial class adminHome
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_mainEdit = new System.Windows.Forms.Button();
            this.btn_mainReport = new System.Windows.Forms.Button();
            this.btn_mainRoot = new System.Windows.Forms.Button();
            this.btn_mainUser = new System.Windows.Forms.Button();
            this.btn_mainVehicle = new System.Windows.Forms.Button();
            this.btn_mainDriver = new System.Windows.Forms.Button();
            this.uc_report1 = new Laundromat.uc_report();
            this.driverDetails1 = new Laundromat.driverDetails();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Blue;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1077, 58);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Blue;
            this.panel2.Controls.Add(this.btn_mainEdit);
            this.panel2.Controls.Add(this.btn_mainReport);
            this.panel2.Controls.Add(this.btn_mainRoot);
            this.panel2.Controls.Add(this.btn_mainUser);
            this.panel2.Controls.Add(this.btn_mainVehicle);
            this.panel2.Controls.Add(this.btn_mainDriver);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 58);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(300, 568);
            this.panel2.TabIndex = 1;
            // 
            // btn_mainEdit
            // 
            this.btn_mainEdit.BackColor = System.Drawing.Color.Blue;
            this.btn_mainEdit.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btn_mainEdit.FlatAppearance.BorderSize = 0;
            this.btn_mainEdit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btn_mainEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btn_mainEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_mainEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mainEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_mainEdit.Location = new System.Drawing.Point(0, 180);
            this.btn_mainEdit.Name = "btn_mainEdit";
            this.btn_mainEdit.Size = new System.Drawing.Size(300, 89);
            this.btn_mainEdit.TabIndex = 2;
            this.btn_mainEdit.Text = "Edits";
            this.btn_mainEdit.UseVisualStyleBackColor = false;
            this.btn_mainEdit.Click += new System.EventHandler(this.btn_mainEdit_Click);
            this.btn_mainEdit.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn_mainEdit_MouseClick);
            this.btn_mainEdit.MouseHover += new System.EventHandler(this.btn_mainEdit_MouseHover);
            // 
            // btn_mainReport
            // 
            this.btn_mainReport.BackColor = System.Drawing.Color.Blue;
            this.btn_mainReport.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btn_mainReport.FlatAppearance.BorderSize = 0;
            this.btn_mainReport.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btn_mainReport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btn_mainReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_mainReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mainReport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_mainReport.Location = new System.Drawing.Point(0, 47);
            this.btn_mainReport.Name = "btn_mainReport";
            this.btn_mainReport.Size = new System.Drawing.Size(300, 89);
            this.btn_mainReport.TabIndex = 2;
            this.btn_mainReport.Text = "Reports";
            this.btn_mainReport.UseVisualStyleBackColor = false;
            // 
            // btn_mainRoot
            // 
            this.btn_mainRoot.BackColor = System.Drawing.Color.White;
            this.btn_mainRoot.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mainRoot.Image = global::Laundromat.Properties.Resources._02_512;
            this.btn_mainRoot.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_mainRoot.Location = new System.Drawing.Point(0, 413);
            this.btn_mainRoot.Name = "btn_mainRoot";
            this.btn_mainRoot.Size = new System.Drawing.Size(300, 63);
            this.btn_mainRoot.TabIndex = 1;
            this.btn_mainRoot.Text = "Root";
            this.btn_mainRoot.UseVisualStyleBackColor = false;
            this.btn_mainRoot.Visible = false;
            // 
            // btn_mainUser
            // 
            this.btn_mainUser.BackColor = System.Drawing.Color.White;
            this.btn_mainUser.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mainUser.Image = global::Laundromat.Properties.Resources._11;
            this.btn_mainUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_mainUser.Location = new System.Drawing.Point(0, 482);
            this.btn_mainUser.Name = "btn_mainUser";
            this.btn_mainUser.Size = new System.Drawing.Size(300, 63);
            this.btn_mainUser.TabIndex = 1;
            this.btn_mainUser.Text = "Users";
            this.btn_mainUser.UseVisualStyleBackColor = false;
            this.btn_mainUser.Visible = false;
            // 
            // btn_mainVehicle
            // 
            this.btn_mainVehicle.BackColor = System.Drawing.Color.White;
            this.btn_mainVehicle.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mainVehicle.Image = global::Laundromat.Properties.Resources.truck_shipping_logistic_delivery_transport_supply_vehicle_3941bc31c595862b_512x512;
            this.btn_mainVehicle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_mainVehicle.Location = new System.Drawing.Point(0, 344);
            this.btn_mainVehicle.Name = "btn_mainVehicle";
            this.btn_mainVehicle.Size = new System.Drawing.Size(300, 63);
            this.btn_mainVehicle.TabIndex = 1;
            this.btn_mainVehicle.Text = "Vehicles";
            this.btn_mainVehicle.UseVisualStyleBackColor = false;
            this.btn_mainVehicle.Visible = false;
            // 
            // btn_mainDriver
            // 
            this.btn_mainDriver.BackColor = System.Drawing.Color.White;
            this.btn_mainDriver.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mainDriver.Image = global::Laundromat.Properties.Resources._509406_2001;
            this.btn_mainDriver.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_mainDriver.Location = new System.Drawing.Point(0, 275);
            this.btn_mainDriver.Name = "btn_mainDriver";
            this.btn_mainDriver.Size = new System.Drawing.Size(300, 63);
            this.btn_mainDriver.TabIndex = 1;
            this.btn_mainDriver.Text = "Drivers";
            this.btn_mainDriver.UseVisualStyleBackColor = false;
            this.btn_mainDriver.Visible = false;
            // 
            // uc_report1
            // 
            this.uc_report1.AutoSize = true;
            this.uc_report1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.uc_report1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uc_report1.Location = new System.Drawing.Point(300, 58);
            this.uc_report1.Name = "uc_report1";
            this.uc_report1.Size = new System.Drawing.Size(777, 568);
            this.uc_report1.TabIndex = 2;
            // 
            // driverDetails1
            // 
            this.driverDetails1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.driverDetails1.Location = new System.Drawing.Point(300, 58);
            this.driverDetails1.Name = "driverDetails1";
            this.driverDetails1.Size = new System.Drawing.Size(777, 568);
            this.driverDetails1.TabIndex = 3;
            // 
            // adminHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 626);
            this.Controls.Add(this.driverDetails1);
            this.Controls.Add(this.uc_report1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "adminHome";
            this.Text = "adminHome";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private uc_report uc_report1;
        private driverDetails driverDetails1;
        private System.Windows.Forms.Button btn_mainRoot;
        private System.Windows.Forms.Button btn_mainUser;
        private System.Windows.Forms.Button btn_mainVehicle;
        private System.Windows.Forms.Button btn_mainDriver;
        private System.Windows.Forms.Button btn_mainReport;
        private System.Windows.Forms.Button btn_mainEdit;
    }
}