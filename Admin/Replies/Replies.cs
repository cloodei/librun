using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using librun.Admin.Replies;

namespace Library
{
    public partial class Replies : Form, IFData
    {
        public Replies()
        {
            InitializeComponent();
            global.SetActiveButton(adminSidenav1.panel1.Controls, adminSidenav1.btnQuanLyPhanHoi);
        }

        public void InitForm()
        {
            conn = new SqlConnection(chuoiketnoi);
            conn.Open();

            string sql = "select ROW_NUMBER() Over(order by REPLY.id) as STT ,ten, email , noi_dung, REPLY.trang_thai,muc_do,ngay_gui, hoi_dap,user_id from USERS " +
                "join REPLY on USERS.id = REPLY.user_id;";
            daPhanHoi = new SqlDataAdapter(sql, conn);
            dtPhanHoi = new DataTable(sql);
            daPhanHoi.Fill(dtPhanHoi);
            dgv_phan_hoi.DataSource = dtPhanHoi;

            dgv_phan_hoi.Columns["ten"].HeaderText = "Tên";
            dgv_phan_hoi.Columns["email"].HeaderText = "Email";
            dgv_phan_hoi.Columns["noi_dung"].HeaderText = "Nội dung";
            dgv_phan_hoi.Columns["trang_thai"].HeaderText = "Trạng thái";
            dgv_phan_hoi.Columns["muc_do"].HeaderText = "Mức độ";
            dgv_phan_hoi.Columns["ngay_gui"].HeaderText = "Ngày gửi";
            dgv_phan_hoi.Columns["user_id"].Visible = false;
            dgv_phan_hoi.Columns["hoi_dap"].Visible = false;
        }

        public void ResetFields()
        {
            cbb_loc_muc_do.ResetText();
            cbb_loc_trang_thai.ResetText();
        }

        string chuoiketnoi = global.connectionString;
        SqlConnection conn;
        SqlDataAdapter daPhanHoi;
        DataTable dtPhanHoi;

        private void BorrowRequests_Load(object sender, EventArgs e)
        {
            InitForm();
        }

        SqlCommand cmd;
        private void dgv_phan_hoi_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string noiDung = dgv_phan_hoi.CurrentRow.Cells["noi_dung"].Value.ToString();
            string hoiDap = dgv_phan_hoi.CurrentRow.Cells["hoi_dap"].Value.ToString();
            string trangThai = dgv_phan_hoi.CurrentRow.Cells["trang_thai"].Value.ToString();
            var user_id = dgv_phan_hoi.CurrentRow.Cells["user_id"].Value;
            if(trangThai == "đã giải quyết")
            {
                
                var frm = new ReadReply(noiDung,hoiDap);
                frm.ShowDialog();
            }
            else
            {
                var frm = new CreateReply(noiDung);
                frm.ShowDialog();
                var ketQua = frm.DialogResult;
                if(ketQua == DialogResult.OK)
                {
                    string sql = "update REPLY " +
                        "set hoi_dap = N'" + frm.hoiDap + "' , trang_thai = N'đã giải quyết' " +
                        "where user_id = "+user_id;
                    cmd = new SqlCommand(sql,conn);
                    cmd.ExecuteNonQuery();
                    cbb_loc_trang_thai_SelectedIndexChanged(sender, e);
                }
            }
        }

        private void dgv_phan_hoi_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            string mucDo = dgv_phan_hoi.Rows[e.RowIndex].Cells["muc_do"].Value.ToString();
            if (mucDo == "phản hồi")
            {
                dgv_phan_hoi.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightBlue;
            }
            if (mucDo == "khiếu nại")
            {
                dgv_phan_hoi.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightPink;
            }
            if (mucDo == "yêu cầu")
            {
                dgv_phan_hoi.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightYellow;
            }
        }
        private string check_fill(string sql)
        {
            bool allTT = (cbb_loc_trang_thai.Text == "") || (cbb_loc_trang_thai.Text == "Tất cả");
            bool allMD = (cbb_loc_muc_do.Text == "") || (cbb_loc_muc_do.Text == "Tất cả");
            if (allTT && allMD)
                return "";
            string mucDo = cbb_loc_muc_do.Text;
            if (allTT)
                return "where muc_do = N'" + mucDo + "'";
            string trangThai = cbb_loc_trang_thai.Text;
            if (allMD)
                return "where REPLY.trang_thai = N'" + trangThai + "'";
            return "where muc_do = N'" + mucDo + "' and REPLY.trang_thai = N'"+trangThai+"'";
        }
        SqlDataAdapter daLoc;
        
        private void cbb_loc_trang_thai_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql = "select ROW_NUMBER() Over(order by REPLY.id) as STT ,ten, email , noi_dung, REPLY.trang_thai,muc_do,ngay_gui, hoi_dap,user_id from USERS " +
                "join REPLY on USERS.id = REPLY.user_id ";
            sql+=check_fill(sql);
            Console.WriteLine(sql);
            daLoc = new SqlDataAdapter(sql, conn);
            dtPhanHoi.Clear();
            daLoc.Fill(dtPhanHoi);
        }

        private void cbb_loc_muc_do_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbb_loc_trang_thai_SelectedIndexChanged(sender, e);
        }

        private void Replies_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
