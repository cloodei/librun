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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserRepliesForm));
            this.quảnLýTàiKhảoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xemThôngTinPhảnHồiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelContent = new System.Windows.Forms.Panel();
            this.panelContentHeader = new System.Windows.Forms.Panel();
            this.lblContentHeader = new System.Windows.Forms.Label();
            this.userSidenav1 = new Library.UserSidenav();
            this.panelContent.SuspendLayout();
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
            this.panelContent.Controls.Add(this.panelContentHeader);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(171, 0);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(837, 561);
            this.panelContent.TabIndex = 7;
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
            this.Load += new System.EventHandler(this.UserBooks_Load);
            this.panelContent.ResumeLayout(false);
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
    }
}
