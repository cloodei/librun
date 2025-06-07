using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Library
{
    public partial class SignInForm : Form
    {
        DataTable dt = new DataTable();
        readonly SqlConnection conn = new SqlConnection(global.connectionString);
        SqlDataAdapter da;

        public SignInForm()
        {
            InitializeComponent();

            lblWelcome.Location = new Point(
                (lblWelcome.Parent.ClientSize.Width - lblWelcome.Width) / 2,
                12
            );
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text == "1" && txtPassword.Text == "1")
            {
                global.swapForm(global.borrowAF, this);

                return;
            }

            if (!string.IsNullOrWhiteSpace(txtEmail.Text) && !string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                da = new SqlDataAdapter("SELECT * FROM USERS WHERE email = N'" + txtEmail.Text + "'", conn);

                try
                {
                    dt.Clear();
                    da.Fill(dt);
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Lỗi khi lấy dữ liệu người dùng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi không xác định: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Tài khoản không tồn tại.", "Đăng nhập lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var email = dt.Rows[0]["email"].ToString();
                var password = dt.Rows[0]["mat_khau"].ToString();
                var lck = dt.Rows[0]["trang_thai"].ToString() == "Khóa";

                if (email == txtEmail.Text)
                {
                    if (password  == txtPassword.Text)
                    {
                        if (lck)
                        {
                            MessageBox.Show("Bạn không thể đăng nhập do tài khoản của bạn hiện đang bị khóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            return;
                        }

                        global.user_id = Convert.ToInt64(dt.Rows[0]["id"]);

                        var some = new SqlDataAdapter("SELECT ngay_muon FROM BORROW WHERE user_id = " + global.user_id, conn);
                        var thing = new DataTable();
                        some.Fill(thing);

                        var ck = false;
                        for (int i = 0; i < thing.Rows.Count; ++i)
                        {
                            var ngay = Convert.ToDateTime(thing.Rows[i][0]);
                            if (ngay.AddDays(14) < DateTime.Now)
                            {
                                ck = true;
                                break;
                            }
                        }

                        global.locked = ck;
                        global.swapForm(global.mainUF, this);

                        return;
                    }

                    MessageBox.Show("Sai mật khẩu.", "Đăng nhập lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            MessageBox.Show("Vui lòng điền đầy đủ thông tin đăng nhập.", "Đăng nhập lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnSwitchToSignUp_Click(object sender, EventArgs e)
        {
            global.swapForm(global.signUpF, this);
        }

        private void SignInForm_Load(object sender, EventArgs e)
        {
            conn.Open();
        }
    }
}
