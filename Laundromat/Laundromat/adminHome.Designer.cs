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
            this.uc_report1 = new Laundromat.uc_report();
            this.driverDetails1 = new Laundromat.driverDetails();
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
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 58);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(300, 568);
            this.panel2.TabIndex = 1;
            // 
            // uc_report1
            // 
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private uc_report uc_report1;
        private driverDetails driverDetails1;
    }
}