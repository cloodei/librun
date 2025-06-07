using System.Drawing;
using System.Windows.Forms;

namespace Library
{
    partial class MainUserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainUserForm));
            this.panelContent = new System.Windows.Forms.Panel();
            this.dgvBooks = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tieudeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tentacgiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noidungDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.theloaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayxuatbanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bOOKSBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.userBooksDataSet = new librun.userBooksDataSet();
            this.panelContentHeader = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tbTimSach = new System.Windows.Forms.TextBox();
            this.lblContentHeader = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.bOOKSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.libDataSet = new librun.libDataSet();
            this.bOOKSTableAdapter = new librun.libDataSetTableAdapters.BOOKSTableAdapter();
            this.bOOKSTableAdapter2 = new librun.userBooksDataSetTableAdapters.BOOKSTableAdapter();
            this.userSidenav1 = new Library.UserSidenav();
            this.panelContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOOKSBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBooksDataSet)).BeginInit();
            this.panelContentHeader.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bOOKSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // panelContent
            // 
            this.panelContent.Controls.Add(this.dgvBooks);
            this.panelContent.Controls.Add(this.panelContentHeader);
            this.panelContent.Controls.Add(this.panel2);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(171, 0);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(837, 561);
            this.panelContent.TabIndex = 7;
            // 
            // dgvBooks
            // 
            this.dgvBooks.AllowUserToAddRows = false;
            this.dgvBooks.AllowUserToDeleteRows = false;
            this.dgvBooks.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBooks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBooks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.tieudeDataGridViewTextBoxColumn,
            this.tentacgiaDataGridViewTextBoxColumn,
            this.noidungDataGridViewTextBoxColumn,
            this.theloaiDataGridViewTextBoxColumn,
            this.ngayxuatbanDataGridViewTextBoxColumn});
            this.dgvBooks.DataSource = this.bOOKSBindingSource2;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBooks.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBooks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBooks.Location = new System.Drawing.Point(0, 52);
            this.dgvBooks.Margin = new System.Windows.Forms.Padding(2);
            this.dgvBooks.Name = "dgvBooks";
            this.dgvBooks.ReadOnly = true;
            this.dgvBooks.RowHeadersWidth = 51;
            this.dgvBooks.RowTemplate.Height = 24;
            this.dgvBooks.Size = new System.Drawing.Size(837, 451);
            this.dgvBooks.TabIndex = 4;
            this.dgvBooks.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ChonSach);
            this.dgvBooks.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBooks_CellContentClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
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
            this.tieudeDataGridViewTextBoxColumn.ReadOnly = true;
            this.tieudeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // tentacgiaDataGridViewTextBoxColumn
            // 
            this.tentacgiaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tentacgiaDataGridViewTextBoxColumn.DataPropertyName = "ten_tac_gia";
            this.tentacgiaDataGridViewTextBoxColumn.HeaderText = "Tên tác giả";
            this.tentacgiaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tentacgiaDataGridViewTextBoxColumn.Name = "tentacgiaDataGridViewTextBoxColumn";
            this.tentacgiaDataGridViewTextBoxColumn.ReadOnly = true;
            this.tentacgiaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // noidungDataGridViewTextBoxColumn
            // 
            this.noidungDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.noidungDataGridViewTextBoxColumn.DataPropertyName = "noi_dung";
            this.noidungDataGridViewTextBoxColumn.HeaderText = "Nội dung";
            this.noidungDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.noidungDataGridViewTextBoxColumn.Name = "noidungDataGridViewTextBoxColumn";
            this.noidungDataGridViewTextBoxColumn.ReadOnly = true;
            this.noidungDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // theloaiDataGridViewTextBoxColumn
            // 
            this.theloaiDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.theloaiDataGridViewTextBoxColumn.DataPropertyName = "the_loai";
            this.theloaiDataGridViewTextBoxColumn.HeaderText = "Thể loại";
            this.theloaiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.theloaiDataGridViewTextBoxColumn.Name = "theloaiDataGridViewTextBoxColumn";
            this.theloaiDataGridViewTextBoxColumn.ReadOnly = true;
            this.theloaiDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ngayxuatbanDataGridViewTextBoxColumn
            // 
            this.ngayxuatbanDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ngayxuatbanDataGridViewTextBoxColumn.DataPropertyName = "ngay_xuat_ban";
            this.ngayxuatbanDataGridViewTextBoxColumn.HeaderText = "Ngày xuất bản";
            this.ngayxuatbanDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ngayxuatbanDataGridViewTextBoxColumn.Name = "ngayxuatbanDataGridViewTextBoxColumn";
            this.ngayxuatbanDataGridViewTextBoxColumn.ReadOnly = true;
            this.ngayxuatbanDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
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
            // panelContentHeader
            // 
            this.panelContentHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.panelContentHeader.Controls.Add(this.label1);
            this.panelContentHeader.Controls.Add(this.tbTimSach);
            this.panelContentHeader.Controls.Add(this.lblContentHeader);
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
            this.label1.Location = new System.Drawing.Point(506, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tìm sách";
            // 
            // tbTimSach
            // 
            this.tbTimSach.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTimSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTimSach.Location = new System.Drawing.Point(589, 17);
            this.tbTimSach.Name = "tbTimSach";
            this.tbTimSach.Size = new System.Drawing.Size(236, 21);
            this.tbTimSach.TabIndex = 1;
            this.tbTimSach.TextChanged += new System.EventHandler(this.tbTimSach_TextChanged);
            // 
            // lblContentHeader
            // 
            this.lblContentHeader.AutoSize = true;
            this.lblContentHeader.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblContentHeader.ForeColor = System.Drawing.Color.White;
            this.lblContentHeader.Location = new System.Drawing.Point(13, 13);
            this.lblContentHeader.Name = "lblContentHeader";
            this.lblContentHeader.Size = new System.Drawing.Size(105, 30);
            this.lblContentHeader.TabIndex = 0;
            this.lblContentHeader.Text = "Kho sách";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Cornsilk;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 503);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(837, 58);
            this.panel2.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(311, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(288, 47);
            this.button1.TabIndex = 1;
            this.button1.Text = "Mượn sách";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            // bOOKSTableAdapter
            // 
            this.bOOKSTableAdapter.ClearBeforeFill = true;
            // 
            // bOOKSTableAdapter2
            // 
            this.bOOKSTableAdapter2.ClearBeforeFill = true;
            // 
            // userSidenav1
            // 
            this.userSidenav1.Dock = System.Windows.Forms.DockStyle.Left;
            this.userSidenav1.Location = new System.Drawing.Point(0, 0);
            this.userSidenav1.Name = "userSidenav1";
            this.userSidenav1.Size = new System.Drawing.Size(171, 561);
            this.userSidenav1.TabIndex = 8;
            // 
            // MainUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 561);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.userSidenav1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1024, 600);
            this.Name = "MainUserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Liberate";
            this.Load += new System.EventHandler(this.MainUserForm_Load);
            this.panelContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOOKSBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBooksDataSet)).EndInit();
            this.panelContentHeader.ResumeLayout(false);
            this.panelContentHeader.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bOOKSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libDataSet)).EndInit();
            this.ResumeLayout(false);

        }
        private librun.libDataSet libDataSet;
        private BindingSource bOOKSBindingSource;
        private librun.libDataSetTableAdapters.BOOKSTableAdapter bOOKSTableAdapter;
        private TextBox tbTimSach;
        private Panel panel2;
        private Button button1;
        private librun.userBooksDataSet userBooksDataSet;
        private BindingSource bOOKSBindingSource2;
        private librun.userBooksDataSetTableAdapters.BOOKSTableAdapter bOOKSTableAdapter2;
        private DataGridView dgvBooks;
        private Label label1;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tieudeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tentacgiaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn noidungDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn theloaiDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ngayxuatbanDataGridViewTextBoxColumn;
        private UserSidenav userSidenav1;
    }
}
