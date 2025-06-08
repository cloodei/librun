using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Library
{
    public partial class UserBooks : Form, IFData
    {
        public UserBooks()
        {
            InitializeComponent();
            global.SetActiveButton(userSidenav1.panel1.Controls, userSidenav1.btnQuanLySach);
        }

        public void InitForm()
        {
            fillBooks();
        }

        void fillBooks()
        {
            bORROWTableAdapter.Fill(this.userBorrowedBooks.BORROW, global.user_id);
        }

        private void UserBooks_Load(object sender, EventArgs e)
        {
            fillBooks();
        }

        private void btnReturnBooks_Click(object sender, EventArgs e)
        {
            var n = dgvUsersBooks.SelectedRows.Count;
            if (n == 0)
            {
                MessageBox.Show("Vui lòng chọn ít nhất một sách để trả.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirm = MessageBox.Show("Bạn có muốn trả " + n + " sách đã mượn?", "Xác nhận trả sách", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                for (int i = 0; i < n; ++i)
                {
                    long bookId = Convert.ToInt64(dgvUsersBooks.SelectedRows[i].Cells["id"].Value);
                    bORROWTableAdapter.Delete(global.user_id, bookId);
                }

                var lck = false;
                var some = bORROWTableAdapter.GetData(global.user_id);
                foreach (DataRow r in some.Rows)
                {
                    if (Convert.ToDateTime(r["ngay_muon"]).AddDays(14) < DateTime.Now)
                    {
                        lck = true;
                        break;
                    }
                }

                global.locked = lck;
                fillBooks();
            }

            dgvUsersBooks.ClearSelection();
        }

        private void dgvUsersBooks_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                if (global.locked)
                {
                    MessageBox.Show("Bạn chưa được đọc sách do tài khoản của bạn đã bị khóa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var readForm = new ReadBookForm(
                    dgvUsersBooks.Rows[e.RowIndex].Cells["tieu_de"].Value.ToString(),
                    dgvUsersBooks.Rows[e.RowIndex].Cells["noi_dung"].Value.ToString()
                );
                readForm.ShowDialog();
            }
        }

        private void dgvUsersBooks_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.A)
            {
                dgvUsersBooks.SelectAll();
                e.Handled = true;
            }
        }

        private void tbTimSach_TextChanged(object sender, EventArgs e)
        {
            string searchText = tbTimSach.Text.Trim();
            string safeSearch = searchText.Replace("'", "''");

            if (string.IsNullOrEmpty(searchText))
                bORROWBindingSource.Filter = "";
            else
                bORROWBindingSource.Filter = $"tieu_de LIKE '%{safeSearch}%'";
        }

        private void dgvUsersBooks_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            var r = dgvUsersBooks.Rows[e.RowIndex];
            if (Convert.ToDateTime(r.Cells["ngay_muon"].Value).AddDays(14) < DateTime.Now)
            {
                r.DefaultCellStyle.BackColor = Color.LightPink;
            }
        }
    }
}
