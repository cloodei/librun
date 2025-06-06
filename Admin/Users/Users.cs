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
            try
            {
                conn = new SqlConnection(chuoiketnoi);
                conn.Open();

                string sql = "select ROW_NUMBER() OVER(ORDER BY id) as STT, ten, email, mat_khau, trang_thai, id from USERS";
                daQuanLyNguoiDung = new SqlDataAdapter(sql, conn);
                dtQuanLyNguoiDung = new DataTable();
                daQuanLyNguoiDung.Fill(dtQuanLyNguoiDung);
                dtQuanLyNguoiDung.Columns.Add("mat_khau_display", typeof(string));
                add_mat_khau_display();
            }
            catch (Exception ex) {
                MessageBox.Show("Lỗi khi tải dữ liệu: " , "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void add_mat_khau_display()
        {
            
            foreach (DataRow row in dtQuanLyNguoiDung.Rows)
                row["mat_khau_display"] = new string('*', row["mat_khau"].ToString().Length);

            dgv_quan_ly_nguoi_dung.DataSource = dtQuanLyNguoiDung;



            dgv_quan_ly_nguoi_dung.Columns[1].HeaderText = "Tên";
            dgv_quan_ly_nguoi_dung.Columns[2].HeaderText = "Email";
            dgv_quan_ly_nguoi_dung.Columns[3].Visible = false;
            dgv_quan_ly_nguoi_dung.Columns[4].HeaderText = "Trạng thái";
            dgv_quan_ly_nguoi_dung.Columns[5].Visible = false;
            dgv_quan_ly_nguoi_dung.Columns[6].HeaderText = "Mật khẩu";

            dgv_quan_ly_nguoi_dung.Columns["mat_khau_display"].DisplayIndex = 3;
            dgv_quan_ly_nguoi_dung.Columns["mat_khau"].DisplayIndex = 6;
        }
        SqlCommand cmd;

        private void btn_them_Click(object sender, EventArgs e)
        {
            string sql = "INSERT INTO USERS VALUES(N'"+txt_ten.Text+"', N'"+txt_email.Text+"', N'"+cbb_trang_thai.Text+"', N'"+txt_mat_khau.Text+"')";
            cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            dtQuanLyNguoiDung.Clear();
            daQuanLyNguoiDung.Fill(dtQuanLyNguoiDung);
            add_mat_khau_display();
        }

        string email_current;
        DataGridViewRow row_befor = null;
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

            dgv_quan_ly_nguoi_dung.CurrentRow.DefaultCellStyle.BackColor = Color.LightBlue;
            row_befor = dgv_quan_ly_nguoi_dung.CurrentRow;
            

        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            string idUser = dgv_quan_ly_nguoi_dung.CurrentRow.Cells["id"].Value.ToString();
            cmd = new SqlCommand(
                "UPDATE USERS SET " +
                "ten = N'"+txt_ten.Text+"', email = N'"+txt_email.Text+"', trang_thai = N'"+cbb_trang_thai.Text+"', mat_khau = N'"+txt_mat_khau.Text+"' " +
                "WHERE id = "+idUser+"",
                conn
            );

            
            cmd.ExecuteNonQuery();

            dtQuanLyNguoiDung.Clear();
            daQuanLyNguoiDung.Fill(dtQuanLyNguoiDung);
            add_mat_khau_display();
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
            if (txt_email.Text!="" && MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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
