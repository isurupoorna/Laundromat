namespace Laundromat
{
    partial class driver
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_driverNic = new System.Windows.Forms.TextBox();
            this.txt_driverContact = new System.Windows.Forms.TextBox();
            this.txt_driverName = new System.Windows.Forms.TextBox();
            this.btn_saveDriver = new System.Windows.Forms.Button();
            this.dgv_driverDetails = new System.Windows.Forms.DataGridView();
            this.errorProvider_name = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider_contact = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider_nic = new System.Windows.Forms.ErrorProvider(this.components);
            this.btn_updateDriver = new System.Windows.Forms.Button();
            this.btn_delDriver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_driverDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_name)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_contact)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_nic)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(136, 219);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "NIC Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(135, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contact Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(136, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Name";
            // 
            // txt_driverNic
            // 
            this.txt_driverNic.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_driverNic.Location = new System.Drawing.Point(323, 215);
            this.txt_driverNic.MaxLength = 10;
            this.txt_driverNic.Name = "txt_driverNic";
            this.txt_driverNic.Size = new System.Drawing.Size(238, 28);
            this.txt_driverNic.TabIndex = 3;
            // 
            // txt_driverContact
            // 
            this.txt_driverContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_driverContact.Location = new System.Drawing.Point(323, 140);
            this.txt_driverContact.Name = "txt_driverContact";
            this.txt_driverContact.Size = new System.Drawing.Size(238, 28);
            this.txt_driverContact.TabIndex = 4;
            // 
            // txt_driverName
            // 
            this.txt_driverName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_driverName.Location = new System.Drawing.Point(323, 66);
            this.txt_driverName.Name = "txt_driverName";
            this.txt_driverName.Size = new System.Drawing.Size(238, 28);
            this.txt_driverName.TabIndex = 5;
            // 
            // btn_saveDriver
            // 
            this.btn_saveDriver.BackColor = System.Drawing.Color.White;
            this.btn_saveDriver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_saveDriver.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_saveDriver.ForeColor = System.Drawing.Color.Blue;
            this.btn_saveDriver.Location = new System.Drawing.Point(760, 66);
            this.btn_saveDriver.Name = "btn_saveDriver";
            this.btn_saveDriver.Size = new System.Drawing.Size(117, 38);
            this.btn_saveDriver.TabIndex = 6;
            this.btn_saveDriver.Text = "Add";
            this.btn_saveDriver.UseVisualStyleBackColor = false;
            this.btn_saveDriver.Click += new System.EventHandler(this.btn_saveDriver_Click);
            // 
            // dgv_driverDetails
            // 
            this.dgv_driverDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_driverDetails.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_driverDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_driverDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_driverDetails.Location = new System.Drawing.Point(139, 385);
            this.dgv_driverDetails.Name = "dgv_driverDetails";
            this.dgv_driverDetails.RowTemplate.Height = 24;
            this.dgv_driverDetails.Size = new System.Drawing.Size(1030, 323);
            this.dgv_driverDetails.TabIndex = 7;
            this.dgv_driverDetails.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_driverDetails_CellClick);
            this.dgv_driverDetails.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_driverDetails_CellContentClick);
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
            // btn_updateDriver
            // 
            this.btn_updateDriver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_updateDriver.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_updateDriver.ForeColor = System.Drawing.Color.Blue;
            this.btn_updateDriver.Location = new System.Drawing.Point(760, 140);
            this.btn_updateDriver.Name = "btn_updateDriver";
            this.btn_updateDriver.Size = new System.Drawing.Size(117, 35);
            this.btn_updateDriver.TabIndex = 8;
            this.btn_updateDriver.Text = "Update";
            this.btn_updateDriver.UseVisualStyleBackColor = true;
            this.btn_updateDriver.Click += new System.EventHandler(this.btn_updateDriver_Click);
            // 
            // btn_delDriver
            // 
            this.btn_delDriver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delDriver.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delDriver.ForeColor = System.Drawing.Color.Blue;
            this.btn_delDriver.Location = new System.Drawing.Point(760, 215);
            this.btn_delDriver.Name = "btn_delDriver";
            this.btn_delDriver.Size = new System.Drawing.Size(117, 35);
            this.btn_delDriver.TabIndex = 9;
            this.btn_delDriver.Text = "Delete";
            this.btn_delDriver.UseVisualStyleBackColor = true;
            this.btn_delDriver.Click += new System.EventHandler(this.btn_delDriver_Click);
            // 
            // driver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btn_delDriver);
            this.Controls.Add(this.btn_updateDriver);
            this.Controls.Add(this.dgv_driverDetails);
            this.Controls.Add(this.btn_saveDriver);
            this.Controls.Add(this.txt_driverName);
            this.Controls.Add(this.txt_driverContact);
            this.Controls.Add(this.txt_driverNic);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "driver";
            this.Size = new System.Drawing.Size(1503, 791);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_driverDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_name)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_contact)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_nic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_driverNic;
        private System.Windows.Forms.TextBox txt_driverContact;
        private System.Windows.Forms.Button btn_saveDriver;
        private System.Windows.Forms.DataGridView dgv_driverDetails;
        private System.Windows.Forms.TextBox txt_driverName;
        private System.Windows.Forms.ErrorProvider errorProvider_name;
        private System.Windows.Forms.ErrorProvider errorProvider_contact;
        private System.Windows.Forms.ErrorProvider errorProvider_nic;
        private System.Windows.Forms.Button btn_delDriver;
        private System.Windows.Forms.Button btn_updateDriver;
    }
}
