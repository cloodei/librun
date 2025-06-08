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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Replies));
            this.panelContent = new System.Windows.Forms.Panel();
            this.splitContainerDetails = new System.Windows.Forms.SplitContainer();
            this.bORROWBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.adminBorrowDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.adminBorrowDataSet = new librun.adminBorrowDataSet();
            this.panelContentHeader = new System.Windows.Forms.Panel();
            this.lblContentHeader = new System.Windows.Forms.Label();
            this.bORROWTableAdapter = new librun.adminBorrowDataSetTableAdapters.BORROWTableAdapter();
            this.adminSidenav1 = new Library.AdminSidenav();
            this.panelContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerDetails)).BeginInit();
            this.splitContainerDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bORROWBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminBorrowDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminBorrowDataSet)).BeginInit();
            this.panelContentHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelContent
            // 
            this.panelContent.Controls.Add(this.splitContainerDetails);
            this.panelContent.Controls.Add(this.panelContentHeader);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(171, 0);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(837, 561);
            this.panelContent.TabIndex = 9;
            // 
            // splitContainerDetails
            // 
            this.splitContainerDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerDetails.Location = new System.Drawing.Point(0, 52);
            this.splitContainerDetails.Name = "splitContainerDetails";
            this.splitContainerDetails.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerDetails.Panel2
            // 
            this.splitContainerDetails.Panel2.BackColor = System.Drawing.Color.Cornsilk;
            this.splitContainerDetails.Size = new System.Drawing.Size(837, 509);
            this.splitContainerDetails.SplitterDistance = 347;
            this.splitContainerDetails.TabIndex = 1;
            // 
            // bORROWBindingSource
            // 
            this.bORROWBindingSource.DataMember = "BORROW";
            this.bORROWBindingSource.DataSource = this.adminBorrowDataSetBindingSource;
            // 
            // adminBorrowDataSetBindingSource
            // 
            this.adminBorrowDataSetBindingSource.DataSource = this.adminBorrowDataSet;
            this.adminBorrowDataSetBindingSource.Position = 0;
            // 
            // adminBorrowDataSet
            // 
            this.adminBorrowDataSet.DataSetName = "adminBorrowDataSet";
            this.adminBorrowDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // bORROWTableAdapter
            // 
            this.bORROWTableAdapter.ClearBeforeFill = true;
            // 
            // adminSidenav1
            // 
            this.adminSidenav1.Dock = System.Windows.Forms.DockStyle.Left;
            this.adminSidenav1.Location = new System.Drawing.Point(0, 0);
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
            this.MinimumSize = new System.Drawing.Size(1024, 600);
            this.Name = "Replies";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Liberate";
            this.Load += new System.EventHandler(this.BorrowRequests_Load);
            this.panelContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerDetails)).EndInit();
            this.splitContainerDetails.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bORROWBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminBorrowDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminBorrowDataSet)).EndInit();
            this.panelContentHeader.ResumeLayout(false);
            this.panelContentHeader.PerformLayout();
            this.ResumeLayout(false);

        }
        private Panel panelContent;
        private Panel panelContentHeader;
        private Label lblContentHeader;
        private SplitContainer splitContainerDetails;
        private librun.adminBorrowDataSet adminBorrowDataSet;
        private BindingSource adminBorrowDataSetBindingSource;
        private BindingSource bORROWBindingSource;
        private librun.adminBorrowDataSetTableAdapters.BORROWTableAdapter bORROWTableAdapter;
        private AdminSidenav adminSidenav1;
    }
}
