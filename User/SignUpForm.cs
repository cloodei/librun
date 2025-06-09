using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Net.Mail;
using System.Windows.Forms;

namespace Library
{
    public partial class SignUpForm : Form, IFData
    {
        SqlDataAdapter da;
        DataTable dt = new DataTable();
        SqlConnection conn;

        public SignUpForm()
        {
            InitializeComponent();
            lblTitle.Location = new Point(
                (lblTitle.Parent.ClientSize.Width - lblTitle.Width) / 2,
                12
            );
        }

        public void InitForm()
        {
            conn = new SqlConnection(global.connectionString);
            conn.Open();

            cmd = new SqlCommand(
                "INSERT INTO REPLY(user_id, noi_dung, trang_thai, muc_do) " +
                "VALUES(@uid, @nd, N'chưa hồi đáp', @md)",
                conn
            );
        }

        public void ResetFields()
        {
            txtConfirmPassword.ResetText();
            txtEmail.ResetText();
            txtPassword.ResetText();
            txtUsername.ResetText();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text) || string.IsNullOrWhiteSpace(txtPassword.Text) || string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin đăng ký", "Đăng ký lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtUsername.Text.Length < 3)
            {
                MessageBox.Show("Tên đăng nhập phải có ít nhất 3 ký tự.", "Đăng ký lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtPassword.Text.Length < 6)
            {
                MessageBox.Show("Mật khẩu phải có ít nhất 6 ký tự.", "Đăng ký lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                var email = new MailAddress(txtEmail.Text);
                if (email.Address != txtEmail.Text)
                {
                    MessageBox.Show("Email không đúng định dạng", "Đăng ký lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Email không đúng định dạng", "Đăng ký lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                global.mainUF = global.swapForm(global.mainUF, this);
            }
            catch (Exception err)
            {
                MessageBox.Show("Không đăng ký được tài khoản: " + err.Message, "Đăng ký lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSwitchToSignIn_Click(object sender, EventArgs e)
        {
            global.swapForm(global.signInF, this);
        }

        private void SignUpForm_Load(object sender, EventArgs e)
        {
            InitForm();
        }

        SqlDataAdapter findda;
        SqlCommand cmd;
        DataTable finddt;

        private void lbContact_Click(object sender, EventArgs e)
        {
            var f = new ContactForm();
            var r = f.ShowDialog();

            if (r == DialogResult.OK)
            {
                var (ue, nd, pl) = (f.ue, f.nd, f.pl);
                findda = new SqlDataAdapter(
                    "SELECT id FROM USERS WHERE email = N'" + ue + "'",
                    conn
                );
                finddt = new DataTable();
                findda.Fill(finddt);

                if (finddt.Rows.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy tài khoản với email: " + ue, "Thông tin không hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                cmd.Parameters.AddWithValue("@uid", finddt.Rows[0][0]);
                cmd.Parameters.AddWithValue("@nd", nd);
                cmd.Parameters.AddWithValue("@md", pl);

                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Phản hồi của bạn đã được ghi nhận", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Phản hồi của bạn đã không được gửi thành công", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void SignUpForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
