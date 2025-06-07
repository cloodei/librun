using System;
using System.Drawing;
using System.Windows.Forms;

namespace Library
{
    public partial class BorrowRequests : Form
    {
        public BorrowRequests()
        {
            InitializeComponent();
            global.SetActiveButton(adminSidenav1.panel1.Controls, adminSidenav1.btnYeuCauMuonSach);
        }

        private void BorrowRequests_Load(object sender, EventArgs e)
        {
            fillDgvBorrowedBooks();
        }

        void fillDgvBorrowedBooks()
        {
            try
            {
                this.bORROWTableAdapter.Fill(this.adminBorrowDataSet.BORROW);
                for (int i = 0; i < dgvBorrowedBooks.Rows.Count; ++i)
                {
                    DateTime borrowDate = DateTime.Parse(dgvBorrowedBooks.Rows[i].Cells["ngay_muon"].Value.ToString());
                    if (borrowDate.AddDays(14) < DateTime.Now)
                        dgvBorrowedBooks.Rows[i].DefaultCellStyle.BackColor = Color.LightPink;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                long uid = long.Parse(dgvBorrowedBooks.CurrentRow.Cells[1].Value.ToString());
                long bid = long.Parse(dgvBorrowedBooks.CurrentRow.Cells[3].Value.ToString());

                this.bORROWTableAdapter.Update(dtpBorrowDate.Text, uid, bid, bid, uid);
                fillDgvBorrowedBooks();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một yêu cầu mượn sách để cập nhật.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        bool checkAddRow(string finduname, string findbname, string uname, string bname)
        {
            uname = uname.Trim().ToLower();
            bname = bname.Trim().ToLower();
            finduname = finduname.Trim().ToLower();
            findbname = findbname.Trim().ToLower();

            if (uname == "")
            {
                if (bname == "")
                    return true;

                return findbname.Contains(bname);
            }

            if (bname == "")
                return finduname.Contains(uname);

            return (findbname.Contains(bname) && finduname.Contains(uname));
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillDgvBorrowedBooks();
            dgvBorrowedBooks.ClearSelection();

            CurrencyManager cm = (CurrencyManager)BindingContext[dgvBorrowedBooks.DataSource];
            cm.SuspendBinding();

            if (cbFilter.Text == "Đúng hạn")
            {
                foreach (DataGridViewRow row in dgvBorrowedBooks.Rows)
                {
                    if (
                        row.DefaultCellStyle.BackColor != Color.LightPink &&
                        checkAddRow(
                            row.Cells["ten_user"].Value.ToString(),
                            row.Cells["ten_sach"].Value.ToString(),
                            tbUsername.Text,
                            tbBookName.Text
                        )
                    )
                    {
                        row.Visible = true;
                    }
                    else
                    {
                        row.Visible = false;
                    }
                }
            }
            else if (cbFilter.Text == "Quá hạn")
            {
                foreach (DataGridViewRow row in dgvBorrowedBooks.Rows)
                {
                    if (
                        row.DefaultCellStyle.BackColor == Color.LightPink &&
                        checkAddRow(
                            row.Cells["ten_user"].Value.ToString(),
                            row.Cells["ten_sach"].Value.ToString(),
                            tbUsername.Text,
                            tbBookName.Text
                        )
                    )
                    {
                        row.Visible = true;
                    }
                    else
                    {
                        row.Visible = false;
                    }
                }
            }
            else
            {
                foreach (DataGridViewRow row in dgvBorrowedBooks.Rows)
                {
                    row.Visible = checkAddRow(
                        row.Cells["ten_user"].Value.ToString(),
                        row.Cells["ten_sach"].Value.ToString(),
                        tbUsername.Text,
                        tbBookName.Text
                    );
                }
            }

            cm.ResumeBinding();
        }

        private void tbBookName_TextChanged(object sender, EventArgs e)
        {
            cbFilter_SelectedIndexChanged(sender, e);
        }

        private void tbUsername_TextChanged(object sender, EventArgs e)
        {
            cbFilter_SelectedIndexChanged(sender, e);
        }
    }
}
