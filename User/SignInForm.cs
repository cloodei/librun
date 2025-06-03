using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Library
{
    public partial class SignInForm : Form
    {
        SqlDataAdapter da;
        DataTable dt;

        public SignInForm()
        {
            InitializeComponent();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "1" && txtPassword.Text == "1")
            {
                var br = new BorrowRequests();
                br.Show();
                this.Hide();

                return;
            }

            if (!string.IsNullOrWhiteSpace(txtUsername.Text) && !string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                for (int i = 0; i < dt.Rows.Count; ++i)
                {
                    var username = dt.Rows[i]["ten"].ToString();
                    var password = dt.Rows[i]["mat_khau"].ToString();

                    if (txtUsername.Text == username)
                    {
                        if (txtPassword.Text == password)
                        {
                            global.user_id = Convert.ToInt64(dt.Rows[i]["id"]);
                            global.locked = dt.Rows[i]["trang_thai"].ToString() == "Khóa";

                            var mainUserForm = new MainUserForm();
                            mainUserForm.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Sai mật khẩu.", "Đăng nhập lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        return;
                    }
                }

                MessageBox.Show("Tài khoản không tồn tại.", "Đăng nhập lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Vui lòng điền đầy đủ thông tin đăng nhập.", "Đăng nhập lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnSwitchToSignUp_Click(object sender, EventArgs e)
        {
            var signUpForm = new SignUpForm();
            signUpForm.Show();
            this.Hide();
        }

        private void SignInForm_Load(object sender, EventArgs e)
        {
            dt = new DataTable();
            da = new SqlDataAdapter("SELECT id, ten, mat_khau, trang_thai FROM USERS", librun.Properties.Settings.Default.libConnectionString);

            try
            {
                dt.Clear();
                da.Fill(dt);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu người dùng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi không xác định: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
