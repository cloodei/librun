using System.Drawing;
using System.Windows.Forms;

namespace Library
{
    partial class Replies
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Replies));
            this.panelContent = new System.Windows.Forms.Panel();
            this.dgv_phan_hoi = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbb_loc_trang_thai = new System.Windows.Forms.ComboBox();
            this.lbl_loc_theo_trang_thai = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cbb_loc_muc_do = new System.Windows.Forms.ComboBox();
            this.lbl_loc_theo_muc_do = new System.Windows.Forms.Label();
            this.panelContentHeader = new System.Windows.Forms.Panel();
            this.lblContentHeader = new System.Windows.Forms.Label();
            this.adminSidenav1 = new Library.AdminSidenav();
            this.panelContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_phan_hoi)).BeginInit();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panelContentHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelContent
            // 
            this.panelContent.Controls.Add(this.dgv_phan_hoi);
            this.panelContent.Controls.Add(this.panel1);
            this.panelContent.Controls.Add(this.panelContentHeader);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(171, 0);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(837, 561);
            this.panelContent.TabIndex = 9;
            // 
            // dgv_phan_hoi
            // 
            this.dgv_phan_hoi.AllowUserToAddRows = false;
            this.dgv_phan_hoi.AllowUserToDeleteRows = false;
            this.dgv_phan_hoi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_phan_hoi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_phan_hoi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_phan_hoi.Location = new System.Drawing.Point(0, 133);
            this.dgv_phan_hoi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgv_phan_hoi.Name = "dgv_phan_hoi";
            this.dgv_phan_hoi.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_phan_hoi.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_phan_hoi.RowHeadersWidth = 51;
            this.dgv_phan_hoi.RowTemplate.Height = 24;
            this.dgv_phan_hoi.Size = new System.Drawing.Size(837, 428);
            this.dgv_phan_hoi.TabIndex = 2;
            this.dgv_phan_hoi.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_phan_hoi_CellDoubleClick);
            this.dgv_phan_hoi.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgv_phan_hoi_CellFormatting);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 52);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(837, 81);
            this.panel1.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(837, 81);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cbb_loc_trang_thai);
            this.panel2.Controls.Add(this.lbl_loc_theo_trang_thai);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(2, 2);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(414, 77);
            this.panel2.TabIndex = 0;
            // 
            // cbb_loc_trang_thai
            // 
            this.cbb_loc_trang_thai.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbb_loc_trang_thai.FormattingEnabled = true;
            this.cbb_loc_trang_thai.Items.AddRange(new object[] {
            "Tất cả",
            "Đã giải quyết",
            "Chưa hồi đáp"});
            this.cbb_loc_trang_thai.Location = new System.Drawing.Point(178, 25);
            this.cbb_loc_trang_thai.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbb_loc_trang_thai.Name = "cbb_loc_trang_thai";
            this.cbb_loc_trang_thai.Size = new System.Drawing.Size(173, 21);
            this.cbb_loc_trang_thai.TabIndex = 1;
            this.cbb_loc_trang_thai.Text = "Tất cả";
            this.cbb_loc_trang_thai.SelectedIndexChanged += new System.EventHandler(this.cbb_loc_trang_thai_SelectedIndexChanged);
            // 
            // lbl_loc_theo_trang_thai
            // 
            this.lbl_loc_theo_trang_thai.AutoSize = true;
            this.lbl_loc_theo_trang_thai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_loc_theo_trang_thai.Location = new System.Drawing.Point(58, 25);
            this.lbl_loc_theo_trang_thai.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_loc_theo_trang_thai.Name = "lbl_loc_theo_trang_thai";
            this.lbl_loc_theo_trang_thai.Size = new System.Drawing.Size(131, 17);
            this.lbl_loc_theo_trang_thai.TabIndex = 0;
            this.lbl_loc_theo_trang_thai.Text = "Lọc theo trạng thái:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cbb_loc_muc_do);
            this.panel3.Controls.Add(this.lbl_loc_theo_muc_do);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(420, 2);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(415, 77);
            this.panel3.TabIndex = 1;
            // 
            // cbb_loc_muc_do
            // 
            this.cbb_loc_muc_do.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbb_loc_muc_do.FormattingEnabled = true;
            this.cbb_loc_muc_do.Items.AddRange(new object[] {
            "Tất cả",
            "Phản hồi",
            "Khiếu nại",
            "Yêu cầu"});
            this.cbb_loc_muc_do.Location = new System.Drawing.Point(166, 25);
            this.cbb_loc_muc_do.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbb_loc_muc_do.Name = "cbb_loc_muc_do";
            this.cbb_loc_muc_do.Size = new System.Drawing.Size(174, 21);
            this.cbb_loc_muc_do.TabIndex = 1;
            this.cbb_loc_muc_do.Text = "Tất cả";
            this.cbb_loc_muc_do.SelectedIndexChanged += new System.EventHandler(this.cbb_loc_muc_do_SelectedIndexChanged);
            // 
            // lbl_loc_theo_muc_do
            // 
            this.lbl_loc_theo_muc_do.AutoSize = true;
            this.lbl_loc_theo_muc_do.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_loc_theo_muc_do.Location = new System.Drawing.Point(58, 25);
            this.lbl_loc_theo_muc_do.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_loc_theo_muc_do.Name = "lbl_loc_theo_muc_do";
            this.lbl_loc_theo_muc_do.Size = new System.Drawing.Size(117, 17);
            this.lbl_loc_theo_muc_do.TabIndex = 0;
            this.lbl_loc_theo_muc_do.Text = "Lọc theo mức độ:";
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
            this.lblContentHeader.Size = new System.Drawing.Size(231, 30);
            this.lblContentHeader.TabIndex = 0;
            this.lblContentHeader.Text = "Phản hồi người dùng";
            // 
            // adminSidenav1
            // 
            this.adminSidenav1.Dock = System.Windows.Forms.DockStyle.Left;
            this.adminSidenav1.Location = new System.Drawing.Point(0, 0);
            this.adminSidenav1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.adminSidenav1.Name = "adminSidenav1";
            this.adminSidenav1.Size = new System.Drawing.Size(171, 561);
            this.adminSidenav1.TabIndex = 10;
            // 
            // Replies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 561);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.adminSidenav1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1023, 591);
            this.Name = "Replies";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Liberate";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Replies_FormClosed);
            this.Load += new System.EventHandler(this.BorrowRequests_Load);
            this.panelContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_phan_hoi)).EndInit();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panelContentHeader.ResumeLayout(false);
            this.panelContentHeader.PerformLayout();
            this.ResumeLayout(false);

        }
        private Panel panelContent;
        private Panel panelContentHeader;
        private Label lblContentHeader;
        private AdminSidenav adminSidenav1;
        private DataGridView dgv_phan_hoi;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel2;
        private ComboBox cbb_loc_trang_thai;
        private Label lbl_loc_theo_trang_thai;
        private Panel panel3;
        private ComboBox cbb_loc_muc_do;
        private Label lbl_loc_theo_muc_do;
    }
}
