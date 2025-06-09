namespace librun.Admin.Replies
{
    partial class CreateReply
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_noi_dung = new System.Windows.Forms.Label();
            this.rtxtb_nhap_hoi_dap = new System.Windows.Forms.RichTextBox();
            this.lbl_nhap_hoi_dap = new System.Windows.Forms.Label();
            this.btn_gui_hoi_dap = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbl_noi_dung);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(614, 160);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_gui_hoi_dap);
            this.panel2.Controls.Add(this.lbl_nhap_hoi_dap);
            this.panel2.Controls.Add(this.rtxtb_nhap_hoi_dap);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 160);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(614, 229);
            this.panel2.TabIndex = 1;
            // 
            // lbl_noi_dung
            // 
            this.lbl_noi_dung.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_noi_dung.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_noi_dung.Location = new System.Drawing.Point(0, 0);
            this.lbl_noi_dung.Name = "lbl_noi_dung";
            this.lbl_noi_dung.Size = new System.Drawing.Size(614, 160);
            this.lbl_noi_dung.TabIndex = 0;
            this.lbl_noi_dung.Text = "Nội dung: ";
            // 
            // rtxtb_nhap_hoi_dap
            // 
            this.rtxtb_nhap_hoi_dap.Location = new System.Drawing.Point(147, 26);
            this.rtxtb_nhap_hoi_dap.Name = "rtxtb_nhap_hoi_dap";
            this.rtxtb_nhap_hoi_dap.Size = new System.Drawing.Size(405, 96);
            this.rtxtb_nhap_hoi_dap.TabIndex = 0;
            this.rtxtb_nhap_hoi_dap.Text = "";
            // 
            // lbl_nhap_hoi_dap
            // 
            this.lbl_nhap_hoi_dap.AutoSize = true;
            this.lbl_nhap_hoi_dap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nhap_hoi_dap.Location = new System.Drawing.Point(12, 64);
            this.lbl_nhap_hoi_dap.Name = "lbl_nhap_hoi_dap";
            this.lbl_nhap_hoi_dap.Size = new System.Drawing.Size(112, 20);
            this.lbl_nhap_hoi_dap.TabIndex = 1;
            this.lbl_nhap_hoi_dap.Text = "Nhập hồi đáp:";
            // 
            // btn_gui_hoi_dap
            // 
            this.btn_gui_hoi_dap.Location = new System.Drawing.Point(205, 157);
            this.btn_gui_hoi_dap.Name = "btn_gui_hoi_dap";
            this.btn_gui_hoi_dap.Size = new System.Drawing.Size(219, 43);
            this.btn_gui_hoi_dap.TabIndex = 2;
            this.btn_gui_hoi_dap.Text = "Gửi";
            this.btn_gui_hoi_dap.UseVisualStyleBackColor = true;
            this.btn_gui_hoi_dap.Click += new System.EventHandler(this.btn_gui_hoi_dap_Click);
            // 
            // CreateReply
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 389);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "CreateReply";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CreateReply";
            this.Load += new System.EventHandler(this.CreateReply_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_noi_dung;
        private System.Windows.Forms.RichTextBox rtxtb_nhap_hoi_dap;
        private System.Windows.Forms.Button btn_gui_hoi_dap;
        private System.Windows.Forms.Label lbl_nhap_hoi_dap;
    }
}