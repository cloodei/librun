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
        SqlConnection conn = new SqlConnection(librun.Properties.Settings.Default.mainConnectionString);

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
                            bool lck = dt.Rows[i]["trang_thai"].ToString() == "Khóa";

                            if (!lck)
                            {
                                var dap = new SqlDataAdapter(
                                    "SELECT ngay_muon FROM BORROW WHERE user_id = " + global.user_id,
                                    conn
                                );
                                var dat = new DataTable();
                                dap.Fill(dat);

                                for (int j = 0; j < dat.Rows.Count; ++j)
                                {
                                    DateTime ngaymuon = DateTime.Parse(dat.Rows[j][0].ToString());
                                    if (ngaymuon.AddDays(14) < DateTime.Now)
                                    {
                                        var cmd = new SqlCommand(
                                            "UPDATE USERS SET trang_thai = N'Khóa' WHERE id = " + global.user_id,
                                            conn
                                        );
                                        cmd.ExecuteNonQuery();

                                        lck = true;
                                        break;
                                    }
                                }
                            }

                            global.locked = lck;

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
            conn.Open();
            dt = new DataTable();
            da = new SqlDataAdapter("SELECT id, ten, mat_khau, trang_thai FROM USERS", conn);

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
