namespace Laundromat
{
    partial class driverDetails
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_view = new System.Windows.Forms.Button();
            this.btn_editDriver = new System.Windows.Forms.Button();
            this.btn_newDriver = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_driverSearch = new System.Windows.Forms.Button();
            this.btn_driverDelete = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(127, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(127, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(127, 431);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "NIC";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(127, 351);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(187, 29);
            this.label5.TabIndex = 4;
            this.label5.Text = "Contact Number";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.btn_view);
            this.panel1.Controls.Add(this.btn_editDriver);
            this.panel1.Controls.Add(this.btn_newDriver);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1148, 48);
            this.panel1.TabIndex = 5;
            // 
            // btn_view
            // 
            this.btn_view.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_view.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_view.FlatAppearance.BorderSize = 0;
            this.btn_view.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_view.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_view.ForeColor = System.Drawing.Color.Black;
            this.btn_view.Location = new System.Drawing.Point(367, 0);
            this.btn_view.Name = "btn_view";
            this.btn_view.Size = new System.Drawing.Size(377, 48);
            this.btn_view.TabIndex = 1;
            this.btn_view.Text = "View";
            this.btn_view.UseVisualStyleBackColor = false;
            // 
            // btn_editDriver
            // 
            this.btn_editDriver.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_editDriver.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_editDriver.FlatAppearance.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.btn_editDriver.FlatAppearance.BorderSize = 0;
            this.btn_editDriver.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.btn_editDriver.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btn_editDriver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_editDriver.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editDriver.ForeColor = System.Drawing.Color.Black;
            this.btn_editDriver.Location = new System.Drawing.Point(744, 0);
            this.btn_editDriver.Name = "btn_editDriver";
            this.btn_editDriver.Size = new System.Drawing.Size(404, 48);
            this.btn_editDriver.TabIndex = 0;
            this.btn_editDriver.Text = "Edit";
            this.btn_editDriver.UseVisualStyleBackColor = false;
            this.btn_editDriver.Click += new System.EventHandler(this.btn_editDriver_Click);
            // 
            // btn_newDriver
            // 
            this.btn_newDriver.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_newDriver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_newDriver.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_newDriver.FlatAppearance.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.btn_newDriver.FlatAppearance.BorderSize = 0;
            this.btn_newDriver.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.btn_newDriver.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btn_newDriver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_newDriver.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_newDriver.ForeColor = System.Drawing.Color.Black;
            this.btn_newDriver.Location = new System.Drawing.Point(0, 0);
            this.btn_newDriver.Name = "btn_newDriver";
            this.btn_newDriver.Size = new System.Drawing.Size(367, 48);
            this.btn_newDriver.TabIndex = 0;
            this.btn_newDriver.Text = "New";
            this.btn_newDriver.UseVisualStyleBackColor = false;
            this.btn_newDriver.Click += new System.EventHandler(this.btn_newDriver_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(385, 155);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(283, 34);
            this.textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(385, 431);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(283, 34);
            this.textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(385, 243);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(283, 77);
            this.textBox3.TabIndex = 6;
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(385, 351);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(283, 34);
            this.textBox4.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(283, 559);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(188, 54);
            this.button1.TabIndex = 7;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btn_driverSearch
            // 
            this.btn_driverSearch.BackColor = System.Drawing.Color.White;
            this.btn_driverSearch.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btn_driverSearch.FlatAppearance.BorderSize = 2;
            this.btn_driverSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_driverSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_driverSearch.Location = new System.Drawing.Point(797, 146);
            this.btn_driverSearch.Name = "btn_driverSearch";
            this.btn_driverSearch.Size = new System.Drawing.Size(188, 53);
            this.btn_driverSearch.TabIndex = 8;
            this.btn_driverSearch.Text = "Search";
            this.btn_driverSearch.UseVisualStyleBackColor = false;
            this.btn_driverSearch.Visible = false;
            this.btn_driverSearch.Click += new System.EventHandler(this.btn_driverSearch_Click);
            // 
            // btn_driverDelete
            // 
            this.btn_driverDelete.BackColor = System.Drawing.Color.White;
            this.btn_driverDelete.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btn_driverDelete.FlatAppearance.BorderSize = 2;
            this.btn_driverDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_driverDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_driverDelete.Location = new System.Drawing.Point(556, 559);
            this.btn_driverDelete.Name = "btn_driverDelete";
            this.btn_driverDelete.Size = new System.Drawing.Size(188, 54);
            this.btn_driverDelete.TabIndex = 7;
            this.btn_driverDelete.Text = "Delete";
            this.btn_driverDelete.UseVisualStyleBackColor = false;
            this.btn_driverDelete.Visible = false;
            // 
            // driverDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.btn_driverSearch);
            this.Controls.Add(this.btn_driverDelete);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "driverDetails";
            this.Size = new System.Drawing.Size(1148, 694);
            this.Load += new System.EventHandler(this.driverDetails_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_editDriver;
        private System.Windows.Forms.Button btn_newDriver;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_driverSearch;
        private System.Windows.Forms.Button btn_driverDelete;
        private System.Windows.Forms.Button btn_view;
    }
}
