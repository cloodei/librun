using System;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Mail;
using System.Windows.Forms;

namespace Library
{
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text) || string.IsNullOrWhiteSpace(txtPassword.Text) || string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin đăng ký", "Đăng ký lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtUsername.Text.Length < 3 || txtPassword.Text.Length < 6)
            {
                MessageBox.Show("Tên đăng nhập phải có ít nhất 3 ký tự và mật khẩu ít nhất 6 ký tự.", "Đăng ký lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                var email = new MailAddress(txtEmail.Text);
                if (email.Address != txtEmail.Text)
                {
                    MessageBox.Show("Email không đúng", "Đăng ký lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Email không đúng", "Đăng ký lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("Email không đúng", "Đăng ký lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            foreach (var x in global.u_list)
            {
                if (x.email == txtEmail.Text)
                {
                    MessageBox.Show("Email đã tồn tại", "Đăng ký lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            var conn = new SqlConnection(global.connectionString);
            conn.Open();

            var sqlcmd = new SqlCommand(
                @"INSERT INTO USERS (ten, email, trang_thai, mat_khau) 
                   OUTPUT INSERTED.id
                   VALUES (@ten, @email, @trang_thai, @mat_khau);",
                conn
            );

            sqlcmd.Parameters.AddWithValue("@ten", txtUsername.Text);
            sqlcmd.Parameters.AddWithValue("@email", txtEmail.Text);
            sqlcmd.Parameters.AddWithValue("@trang_thai", "OK");
            sqlcmd.Parameters.AddWithValue("@mat_khau", txtPassword.Text);

            try
            {
                global.user_id = (long)sqlcmd.ExecuteScalar();
                global.u_list.Append(new ucheck
                {
                    id = global.user_id,
                    password = txtPassword.Text,
                    email = txtEmail.Text,
                    username = txtUsername.Text
                });

                var u = new MainUserForm();
                u.Show();
                this.Hide();
            }
            catch (Exception err)
            {
                MessageBox.Show("Không đăng ký được tài khoản: " + err.Message, "Đăng ký lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSwitchToSignIn_Click(object sender, EventArgs e)
        {
            var signInForm = new SignInForm();
            signInForm.Show();
            this.Close();
        }

        private void SignUpForm_Load(object sender, EventArgs e)
        {

        }
    }
}
