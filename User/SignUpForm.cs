using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Net.Mail;
using System.Windows.Forms;

namespace Library
{
    public partial class SignUpForm : Form
    {
        SqlDataAdapter da;
        DataTable dt = new DataTable();
        readonly SqlConnection conn = new SqlConnection(global.connectionString);

        public SignUpForm()
        {
            InitializeComponent();
            lblTitle.Location = new Point(
                (lblTitle.Parent.ClientSize.Width - lblTitle.Width) / 2,
                12
            );
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
                MessageBox.Show("Mật khẩu không khớp", "Đăng ký lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            da = new SqlDataAdapter("SELECT email FROM USERS WHERE email = N'" + txtEmail.Text + "'", conn);
            dt.Clear();
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Email đã tồn tại", "Đăng ký lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var sqlcmd = new SqlCommand(
                "INSERT INTO USERS (ten, email, trang_thai, mat_khau) " +
                "OUTPUT INSERTED.id " +
                "VALUES (@ten, @email, @trang_thai, @mat_khau);",
                conn
            );

            sqlcmd.Parameters.AddWithValue("@ten", txtUsername.Text);
            sqlcmd.Parameters.AddWithValue("@email", txtEmail.Text);
            sqlcmd.Parameters.AddWithValue("@trang_thai", "Hoạt động");
            sqlcmd.Parameters.AddWithValue("@mat_khau", txtPassword.Text);

            try
            {
                global.user_id = (long)sqlcmd.ExecuteScalar();
                global.locked = false;
                global.swapForm(global.mainUF, this);
            }
            catch (Exception err)
            {
                MessageBox.Show("Không đăng ký được tài khoản: " + err.Message, "Đăng ký lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSwitchToSignIn_Click(object sender, EventArgs e)
        {
            global.swapForm(new SignInForm(), this);
        }

        private void SignUpForm_Load(object sender, EventArgs e)
        {
            conn.Open();
        }
    }
}
