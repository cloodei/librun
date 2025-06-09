using System;
using System.Drawing;
using System.Windows.Forms;

namespace Library
{
    public partial class BorrowRequests : Form, IFData
    {
        public BorrowRequests()
        {
            InitializeComponent();
            global.SetActiveButton(adminSidenav1.panel1.Controls, adminSidenav1.btnTtMuonSach);
        }

        public void InitForm()
        {
            fillDgvBorrowedBooks();
            cbFilter.Text = "Tất cả";
        }

        public void ResetFields()
        {
            dtpBorrowDate.ResetText();
            dtpBorrowDate.Refresh();
            tbBookName.ResetText();
            tbUsername.ResetText();
            cbFilter.Text = "Tất cả";
        }

        private void BorrowRequests_Load(object sender, EventArgs e)
        {
            fillDgvBorrowedBooks();
        }

        void fillDgvBorrowedBooks()
        {
            this.bORROWTableAdapter.Fill(this.adminBorrowDataSet.BORROW);
            for (int i = 0; i < dgvBorrowedBooks.Rows.Count; ++i)
            {
                DateTime borrowDate = DateTime.Parse(dgvBorrowedBooks.Rows[i].Cells["ngay_muon"].Value.ToString());
                if (borrowDate.AddDays(14) < DateTime.Now)
                    dgvBorrowedBooks.Rows[i].DefaultCellStyle.BackColor = Color.LightPink;
            }

            dgvBorrowedBooks.ClearSelection();
        }

        private void dgvBorrowedBooks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dtpBorrowDate.Value = DateTime.Parse(dgvBorrowedBooks.CurrentRow.Cells[4].Value.ToString());
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvBorrowedBooks.CurrentRow != null)
            {
                if (Convert.ToDateTime(dgvBorrowedBooks.CurrentRow.Cells["ngay_muon"].Value) == dtpBorrowDate.Value)
                    return;

                long uid = Convert.ToInt64(dgvBorrowedBooks.CurrentRow.Cells[1].Value);
                long bid = Convert.ToInt64(dgvBorrowedBooks.CurrentRow.Cells[3].Value);
                var bname = dgvBorrowedBooks.CurrentRow.Cells["ten_sach"].Value.ToString();
                var uname = dgvBorrowedBooks.CurrentRow.Cells["ten_user"].Value.ToString();

                this.bORROWTableAdapter.Update(dtpBorrowDate.Text, uid, bid, bid, uid);
                cbFilter_SelectedIndexChanged(sender, e);

                MessageBox.Show(
                    "Sửa ngày mượn sách [ " + bname + " ] của user [ " + uname + " ] thành công",
                    "Sửa",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                dgvBorrowedBooks.ClearSelection();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một yêu cầu mượn sách để cập nhật.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        bool checkAddRow(string finduname, string findbname, string uname, string bname)
        {
            uname = uname.ToLower();
            bname = bname.ToLower();
            finduname = finduname.ToLower();
            findbname = findbname.ToLower();

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

        private void BorrowRequests_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
