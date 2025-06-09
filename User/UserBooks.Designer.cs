using System.Drawing;
using System.Windows.Forms;

namespace Library
{
    partial class UserBooks
    {
        private System.ComponentModel.IContainer components = null;
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserBooks));
            this.panelContent = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dgvUsersBooks = new System.Windows.Forms.DataGridView();
            this.tieu_de = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ten_tac_gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.the_loai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngay_xuat_ban = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngay_muon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noi_dung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bORROWBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userBorrowedBooksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userBorrowedBooks = new librun.userBorrowedBooks();
            this.btnReturnBooks = new System.Windows.Forms.Button();
            this.panelContentHeader = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblContentHeader = new System.Windows.Forms.Label();
            this.tbTimSach = new System.Windows.Forms.TextBox();
            this.bORROWTableAdapter = new librun.userBorrowedBooksTableAdapters.BORROWTableAdapter();
            this.userSidenav1 = new Library.UserSidenav();
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
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.Cornsilk;
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUsersBooks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUsersBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsersBooks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tieu_de,
            this.ten_tac_gia,
            this.the_loai,
            this.ngay_xuat_ban,
            this.ngay_muon,
            this.id,
            this.noi_dung});
            this.dgvUsersBooks.DataSource = this.bORROWBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUsersBooks.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvUsersBooks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUsersBooks.Location = new System.Drawing.Point(0, 0);
            this.dgvUsersBooks.Name = "dgvUsersBooks";
            this.dgvUsersBooks.ReadOnly = true;
            this.dgvUsersBooks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsersBooks.Size = new System.Drawing.Size(837, 439);
            this.dgvUsersBooks.TabIndex = 0;
            this.dgvUsersBooks.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsersBooks_CellContentDoubleClick);
            this.dgvUsersBooks.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsersBooks_CellContentDoubleClick);
            this.dgvUsersBooks.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvUsersBooks_CellFormatting);
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
            // ngay_muon
            // 
            this.ngay_muon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ngay_muon.DataPropertyName = "ngay_muon";
            this.ngay_muon.HeaderText = "Ngày mượn";
            this.ngay_muon.Name = "ngay_muon";
            this.ngay_muon.ReadOnly = true;
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
            this.btnReturnBooks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnReturnBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturnBooks.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnReturnBooks.ForeColor = System.Drawing.Color.White;
            this.btnReturnBooks.Location = new System.Drawing.Point(331, 5);
            this.btnReturnBooks.Name = "btnReturnBooks";
            this.btnReturnBooks.Size = new System.Drawing.Size(196, 51);
            this.btnReturnBooks.TabIndex = 0;
            this.btnReturnBooks.Text = "Trả sách";
            this.btnReturnBooks.UseVisualStyleBackColor = false;
            this.btnReturnBooks.Click += new System.EventHandler(this.btnReturnBooks_Click);
            // 
            // panelContentHeader
            // 
            this.panelContentHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.panelContentHeader.Controls.Add(this.label1);
            this.panelContentHeader.Controls.Add(this.lblContentHeader);
            this.panelContentHeader.Controls.Add(this.tbTimSach);
            this.panelContentHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelContentHeader.Location = new System.Drawing.Point(0, 0);
            this.panelContentHeader.Name = "panelContentHeader";
            this.panelContentHeader.Size = new System.Drawing.Size(837, 52);
            this.panelContentHeader.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(506, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tìm sách";
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
            // tbTimSach
            // 
            this.tbTimSach.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTimSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTimSach.Location = new System.Drawing.Point(589, 21);
            this.tbTimSach.Name = "tbTimSach";
            this.tbTimSach.Size = new System.Drawing.Size(236, 21);
            this.tbTimSach.TabIndex = 4;
            this.tbTimSach.TextChanged += new System.EventHandler(this.tbTimSach_TextChanged);
            // 
            // bORROWTableAdapter
            // 
            this.bORROWTableAdapter.ClearBeforeFill = true;
            // 
            // userSidenav1
            // 
            this.userSidenav1.Dock = System.Windows.Forms.DockStyle.Left;
            this.userSidenav1.Location = new System.Drawing.Point(0, 0);
            this.userSidenav1.Name = "userSidenav1";
            this.userSidenav1.Size = new System.Drawing.Size(171, 561);
            this.userSidenav1.TabIndex = 8;
            // 
            // UserBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 561);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.userSidenav1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1024, 600);
            this.Name = "UserBooks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Liberate";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UserBooks_FormClosed);
            this.Load += new System.EventHandler(this.UserBooks_Load);
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
        private SplitContainer splitContainer1;
        private DataGridView dgvUsersBooks;
        private BindingSource userBorrowedBooksBindingSource;
        private librun.userBorrowedBooks userBorrowedBooks;
        private Button btnReturnBooks;
        private DataGridViewTextBoxColumn useridDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn bookidDataGridViewTextBoxColumn;
        private BindingSource bORROWBindingSource;
        private librun.userBorrowedBooksTableAdapters.BORROWTableAdapter bORROWTableAdapter;
        private Label label1;
        private TextBox tbTimSach;
        private DataGridViewTextBoxColumn tieu_de;
        private DataGridViewTextBoxColumn ten_tac_gia;
        private DataGridViewTextBoxColumn the_loai;
        private DataGridViewTextBoxColumn ngay_xuat_ban;
        private DataGridViewTextBoxColumn ngay_muon;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn noi_dung;
        private UserSidenav userSidenav1;
    }
}
