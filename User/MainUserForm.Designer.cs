using System.Drawing;
using System.Windows.Forms;

namespace Library
{
    partial class MainUserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainUserForm));
            this.bOOKSBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.userBooksDataSet = new librun.userBooksDataSet();
            this.bOOKSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.libDataSet = new librun.libDataSet();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnQuanLySach = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSignOut = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelContent = new System.Windows.Forms.Panel();
            this.dgvBooks = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tieudeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tentacgiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noidungDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.theloaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayxuatbanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panelContentHeader = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.tbTimSach = new System.Windows.Forms.TextBox();
            this.lblContentHeader = new System.Windows.Forms.Label();
            this.bOOKSTableAdapter = new librun.libDataSetTableAdapters.BOOKSTableAdapter();
            this.bOOKSTableAdapter2 = new librun.userBooksDataSetTableAdapters.BOOKSTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bOOKSBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBooksDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOOKSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).BeginInit();
            this.panel2.SuspendLayout();
            this.panelContentHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // bOOKSBindingSource2
            // 
            this.bOOKSBindingSource2.DataMember = "BOOKS";
            this.bOOKSBindingSource2.DataSource = this.userBooksDataSet;
            // 
            // userBooksDataSet
            // 
            this.userBooksDataSet.DataSetName = "userBooksDataSet";
            this.userBooksDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bOOKSBindingSource
            // 
            this.bOOKSBindingSource.DataMember = "BOOKS";
            this.bOOKSBindingSource.DataSource = this.libDataSet;
            // 
            // libDataSet
            // 
            this.libDataSet.DataSetName = "libDataSet";
            this.libDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Location = new System.Drawing.Point(4, 180);
            this.btnHome.Margin = new System.Windows.Forms.Padding(4);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(221, 49);
            this.btnHome.TabIndex = 3;
            this.btnHome.Text = "Giá sách";
            this.btnHome.UseVisualStyleBackColor = false;
            // 
            // btnQuanLySach
            // 
            this.btnQuanLySach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnQuanLySach.FlatAppearance.BorderSize = 0;
            this.btnQuanLySach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuanLySach.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnQuanLySach.ForeColor = System.Drawing.Color.White;
            this.btnQuanLySach.Location = new System.Drawing.Point(4, 240);
            this.btnQuanLySach.Margin = new System.Windows.Forms.Padding(4);
            this.btnQuanLySach.Name = "btnQuanLySach";
            this.btnQuanLySach.Size = new System.Drawing.Size(221, 49);
            this.btnQuanLySach.TabIndex = 4;
            this.btnQuanLySach.Text = "Sách Của Tôi";
            this.btnQuanLySach.UseVisualStyleBackColor = false;
            this.btnQuanLySach.Click += new System.EventHandler(this.btnQuanLySach_Click_1);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTitle.Location = new System.Drawing.Point(28, 114);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(164, 46);
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
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(228, 619);
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
            this.btnSignOut.Location = new System.Drawing.Point(4, 558);
            this.btnSignOut.Margin = new System.Windows.Forms.Padding(4);
            this.btnSignOut.Name = "btnSignOut";
            this.btnSignOut.Size = new System.Drawing.Size(221, 49);
            this.btnSignOut.TabIndex = 10;
            this.btnSignOut.Text = "Đăng xuất";
            this.btnSignOut.UseVisualStyleBackColor = false;
            this.btnSignOut.Click += new System.EventHandler(this.btnSignOut_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(4, 12);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(219, 98);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // panelContent
            // 
            this.panelContent.Controls.Add(this.dgvBooks);
            this.panelContent.Controls.Add(this.panel2);
            this.panelContent.Controls.Add(this.panelContentHeader);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(228, 0);
            this.panelContent.Margin = new System.Windows.Forms.Padding(4);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(985, 619);
            this.panelContent.TabIndex = 7;
            // 
            // dgvBooks
            // 
            this.dgvBooks.AllowUserToAddRows = false;
            this.dgvBooks.AutoGenerateColumns = false;
            this.dgvBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBooks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.tieudeDataGridViewTextBoxColumn,
            this.tentacgiaDataGridViewTextBoxColumn,
            this.noidungDataGridViewTextBoxColumn,
            this.theloaiDataGridViewTextBoxColumn,
            this.ngayxuatbanDataGridViewTextBoxColumn});
            this.dgvBooks.DataSource = this.bOOKSBindingSource2;
            this.dgvBooks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBooks.Location = new System.Drawing.Point(0, 64);
            this.dgvBooks.Name = "dgvBooks";
            this.dgvBooks.RowHeadersWidth = 51;
            this.dgvBooks.RowTemplate.Height = 24;
            this.dgvBooks.Size = new System.Drawing.Size(985, 484);
            this.dgvBooks.TabIndex = 4;
            this.dgvBooks.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ChonSach);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // tieudeDataGridViewTextBoxColumn
            // 
            this.tieudeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tieudeDataGridViewTextBoxColumn.DataPropertyName = "tieu_de";
            this.tieudeDataGridViewTextBoxColumn.HeaderText = "Tiêu đề";
            this.tieudeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tieudeDataGridViewTextBoxColumn.Name = "tieudeDataGridViewTextBoxColumn";
            // 
            // tentacgiaDataGridViewTextBoxColumn
            // 
            this.tentacgiaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tentacgiaDataGridViewTextBoxColumn.DataPropertyName = "ten_tac_gia";
            this.tentacgiaDataGridViewTextBoxColumn.HeaderText = "Tên tác giả";
            this.tentacgiaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tentacgiaDataGridViewTextBoxColumn.Name = "tentacgiaDataGridViewTextBoxColumn";
            // 
            // noidungDataGridViewTextBoxColumn
            // 
            this.noidungDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.noidungDataGridViewTextBoxColumn.DataPropertyName = "noi_dung";
            this.noidungDataGridViewTextBoxColumn.HeaderText = "Nội dung";
            this.noidungDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.noidungDataGridViewTextBoxColumn.Name = "noidungDataGridViewTextBoxColumn";
            // 
            // theloaiDataGridViewTextBoxColumn
            // 
            this.theloaiDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.theloaiDataGridViewTextBoxColumn.DataPropertyName = "the_loai";
            this.theloaiDataGridViewTextBoxColumn.HeaderText = "Thể loại";
            this.theloaiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.theloaiDataGridViewTextBoxColumn.Name = "theloaiDataGridViewTextBoxColumn";
            // 
            // ngayxuatbanDataGridViewTextBoxColumn
            // 
            this.ngayxuatbanDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ngayxuatbanDataGridViewTextBoxColumn.DataPropertyName = "ngay_xuat_ban";
            this.ngayxuatbanDataGridViewTextBoxColumn.HeaderText = "Ngày xuất bản";
            this.ngayxuatbanDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ngayxuatbanDataGridViewTextBoxColumn.Name = "ngayxuatbanDataGridViewTextBoxColumn";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 548);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(985, 71);
            this.panel2.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(780, 10);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(201, 58);
            this.button1.TabIndex = 1;
            this.button1.Text = "Mượn";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelContentHeader
            // 
            this.panelContentHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.panelContentHeader.Controls.Add(this.button2);
            this.panelContentHeader.Controls.Add(this.tbTimSach);
            this.panelContentHeader.Controls.Add(this.lblContentHeader);
            this.panelContentHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelContentHeader.Location = new System.Drawing.Point(0, 0);
            this.panelContentHeader.Margin = new System.Windows.Forms.Padding(4);
            this.panelContentHeader.Name = "panelContentHeader";
            this.panelContentHeader.Size = new System.Drawing.Size(985, 64);
            this.panelContentHeader.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(836, 20);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(133, 28);
            this.button2.TabIndex = 2;
            this.button2.Text = "Tìm sách";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Enter += new System.EventHandler(this.TimSach);
            // 
            // tbTimSach
            // 
            this.tbTimSach.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTimSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTimSach.Location = new System.Drawing.Point(560, 21);
            this.tbTimSach.Margin = new System.Windows.Forms.Padding(4);
            this.tbTimSach.Name = "tbTimSach";
            this.tbTimSach.Size = new System.Drawing.Size(265, 24);
            this.tbTimSach.TabIndex = 1;
            this.tbTimSach.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NhanEnter);
            // 
            // lblContentHeader
            // 
            this.lblContentHeader.AutoSize = true;
            this.lblContentHeader.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblContentHeader.ForeColor = System.Drawing.Color.White;
            this.lblContentHeader.Location = new System.Drawing.Point(17, 16);
            this.lblContentHeader.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblContentHeader.Name = "lblContentHeader";
            this.lblContentHeader.Size = new System.Drawing.Size(131, 37);
            this.lblContentHeader.TabIndex = 0;
            this.lblContentHeader.Text = "Kho sách";
            // 
            // bOOKSTableAdapter
            // 
            this.bOOKSTableAdapter.ClearBeforeFill = true;
            // 
            // bOOKSTableAdapter2
            // 
            this.bOOKSTableAdapter2.ClearBeforeFill = true;
            // 
            // MainUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1213, 619);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1167, 580);
            this.Name = "MainUserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Liberate";
            this.Load += new System.EventHandler(this.MainUserForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bOOKSBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBooksDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOOKSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panelContentHeader.ResumeLayout(false);
            this.panelContentHeader.PerformLayout();
            this.ResumeLayout(false);

        }
        internal Button btnSignOut;
        private librun.libDataSet libDataSet;
        private BindingSource bOOKSBindingSource;
        private librun.libDataSetTableAdapters.BOOKSTableAdapter bOOKSTableAdapter;
        private TextBox tbTimSach;
        private Panel panel2;
        private Button button1;
        private Button button2;
        private librun.userBooksDataSet userBooksDataSet;
        private BindingSource bOOKSBindingSource2;
        private librun.userBooksDataSetTableAdapters.BOOKSTableAdapter bOOKSTableAdapter2;
        private DataGridView dgvBooks;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tieudeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tentacgiaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn noidungDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn theloaiDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ngayxuatbanDataGridViewTextBoxColumn;
    }
}
