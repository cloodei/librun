using System.Drawing;
using System.Windows.Forms;

namespace Library
{
    partial class BorrowRequests
    {
        private System.ComponentModel.IContainer components = null;

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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BorrowRequests));
            this.panelContent = new System.Windows.Forms.Panel();
            this.splitContainerDetails = new System.Windows.Forms.SplitContainer();
            this.dgvBorrowedBooks = new System.Windows.Forms.DataGridView();
            this.ten_user = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.user_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ten_sach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.book_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaymuonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bORROWBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.adminBorrowDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.adminBorrowDataSet = new librun.adminBorrowDataSet();
            this.lblBorrowDate = new System.Windows.Forms.Label();
            this.dtpBorrowDate = new System.Windows.Forms.DateTimePicker();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.panelContentHeader = new System.Windows.Forms.Panel();
            this.lblContentHeader = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSignOut = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnYeuCauMuonSach = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnQuanLySach = new System.Windows.Forms.Button();
            this.btnQuanLyNguoiDung = new System.Windows.Forms.Button();
            this.bORROWTableAdapter = new librun.adminBorrowDataSetTableAdapters.BORROWTableAdapter();
            this.panelContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerDetails)).BeginInit();
            this.splitContainerDetails.Panel1.SuspendLayout();
            this.splitContainerDetails.Panel2.SuspendLayout();
            this.splitContainerDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorrowedBooks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bORROWBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminBorrowDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminBorrowDataSet)).BeginInit();
            this.panelContentHeader.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelContent
            // 
            this.panelContent.Controls.Add(this.splitContainerDetails);
            this.panelContent.Controls.Add(this.panelContentHeader);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(171, 0);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(837, 561);
            this.panelContent.TabIndex = 9;
            // 
            // splitContainerDetails
            // 
            this.splitContainerDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerDetails.Location = new System.Drawing.Point(0, 52);
            this.splitContainerDetails.Name = "splitContainerDetails";
            this.splitContainerDetails.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerDetails.Panel1
            // 
            this.splitContainerDetails.Panel1.Controls.Add(this.dgvBorrowedBooks);
            // 
            // splitContainerDetails.Panel2
            // 
            this.splitContainerDetails.Panel2.BackColor = System.Drawing.Color.Cornsilk;
            this.splitContainerDetails.Panel2.Controls.Add(this.lblBorrowDate);
            this.splitContainerDetails.Panel2.Controls.Add(this.dtpBorrowDate);
            this.splitContainerDetails.Panel2.Controls.Add(this.btnUpdate);
            this.splitContainerDetails.Size = new System.Drawing.Size(837, 509);
            this.splitContainerDetails.SplitterDistance = 347;
            this.splitContainerDetails.TabIndex = 1;
            // 
            // dgvBorrowedBooks
            // 
            this.dgvBorrowedBooks.AllowUserToAddRows = false;
            this.dgvBorrowedBooks.AllowUserToDeleteRows = false;
            this.dgvBorrowedBooks.AutoGenerateColumns = false;
            this.dgvBorrowedBooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBorrowedBooks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBorrowedBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBorrowedBooks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ten_user,
            this.user_id,
            this.ten_sach,
            this.book_id,
            this.ngaymuonDataGridViewTextBoxColumn});
            this.dgvBorrowedBooks.DataSource = this.bORROWBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBorrowedBooks.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBorrowedBooks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBorrowedBooks.Location = new System.Drawing.Point(0, 0);
            this.dgvBorrowedBooks.MultiSelect = false;
            this.dgvBorrowedBooks.Name = "dgvBorrowedBooks";
            this.dgvBorrowedBooks.ReadOnly = true;
            this.dgvBorrowedBooks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBorrowedBooks.Size = new System.Drawing.Size(837, 347);
            this.dgvBorrowedBooks.TabIndex = 0;
            this.dgvBorrowedBooks.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBorrowedBooks_CellClick);
            // 
            // ten_user
            // 
            this.ten_user.DataPropertyName = "ten_user";
            this.ten_user.HeaderText = "Tên người dùng";
            this.ten_user.Name = "ten_user";
            this.ten_user.ReadOnly = true;
            // 
            // user_id
            // 
            this.user_id.DataPropertyName = "user_id";
            this.user_id.HeaderText = "user_id";
            this.user_id.Name = "user_id";
            this.user_id.ReadOnly = true;
            this.user_id.Visible = false;
            // 
            // ten_sach
            // 
            this.ten_sach.DataPropertyName = "ten_sach";
            this.ten_sach.HeaderText = "Tên sách";
            this.ten_sach.Name = "ten_sach";
            this.ten_sach.ReadOnly = true;
            // 
            // book_id
            // 
            this.book_id.DataPropertyName = "book_id";
            this.book_id.HeaderText = "book_id";
            this.book_id.Name = "book_id";
            this.book_id.ReadOnly = true;
            this.book_id.Visible = false;
            // 
            // ngaymuonDataGridViewTextBoxColumn
            // 
            this.ngaymuonDataGridViewTextBoxColumn.DataPropertyName = "ngay_muon";
            this.ngaymuonDataGridViewTextBoxColumn.HeaderText = "Ngày mượn";
            this.ngaymuonDataGridViewTextBoxColumn.Name = "ngaymuonDataGridViewTextBoxColumn";
            this.ngaymuonDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bORROWBindingSource
            // 
            this.bORROWBindingSource.DataMember = "BORROW";
            this.bORROWBindingSource.DataSource = this.adminBorrowDataSetBindingSource;
            // 
            // adminBorrowDataSetBindingSource
            // 
            this.adminBorrowDataSetBindingSource.DataSource = this.adminBorrowDataSet;
            this.adminBorrowDataSetBindingSource.Position = 0;
            // 
            // adminBorrowDataSet
            // 
            this.adminBorrowDataSet.DataSetName = "adminBorrowDataSet";
            this.adminBorrowDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblBorrowDate
            // 
            this.lblBorrowDate.AutoSize = true;
            this.lblBorrowDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBorrowDate.Location = new System.Drawing.Point(14, 28);
            this.lblBorrowDate.Name = "lblBorrowDate";
            this.lblBorrowDate.Size = new System.Drawing.Size(93, 20);
            this.lblBorrowDate.TabIndex = 5;
            this.lblBorrowDate.Text = "Ngày mượn:";
            // 
            // dtpBorrowDate
            // 
            this.dtpBorrowDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpBorrowDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBorrowDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBorrowDate.Location = new System.Drawing.Point(113, 23);
            this.dtpBorrowDate.Name = "dtpBorrowDate";
            this.dtpBorrowDate.Size = new System.Drawing.Size(561, 26);
            this.dtpBorrowDate.TabIndex = 6;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(694, 12);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(130, 50);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
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
            this.lblContentHeader.Size = new System.Drawing.Size(109, 30);
            this.lblContentHeader.TabIndex = 0;
            this.lblContentHeader.Text = "Thống kê";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.panel1.Controls.Add(this.btnSignOut);
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Controls.Add(this.btnYeuCauMuonSach);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnQuanLySach);
            this.panel1.Controls.Add(this.btnQuanLyNguoiDung);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(171, 561);
            this.panel1.TabIndex = 8;
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
            // btnYeuCauMuonSach
            // 
            this.btnYeuCauMuonSach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnYeuCauMuonSach.FlatAppearance.BorderSize = 0;
            this.btnYeuCauMuonSach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYeuCauMuonSach.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnYeuCauMuonSach.ForeColor = System.Drawing.Color.White;
            this.btnYeuCauMuonSach.Location = new System.Drawing.Point(2, 149);
            this.btnYeuCauMuonSach.Name = "btnYeuCauMuonSach";
            this.btnYeuCauMuonSach.Size = new System.Drawing.Size(166, 51);
            this.btnYeuCauMuonSach.TabIndex = 7;
            this.btnYeuCauMuonSach.Text = "Thống kê thông tin mượn/trả sách";
            this.btnYeuCauMuonSach.UseVisualStyleBackColor = false;
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
            this.btnQuanLySach.Click += new System.EventHandler(this.btnQuanLySach_Click_1);
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
            // bORROWTableAdapter
            // 
            this.bORROWTableAdapter.ClearBeforeFill = true;
            // 
            // BorrowRequests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 561);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1024, 600);
            this.Name = "BorrowRequests";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Liberate";
            this.Load += new System.EventHandler(this.BorrowRequests_Load);
            this.panelContent.ResumeLayout(false);
            this.splitContainerDetails.Panel1.ResumeLayout(false);
            this.splitContainerDetails.Panel2.ResumeLayout(false);
            this.splitContainerDetails.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerDetails)).EndInit();
            this.splitContainerDetails.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorrowedBooks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bORROWBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminBorrowDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminBorrowDataSet)).EndInit();
            this.panelContentHeader.ResumeLayout(false);
            this.panelContentHeader.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }
        private Panel panelContent;
        private Panel panelContentHeader;
        private Label lblContentHeader;
        private Panel panel1;
        internal Button btnSignOut;
        private Label lblTitle;
        internal Button btnYeuCauMuonSach;
        private PictureBox pictureBox1;
        internal Button btnQuanLySach;
        internal Button btnQuanLyNguoiDung;
        private SplitContainer splitContainerDetails;
        private DataGridView dgvBorrowedBooks;
        private Label lblBorrowDate;
        private DateTimePicker dtpBorrowDate;
        private Button btnUpdate;
        private librun.adminBorrowDataSet adminBorrowDataSet;
        private BindingSource adminBorrowDataSetBindingSource;
        private BindingSource bORROWBindingSource;
        private librun.adminBorrowDataSetTableAdapters.BORROWTableAdapter bORROWTableAdapter;
        private DataGridViewTextBoxColumn ten_user;
        private DataGridViewTextBoxColumn user_id;
        private DataGridViewTextBoxColumn ten_sach;
        private DataGridViewTextBoxColumn book_id;
        private DataGridViewTextBoxColumn ngaymuonDataGridViewTextBoxColumn;
    }
}
