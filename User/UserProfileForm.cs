using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Library
{
    public partial class UserProfileForm : Form
    {
        SqlDataAdapter da;
        DataTable dt = new DataTable();
        public UserProfileForm()
        {
            InitializeComponent();
        }

        private void UserBooks_Load(object sender, EventArgs e)
        {
            global.SetActiveButton(userSidenav1.panel1.Controls, null);
            global.booksUF = new UserBooks();

            da = new SqlDataAdapter(
                "SELECT * FROM USERS WHERE id = " + global.user_id,
                librun.Properties.Settings.Default.mainConnectionString
            );
            dt.Clear();
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                txtName.Text = row["ten"].ToString();
                txtEmail.Text = row["email"].ToString();
                txtPassword.Text = new string('*', dt.Rows[0]["mat_khau"].ToString().Length);
                int sosachdangmuon = global.booksUF.GetBorrowedBooksCount(global.user_id);
                txtSoSach.Text = sosachdangmuon.ToString();
            }
            else
            {
                MessageBox.Show("Không tìm thấy thông tin người dùng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (global.locked) 
                lbCanhBao.Visible = true;
            else
                lbCanhBao.Visible = false;
        }

        private void HienPass(object sender, EventArgs e)
        {
            txtPassword.Text = dt.Rows[0]["mat_khau"].ToString();
        }

        private void AnPass(object sender, EventArgs e)
        {
            txtPassword.Text = new string('*', dt.Rows[0]["mat_khau"].ToString().Length);
        }

        private void btnSuaTT_Click(object sender, EventArgs e)
        {
            panelSuaTT.Visible = true;
        }

        private void HienChoSua(object sender, EventArgs e)
        {
            txtSuaName.Text = txtName.Text;
            txtSuaEmail.Text = txtEmail.Text;
            txtPasswordCu.Text = new string('*', dt.Rows[0]["mat_khau"].ToString().Length);
            txtPasswordMoi.ResetText();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            foreach(TextBox textBox in panelSuaThongTin.Controls.OfType<TextBox>())
            {
                if (string.IsNullOrWhiteSpace(textBox.Text))
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
                    using (SqlConnection conn = new SqlConnection(librun.Properties.Settings.Default.mainConnectionString))
                    {
                        conn.Open();
                        string query = "UPDATE USERS SET ten = @ten, email = @email, mat_khau = @mat_khau WHERE id = @id";
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@ten", txtSuaName.Text);
                            cmd.Parameters.AddWithValue("@email", txtSuaEmail.Text);
                            cmd.Parameters.AddWithValue("@mat_khau", txtPasswordMoi.Text);
                            cmd.Parameters.AddWithValue("@id", global.user_id);
                            cmd.ExecuteNonQuery();
                        }
                    }
                    MessageBox.Show("Cập nhật thông tin thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    panelSuaTT.Visible = false;
                    UserBooks_Load(sender, e);
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
                UserBooks_Load(sender, e);
            }
        }
    }
    public partial class UserBooks : Form
    {
        // Add a public method to expose the count of borrowed books
        public int GetBorrowedBooksCount(long userId)
        {
            return bORROWTableAdapter.GetData(userId).Rows.Count;
        }
    }
}
