namespace Library
{
    partial class AdminSidenav
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminSidenav));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSignOut = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnTtMuonSach = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnQuanLySach = new System.Windows.Forms.Button();
            this.btnQuanLyNguoiDung = new System.Windows.Forms.Button();
            this.btnQuanLyPhanHoi = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.panel1.Controls.Add(this.btnQuanLyPhanHoi);
            this.panel1.Controls.Add(this.btnSignOut);
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Controls.Add(this.btnTtMuonSach);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnQuanLySach);
            this.panel1.Controls.Add(this.btnQuanLyNguoiDung);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(171, 561);
            this.panel1.TabIndex = 9;
            // 
            // btnSignOut
            // 
            this.btnSignOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSignOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnSignOut.FlatAppearance.BorderSize = 0;
            this.btnSignOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignOut.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSignOut.ForeColor = System.Drawing.Color.White;
            this.btnSignOut.Location = new System.Drawing.Point(2, 498);
            this.btnSignOut.Name = "btnSignOut";
            this.btnSignOut.Size = new System.Drawing.Size(166, 51);
            this.btnSignOut.TabIndex = 9;
            this.btnSignOut.Text = "Đăng xuất";
            this.btnSignOut.UseVisualStyleBackColor = false;
            this.btnSignOut.Click += new System.EventHandler(this.btnSignOut_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTitle.Location = new System.Drawing.Point(34, 93);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(102, 37);
            this.lblTitle.TabIndex = 8;
            this.lblTitle.Text = "Admin";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnTtMuonSach
            // 
            this.btnTtMuonSach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnTtMuonSach.FlatAppearance.BorderSize = 0;
            this.btnTtMuonSach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTtMuonSach.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnTtMuonSach.ForeColor = System.Drawing.Color.White;
            this.btnTtMuonSach.Location = new System.Drawing.Point(2, 149);
            this.btnTtMuonSach.Name = "btnTtMuonSach";
            this.btnTtMuonSach.Size = new System.Drawing.Size(166, 51);
            this.btnTtMuonSach.TabIndex = 7;
            this.btnTtMuonSach.Text = "Thống kê thông tin mượn sách";
            this.btnTtMuonSach.UseVisualStyleBackColor = false;
            this.btnTtMuonSach.Click += new System.EventHandler(this.btnYeuCauMuonSach_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(164, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // btnQuanLySach
            // 
            this.btnQuanLySach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnQuanLySach.FlatAppearance.BorderSize = 0;
            this.btnQuanLySach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuanLySach.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnQuanLySach.ForeColor = System.Drawing.Color.White;
            this.btnQuanLySach.Location = new System.Drawing.Point(2, 206);
            this.btnQuanLySach.Name = "btnQuanLySach";
            this.btnQuanLySach.Size = new System.Drawing.Size(166, 51);
            this.btnQuanLySach.TabIndex = 4;
            this.btnQuanLySach.Text = "Quản lý sách";
            this.btnQuanLySach.UseVisualStyleBackColor = false;
            this.btnQuanLySach.Click += new System.EventHandler(this.btnQuanLySach_Click);
            // 
            // btnQuanLyNguoiDung
            // 
            this.btnQuanLyNguoiDung.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnQuanLyNguoiDung.FlatAppearance.BorderSize = 0;
            this.btnQuanLyNguoiDung.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuanLyNguoiDung.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnQuanLyNguoiDung.ForeColor = System.Drawing.Color.White;
            this.btnQuanLyNguoiDung.Location = new System.Drawing.Point(2, 263);
            this.btnQuanLyNguoiDung.Name = "btnQuanLyNguoiDung";
            this.btnQuanLyNguoiDung.Size = new System.Drawing.Size(166, 51);
            this.btnQuanLyNguoiDung.TabIndex = 5;
            this.btnQuanLyNguoiDung.Text = "Quản lý người dùng";
            this.btnQuanLyNguoiDung.UseVisualStyleBackColor = false;
            this.btnQuanLyNguoiDung.Click += new System.EventHandler(this.btnQuanLyNguoiDung_Click);
            // 
            // btnQuanLyPhanHoi
            // 
            this.btnQuanLyPhanHoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnQuanLyPhanHoi.FlatAppearance.BorderSize = 0;
            this.btnQuanLyPhanHoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuanLyPhanHoi.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnQuanLyPhanHoi.ForeColor = System.Drawing.Color.White;
            this.btnQuanLyPhanHoi.Location = new System.Drawing.Point(2, 320);
            this.btnQuanLyPhanHoi.Name = "btnQuanLyPhanHoi";
            this.btnQuanLyPhanHoi.Size = new System.Drawing.Size(166, 51);
            this.btnQuanLyPhanHoi.TabIndex = 10;
            this.btnQuanLyPhanHoi.Text = "Quản lý phản hồi";
            this.btnQuanLyPhanHoi.UseVisualStyleBackColor = false;
            this.btnQuanLyPhanHoi.Click += new System.EventHandler(this.btnQuanLyPhanHoi_Click);
            // 
            // AdminSidenav
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "AdminSidenav";
            this.Size = new System.Drawing.Size(171, 561);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        internal System.Windows.Forms.Button btnSignOut;
        private System.Windows.Forms.Label lblTitle;
        internal System.Windows.Forms.Button btnTtMuonSach;
        private System.Windows.Forms.PictureBox pictureBox1;
        internal System.Windows.Forms.Button btnQuanLySach;
        internal System.Windows.Forms.Button btnQuanLyNguoiDung;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Button btnQuanLyPhanHoi;
    }
}
