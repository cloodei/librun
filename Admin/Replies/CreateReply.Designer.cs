namespace librun.Admin.Replies
{
    partial class CreateReply
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lbl_noi_dung;
        private System.Windows.Forms.Label lbl_nhap_hoi_dap;
        private System.Windows.Forms.RichTextBox rtxtb_nhap_hoi_dap;
        private System.Windows.Forms.Button btn_gui_hoi_dap;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lbl_noi_dung = new System.Windows.Forms.Label();
            this.lbl_nhap_hoi_dap = new System.Windows.Forms.Label();
            this.rtxtb_nhap_hoi_dap = new System.Windows.Forms.RichTextBox();
            this.btn_gui_hoi_dap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.lblTitle.Size = new System.Drawing.Size(500, 50);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Phản hồi người dùng";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_noi_dung
            // 
            this.lbl_noi_dung.BackColor = System.Drawing.Color.White;
            this.lbl_noi_dung.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_noi_dung.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lbl_noi_dung.Location = new System.Drawing.Point(20, 60);
            this.lbl_noi_dung.Name = "lbl_noi_dung";
            this.lbl_noi_dung.Padding = new System.Windows.Forms.Padding(10);
            this.lbl_noi_dung.Size = new System.Drawing.Size(440, 80);
            this.lbl_noi_dung.TabIndex = 1;
            this.lbl_noi_dung.Text = "Nội dung: ...";
            // 
            // lbl_nhap_hoi_dap
            // 
            this.lbl_nhap_hoi_dap.AutoSize = true;
            this.lbl_nhap_hoi_dap.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lbl_nhap_hoi_dap.Location = new System.Drawing.Point(20, 160);
            this.lbl_nhap_hoi_dap.Name = "lbl_nhap_hoi_dap";
            this.lbl_nhap_hoi_dap.Size = new System.Drawing.Size(119, 23);
            this.lbl_nhap_hoi_dap.TabIndex = 2;
            this.lbl_nhap_hoi_dap.Text = "Nhập hồi đáp:";
            // 
            // rtxtb_nhap_hoi_dap
            // 
            this.rtxtb_nhap_hoi_dap.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.rtxtb_nhap_hoi_dap.Location = new System.Drawing.Point(20, 190);
            this.rtxtb_nhap_hoi_dap.Name = "rtxtb_nhap_hoi_dap";
            this.rtxtb_nhap_hoi_dap.Size = new System.Drawing.Size(440, 100);
            this.rtxtb_nhap_hoi_dap.TabIndex = 3;
            this.rtxtb_nhap_hoi_dap.Text = "";
            // 
            // btn_gui_hoi_dap
            // 
            this.btn_gui_hoi_dap.BackColor = System.Drawing.Color.White;
            this.btn_gui_hoi_dap.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btn_gui_hoi_dap.FlatAppearance.BorderSize = 2;
            this.btn_gui_hoi_dap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_gui_hoi_dap.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btn_gui_hoi_dap.Location = new System.Drawing.Point(180, 310);
            this.btn_gui_hoi_dap.Name = "btn_gui_hoi_dap";
            this.btn_gui_hoi_dap.Size = new System.Drawing.Size(120, 35);
            this.btn_gui_hoi_dap.TabIndex = 4;
            this.btn_gui_hoi_dap.Text = "Gửi";
            this.btn_gui_hoi_dap.UseVisualStyleBackColor = false;
            this.btn_gui_hoi_dap.Click += new System.EventHandler(this.btn_gui_hoi_dap_Click);
            // 
            // CreateReply
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(500, 380);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lbl_noi_dung);
            this.Controls.Add(this.lbl_nhap_hoi_dap);
            this.Controls.Add(this.rtxtb_nhap_hoi_dap);
            this.Controls.Add(this.btn_gui_hoi_dap);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CreateReply";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Tạo phản hồi";
            this.Load += new System.EventHandler(this.CreateReply_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}
