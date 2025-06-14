using System.Drawing;
using System.Windows.Forms;

namespace Library
{
    partial class Users
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Users));
            this.panelContent = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dgv_quan_ly_nguoi_dung = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_ten = new System.Windows.Forms.TextBox();
            this.lbl_email = new System.Windows.Forms.Label();
            this.lbl_ten = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.cbb_trang_thai = new System.Windows.Forms.ComboBox();
            this.txt_mat_khau = new System.Windows.Forms.TextBox();
            this.lbl_trang_thai = new System.Windows.Forms.Label();
            this.lbl_mat_khau = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.txt_tim_kiem = new System.Windows.Forms.TextBox();
            this.lbl_tim_kiem = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.lbl_loc_trang_thai = new System.Windows.Forms.Label();
            this.cbb_loc = new System.Windows.Forms.ComboBox();
            this.panelContentHeader = new System.Windows.Forms.Panel();
            this.lblContentHeader = new System.Windows.Forms.Label();
            this.adminSidenav1 = new Library.AdminSidenav();
            this.panelContent.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_quan_ly_nguoi_dung)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panelContentHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelContent
            // 
            this.panelContent.Controls.Add(this.panel2);
            this.panelContent.Controls.Add(this.panelContentHeader);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(171, 0);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(836, 561);
            this.panelContent.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.splitContainer1);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 52);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(836, 509);
            this.panel2.TabIndex = 1;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 66);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dgv_quan_ly_nguoi_dung);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer1.Size = new System.Drawing.Size(836, 443);
            this.splitContainer1.SplitterDistance = 271;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 2;
            // 
            // dgv_quan_ly_nguoi_dung
            // 
            this.dgv_quan_ly_nguoi_dung.AllowUserToAddRows = false;
            this.dgv_quan_ly_nguoi_dung.AllowUserToDeleteRows = false;
            this.dgv_quan_ly_nguoi_dung.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_quan_ly_nguoi_dung.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_quan_ly_nguoi_dung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_quan_ly_nguoi_dung.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_quan_ly_nguoi_dung.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_quan_ly_nguoi_dung.Location = new System.Drawing.Point(0, 0);
            this.dgv_quan_ly_nguoi_dung.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_quan_ly_nguoi_dung.Name = "dgv_quan_ly_nguoi_dung";
            this.dgv_quan_ly_nguoi_dung.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_quan_ly_nguoi_dung.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_quan_ly_nguoi_dung.RowHeadersWidth = 51;
            this.dgv_quan_ly_nguoi_dung.RowTemplate.Height = 24;
            this.dgv_quan_ly_nguoi_dung.Size = new System.Drawing.Size(836, 271);
            this.dgv_quan_ly_nguoi_dung.TabIndex = 0;
            this.dgv_quan_ly_nguoi_dung.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_quan_ly_nguoi_dung_CellClick);
            this.dgv_quan_ly_nguoi_dung.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_quan_ly_nguoi_dung_CellDoubleClick);
            this.dgv_quan_ly_nguoi_dung.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgv_quan_ly_nguoi_dung_CellFormatting);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Cornsilk;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.69843F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.30157F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 230F));
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel5, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel6, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(836, 169);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Cornsilk;
            this.panel3.Controls.Add(this.txt_email);
            this.panel3.Controls.Add(this.txt_ten);
            this.panel3.Controls.Add(this.lbl_email);
            this.panel3.Controls.Add(this.lbl_ten);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(2, 2);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(297, 165);
            this.panel3.TabIndex = 0;
            // 
            // txt_email
            // 
            this.txt_email.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_email.Location = new System.Drawing.Point(82, 80);
            this.txt_email.Margin = new System.Windows.Forms.Padding(2);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(202, 23);
            this.txt_email.TabIndex = 3;
            // 
            // txt_ten
            // 
            this.txt_ten.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_ten.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ten.Location = new System.Drawing.Point(82, 29);
            this.txt_ten.Margin = new System.Windows.Forms.Padding(2);
            this.txt_ten.Name = "txt_ten";
            this.txt_ten.Size = new System.Drawing.Size(202, 23);
            this.txt_ten.TabIndex = 2;
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_email.Location = new System.Drawing.Point(20, 85);
            this.lbl_email.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(49, 18);
            this.lbl_email.TabIndex = 1;
            this.lbl_email.Text = "Email:";
            // 
            // lbl_ten
            // 
            this.lbl_ten.AutoSize = true;
            this.lbl_ten.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ten.Location = new System.Drawing.Point(28, 34);
            this.lbl_ten.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_ten.Name = "lbl_ten";
            this.lbl_ten.Size = new System.Drawing.Size(37, 18);
            this.lbl_ten.TabIndex = 0;
            this.lbl_ten.Text = "Tên:";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Cornsilk;
            this.panel5.Controls.Add(this.cbb_trang_thai);
            this.panel5.Controls.Add(this.txt_mat_khau);
            this.panel5.Controls.Add(this.lbl_trang_thai);
            this.panel5.Controls.Add(this.lbl_mat_khau);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(303, 2);
            this.panel5.Margin = new System.Windows.Forms.Padding(2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(300, 165);
            this.panel5.TabIndex = 1;
            // 
            // cbb_trang_thai
            // 
            this.cbb_trang_thai.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbb_trang_thai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_trang_thai.FormattingEnabled = true;
            this.cbb_trang_thai.Items.AddRange(new object[] {
            "Hoạt động",
            "Khóa"});
            this.cbb_trang_thai.Location = new System.Drawing.Point(98, 82);
            this.cbb_trang_thai.Margin = new System.Windows.Forms.Padding(2);
            this.cbb_trang_thai.Name = "cbb_trang_thai";
            this.cbb_trang_thai.Size = new System.Drawing.Size(200, 25);
            this.cbb_trang_thai.TabIndex = 5;
            // 
            // txt_mat_khau
            // 
            this.txt_mat_khau.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_mat_khau.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mat_khau.Location = new System.Drawing.Point(97, 29);
            this.txt_mat_khau.Margin = new System.Windows.Forms.Padding(2);
            this.txt_mat_khau.Name = "txt_mat_khau";
            this.txt_mat_khau.Size = new System.Drawing.Size(200, 23);
            this.txt_mat_khau.TabIndex = 4;
            // 
            // lbl_trang_thai
            // 
            this.lbl_trang_thai.AutoSize = true;
            this.lbl_trang_thai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_trang_thai.Location = new System.Drawing.Point(14, 87);
            this.lbl_trang_thai.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_trang_thai.Name = "lbl_trang_thai";
            this.lbl_trang_thai.Size = new System.Drawing.Size(77, 18);
            this.lbl_trang_thai.TabIndex = 1;
            this.lbl_trang_thai.Text = "Trạng thái:";
            // 
            // lbl_mat_khau
            // 
            this.lbl_mat_khau.AutoSize = true;
            this.lbl_mat_khau.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mat_khau.Location = new System.Drawing.Point(20, 34);
            this.lbl_mat_khau.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_mat_khau.Name = "lbl_mat_khau";
            this.lbl_mat_khau.Size = new System.Drawing.Size(73, 18);
            this.lbl_mat_khau.TabIndex = 0;
            this.lbl_mat_khau.Text = "Mật khẩu:";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Cornsilk;
            this.panel6.Controls.Add(this.btn_xoa);
            this.panel6.Controls.Add(this.btn_sua);
            this.panel6.Controls.Add(this.btn_them);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(607, 2);
            this.panel6.Margin = new System.Windows.Forms.Padding(2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(227, 165);
            this.panel6.TabIndex = 2;
            // 
            // btn_xoa
            // 
            this.btn_xoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btn_xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_xoa.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa.ForeColor = System.Drawing.Color.White;
            this.btn_xoa.Location = new System.Drawing.Point(60, 110);
            this.btn_xoa.Margin = new System.Windows.Forms.Padding(2);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(95, 34);
            this.btn_xoa.TabIndex = 2;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = false;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btn_sua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sua.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sua.ForeColor = System.Drawing.Color.White;
            this.btn_sua.Location = new System.Drawing.Point(60, 60);
            this.btn_sua.Margin = new System.Windows.Forms.Padding(2);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(95, 34);
            this.btn_sua.TabIndex = 1;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = false;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_them
            // 
            this.btn_them.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btn_them.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_them.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_them.ForeColor = System.Drawing.Color.White;
            this.btn_them.Location = new System.Drawing.Point(60, 11);
            this.btn_them.Margin = new System.Windows.Forms.Padding(2);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(95, 34);
            this.btn_them.TabIndex = 0;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = false;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Cornsilk;
            this.panel4.Controls.Add(this.tableLayoutPanel2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(836, 66);
            this.panel4.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.07177F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.92823F));
            this.tableLayoutPanel2.Controls.Add(this.panel7, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel8, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(836, 66);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.txt_tim_kiem);
            this.panel7.Controls.Add(this.lbl_tim_kiem);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(3, 3);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(538, 60);
            this.panel7.TabIndex = 0;
            // 
            // txt_tim_kiem
            // 
            this.txt_tim_kiem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_tim_kiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tim_kiem.Location = new System.Drawing.Point(145, 13);
            this.txt_tim_kiem.Margin = new System.Windows.Forms.Padding(2);
            this.txt_tim_kiem.Name = "txt_tim_kiem";
            this.txt_tim_kiem.Size = new System.Drawing.Size(342, 23);
            this.txt_tim_kiem.TabIndex = 7;
            this.txt_tim_kiem.TextChanged += new System.EventHandler(this.txt_tim_kiem_TextChanged);
            // 
            // lbl_tim_kiem
            // 
            this.lbl_tim_kiem.AutoSize = true;
            this.lbl_tim_kiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tim_kiem.Location = new System.Drawing.Point(58, 18);
            this.lbl_tim_kiem.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_tim_kiem.Name = "lbl_tim_kiem";
            this.lbl_tim_kiem.Size = new System.Drawing.Size(73, 18);
            this.lbl_tim_kiem.TabIndex = 8;
            this.lbl_tim_kiem.Text = "Tìm kiếm:";
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.lbl_loc_trang_thai);
            this.panel8.Controls.Add(this.cbb_loc);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(547, 3);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(286, 60);
            this.panel8.TabIndex = 1;
            // 
            // lbl_loc_trang_thai
            // 
            this.lbl_loc_trang_thai.AutoSize = true;
            this.lbl_loc_trang_thai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_loc_trang_thai.Location = new System.Drawing.Point(28, 16);
            this.lbl_loc_trang_thai.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_loc_trang_thai.Name = "lbl_loc_trang_thai";
            this.lbl_loc_trang_thai.Size = new System.Drawing.Size(101, 18);
            this.lbl_loc_trang_thai.TabIndex = 10;
            this.lbl_loc_trang_thai.Text = "Lọc trạng thái:";
            // 
            // cbb_loc
            // 
            this.cbb_loc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbb_loc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_loc.FormattingEnabled = true;
            this.cbb_loc.Items.AddRange(new object[] {
            "Tất cả",
            "Hoạt động",
            "Khóa"});
            this.cbb_loc.Location = new System.Drawing.Point(133, 13);
            this.cbb_loc.Margin = new System.Windows.Forms.Padding(2);
            this.cbb_loc.Name = "cbb_loc";
            this.cbb_loc.Size = new System.Drawing.Size(92, 25);
            this.cbb_loc.TabIndex = 9;
            this.cbb_loc.Text = "Tất cả";
            this.cbb_loc.SelectedIndexChanged += new System.EventHandler(this.cbb_loc_SelectedIndexChanged);
            // 
            // panelContentHeader
            // 
            this.panelContentHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.panelContentHeader.Controls.Add(this.lblContentHeader);
            this.panelContentHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelContentHeader.Location = new System.Drawing.Point(0, 0);
            this.panelContentHeader.Name = "panelContentHeader";
            this.panelContentHeader.Size = new System.Drawing.Size(836, 52);
            this.panelContentHeader.TabIndex = 0;
            // 
            // lblContentHeader
            // 
            this.lblContentHeader.AutoSize = true;
            this.lblContentHeader.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblContentHeader.ForeColor = System.Drawing.Color.White;
            this.lblContentHeader.Location = new System.Drawing.Point(13, 13);
            this.lblContentHeader.Name = "lblContentHeader";
            this.lblContentHeader.Size = new System.Drawing.Size(220, 30);
            this.lblContentHeader.TabIndex = 0;
            this.lblContentHeader.Text = "Quản lý người dùng";
            // 
            // adminSidenav1
            // 
            this.adminSidenav1.Dock = System.Windows.Forms.DockStyle.Left;
            this.adminSidenav1.Location = new System.Drawing.Point(0, 0);
            this.adminSidenav1.Name = "adminSidenav1";
            this.adminSidenav1.Size = new System.Drawing.Size(171, 561);
            this.adminSidenav1.TabIndex = 10;
            // 
            // Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 561);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.adminSidenav1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1022, 588);
            this.Name = "Users";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý người dùng";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Users_FormClosed);
            this.Load += new System.EventHandler(this.Users_Load);
            this.panelContent.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_quan_ly_nguoi_dung)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panelContentHeader.ResumeLayout(false);
            this.panelContentHeader.PerformLayout();
            this.ResumeLayout(false);

        }
        private Panel panelContent;
        private Panel panelContentHeader;
        private Label lblContentHeader;
        private Panel panel2;
        private SplitContainer splitContainer1;
        private DataGridView dgv_quan_ly_nguoi_dung;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel3;
        private Label lbl_email;
        private Label lbl_ten;
        private Panel panel5;
        private Label lbl_trang_thai;
        private Label lbl_mat_khau;
        private Panel panel6;
        private TextBox txt_email;
        private TextBox txt_ten;
        private ComboBox cbb_trang_thai;
        private TextBox txt_mat_khau;
        private Button btn_them;
        private Button btn_xoa;
        private Button btn_sua;
        private Panel panel4;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel7;
        private TextBox txt_tim_kiem;
        private Label lbl_tim_kiem;
        private Panel panel8;
        private Label lbl_loc_trang_thai;
        private ComboBox cbb_loc;
        private AdminSidenav adminSidenav1;
    }
}
