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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_view = new System.Windows.Forms.Button();
            this.btn_editDriver = new System.Windows.Forms.Button();
            this.btn_newDriver = new System.Windows.Forms.Button();
            this.txt_driverName = new System.Windows.Forms.TextBox();
            this.txt_driverNic = new System.Windows.Forms.TextBox();
            this.txt_driverContact = new System.Windows.Forms.TextBox();
            this.btn_driverSave = new System.Windows.Forms.Button();
            this.btn_driverSearch = new System.Windows.Forms.Button();
            this.btn_driverDelete = new System.Windows.Forms.Button();
            this.dataGridView_showDriverDetails = new System.Windows.Forms.DataGridView();
            this.errorProvider_name = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider_contact = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider_nic = new System.Windows.Forms.ErrorProvider(this.components);
            this.dataGridView_showDriverDetails_driverId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView_showDriverDetails_driverName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView_showDriverDetails_driverContact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView_showDriverDetails_save = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_showDriverDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_name)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_contact)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_nic)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "NIC";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(33, 186);
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
            this.panel1.Size = new System.Drawing.Size(1374, 48);
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
            this.btn_view.Size = new System.Drawing.Size(603, 48);
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
            this.btn_editDriver.Location = new System.Drawing.Point(970, 0);
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
            // txt_driverName
            // 
            this.txt_driverName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_driverName.Location = new System.Drawing.Point(239, 118);
            this.txt_driverName.Name = "txt_driverName";
            this.txt_driverName.Size = new System.Drawing.Size(283, 34);
            this.txt_driverName.TabIndex = 6;
            // 
            // txt_driverNic
            // 
            this.txt_driverNic.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_driverNic.Location = new System.Drawing.Point(239, 247);
            this.txt_driverNic.Name = "txt_driverNic";
            this.txt_driverNic.Size = new System.Drawing.Size(283, 34);
            this.txt_driverNic.TabIndex = 6;
            // 
            // txt_driverContact
            // 
            this.txt_driverContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_driverContact.Location = new System.Drawing.Point(239, 183);
            this.txt_driverContact.Name = "txt_driverContact";
            this.txt_driverContact.Size = new System.Drawing.Size(283, 34);
            this.txt_driverContact.TabIndex = 6;
            // 
            // btn_driverSave
            // 
            this.btn_driverSave.BackColor = System.Drawing.Color.White;
            this.btn_driverSave.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btn_driverSave.FlatAppearance.BorderSize = 2;
            this.btn_driverSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_driverSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_driverSave.Location = new System.Drawing.Point(815, 105);
            this.btn_driverSave.Name = "btn_driverSave";
            this.btn_driverSave.Size = new System.Drawing.Size(188, 54);
            this.btn_driverSave.TabIndex = 7;
            this.btn_driverSave.Text = "Save";
            this.btn_driverSave.UseVisualStyleBackColor = false;
            this.btn_driverSave.Click += new System.EventHandler(this.btn_driverSave_Click);
            // 
            // btn_driverSearch
            // 
            this.btn_driverSearch.BackColor = System.Drawing.Color.White;
            this.btn_driverSearch.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btn_driverSearch.FlatAppearance.BorderSize = 2;
            this.btn_driverSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_driverSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_driverSearch.Location = new System.Drawing.Point(1096, 105);
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
            this.btn_driverDelete.Location = new System.Drawing.Point(815, 208);
            this.btn_driverDelete.Name = "btn_driverDelete";
            this.btn_driverDelete.Size = new System.Drawing.Size(188, 54);
            this.btn_driverDelete.TabIndex = 7;
            this.btn_driverDelete.Text = "Delete";
            this.btn_driverDelete.UseVisualStyleBackColor = false;
            this.btn_driverDelete.Visible = false;
            // 
            // dataGridView_showDriverDetails
            // 
            this.dataGridView_showDriverDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_showDriverDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_showDriverDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_showDriverDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridView_showDriverDetails_driverId,
            this.dataGridView_showDriverDetails_driverName,
            this.dataGridView_showDriverDetails_driverContact,
            this.dataGridView_showDriverDetails_save});
            this.dataGridView_showDriverDetails.Location = new System.Drawing.Point(63, 340);
            this.dataGridView_showDriverDetails.Name = "dataGridView_showDriverDetails";
            this.dataGridView_showDriverDetails.RowTemplate.Height = 24;
            this.dataGridView_showDriverDetails.Size = new System.Drawing.Size(1283, 374);
            this.dataGridView_showDriverDetails.TabIndex = 9;
            // 
            // errorProvider_name
            // 
            this.errorProvider_name.ContainerControl = this;
            // 
            // errorProvider_contact
            // 
            this.errorProvider_contact.ContainerControl = this;
            // 
            // errorProvider_nic
            // 
            this.errorProvider_nic.ContainerControl = this;
            // 
            // dataGridView_showDriverDetails_driverId
            // 
            this.dataGridView_showDriverDetails_driverId.DataPropertyName = "driver_id";
            this.dataGridView_showDriverDetails_driverId.HeaderText = "Driver ID";
            this.dataGridView_showDriverDetails_driverId.Name = "dataGridView_showDriverDetails_driverId";
            // 
            // dataGridView_showDriverDetails_driverName
            // 
            this.dataGridView_showDriverDetails_driverName.DataPropertyName = "driver_name";
            this.dataGridView_showDriverDetails_driverName.HeaderText = "Driver Name";
            this.dataGridView_showDriverDetails_driverName.Name = "dataGridView_showDriverDetails_driverName";
            // 
            // dataGridView_showDriverDetails_driverContact
            // 
            this.dataGridView_showDriverDetails_driverContact.DataPropertyName = "driver_contact";
            this.dataGridView_showDriverDetails_driverContact.HeaderText = "Driver Contact";
            this.dataGridView_showDriverDetails_driverContact.Name = "dataGridView_showDriverDetails_driverContact";
            // 
            // dataGridView_showDriverDetails_save
            // 
            this.dataGridView_showDriverDetails_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dataGridView_showDriverDetails_save.HeaderText = "Save";
            this.dataGridView_showDriverDetails_save.Name = "dataGridView_showDriverDetails_save";
            this.dataGridView_showDriverDetails_save.Text = "Save";
            this.dataGridView_showDriverDetails_save.ToolTipText = "Save";
            this.dataGridView_showDriverDetails_save.UseColumnTextForButtonValue = true;
            // 
            // driverDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.dataGridView_showDriverDetails);
            this.Controls.Add(this.btn_driverSearch);
            this.Controls.Add(this.btn_driverDelete);
            this.Controls.Add(this.btn_driverSave);
            this.Controls.Add(this.txt_driverContact);
            this.Controls.Add(this.txt_driverNic);
            this.Controls.Add(this.txt_driverName);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Name = "driverDetails";
            this.Size = new System.Drawing.Size(1374, 801);
            this.Load += new System.EventHandler(this.driverDetails_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_showDriverDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_name)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_contact)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_nic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_editDriver;
        private System.Windows.Forms.Button btn_newDriver;
        private System.Windows.Forms.TextBox txt_driverName;
        private System.Windows.Forms.TextBox txt_driverNic;
        private System.Windows.Forms.TextBox txt_driverContact;
        private System.Windows.Forms.Button btn_driverSave;
        private System.Windows.Forms.Button btn_driverSearch;
        private System.Windows.Forms.Button btn_driverDelete;
        private System.Windows.Forms.Button btn_view;
        private System.Windows.Forms.DataGridView dataGridView_showDriverDetails;
        private System.Windows.Forms.ErrorProvider errorProvider_name;
        private System.Windows.Forms.ErrorProvider errorProvider_contact;
        private System.Windows.Forms.ErrorProvider errorProvider_nic;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridView_showDriverDetails_driverId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridView_showDriverDetails_driverName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridView_showDriverDetails_driverContact;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridView_showDriverDetails_save;
    }
}
