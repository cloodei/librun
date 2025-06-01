using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Library
{
    public struct ucheck
    {
        public long id;
        public string email;
        public string username;
        public string password;
    }

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
            }
            else if (!string.IsNullOrWhiteSpace(txtUsername.Text) && !string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                for (int i = 0; i < global.u_list.Length; ++i)
                {
                    if (txtUsername.Text == global.u_list[i].username)
                    {
                        if (txtPassword.Text == global.u_list[i].password)
                        {
                            global.user_id = global.u_list[i].id;
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
            }
            else
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin đăng nhập.", "Đăng nhập lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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
            da = new SqlDataAdapter("SELECT id, email, ten, mat_khau FROM USERS", librun.Properties.Settings.Default.libConnectionString);

            try
            {
                da.Fill(dt);
                global.u_list = new ucheck[dt.Rows.Count];

                for (int i = 0; i < dt.Rows.Count; ++i)
                {
                    global.u_list[i].id = Convert.ToInt64(dt.Rows[i][0]);
                    global.u_list[i].email = dt.Rows[i][1].ToString();
                    global.u_list[i].username = dt.Rows[i][2].ToString();
                    global.u_list[i].password = dt.Rows[i][3].ToString();
                }
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
