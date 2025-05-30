using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Library
{
    public partial class MainUserForm : Form
    {
        private readonly Color PrimaryColor = Color.FromArgb(0, 123, 255);
        private readonly Color SecondaryColor = Color.FromArgb(40, 44, 52);

        public MainUserForm()
        {
            InitializeComponent();
            LoadBooks();
            SetActiveButton(btnHome);
        }

        private void dgvBooks_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dgvBooks.Cursor = Cursors.Hand;
            }
        }

        private void dgvBooks_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            dgvBooks.Cursor = Cursors.Default;
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

        private void btnQuanLySach_Click(object sender, EventArgs e)
        {
            var userBooks = new UserBooks();
            userBooks.Show();
            this.Close();
        }

        private void LoadBooks()
        {
            var books = new[]
            {
                new {
                    Cover = (Image)null,
                    Title = "The Great Gatsby",
                    Author = "F. Scott Fitzgerald",
                    Published = new DateTime(1925, 4, 10),
                    Status = "Available",
                    Actions = "View Details"
                },
                new {
                    Cover = (Image)null,
                    Title = "To Kill a Mockingbird",
                    Author = "Harper Lee",
                    Published = new DateTime(1960, 7, 11),
                    Status = "Available",
                    Actions = "View Details"
                },
                new {
                    Cover = (Image)null,
                    Title = "1984",
                    Author = "George Orwell",
                    Published = new DateTime(1949, 6, 8),
                    Status = "Borrowed",
                    Actions = "View Details"
                },
                new {
                    Cover = (Image)null,
                    Title = "Pride and Prejudice",
                    Author = "Jane Austen",
                    Published = new DateTime(1813, 1, 28),
                    Status = "Available",
                    Actions = "View Details"
                },
                new {
                    Cover = (Image)null,
                    Title = "The Hobbit",
                    Author = "J.R.R. Tolkien",
                    Published = new DateTime(1937, 9, 21),
                    Status = "Available",
                    Actions = "View Details"
                },
            };

            dgvBooks.DataSource = books;

            if (dgvBooks.Columns.Count > 0)
            {
                dgvBooks.Columns["Published"].DefaultCellStyle.Format = "d MMM yyyy";
                dgvBooks.Columns["Status"].DefaultCellStyle.ForeColor = Color.Green;
                dgvBooks.Columns["Status"].DefaultCellStyle.Font = new Font("Segoe UI", 9, FontStyle.Bold);
                dgvBooks.Columns["Status"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvBooks.Columns["Actions"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvBooks.Columns["Actions"].DefaultCellStyle.ForeColor = PrimaryColor;
                dgvBooks.Columns["Actions"].DefaultCellStyle.Font = new Font("Segoe UI", 9, FontStyle.Underline);
                dgvBooks.Columns["Cover"].Width = 80;
                dgvBooks.Columns["Status"].Width = 100;
                dgvBooks.Columns["Actions"].Width = 120;
                dgvBooks.Columns["Published"].Width = 120;
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

        private void MainUserForm_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
