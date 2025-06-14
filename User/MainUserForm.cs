using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Library
{
    public partial class MainUserForm : Form, IFData
    {
        SqlDataAdapter da;
        DataTable dt = new DataTable();

        int so_sach_da_chon = 0;

        public MainUserForm()
        {
            InitializeComponent();
            global.SetActiveButton(userSidenav1.panel1.Controls, userSidenav1.btnHome);
        }

        public void InitForm()
        {
            this.bOOKSTableAdapter2.Fill(this.userBooksDataSet.BOOKS);
            dgvBooks.ClearSelection();

            da = new SqlDataAdapter(
                "SELECT book_id FROM BORROW WHERE user_id = " + global.user_id,
                global.connectionString
            );

            handleBooks();
        }

        public void ResetFields()
        {
            tbTimSach.ResetText();
            so_sach_da_chon = 0;
        }

        void handleBooks()
        {
            dt.Clear();
            da.Fill(dt);

            for (int i = 0; i < dgvBooks.RowCount; ++i)
            {
                for (int j = 0; j < dt.Rows.Count; ++j)
                {
                    if (dgvBooks.Rows[i].Cells[0].Value.ToString() == dt.Rows[j][0].ToString())
                    {
                        dgvBooks.Rows[i].DefaultCellStyle.BackColor = Color.LightGray;
                        break;
                    }
                }
            }
        }

        private void MainUserForm_Load(object sender, EventArgs e)
        {
            InitForm();
        }

        private void ChonSach(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgvBooks.Rows[e.RowIndex];

                if (row.DefaultCellStyle.BackColor == Color.LightGray)
                    return;

                if (row.DefaultCellStyle.BackColor == Color.LightBlue)
                {
                    row.DefaultCellStyle.BackColor = Color.White;
                    so_sach_da_chon--;
                }
                else
                {
                    row.DefaultCellStyle.BackColor = Color.LightBlue;
                    so_sach_da_chon++;
                }
            }

            dgvBooks.ClearSelection();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (so_sach_da_chon == 0)
                return;

            if (global.locked)
            {
                MessageBox.Show("Bạn chưa được mượn sách do tài khoản của bạn đã bị hạn chế!Vui lòng trả những đầu sách quá hạn để tiếp tục.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var result = MessageBox.Show($"Bạn đã chọn {so_sach_da_chon} quyển sách. Bạn có chắc chắn muốn mượn những sách này không?", "Xác nhận mượn sách", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                for (int i = 0; i < dgvBooks.RowCount; i++)
                {
                    if (dgvBooks.Rows[i].DefaultCellStyle.BackColor == Color.LightBlue)
                    {
                        bOOKSTableAdapter2.Insert(global.user_id, Convert.ToInt64(dgvBooks.Rows[i].Cells[0].Value), DateTime.Now.ToString());
                        dgvBooks.Rows[i].DefaultCellStyle.BackColor = Color.White;
                    }
                }

                handleBooks();
                so_sach_da_chon = 0;
            }
        }

        private void dgvBooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void tbTimSach_TextChanged(object sender, EventArgs e)
        {
            string searchText = tbTimSach.Text.Trim();
            string safeSearch = searchText.Replace("'", "''");

            if (string.IsNullOrEmpty(searchText))
                bOOKSBindingSource2.Filter = "";
            else
                bOOKSBindingSource2.Filter = $"tieu_de LIKE '%{safeSearch}%'";

            handleBooks();
        }

        private void MainUserForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
