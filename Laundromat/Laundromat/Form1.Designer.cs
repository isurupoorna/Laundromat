namespace Laundromat
{
    partial class frm_display
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
            this.pnl_header = new System.Windows.Forms.Panel();
            this.pnl_displayOut = new System.Windows.Forms.Panel();
            this.dataGridView_displayOut = new System.Windows.Forms.DataGridView();
            this.pnl_displayIn = new System.Windows.Forms.Panel();
            this.dataGridView_displayIn = new System.Windows.Forms.DataGridView();
            this.pnl_displayOut.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_displayOut)).BeginInit();
            this.pnl_displayIn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_displayIn)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_header
            // 
            this.pnl_header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.pnl_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_header.Location = new System.Drawing.Point(0, 0);
            this.pnl_header.Name = "pnl_header";
            this.pnl_header.Size = new System.Drawing.Size(1121, 58);
            this.pnl_header.TabIndex = 0;
            // 
            // pnl_displayOut
            // 
            this.pnl_displayOut.Controls.Add(this.dataGridView_displayOut);
            this.pnl_displayOut.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_displayOut.Location = new System.Drawing.Point(0, 58);
            this.pnl_displayOut.Name = "pnl_displayOut";
            this.pnl_displayOut.Size = new System.Drawing.Size(1121, 289);
            this.pnl_displayOut.TabIndex = 1;
            // 
            // dataGridView_displayOut
            // 
            this.dataGridView_displayOut.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_displayOut.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_displayOut.Name = "dataGridView_displayOut";
            this.dataGridView_displayOut.RowTemplate.Height = 24;
            this.dataGridView_displayOut.Size = new System.Drawing.Size(1121, 289);
            this.dataGridView_displayOut.TabIndex = 0;
            // 
            // pnl_displayIn
            // 
            this.pnl_displayIn.Controls.Add(this.dataGridView_displayIn);
            this.pnl_displayIn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_displayIn.Location = new System.Drawing.Point(0, 353);
            this.pnl_displayIn.Name = "pnl_displayIn";
            this.pnl_displayIn.Size = new System.Drawing.Size(1121, 315);
            this.pnl_displayIn.TabIndex = 1;
            // 
            // dataGridView_displayIn
            // 
            this.dataGridView_displayIn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_displayIn.Location = new System.Drawing.Point(-3, 0);
            this.dataGridView_displayIn.Name = "dataGridView_displayIn";
            this.dataGridView_displayIn.RowTemplate.Height = 24;
            this.dataGridView_displayIn.Size = new System.Drawing.Size(1121, 315);
            this.dataGridView_displayIn.TabIndex = 0;
            // 
            // frm_display
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 668);
            this.Controls.Add(this.pnl_displayIn);
            this.Controls.Add(this.pnl_displayOut);
            this.Controls.Add(this.pnl_header);
            this.Name = "frm_display";
            this.Text = "LOMDROMAT";
            this.pnl_displayOut.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_displayOut)).EndInit();
            this.pnl_displayIn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_displayIn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_header;
        private System.Windows.Forms.Panel pnl_displayOut;
        private System.Windows.Forms.Panel pnl_displayIn;
        private System.Windows.Forms.DataGridView dataGridView_displayOut;
        private System.Windows.Forms.DataGridView dataGridView_displayIn;
    }
}

