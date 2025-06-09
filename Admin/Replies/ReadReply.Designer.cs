namespace librun.Admin.Replies
{
    partial class ReadReply
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lbl_noi_dung;
        private System.Windows.Forms.Label lbl_hoi_dap;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lbl_noi_dung = new System.Windows.Forms.Label();
            this.lbl_hoi_dap = new System.Windows.Forms.Label();
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
            this.lblTitle.Text = "Phản hồi chi tiết";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_noi_dung
            // 
            this.lbl_noi_dung.BackColor = System.Drawing.Color.White;
            this.lbl_noi_dung.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_noi_dung.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lbl_noi_dung.ForeColor = System.Drawing.Color.Black;
            this.lbl_noi_dung.Location = new System.Drawing.Point(20, 70);
            this.lbl_noi_dung.Name = "lbl_noi_dung";
            this.lbl_noi_dung.Padding = new System.Windows.Forms.Padding(10);
            this.lbl_noi_dung.Size = new System.Drawing.Size(440, 80);
            this.lbl_noi_dung.TabIndex = 1;
            this.lbl_noi_dung.Text = "Nội dung: ";
            // 
            // lbl_hoi_dap
            // 
            this.lbl_hoi_dap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.lbl_hoi_dap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_hoi_dap.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic);
            this.lbl_hoi_dap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_hoi_dap.Location = new System.Drawing.Point(20, 170);
            this.lbl_hoi_dap.Name = "lbl_hoi_dap";
            this.lbl_hoi_dap.Padding = new System.Windows.Forms.Padding(10);
            this.lbl_hoi_dap.Size = new System.Drawing.Size(440, 80);
            this.lbl_hoi_dap.TabIndex = 2;
            this.lbl_hoi_dap.Text = "Hồi đáp từ thủ thư: ";
            // 
            // ReadReply
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(500, 280);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lbl_noi_dung);
            this.Controls.Add(this.lbl_hoi_dap);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ReadReply";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Phản hồi người dùng";
            this.Load += new System.EventHandler(this.ReadReply_Load);
            this.ResumeLayout(false);

        }

        
    }
}
