using System.Drawing;
using System.Windows.Forms;

namespace Library
{
    partial class UserBooks
    {
        private System.ComponentModel.IContainer components = null;
        internal System.Windows.Forms.Button btnHome;
        internal System.Windows.Forms.Button btnQuanLySach;
        private System.Windows.Forms.Label lblTitle;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Panel panelContent;
        private Panel panelContentHeader;
        private Label lblContentHeader;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        /// <summary>
        /// Required method for Designer support.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserBooks));
            this.btnHome = new System.Windows.Forms.Button();
            this.btnQuanLySach = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSignOut = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelContent = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dgvUsersBooks = new System.Windows.Forms.DataGridView();
            this.tieu_de = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ten_tac_gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.the_loai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngay_xuat_ban = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaymuonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noi_dung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bORROWBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userBorrowedBooksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userBorrowedBooks = new librun.userBorrowedBooks();
            this.btnReturnBooks = new System.Windows.Forms.Button();
            this.panelContentHeader = new System.Windows.Forms.Panel();
            this.lblContentHeader = new System.Windows.Forms.Label();
            this.bORROWTableAdapter = new librun.userBorrowedBooksTableAdapters.BORROWTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsersBooks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bORROWBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBorrowedBooksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBorrowedBooks)).BeginInit();
            this.panelContentHeader.SuspendLayout();
            this.SuspendLayout();
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.panel1.Controls.Add(this.btnSignOut);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Controls.Add(this.btnQuanLySach);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(171, 561);
            this.panel1.TabIndex = 4;
            // 
            // btnSignOut
            // 
            this.btnSignOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSignOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnSignOut.FlatAppearance.BorderSize = 0;
            this.btnSignOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignOut.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSignOut.ForeColor = System.Drawing.Color.White;
            this.btnSignOut.Location = new System.Drawing.Point(3, 511);
            this.btnSignOut.Name = "btnSignOut";
            this.btnSignOut.Size = new System.Drawing.Size(166, 40);
            this.btnSignOut.TabIndex = 11;
            this.btnSignOut.Text = "Đăng xuất";
            this.btnSignOut.UseVisualStyleBackColor = false;
            this.btnSignOut.Click += new System.EventHandler(this.btnSignOut_Click);
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
            // panelContent
            // 
            this.panelContent.Controls.Add(this.splitContainer1);
            this.panelContent.Controls.Add(this.panelContentHeader);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(171, 0);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(837, 561);
            this.panelContent.TabIndex = 7;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 52);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dgvUsersBooks);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.Info;
            this.splitContainer1.Panel2.Controls.Add(this.btnReturnBooks);
            this.splitContainer1.Size = new System.Drawing.Size(837, 509);
            this.splitContainer1.SplitterDistance = 439;
            this.splitContainer1.TabIndex = 1;
            // 
            // dgvUsersBooks
            // 
            this.dgvUsersBooks.AllowUserToAddRows = false;
            this.dgvUsersBooks.AllowUserToDeleteRows = false;
            this.dgvUsersBooks.AutoGenerateColumns = false;
            this.dgvUsersBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsersBooks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tieu_de,
            this.ten_tac_gia,
            this.the_loai,
            this.ngay_xuat_ban,
            this.ngaymuonDataGridViewTextBoxColumn,
            this.id,
            this.noi_dung});
            this.dgvUsersBooks.DataSource = this.bORROWBindingSource;
            this.dgvUsersBooks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUsersBooks.Location = new System.Drawing.Point(0, 0);
            this.dgvUsersBooks.Name = "dgvUsersBooks";
            this.dgvUsersBooks.ReadOnly = true;
            this.dgvUsersBooks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsersBooks.Size = new System.Drawing.Size(837, 439);
            this.dgvUsersBooks.TabIndex = 0;
            this.dgvUsersBooks.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsersBooks_CellContentDoubleClick);
            this.dgvUsersBooks.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsersBooks_CellContentDoubleClick);
            this.dgvUsersBooks.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvUsersBooks_KeyDown);
            // 
            // tieu_de
            // 
            this.tieu_de.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tieu_de.DataPropertyName = "tieu_de";
            this.tieu_de.HeaderText = "Tiêu đề sách";
            this.tieu_de.Name = "tieu_de";
            this.tieu_de.ReadOnly = true;
            // 
            // ten_tac_gia
            // 
            this.ten_tac_gia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ten_tac_gia.DataPropertyName = "ten_tac_gia";
            this.ten_tac_gia.HeaderText = "Tên tác giả";
            this.ten_tac_gia.Name = "ten_tac_gia";
            this.ten_tac_gia.ReadOnly = true;
            // 
            // the_loai
            // 
            this.the_loai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.the_loai.DataPropertyName = "the_loai";
            this.the_loai.HeaderText = "Thể loại";
            this.the_loai.Name = "the_loai";
            this.the_loai.ReadOnly = true;
            // 
            // ngay_xuat_ban
            // 
            this.ngay_xuat_ban.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ngay_xuat_ban.DataPropertyName = "ngay_xuat_ban";
            this.ngay_xuat_ban.HeaderText = "Ngày xuất bản";
            this.ngay_xuat_ban.Name = "ngay_xuat_ban";
            this.ngay_xuat_ban.ReadOnly = true;
            // 
            // ngaymuonDataGridViewTextBoxColumn
            // 
            this.ngaymuonDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ngaymuonDataGridViewTextBoxColumn.DataPropertyName = "ngay_muon";
            this.ngaymuonDataGridViewTextBoxColumn.HeaderText = "Ngày mượn";
            this.ngaymuonDataGridViewTextBoxColumn.Name = "ngaymuonDataGridViewTextBoxColumn";
            this.ngaymuonDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // noi_dung
            // 
            this.noi_dung.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.noi_dung.DataPropertyName = "noi_dung";
            this.noi_dung.HeaderText = "noi_dung";
            this.noi_dung.Name = "noi_dung";
            this.noi_dung.ReadOnly = true;
            this.noi_dung.Visible = false;
            // 
            // bORROWBindingSource
            // 
            this.bORROWBindingSource.DataMember = "BORROW";
            this.bORROWBindingSource.DataSource = this.userBorrowedBooksBindingSource;
            // 
            // userBorrowedBooksBindingSource
            // 
            this.userBorrowedBooksBindingSource.DataSource = this.userBorrowedBooks;
            this.userBorrowedBooksBindingSource.Position = 0;
            // 
            // userBorrowedBooks
            // 
            this.userBorrowedBooks.DataSetName = "userBorrowedBooks";
            this.userBorrowedBooks.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnReturnBooks
            // 
            this.btnReturnBooks.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReturnBooks.BackColor = System.Drawing.Color.Orange;
            this.btnReturnBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturnBooks.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnReturnBooks.ForeColor = System.Drawing.Color.White;
            this.btnReturnBooks.Location = new System.Drawing.Point(300, 14);
            this.btnReturnBooks.Name = "btnReturnBooks";
            this.btnReturnBooks.Size = new System.Drawing.Size(251, 40);
            this.btnReturnBooks.TabIndex = 0;
            this.btnReturnBooks.Text = "Trả sách";
            this.btnReturnBooks.UseVisualStyleBackColor = false;
            this.btnReturnBooks.Click += new System.EventHandler(this.btnReturnBooks_Click);
            // 
            // panelContentHeader
            // 
            this.panelContentHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.panelContentHeader.Controls.Add(this.lblContentHeader);
            this.panelContentHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelContentHeader.Location = new System.Drawing.Point(0, 0);
            this.panelContentHeader.Name = "panelContentHeader";
            this.panelContentHeader.Size = new System.Drawing.Size(837, 52);
            this.panelContentHeader.TabIndex = 0;
            // 
            // lblContentHeader
            // 
            this.lblContentHeader.AutoSize = true;
            this.lblContentHeader.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblContentHeader.ForeColor = System.Drawing.Color.White;
            this.lblContentHeader.Location = new System.Drawing.Point(13, 13);
            this.lblContentHeader.Name = "lblContentHeader";
            this.lblContentHeader.Size = new System.Drawing.Size(161, 30);
            this.lblContentHeader.TabIndex = 0;
            this.lblContentHeader.Text = "Sách đã mượn";
            // 
            // bORROWTableAdapter
            // 
            this.bORROWTableAdapter.ClearBeforeFill = true;
            // 
            // UserBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 561);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1024, 600);
            this.Name = "UserBooks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Liberate";
            this.Load += new System.EventHandler(this.UserBooks_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelContent.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsersBooks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bORROWBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBorrowedBooksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBorrowedBooks)).EndInit();
            this.panelContentHeader.ResumeLayout(false);
            this.panelContentHeader.PerformLayout();
            this.ResumeLayout(false);

        }
        internal Button btnSignOut;
        private SplitContainer splitContainer1;
        private DataGridView dgvUsersBooks;
        private BindingSource userBorrowedBooksBindingSource;
        private librun.userBorrowedBooks userBorrowedBooks;
        private Button btnReturnBooks;
        private DataGridViewTextBoxColumn useridDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn bookidDataGridViewTextBoxColumn;
        private BindingSource bORROWBindingSource;
        private librun.userBorrowedBooksTableAdapters.BORROWTableAdapter bORROWTableAdapter;
        private DataGridViewTextBoxColumn tieu_de;
        private DataGridViewTextBoxColumn ten_tac_gia;
        private DataGridViewTextBoxColumn the_loai;
        private DataGridViewTextBoxColumn ngay_xuat_ban;
        private DataGridViewTextBoxColumn ngaymuonDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn noi_dung;
    }
}
