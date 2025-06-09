using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Library
{
    public partial class Books : Form, IFData
    {
        string ketnoi = global.connectionString;
        SqlConnection connection;
        SqlDataAdapter da;
        DataTable dt = new DataTable();

        public Books()
        {
            InitializeComponent();
            global.SetActiveButton(adminSidenav1.panel1.Controls, adminSidenav1.btnQuanLySach);
        }

        public void InitForm()
        {
            connection = new SqlConnection(ketnoi);
            connection.Open();
            string sql = "SELECT * FROM BOOKS";
            da = new SqlDataAdapter(sql, connection);
            dt.Clear();
            da.Fill(dt);

            dataGridView1.DataSource = dt;

            dataGridView1.Columns[0].HeaderText = "Mã sách";
            dataGridView1.Columns[1].HeaderText = "Tên sách";
            dataGridView1.Columns[2].HeaderText = "Tác giả";
            dataGridView1.Columns[3].HeaderText = "Nội dung";
            dataGridView1.Columns[4].HeaderText = "Thể loại";
            dataGridView1.Columns[5].HeaderText = "Ngày xuất bản";

            try
            {
                var _ = dataGridView1.Columns[6];
            }
            catch
            {
                dataGridView1.Columns.Add("sua", "");
                dataGridView1.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            try
            {
                var _ = dataGridView1.Columns[7];
            }
            catch
            {
                dataGridView1.Columns.Add("xoa", "");
                dataGridView1.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                dataGridView1.Rows[i].Cells[6].Value = "Sửa";
                dataGridView1.Rows[i].Cells[7].Value = "Xóa";
                dataGridView1.Columns[6].DefaultCellStyle.BackColor = Color.LightGreen;
                dataGridView1.Columns[7].DefaultCellStyle.BackColor = Color.LightPink;
            }
            foreach (DataGridViewColumn col in dataGridView1.Columns)
            {
                col.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        public void ResetFields()
        {
            textBox1.ResetText();
        }

        private void Books_Load(object sender, EventArgs e)
        {
            InitForm();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BorrowBookForm bookForm = new BorrowBookForm(this, da,  dt, 0);
            bookForm.ShowDialog();
            this.Enabled = false;
            bookForm.button3.Enabled = false;
            bookForm.button3.Visible = false;
            bookForm.button1.Enabled = true;
            bookForm.button1.Visible = true;
        }

        private void button1_EnabledChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                dataGridView1.Rows[i].Cells[6].Value = "Sửa";
                dataGridView1.Rows[i].Cells[7].Value = "Xóa";
                dataGridView1.Columns[6].DefaultCellStyle.BackColor = Color.LightGreen;
                dataGridView1.Columns[7].DefaultCellStyle.BackColor = Color.LightPink;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                if(e.ColumnIndex == 6)
                {
                    long id = Convert.ToInt64(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                    BorrowBookForm bookForm = new BorrowBookForm(this, da, dt, id);
                    bookForm.ShowDialog();
                    this.Enabled = false;
                    bookForm.button3.Enabled = true;
                    bookForm.button3.Visible = true;
                    bookForm.button1.Enabled = false;
                    bookForm.button1.Visible = false;
                    bookForm.textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                    bookForm.textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                    bookForm.richTextBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                    bookForm.textBox4.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                    bookForm.dateTimePicker1.Value = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells[5].Value);
                }
                else if(e.ColumnIndex == 7)
                {
                    DialogResult result = MessageBox.Show(
                        "Bạn có chắc chắn muốn xóa sách này?",
                        "Xác nhận xóa",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );
                    if( result == DialogResult.Yes)
                    {
                        string sql = "DELETE FROM BOOKS WHERE id = @masach";
                        using (var command = new SqlCommand(sql, connection))
                        {
                            command.Parameters.AddWithValue("@masach", dataGridView1.CurrentRow.Cells[0].Value);
                            command.ExecuteNonQuery();
                        }
                        MessageBox.Show("Xóa thành công");
                        dt.Clear();
                        da.Fill(dt);
                        for (int i = 0; i < dataGridView1.RowCount; i++)
                        {
                            dataGridView1.Rows[i].Cells[6].Value = "Sửa";
                            dataGridView1.Rows[i].Cells[7].Value = "Xóa";
                            dataGridView1.Columns[6].DefaultCellStyle.BackColor = Color.LightGreen;
                            dataGridView1.Columns[7].DefaultCellStyle.BackColor = Color.LightPink;
                        }
                    }
                }
                else
                {
                    UserBooksBorrow ub = new UserBooksBorrow(Convert.ToInt64(dataGridView1.Rows[e.RowIndex].Cells[0].Value));
                    ub.ShowDialog();
                }
            }
        }


        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            string keyword = ((TextBox)sender).Text.Trim();

            try
            {
                string sql = "SELECT * FROM BOOKS WHERE tieu_de LIKE @ten";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@ten", "%" + keyword + "%");
                    da = new SqlDataAdapter(command);
                    dt.Clear();
                    da.Fill(dt);
                }

                dataGridView1.DataSource = dt;

                if (dt.Rows.Count > 0)
                {
                    dataGridView1.Columns[0].HeaderText = "Mã sách";
                    dataGridView1.Columns[1].HeaderText = "Tên sách";
                    dataGridView1.Columns[2].HeaderText = "Tác giả";
                    dataGridView1.Columns[3].HeaderText = "Nội dung";
                    dataGridView1.Columns[4].HeaderText = "Thể loại";
                    dataGridView1.Columns[5].HeaderText = "Ngày xuất bản";
                }
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    dataGridView1.Rows[i].Cells[6].Value = "Sửa";
                    dataGridView1.Rows[i].Cells[7].Value = "Xóa";
                    dataGridView1.Columns[6].DefaultCellStyle.BackColor = Color.LightGreen;
                    dataGridView1.Columns[7].DefaultCellStyle.BackColor = Color.LightPink;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi tìm kiếm: " + ex.Message);
                Books_Load(sender, e);
            }
        }

        private void dataGridView1_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                dataGridView1.Rows[e.RowIndex].Cells[0].Style.BackColor = Color.LightBlue;
                dataGridView1.Rows[e.RowIndex].Cells[1].Style.BackColor = Color.LightBlue;
                dataGridView1.Rows[e.RowIndex].Cells[2].Style.BackColor = Color.LightBlue;
                dataGridView1.Rows[e.RowIndex].Cells[3].Style.BackColor = Color.LightBlue;
                dataGridView1.Rows[e.RowIndex].Cells[4].Style.BackColor = Color.LightBlue;
                dataGridView1.Rows[e.RowIndex].Cells[5].Style.BackColor = Color.LightBlue;
            }
        }

        private void dataGridView1_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dataGridView1.Rows[e.RowIndex].Cells[0].Style.BackColor = Color.White;
                dataGridView1.Rows[e.RowIndex].Cells[1].Style.BackColor = Color.White;
                dataGridView1.Rows[e.RowIndex].Cells[2].Style.BackColor = Color.White;
                dataGridView1.Rows[e.RowIndex].Cells[3].Style.BackColor = Color.White;
                dataGridView1.Rows[e.RowIndex].Cells[4].Style.BackColor = Color.White;
                dataGridView1.Rows[e.RowIndex].Cells[5].Style.BackColor = Color.White;
            }
        }

        private void Books_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
