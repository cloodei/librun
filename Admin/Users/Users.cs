using librun;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Library
{
    public partial class Users : Form
    {
        private readonly Color PrimaryColor = Color.FromArgb(0, 123, 255);
        private readonly Color SecondaryColor = Color.FromArgb(40, 44, 52);


        public Users()
        {
            InitializeComponent();
            SetActiveButton(btnQuanLyNguoiDung);
        }

        private void SetActiveButton(Button activeButton)
        {
            foreach (Control control in panel1.Controls)
            {
                if (control is Button button)
                {
                    button.BackColor = SecondaryColor;
                }
            }
            if (activeButton != null)
            {
                activeButton.BackColor = PrimaryColor;
            }
        }

        private void btnYeuCauMuonSach_Click_1(object sender, EventArgs e)
        {
            var bs = new BorrowRequests();
            bs.Show();
            this.Close();
        }

        private void btnQuanLySach_Click(object sender, EventArgs e)
        {
            var b = new Books();
            b.Show();
            this.Close();
        }

        private void btnSignOut_Click_1(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất?", "Xác nhận đăng xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                var f = new SignInForm();
                f.Show();
                this.Close();
            }
        }

        string chuoiketnoi = global.connectionString;
        SqlConnection conn;
        SqlDataAdapter daQuanLyNguoiDung;
        DataTable dtQuanLyNguoiDung;

        private void Users_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(chuoiketnoi);
            conn.Open();

            string sql = "select ROW_NUMBER() OVER(ORDER BY id) as STT, ten, email, mat_khau, trang_thai, id from USERS";
            daQuanLyNguoiDung = new SqlDataAdapter(sql, conn);
            dtQuanLyNguoiDung = new DataTable();
            daQuanLyNguoiDung.Fill(dtQuanLyNguoiDung);
            dgv_quan_ly_nguoi_dung.DataSource = dtQuanLyNguoiDung;

            dgv_quan_ly_nguoi_dung.Columns[1].HeaderText = "Tên";
            dgv_quan_ly_nguoi_dung.Columns[2].HeaderText = "Email";
            dgv_quan_ly_nguoi_dung.Columns[3].HeaderText = "Mật khẩu";
            dgv_quan_ly_nguoi_dung.Columns[4].HeaderText = "Trạng thái";
            dgv_quan_ly_nguoi_dung.Columns[5].Visible = false;
        }

        SqlCommand cmd;

        private void btn_them_Click(object sender, EventArgs e)
        {
            string sql = "INSERT INTO USERS VALUES(@ten, @email, @tt, @mk)";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@ten", txt_ten.Text);
            cmd.Parameters.AddWithValue("@email", txt_email.Text);
            cmd.Parameters.AddWithValue("@tt", cbb_trang_thai.Text);
            cmd.Parameters.AddWithValue("@mk", txt_mat_khau.Text);

            cmd.ExecuteNonQuery();
            dtQuanLyNguoiDung.Clear();
            daQuanLyNguoiDung.Fill(dtQuanLyNguoiDung);
        }

        string email_current;
        private void dgv_quan_ly_nguoi_dung_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_ten.Text = dgv_quan_ly_nguoi_dung.CurrentRow.Cells[1].Value.ToString();
            txt_email.Text = dgv_quan_ly_nguoi_dung.CurrentRow.Cells[2].Value.ToString();
            txt_mat_khau.Text = dgv_quan_ly_nguoi_dung.CurrentRow.Cells[3].Value.ToString();
            cbb_trang_thai.Text = dgv_quan_ly_nguoi_dung.CurrentRow.Cells[4].Value.ToString();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand(
                "UPDATE USERS SET ten = @t, email = @e, trang_thai = @tt, mat_khau = @m WHERE id = @i",
                conn
            );

            cmd.Parameters.AddWithValue("@t", txt_ten.Text);
            cmd.Parameters.AddWithValue("@e", txt_email.Text);
            cmd.Parameters.AddWithValue("@tt", cbb_trang_thai.Text);
            cmd.Parameters.AddWithValue("@m", txt_mat_khau.Text);
            cmd.Parameters.AddWithValue("@i", dgv_quan_ly_nguoi_dung.CurrentRow.Cells["id"].Value.ToString());
            cmd.ExecuteNonQuery();

            dtQuanLyNguoiDung.Clear();
            daQuanLyNguoiDung.Fill(dtQuanLyNguoiDung);
        }

        SqlDataAdapter daTimKiem;
        private void txt_tim_kiem_TextChanged(object sender, EventArgs e)
        {
            string sql = "select ROW_NUMBER() OVER(ORDER BY id) as STT, ten, email, mat_khau, trang_thai " +
                "from USERS " +
                "where (ten like N'%"+txt_tim_kiem.Text+"%' or email like N'%"+txt_tim_kiem.Text+"%')";
            if (cbb_loc.Text == "Hoạt động")
            {
                sql = sql + " and trang_thai = N'Hoạt động'";
            }else if(cbb_loc.Text == "Khóa")
            {
                sql = sql+" and trang_thai = N'Khóa'";
            }

                daTimKiem = new SqlDataAdapter(sql, conn);
            dtQuanLyNguoiDung.Clear();
            daTimKiem.Fill(dtQuanLyNguoiDung);
        }

        SqlDataAdapter daTBSach;
        DataTable dtTBSach = new DataTable();
        private void dgv_quan_ly_nguoi_dung_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string userDClick = dgv_quan_ly_nguoi_dung.CurrentRow.Cells[5].Value.ToString();
            string sql = "select B.id, B.tieu_de, BR.ngay_muon " +
                "from BOOKS as B " +
                "join BORROW as BR on B.id = BR.book_id " +
                "where BR.user_id = " + userDClick + ";";
            daTBSach = new SqlDataAdapter(sql, conn);

            dtTBSach.Clear();
            daTBSach.Fill(dtTBSach);

            var n = new AlertBorrowed(dtTBSach);
            n.ShowDialog();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (txt_email.Text!="")
            {
                var idUser = dgv_quan_ly_nguoi_dung.CurrentRow.Cells[5].Value.ToString();
                string sql = "delete from USERS where id = " + idUser + "";
                cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                dtQuanLyNguoiDung.Clear();
                daQuanLyNguoiDung.Fill(dtQuanLyNguoiDung);
                txt_ten.Text = "";
                txt_email.Text = "";
                txt_mat_khau.Text = "";
                cbb_trang_thai.Text = "";
                MessageBox.Show("Bạn đã xóa thành công","Thông báo");
            }
            else
            {
                MessageBox.Show("Bạn hãy chọn người dùng muốn xóa trước","Thông báo");
            }
        }

        private void cbb_loc_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_tim_kiem_TextChanged(sender, e);
        }
    }
}
