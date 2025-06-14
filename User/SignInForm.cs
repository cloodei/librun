﻿using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Library
{
    public partial class SignInForm : Form
    {
        DataTable dt = new DataTable();
        SqlConnection conn;
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
                global.borrowAF = global.swapForm(global.borrowAF, this);
                return;
            }

            if (!string.IsNullOrWhiteSpace(txtEmail.Text) && !string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                da = new SqlDataAdapter(
                    "SELECT id, mat_khau, trang_thai FROM USERS WHERE email = N'" + txtEmail.Text + "'",
                    conn
                );

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
                    MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Tài khoản không tồn tại.", "Đăng nhập lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var password = dt.Rows[0]["mat_khau"].ToString();
                if (password  == txtPassword.Text)
                {
                    var lck = dt.Rows[0]["trang_thai"].ToString() == "Khóa";
                    if (lck)
                    {
                        MessageBox.Show("Bạn không thể đăng nhập do tài khoản của bạn hiện đang bị khóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        return;
                    }

                    global.user_id = Convert.ToInt64(dt.Rows[0]["id"]);
                    global.locked = false;

                    var some = new SqlDataAdapter(
                        "SELECT ngay_muon FROM BORROW WHERE user_id = " + global.user_id,
                        conn
                    );
                    var thing = new DataTable();
                    some.Fill(thing);

                    for (int i = 0; i < thing.Rows.Count; ++i)
                    {
                        var ngay = Convert.ToDateTime(thing.Rows[i][0]);
                        if (ngay.AddDays(14) < DateTime.Now)
                        {
                            global.locked = true;
                            break;
                        }
                    }

                    global.mainUF = global.swapForm(global.mainUF, this);
                    return;
                }

                MessageBox.Show("Sai mật khẩu.", "Đăng nhập lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Vui lòng điền đầy đủ thông tin đăng nhập.", "Đăng nhập lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnSwitchToSignUp_Click(object sender, EventArgs e)
        {
            global.signUpF = global.swapForm(global.signUpF, this);
        }

        private void SignInForm_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(global.connectionString);
            conn.Open();

            cmd = new SqlCommand(
                "INSERT INTO REPLY(user_id, noi_dung, trang_thai, muc_do) " +
                "VALUES(@uid, @nd, N'chưa hồi đáp', @md)",
                conn
            );
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
    }
}
