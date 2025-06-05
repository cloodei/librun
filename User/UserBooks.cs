using librun.adminBorrowDataSetTableAdapters;
using librun.User;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Library
{
    public partial class UserBooks : Form
    {
        private readonly Color PrimaryColor = Color.FromArgb(0, 123, 255);
        private readonly Color SecondaryColor = Color.FromArgb(40, 44, 52);

        public UserBooks()
        {
            InitializeComponent();
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

        private void btnHome_Click(object sender, EventArgs e)
        {
            var mainForm = new MainUserForm();
            mainForm.Show();
            this.Close();
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất?", "Xác nhận đăng xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                global.SignOut();

                var f = new SignInForm();
                f.Show();
                this.Close();
            }
        }

        void fillBooks()
        {
            bORROWTableAdapter.Fill(this.userBorrowedBooks.BORROW, global.user_id);

            foreach (DataGridViewRow row in dgvUsersBooks.Rows)
            {
                if (Convert.ToDateTime(row.Cells["ngay_muon"].Value).AddDays(14) < DateTime.Now)
                {
                    row.DefaultCellStyle.BackColor = Color.LightPink;
                }
            }
        }

        private void UserBooks_Load(object sender, EventArgs e)
        {
            SetActiveButton(btnQuanLySach);
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
                fillBooks();
                MessageBox.Show("Đã trả sách thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            {
                bORROWBindingSource.Filter = "";
            }
            else
            {
                bORROWBindingSource.Filter = $"tieu_de LIKE '%{safeSearch}%'";
            }
        }
    }
}
