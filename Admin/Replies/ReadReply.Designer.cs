namespace librun.Admin.Replies
{
    partial class ReadReply
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lbl_noi_dung = new System.Windows.Forms.Label();
            this.lbl_hoi_dap = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lbl_noi_dung);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lbl_hoi_dap);
            this.splitContainer1.Size = new System.Drawing.Size(516, 257);
            this.splitContainer1.SplitterDistance = 134;
            this.splitContainer1.TabIndex = 0;
            // 
            // lbl_noi_dung
            // 
            this.lbl_noi_dung.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_noi_dung.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_noi_dung.Location = new System.Drawing.Point(0, 0);
            this.lbl_noi_dung.Name = "lbl_noi_dung";
            this.lbl_noi_dung.Size = new System.Drawing.Size(516, 134);
            this.lbl_noi_dung.TabIndex = 0;
            this.lbl_noi_dung.Text = "Nội dung: ";
            // 
            // lbl_hoi_dap
            // 
            this.lbl_hoi_dap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_hoi_dap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hoi_dap.Location = new System.Drawing.Point(0, 0);
            this.lbl_hoi_dap.Name = "lbl_hoi_dap";
            this.lbl_hoi_dap.Size = new System.Drawing.Size(516, 119);
            this.lbl_hoi_dap.TabIndex = 0;
            this.lbl_hoi_dap.Text = "Hồi đáp từ thủ thư: ";
            // 
            // ReadReply
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 257);
            this.Controls.Add(this.splitContainer1);
            this.Name = "ReadReply";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ReadReply";
            this.Load += new System.EventHandler(this.ReadReply_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label lbl_noi_dung;
        private System.Windows.Forms.Label lbl_hoi_dap;
    }
}