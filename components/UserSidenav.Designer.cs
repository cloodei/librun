﻿namespace Library
{
    partial class UserSidenav
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserSidenav));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbUserProfile = new System.Windows.Forms.PictureBox();
            this.btnGioiThieu = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnQuanLySach = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.quảnLýTàiKhảoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xemThôngTinPhảnHồiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUserProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.panel1.Controls.Add(this.pbUserProfile);
            this.panel1.Controls.Add(this.btnGioiThieu);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Controls.Add(this.btnQuanLySach);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(171, 561);
            this.panel1.TabIndex = 5;
            // 
            // pbUserProfile
            // 
            this.pbUserProfile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pbUserProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbUserProfile.Image = ((System.Drawing.Image)(resources.GetObject("pbUserProfile.Image")));
            this.pbUserProfile.Location = new System.Drawing.Point(55, 501);
            this.pbUserProfile.Name = "pbUserProfile";
            this.pbUserProfile.Size = new System.Drawing.Size(61, 57);
            this.pbUserProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbUserProfile.TabIndex = 13;
            this.pbUserProfile.TabStop = false;
            this.pbUserProfile.Click += new System.EventHandler(this.pbUserProfile_Click);
            // 
            // btnGioiThieu
            // 
            this.btnGioiThieu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnGioiThieu.FlatAppearance.BorderSize = 0;
            this.btnGioiThieu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGioiThieu.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnGioiThieu.ForeColor = System.Drawing.Color.White;
            this.btnGioiThieu.Location = new System.Drawing.Point(3, 243);
            this.btnGioiThieu.Name = "btnGioiThieu";
            this.btnGioiThieu.Size = new System.Drawing.Size(166, 40);
            this.btnGioiThieu.TabIndex = 12;
            this.btnGioiThieu.Text = "Giới thiệu về thư viện";
            this.btnGioiThieu.UseVisualStyleBackColor = false;
            this.btnGioiThieu.Click += new System.EventHandler(this.btnGioiThieu_Click);
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
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTitle.Location = new System.Drawing.Point(21, 93);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(131, 37);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Thư Viện";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Location = new System.Drawing.Point(3, 146);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(166, 40);
            this.btnHome.TabIndex = 3;
            this.btnHome.Text = "Giá sách";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnQuanLySach
            // 
            this.btnQuanLySach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnQuanLySach.FlatAppearance.BorderSize = 0;
            this.btnQuanLySach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuanLySach.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnQuanLySach.ForeColor = System.Drawing.Color.White;
            this.btnQuanLySach.Location = new System.Drawing.Point(3, 195);
            this.btnQuanLySach.Name = "btnQuanLySach";
            this.btnQuanLySach.Size = new System.Drawing.Size(166, 40);
            this.btnQuanLySach.TabIndex = 4;
            this.btnQuanLySach.Text = "Sách Của Tôi";
            this.btnQuanLySach.UseVisualStyleBackColor = false;
            this.btnQuanLySach.Click += new System.EventHandler(this.btnQuanLySach_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýTàiKhảoToolStripMenuItem,
            this.xemThôngTinPhảnHồiToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(201, 70);
            // 
            // quảnLýTàiKhảoToolStripMenuItem
            // 
            this.quảnLýTàiKhảoToolStripMenuItem.Name = "quảnLýTàiKhảoToolStripMenuItem";
            this.quảnLýTàiKhảoToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.quảnLýTàiKhảoToolStripMenuItem.Text = "Quản lý tài khoản";
            this.quảnLýTàiKhảoToolStripMenuItem.Click += new System.EventHandler(this.quảnLýTàiKhảoToolStripMenuItem_Click);
            // 
            // xemThôngTinPhảnHồiToolStripMenuItem
            // 
            this.xemThôngTinPhảnHồiToolStripMenuItem.Name = "xemThôngTinPhảnHồiToolStripMenuItem";
            this.xemThôngTinPhảnHồiToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.xemThôngTinPhảnHồiToolStripMenuItem.Text = "Xem thông tin phản hồi";
            this.xemThôngTinPhảnHồiToolStripMenuItem.Click += new System.EventHandler(this.xemThôngTinPhảnHồiToolStripMenuItem_Click);
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // UserSidenav
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "UserSidenav";
            this.Size = new System.Drawing.Size(171, 561);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUserProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.PictureBox pbUserProfile;
        internal System.Windows.Forms.Button btnGioiThieu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTitle;
        internal System.Windows.Forms.Button btnHome;
        internal System.Windows.Forms.Button btnQuanLySach;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem quảnLýTàiKhảoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xemThôngTinPhảnHồiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        public System.Windows.Forms.Panel panel1;
    }
}
