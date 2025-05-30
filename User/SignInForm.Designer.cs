using System.Drawing;
using System.Windows.Forms;

namespace Library
{
    partial class SignInForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnSignIn;
        private System.Windows.Forms.Button btnSwitchToSignUp;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignInForm));
            lblUsername = new Label();
            lblPassword = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            btnSignIn = new Button();
            btnSwitchToSignUp = new Button();
            SuspendLayout();
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(58, 30);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(32, 15);
            lblUsername.TabIndex = 0;
            lblUsername.Text = "Tên: ";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(27, 70);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(63, 15);
            lblPassword.TabIndex = 2;
            lblPassword.Text = "Mật khẩu: ";
            // 
            // txtUsername
            // 
            txtUsername.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtUsername.Location = new Point(110, 27);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(223, 23);
            txtUsername.TabIndex = 1;
            // 
            // txtPassword
            // 
            txtPassword.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtPassword.Location = new Point(110, 67);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(223, 23);
            txtPassword.TabIndex = 3;
            // 
            // btnSignIn
            // 
            btnSignIn.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnSignIn.Location = new Point(110, 110);
            btnSignIn.Name = "btnSignIn";
            btnSignIn.Size = new Size(223, 30);
            btnSignIn.TabIndex = 4;
            btnSignIn.Text = "Đăng nhập";
            btnSignIn.UseVisualStyleBackColor = true;
            btnSignIn.Click += btnSignIn_Click;
            // 
            // btnSwitchToSignUp
            // 
            btnSwitchToSignUp.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnSwitchToSignUp.Location = new Point(110, 207);
            btnSwitchToSignUp.Name = "btnSwitchToSignUp";
            btnSwitchToSignUp.Padding = new Padding(4, 0, 1, 0);
            btnSwitchToSignUp.Size = new Size(182, 30);
            btnSwitchToSignUp.TabIndex = 5;
            btnSwitchToSignUp.Text = "Chuyển sang đăng kí";
            btnSwitchToSignUp.UseVisualStyleBackColor = true;
            btnSwitchToSignUp.Click += btnSwitchToSignUp_Click;
            // 
            // SignInForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(393, 249);
            Controls.Add(btnSwitchToSignUp);
            Controls.Add(btnSignIn);
            Controls.Add(txtPassword);
            Controls.Add(lblPassword);
            Controls.Add(txtUsername);
            Controls.Add(lblUsername);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(800, 600);
            MinimumSize = new Size(384, 288);
            Name = "SignInForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "lib dn";
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion
    }
}
