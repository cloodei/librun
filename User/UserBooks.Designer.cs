using System.Drawing;
using System.Windows.Forms;

namespace Library
{
    partial class UserBooks
    {
        private System.ComponentModel.IContainer components = null;
        internal System.Windows.Forms.DataGridView dgvBooks;
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserBooks));
            dgvBooks = new DataGridView();
            btnHome = new Button();
            btnQuanLySach = new Button();
            lblTitle = new Label();
            panel1 = new Panel();
            btnSignOut = new Button();
            pictureBox1 = new PictureBox();
            panelContent = new Panel();
            panelContentHeader = new Panel();
            lblContentHeader = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvBooks).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelContent.SuspendLayout();
            panelContentHeader.SuspendLayout();
            SuspendLayout();
            // 
            // dgvBooks
            // 
            dgvBooks.AllowUserToAddRows = false;
            dgvBooks.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(248, 249, 250);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(73, 80, 87);
            dataGridViewCellStyle1.Padding = new Padding(15, 5, 15, 5);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvBooks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvBooks.ColumnHeadersHeight = 29;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvBooks.DefaultCellStyle = dataGridViewCellStyle2;
            dgvBooks.Dock = DockStyle.Fill;
            dgvBooks.Location = new Point(0, 60);
            dgvBooks.Name = "dgvBooks";
            dgvBooks.ReadOnly = true;
            dgvBooks.RowHeadersVisible = false;
            dgvBooks.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(33, 37, 41);
            dataGridViewCellStyle3.Padding = new Padding(15, 5, 15, 5);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(224, 242, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(33, 37, 41);
            dgvBooks.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dgvBooks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBooks.Size = new Size(808, 501);
            dgvBooks.TabIndex = 2;
            dgvBooks.CellMouseEnter += dgvBooks_CellMouseEnter;
            dgvBooks.CellMouseLeave += dgvBooks_CellMouseLeave;
            // 
            // btnHome
            // 
            btnHome.BackColor = Color.FromArgb(41, 128, 185);
            btnHome.FlatAppearance.BorderSize = 0;
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnHome.ForeColor = Color.White;
            btnHome.Location = new Point(3, 169);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(194, 46);
            btnHome.TabIndex = 3;
            btnHome.Text = "Giá sách";
            btnHome.UseVisualStyleBackColor = false;
            btnHome.Click += btnHome_Click;
            // 
            // btnQuanLySach
            // 
            btnQuanLySach.BackColor = Color.FromArgb(41, 128, 185);
            btnQuanLySach.FlatAppearance.BorderSize = 0;
            btnQuanLySach.FlatStyle = FlatStyle.Flat;
            btnQuanLySach.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnQuanLySach.ForeColor = Color.White;
            btnQuanLySach.Location = new Point(3, 225);
            btnQuanLySach.Name = "btnQuanLySach";
            btnQuanLySach.Size = new Size(194, 46);
            btnQuanLySach.TabIndex = 4;
            btnQuanLySach.Text = "Sách Của Tôi";
            btnQuanLySach.UseVisualStyleBackColor = false;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTitle.ForeColor = SystemColors.Control;
            lblTitle.Location = new Point(37, 107);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(131, 37);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Thư Viện";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(52, 73, 94);
            panel1.Controls.Add(btnSignOut);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(lblTitle);
            panel1.Controls.Add(btnHome);
            panel1.Controls.Add(btnQuanLySach);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 561);
            panel1.TabIndex = 4;
            // 
            // btnSignOut
            // 
            btnSignOut.BackColor = Color.FromArgb(41, 128, 185);
            btnSignOut.FlatAppearance.BorderSize = 0;
            btnSignOut.FlatStyle = FlatStyle.Flat;
            btnSignOut.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSignOut.ForeColor = Color.White;
            btnSignOut.Location = new Point(3, 503);
            btnSignOut.Name = "btnSignOut";
            btnSignOut.Size = new Size(194, 46);
            btnSignOut.TabIndex = 11;
            btnSignOut.Text = "Đăng xuất";
            btnSignOut.UseVisualStyleBackColor = false;
            btnSignOut.Click += btnSignOut_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(191, 92);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // panelContent
            // 
            panelContent.Controls.Add(dgvBooks);
            panelContent.Controls.Add(panelContentHeader);
            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new Point(200, 0);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(808, 561);
            panelContent.TabIndex = 7;
            // 
            // panelContentHeader
            // 
            panelContentHeader.BackColor = Color.FromArgb(41, 128, 185);
            panelContentHeader.Controls.Add(lblContentHeader);
            panelContentHeader.Dock = DockStyle.Top;
            panelContentHeader.Location = new Point(0, 0);
            panelContentHeader.Name = "panelContentHeader";
            panelContentHeader.Size = new Size(808, 60);
            panelContentHeader.TabIndex = 0;
            // 
            // lblContentHeader
            // 
            lblContentHeader.AutoSize = true;
            lblContentHeader.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblContentHeader.ForeColor = Color.White;
            lblContentHeader.Location = new Point(15, 15);
            lblContentHeader.Name = "lblContentHeader";
            lblContentHeader.Size = new Size(161, 30);
            lblContentHeader.TabIndex = 0;
            lblContentHeader.Text = "Sách đã mượn";
            // 
            // UserBooks
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1008, 561);
            Controls.Add(panelContent);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(1024, 548);
            Name = "UserBooks";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Liberate";
            FormClosed += UserBooks_FormClosed;
            ((System.ComponentModel.ISupportInitialize)dgvBooks).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelContent.ResumeLayout(false);
            panelContentHeader.ResumeLayout(false);
            panelContentHeader.PerformLayout();
            ResumeLayout(false);
        }
        internal Button btnSignOut;
    }
}
