namespace librun.Admin.Users
{
    partial class AlertBorrowed
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
            this.lbl_tb_sach = new System.Windows.Forms.Label();
            this.dgv_ten_sach_muon = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ten_sach_muon)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.panel1.Controls.Add(this.lbl_tb_sach);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(639, 81);
            this.panel1.TabIndex = 0;
            // 
            // lbl_tb_sach
            // 
            this.lbl_tb_sach.AutoSize = true;
            this.lbl_tb_sach.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tb_sach.ForeColor = System.Drawing.Color.White;
            this.lbl_tb_sach.Location = new System.Drawing.Point(23, 22);
            this.lbl_tb_sach.Name = "lbl_tb_sach";
            this.lbl_tb_sach.Size = new System.Drawing.Size(441, 31);
            this.lbl_tb_sach.TabIndex = 0;
            this.lbl_tb_sach.Text = "Thông tin sách người dùng đang mượn:";
            // 
            // dgv_ten_sach_muon
            // 
            this.dgv_ten_sach_muon.AllowUserToAddRows = false;
            this.dgv_ten_sach_muon.AllowUserToDeleteRows = false;
            this.dgv_ten_sach_muon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_ten_sach_muon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ten_sach_muon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_ten_sach_muon.Location = new System.Drawing.Point(0, 81);
            this.dgv_ten_sach_muon.Name = "dgv_ten_sach_muon";
            this.dgv_ten_sach_muon.ReadOnly = true;
            this.dgv_ten_sach_muon.RowHeadersWidth = 51;
            this.dgv_ten_sach_muon.RowTemplate.Height = 24;
            this.dgv_ten_sach_muon.Size = new System.Drawing.Size(639, 233);
            this.dgv_ten_sach_muon.TabIndex = 1;
            // 
            // AlertBorrowed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 314);
            this.Controls.Add(this.dgv_ten_sach_muon);
            this.Controls.Add(this.panel1);
            this.Name = "AlertBorrowed";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AlertBorrowed";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ten_sach_muon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_tb_sach;
        private System.Windows.Forms.DataGridView dgv_ten_sach_muon;
    }
}