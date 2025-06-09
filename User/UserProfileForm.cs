using System;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace Library
{
    public partial class UserProfileForm : Form, IFData
    {
        SqlConnection conn;
        SqlDataAdapter da;
        DataTable dt;

        string countBooks;

        public UserProfileForm()
        {
            InitializeComponent();
            lbCanhBao.Visible = global.locked;
            global.SetActiveButton(userSidenav1.panel1.Controls, null);
        }

        public void InitForm()
        {
            dt.Clear();
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                txtName.Text = row["ten"].ToString();
                txtEmail.Text = row["email"].ToString();
                txtPassword.Text = row["mat_khau"].ToString();
                txtSoSach.Text = countBooks;
            }
            else
            {
                MessageBox.Show("Không tìm thấy thông tin người dùng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        SqlDataAdapter dac;
        DataTable dtc;

        private void UserBooks_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(global.connectionString);
            conn.Open();

            dt = new DataTable();
            da = new SqlDataAdapter(
                "SELECT * FROM USERS WHERE id = " + global.user_id,
                conn
            );

            dtc = new DataTable();
            dac = new SqlDataAdapter(
                "SELECT COUNT(*) FROM BORROW WHERE user_id = " + global.user_id + " GROUP BY user_id",
                conn
            );
            dac.Fill(dtc);
            countBooks = dtc.Rows[0][0].ToString();

            InitForm();
        }

        private void HienPass(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = (char)0;
        }

        private void AnPass(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '●';
        }

        private void btnSuaTT_Click(object sender, EventArgs e)
        {
            panelSuaTT.Visible = true;
        }

        private void HienChoSua(object sender, EventArgs e)
        {
            txtSuaName.Text = txtName.Text;
            txtSuaEmail.Text = txtEmail.Text;
            txtPasswordCu.Text = dt.Rows[0]["mat_khau"].ToString();
            txtPasswordMoi.ResetText();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            foreach(Control tb in panelSuaThongTin.Controls)
            {
                if (tb is TextBox textBox && string.IsNullOrWhiteSpace(textBox.Text))
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            if (txtPasswordCu.Text != dt.Rows[0]["mat_khau"].ToString())
            {
                MessageBox.Show("Mật khẩu cũ không đúng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var result = MessageBox.Show("Bạn đã chắc chắn với thông tin vừa chỉnh sửa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    string query = "UPDATE USERS SET ten = @ten, email = @email, mat_khau = @mat_khau WHERE id = @id";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ten", txtSuaName.Text);
                        cmd.Parameters.AddWithValue("@email", txtSuaEmail.Text);
                        cmd.Parameters.AddWithValue("@mat_khau", txtPasswordMoi.Text);
                        cmd.Parameters.AddWithValue("@id", global.user_id);
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Cập nhật thông tin thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    panelSuaTT.Visible = false;
                    InitForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi cập nhật thông tin: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void HuySuaTT(object sender, EventArgs e)
        {
            var luachon = MessageBox.Show("Bạn chắc chắn muốn huỷ chỉnh sửa thông tin?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (luachon == DialogResult.Yes)
            {
                panelSuaTT.Visible = false;
                InitForm();
            }
        }
    }
}
