namespace Laundromat
{
    partial class adminLogin
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
            this.components = new System.ComponentModel.Container();
            this.btn_loginAdmin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_adminPassword = new System.Windows.Forms.TextBox();
            this.txt_adminUserName = new System.Windows.Forms.TextBox();
            this.errorProvider_userName = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider_password = new System.Windows.Forms.ErrorProvider(this.components);
            this.btn_exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_userName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_password)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_loginAdmin
            // 
            this.btn_loginAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_loginAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_loginAdmin.Location = new System.Drawing.Point(144, 200);
            this.btn_loginAdmin.Name = "btn_loginAdmin";
            this.btn_loginAdmin.Size = new System.Drawing.Size(326, 47);
            this.btn_loginAdmin.TabIndex = 0;
            this.btn_loginAdmin.Text = "Login";
            this.btn_loginAdmin.UseVisualStyleBackColor = true;
            this.btn_loginAdmin.Click += new System.EventHandler(this.btn_loginAdmin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(141, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(141, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "User Name";
            // 
            // txt_adminPassword
            // 
            this.txt_adminPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_adminPassword.Location = new System.Drawing.Point(260, 133);
            this.txt_adminPassword.Name = "txt_adminPassword";
            this.txt_adminPassword.PasswordChar = '*';
            this.txt_adminPassword.Size = new System.Drawing.Size(210, 27);
            this.txt_adminPassword.TabIndex = 3;
            // 
            // txt_adminUserName
            // 
            this.txt_adminUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_adminUserName.Location = new System.Drawing.Point(260, 78);
            this.txt_adminUserName.Name = "txt_adminUserName";
            this.txt_adminUserName.Size = new System.Drawing.Size(210, 27);
            this.txt_adminUserName.TabIndex = 4;
            // 
            // errorProvider_userName
            // 
            this.errorProvider_userName.ContainerControl = this;
            // 
            // errorProvider_password
            // 
            this.errorProvider_password.ContainerControl = this;
            // 
            // btn_exit
            // 
            this.btn_exit.BackgroundImage = global::Laundromat.Properties.Resources.shutdown;
            this.btn_exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_exit.Location = new System.Drawing.Point(593, 22);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(37, 35);
            this.btn_exit.TabIndex = 5;
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // adminLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(654, 300);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.txt_adminUserName);
            this.Controls.Add(this.txt_adminPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_loginAdmin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "adminLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Login";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_userName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_password)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_loginAdmin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_adminPassword;
        private System.Windows.Forms.TextBox txt_adminUserName;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.ErrorProvider errorProvider_userName;
        private System.Windows.Forms.ErrorProvider errorProvider_password;
    }
}