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
            SetActiveButton(btnYeuCauMuonSach);
            LoadBorrowedBooks();
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

        private void LoadBorrowedBooks()
        {
            var dt = new DataTable();
            dt.Columns.Add("Book ID", typeof(string));
            dt.Columns.Add("User ID", typeof(string));
            dt.Columns.Add("Borrow Date", typeof(DateTime));
            dt.Columns.Add("Due Date", typeof(DateTime));

            dt.Rows.Add("B001", "U001", DateTime.Now.AddDays(-10), DateTime.Now.AddDays(4));
            dt.Rows.Add("B002", "U002", DateTime.Now.AddDays(-5), DateTime.Now.AddDays(9));
            dt.Rows.Add("B003", "U001", DateTime.Now.AddDays(-20), DateTime.Now.AddDays(-6));

            dgvBorrowedBooks.Rows.Clear();
            foreach (DataRow row in dt.Rows)
            {
                dgvBorrowedBooks.Rows.Add(row.ItemArray);
            }
        }

        private void DgvBorrowedBooks_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvBorrowedBooks.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvBorrowedBooks.SelectedRows[0];
                txtBookId.Text = selectedRow.Cells["Book ID"].Value?.ToString();
                txtUserId.Text = selectedRow.Cells["User ID"].Value?.ToString();

                if (selectedRow.Cells["Borrow Date"].Value != null && DateTime.TryParse(selectedRow.Cells["Borrow Date"].Value.ToString(), out DateTime borrowDate))
                {
                    dtpBorrowDate.Value = borrowDate;
                }
                if (selectedRow.Cells["Due Date"].Value != null && DateTime.TryParse(selectedRow.Cells["Due Date"].Value.ToString(), out DateTime dueDate))
                {
                    dtpDueDate.Value = dueDate;
                }
            }
            else
            {
                ClearDetailControls();
            }
        }

        private void ClearDetailControls()
        {
            txtBookId.Clear();
            txtUserId.Clear();
            dtpBorrowDate.Value = DateTime.Now;
            dtpDueDate.Value = DateTime.Now;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            // Placeholder: Implement add logic
            if (string.IsNullOrWhiteSpace(txtBookId.Text) || string.IsNullOrWhiteSpace(txtUserId.Text))
            {
                MessageBox.Show("Book ID and User ID cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("Add functionality not yet implemented.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadBorrowedBooks(); // Refresh data
            ClearDetailControls();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            // Placeholder: Implement update logic
            if (dgvBorrowedBooks.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a record to update.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtBookId.Text) || string.IsNullOrWhiteSpace(txtUserId.Text))
            {
                MessageBox.Show("Book ID and User ID cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("Update functionality not yet implemented.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadBorrowedBooks();
            ClearDetailControls();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (dgvBorrowedBooks.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a record to delete.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            var confirmation = MessageBox.Show("Are you sure you want to delete this record?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirmation == DialogResult.Yes)
            {
                MessageBox.Show("Delete functionality not yet implemented.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadBorrowedBooks(); // Refresh data
                ClearDetailControls();
            }
        }
    }
}
