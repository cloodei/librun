using librun;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq.Expressions;
using System.Net.Mail;
using System.Windows.Forms;

namespace Library
{
    public partial class Users : Form
    {
        public Users()
        {
            InitializeComponent();
            global.SetActiveButton(panel1.Controls, btnQuanLyNguoiDung);
        }

        private void btnYeuCauMuonSach_Click_1(object sender, EventArgs e)
        {
            global.swapForm(global.borrowAF, this);
        }

        private void btnQuanLySach_Click(object sender, EventArgs e)
        {
            global.swapForm(global.booksAF, this);
        }

        private void btnSignOut_Click_1(object sender, EventArgs e)
        {
            global.SignOut(this);
        }

        string chuoiketnoi = global.connectionString;
        SqlConnection conn;
        SqlDataAdapter daQuanLyNguoiDung;
        DataTable dtQuanLyNguoiDung;

        DataTable dtQLND_Goc;
        private void Users_Load(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection(chuoiketnoi);
                conn.Open();

                string sql = "select ROW_NUMBER() OVER(ORDER BY id) as STT, ten, email, mat_khau, trang_thai, id from USERS";
                daQuanLyNguoiDung = new SqlDataAdapter(sql, conn);
                dtQuanLyNguoiDung = new DataTable();
                dtQLND_Goc = new DataTable();

                daQuanLyNguoiDung.Fill(dtQuanLyNguoiDung);
                daQuanLyNguoiDung.Fill(dtQLND_Goc);

                dtQuanLyNguoiDung.Columns.Add("mat_khau_display", typeof(string));
                dgv_quan_ly_nguoi_dung.DataSource = dtQuanLyNguoiDung;

                dgv_quan_ly_nguoi_dung.Columns["ten"].HeaderText = "Tên";
                dgv_quan_ly_nguoi_dung.Columns["email"].HeaderText = "Email";
                dgv_quan_ly_nguoi_dung.Columns["mat_khau"].Visible = false;
                dgv_quan_ly_nguoi_dung.Columns["trang_thai"].HeaderText = "Trạng thái";
                dgv_quan_ly_nguoi_dung.Columns["id"].Visible = false;
                dgv_quan_ly_nguoi_dung.Columns["mat_khau_display"].HeaderText = "Mật khẩu";

                dgv_quan_ly_nguoi_dung.Columns["mat_khau_display"].DisplayIndex = 3;
                dgv_quan_ly_nguoi_dung.Columns["mat_khau"].DisplayIndex = 6;

                add_mat_khau_display();
            }
            catch {
                MessageBox.Show("Lỗi khi tải dữ liệu: " , "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void add_mat_khau_display()
        {
            foreach (DataRow row in dtQuanLyNguoiDung.Rows)
                row["mat_khau_display"] = new string('*', row["mat_khau"].ToString().Length);
        }
        private bool check_empty(bool funtion_Delete)
        {
            bool check = true;
            string thong_bao = "Bạn chưa nhập dữ liệu:";
            if(txt_ten.Text == "")
            {
                thong_bao += " Tên,";
                check = false;
            }
            if (txt_email.Text == "")
            {
                thong_bao += " Email,";
                check = false;
            }
            if (txt_mat_khau.Text == "")
            {
                thong_bao += " Mật khẩu,";
                check = false;
            }
            if (cbb_trang_thai.Text == "")
            {
                thong_bao += " Trạng thái,";
                check = false;
            }
            if (check) {
                return true;
            }
            else
            {
                if (!funtion_Delete)
                {
                    thong_bao = thong_bao.Substring(0, thong_bao.Length - 1);
                    MessageBox.Show(thong_bao);
                }
                return false;
            }

        }
        private bool check_email(bool funtion_Edit)
        {
            try
            {
                var email = new MailAddress(txt_email.Text);
            }
            catch
            {
                MessageBox.Show("Email không đúng đinh dạng", "Thêm người dùng lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (email_current == txt_email.Text && funtion_Edit)
            {
                return true;
            }
            int len = dtQLND_Goc.Select("email = '" + txt_email.Text + "'").Length;
            
            if (len != 0)
            {
                MessageBox.Show("Email đã tồn tại", "Thêm người dùng lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
            

        }

        SqlCommand cmd;
        private void btn_them_Click(object sender, EventArgs e)
        {
            var kq = MessageBox.Show("Bạn có chắc chắn muốn thêm?", "Xác nhận thêm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kq == DialogResult.Yes && check_empty(false) && check_email(false))
            {
                string sql = "INSERT INTO USERS VALUES(N'" + txt_ten.Text + "', N'" + txt_email.Text + "', N'" + cbb_trang_thai.Text + "', N'" + txt_mat_khau.Text + "')";
                cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                dtQuanLyNguoiDung.Clear();
                daQuanLyNguoiDung.Fill(dtQuanLyNguoiDung);
                dtQLND_Goc.Clear();
                daQuanLyNguoiDung.Fill(dtQLND_Goc);
                add_mat_khau_display();
                txt_tim_kiem_TextChanged(sender, e);
                MessageBox.Show("Bạn đã thêm thành công", "Thông báo");
            }
        }

        DataGridViewRow row_befor = null;
        string email_current;
        private void dgv_quan_ly_nguoi_dung_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(row_befor != null)
            {
                row_befor.DefaultCellStyle.BackColor = Color.White;
            }
            txt_ten.Text = dgv_quan_ly_nguoi_dung.CurrentRow.Cells[1].Value.ToString();
            txt_email.Text = dgv_quan_ly_nguoi_dung.CurrentRow.Cells[2].Value.ToString();
            txt_mat_khau.Text = dgv_quan_ly_nguoi_dung.CurrentRow.Cells[3].Value.ToString();
            cbb_trang_thai.Text = dgv_quan_ly_nguoi_dung.CurrentRow.Cells[4].Value.ToString();
            email_current = txt_email.Text;
            dgv_quan_ly_nguoi_dung.CurrentRow.DefaultCellStyle.BackColor = Color.LightBlue;
            row_befor = dgv_quan_ly_nguoi_dung.CurrentRow;
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            var kq = MessageBox.Show("Bạn có chắc chắn muốn sửa?", "Xác nhận sửa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kq == DialogResult.Yes && check_empty(false) && check_email(true))
            {
                string idUser = dgv_quan_ly_nguoi_dung.CurrentRow.Cells["id"].Value.ToString();
                cmd = new SqlCommand(
                    "UPDATE USERS SET " +
                    "ten = N'" + txt_ten.Text + "', " +
                     "email = N'" + txt_email.Text + "', " +
                     "trang_thai = N'" + cbb_trang_thai.Text + "', " +
                     "mat_khau = N'" + txt_mat_khau.Text + "' " +
                     "WHERE id = " + idUser,
                     conn
                 );
                cmd.ExecuteNonQuery();
                dtQLND_Goc.Clear();
                daQuanLyNguoiDung.Fill(dtQLND_Goc);
                txt_tim_kiem_TextChanged(sender, e);
                MessageBox.Show("Bạn đã sửa thành công", "Thông báo");
            }
        }

        SqlDataAdapter daTimKiem;
        private void txt_tim_kiem_TextChanged(object sender, EventArgs e)
        {
            string sql = "select ROW_NUMBER() OVER(ORDER BY id) as STT, ten, email, mat_khau, trang_thai, id " +
                "from USERS " +
                "where (ten like N'%"+txt_tim_kiem.Text+"%' or email like N'%"+txt_tim_kiem.Text+"%')";
            if (cbb_loc.Text == "Hoạt động")
            {
                sql += " and trang_thai = N'Hoạt động'";
            }
            else if(cbb_loc.Text == "Khóa")
            {
                sql += " and trang_thai = N'Khóa'";
            }

            daTimKiem = new SqlDataAdapter(sql, conn);
            dtQuanLyNguoiDung.Clear();
            daTimKiem.Fill(dtQuanLyNguoiDung);
            add_mat_khau_display() ;
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
            if (check_empty(true))
            {
                var kq = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (kq == DialogResult.Yes)
                {
                    var idUser = dgv_quan_ly_nguoi_dung.CurrentRow.Cells[5].Value.ToString();
                    string sql = "delete from USERS where id = " + idUser + "";
                    cmd = new SqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();
                    dtQuanLyNguoiDung.Clear();
                    daQuanLyNguoiDung.Fill(dtQuanLyNguoiDung);
                    add_mat_khau_display();
                    txt_ten.Text = "";
                    txt_email.Text = "";
                    txt_mat_khau.Text = "";
                    cbb_trang_thai.Text = "";
                    txt_tim_kiem_TextChanged(sender, e);
                    MessageBox.Show("Bạn đã xóa thành công", "Thông báo");
                }
                
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

        private void dgv_quan_ly_nguoi_dung_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DataGridViewRow row = dgv_quan_ly_nguoi_dung.Rows[e.RowIndex];
            if (row.Cells[4].Value.ToString() == "Khóa")
            {
                row.DefaultCellStyle.BackColor = Color.LightPink;
            }
        }
    }
}
