using System.Drawing;
using System.Windows.Forms;

namespace Library
{
    partial class UserRepliesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserRepliesForm));
            this.quảnLýTàiKhảoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xemThôngTinPhảnHồiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelContent = new System.Windows.Forms.Panel();
            this.dgvReplies = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ng = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rEPLYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userRepliesDataSet = new librun.userRepliesDataSet();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSendReply = new System.Windows.Forms.Button();
            this.cbPl = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbTt = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelContentHeader = new System.Windows.Forms.Panel();
            this.lblContentHeader = new System.Windows.Forms.Label();
            this.rEPLYTableAdapter = new librun.userRepliesDataSetTableAdapters.REPLYTableAdapter();
            this.userSidenav1 = new Library.UserSidenav();
            this.panelContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReplies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rEPLYBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userRepliesDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.panelContentHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // quảnLýTàiKhảoToolStripMenuItem
            // 
            this.quảnLýTàiKhảoToolStripMenuItem.Name = "quảnLýTàiKhảoToolStripMenuItem";
            this.quảnLýTàiKhảoToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // xemThôngTinPhảnHồiToolStripMenuItem
            // 
            this.xemThôngTinPhảnHồiToolStripMenuItem.Name = "xemThôngTinPhảnHồiToolStripMenuItem";
            this.xemThôngTinPhảnHồiToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // panelContent
            // 
            this.panelContent.Controls.Add(this.dgvReplies);
            this.panelContent.Controls.Add(this.panel1);
            this.panelContent.Controls.Add(this.panelContentHeader);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(171, 0);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(837, 561);
            this.panelContent.TabIndex = 7;
            // 
            // dgvReplies
            // 
            this.dgvReplies.AllowUserToAddRows = false;
            this.dgvReplies.AllowUserToDeleteRows = false;
            this.dgvReplies.AutoGenerateColumns = false;
            this.dgvReplies.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReplies.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvReplies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReplies.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.nd,
            this.hd,
            this.tt,
            this.pl,
            this.ng});
            this.dgvReplies.DataSource = this.rEPLYBindingSource;
            this.dgvReplies.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvReplies.Location = new System.Drawing.Point(0, 92);
            this.dgvReplies.Name = "dgvReplies";
            this.dgvReplies.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReplies.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvReplies.Size = new System.Drawing.Size(837, 469);
            this.dgvReplies.TabIndex = 1;
            this.dgvReplies.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReplies_CellDoubleClick);
            this.dgvReplies.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvReplies_CellFormatting);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // nd
            // 
            this.nd.DataPropertyName = "noi_dung";
            this.nd.HeaderText = "Nội dung";
            this.nd.Name = "nd";
            this.nd.ReadOnly = true;
            // 
            // hd
            // 
            this.hd.DataPropertyName = "hoi_dap";
            this.hd.HeaderText = "hoi_dap";
            this.hd.Name = "hd";
            this.hd.ReadOnly = true;
            this.hd.Visible = false;
            // 
            // tt
            // 
            this.tt.DataPropertyName = "trang_thai";
            this.tt.HeaderText = "Trạng thái";
            this.tt.Name = "tt";
            this.tt.ReadOnly = true;
            // 
            // pl
            // 
            this.pl.DataPropertyName = "muc_do";
            this.pl.HeaderText = "Phân loại";
            this.pl.Name = "pl";
            this.pl.ReadOnly = true;
            // 
            // ng
            // 
            this.ng.DataPropertyName = "ngay_gui";
            this.ng.HeaderText = "Ngày gửi";
            this.ng.Name = "ng";
            this.ng.ReadOnly = true;
            // 
            // rEPLYBindingSource
            // 
            this.rEPLYBindingSource.DataMember = "REPLY";
            this.rEPLYBindingSource.DataSource = this.userRepliesDataSet;
            // 
            // userRepliesDataSet
            // 
            this.userRepliesDataSet.DataSetName = "userRepliesDataSet";
            this.userRepliesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSendReply);
            this.panel1.Controls.Add(this.cbPl);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cbTt);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(837, 40);
            this.panel1.TabIndex = 3;
            // 
            // btnSendReply
            // 
            this.btnSendReply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSendReply.Location = new System.Drawing.Point(710, 6);
            this.btnSendReply.Name = "btnSendReply";
            this.btnSendReply.Size = new System.Drawing.Size(115, 31);
            this.btnSendReply.TabIndex = 6;
            this.btnSendReply.Text = "Liên hệ";
            this.btnSendReply.UseVisualStyleBackColor = true;
            this.btnSendReply.Click += new System.EventHandler(this.lbReply_Click);
            // 
            // cbPl
            // 
            this.cbPl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPl.FormattingEnabled = true;
            this.cbPl.Items.AddRange(new object[] {
            "Tất cả",
            "Phản hồi",
            "Khiếu nại",
            "Yêu cầu"});
            this.cbPl.Location = new System.Drawing.Point(495, 12);
            this.cbPl.Name = "cbPl";
            this.cbPl.Size = new System.Drawing.Size(186, 21);
            this.cbPl.TabIndex = 5;
            this.cbPl.SelectedIndexChanged += new System.EventHandler(this.cbPl_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(359, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Lọc theo phân loại";
            // 
            // cbTt
            // 
            this.cbTt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTt.FormattingEnabled = true;
            this.cbTt.Items.AddRange(new object[] {
            "Tất cả",
            "Đã giải quyết",
            "Chưa phản hồi"});
            this.cbTt.Location = new System.Drawing.Point(151, 11);
            this.cbTt.Name = "cbTt";
            this.cbTt.Size = new System.Drawing.Size(186, 21);
            this.cbTt.TabIndex = 3;
            this.cbTt.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Lọc theo trạng thái";
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
            this.lblContentHeader.Size = new System.Drawing.Size(209, 30);
            this.lblContentHeader.TabIndex = 0;
            this.lblContentHeader.Text = "Thông tin phản hồi";
            // 
            // rEPLYTableAdapter
            // 
            this.rEPLYTableAdapter.ClearBeforeFill = true;
            // 
            // userSidenav1
            // 
            this.userSidenav1.Dock = System.Windows.Forms.DockStyle.Left;
            this.userSidenav1.Location = new System.Drawing.Point(0, 0);
            this.userSidenav1.Name = "userSidenav1";
            this.userSidenav1.Size = new System.Drawing.Size(171, 561);
            this.userSidenav1.TabIndex = 8;
            // 
            // UserRepliesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 561);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.userSidenav1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1024, 600);
            this.Name = "UserRepliesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Liberate";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UserRepliesForm_FormClosed);
            this.Load += new System.EventHandler(this.UserBooks_Load);
            this.panelContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReplies)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rEPLYBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userRepliesDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelContentHeader.ResumeLayout(false);
            this.panelContentHeader.PerformLayout();
            this.ResumeLayout(false);

        }
        private DataGridViewTextBoxColumn useridDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn bookidDataGridViewTextBoxColumn;
        private ToolStripMenuItem quảnLýTàiKhảoToolStripMenuItem;
        private ToolStripMenuItem xemThôngTinPhảnHồiToolStripMenuItem;
        private ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private UserSidenav userSidenav1;
        private DataGridView dgvReplies;
        private librun.userRepliesDataSet userRepliesDataSet;
        private BindingSource rEPLYBindingSource;
        private librun.userRepliesDataSetTableAdapters.REPLYTableAdapter rEPLYTableAdapter;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private Panel panel1;
        private ComboBox cbPl;
        private Label label2;
        private ComboBox cbTt;
        private Label label1;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn nd;
        private DataGridViewTextBoxColumn hd;
        private DataGridViewTextBoxColumn tt;
        private DataGridViewTextBoxColumn pl;
        private DataGridViewTextBoxColumn ng;
        private Button btnSendReply;
    }
}
