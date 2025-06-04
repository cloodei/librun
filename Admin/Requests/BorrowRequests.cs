using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Library
{
    public partial class BorrowRequests : Form
    {
        private readonly Color PrimaryColor = Color.FromArgb(0, 123, 255);
        private readonly Color SecondaryColor = Color.FromArgb(40, 44, 52);

        public BorrowRequests()
        {
            InitializeComponent();
        }

        private void BorrowRequests_Load(object sender, EventArgs e)
        {
            SetActiveButton(btnYeuCauMuonSach);
            fillDgvBorrowedBooks();
        }

        void fillDgvBorrowedBooks()
        {
            try
            {
                this.bORROWTableAdapter.Fill(this.adminBorrowDataSet.BORROW);
                for (int i = 0; i < dgvBorrowedBooks.Rows.Count; i++)
                {
                    DateTime borrowDate = DateTime.Parse(dgvBorrowedBooks.Rows[i].Cells[4].Value.ToString());
                    if (borrowDate.AddDays(14) < DateTime.Now)
                    {
                        dgvBorrowedBooks.Rows[i].DefaultCellStyle.BackColor = Color.LightPink;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất?", "Xác nhận đăng xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                var f = new SignInForm();
                f.Show();
                this.Close();
            }
        }

        private void btnQuanLySach_Click_1(object sender, EventArgs e)
        {
            var b = new Books();
            b.Show();
            this.Close();
        }

        private void btnQuanLyNguoiDung_Click(object sender, EventArgs e)
        {
            var u = new Users();
            u.Show();
            this.Close();
        }

        private void dgvBorrowedBooks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dtpBorrowDate.Value = DateTime.Parse(dgvBorrowedBooks.CurrentRow.Cells[4].Value.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lấy ngày mượn sách: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvBorrowedBooks.CurrentRow != null)
            {
                int uid = int.Parse(dgvBorrowedBooks.CurrentRow.Cells[1].Value.ToString());
                int bid = int.Parse(dgvBorrowedBooks.CurrentRow.Cells[3].Value.ToString());

                this.bORROWTableAdapter.Update(dtpBorrowDate.Text, uid, bid, bid, uid);
                fillDgvBorrowedBooks();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một yêu cầu mượn sách để cập nhật.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillDgvBorrowedBooks();
            dgvBorrowedBooks.ClearSelection();

            CurrencyManager cm = (CurrencyManager)BindingContext[dgvBorrowedBooks.DataSource];
            cm.SuspendBinding();

            if (cbFilter.Text == "Tất cả")
            {
                return;
            }
            
            if (cbFilter.Text == "Quá hạn")
            {
                foreach (DataGridViewRow row in dgvBorrowedBooks.Rows)
                {
                    row.Visible = row.DefaultCellStyle.BackColor == Color.LightPink;
                }
                return;
            }


            foreach (DataGridViewRow row in dgvBorrowedBooks.Rows)
            {
                row.Visible = row.DefaultCellStyle.BackColor != Color.LightPink;
            }

            cm.ResumeBinding();
        }

    }
}
