using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Library
{
    public partial class UserBooksBorrow : Form
    {
        string ketnoi = global.connectionString;
        SqlConnection connection;
        DataGridViewCellEventArgs a;
        SqlDataAdapter da;
        DataTable dt = new DataTable();
        long userId;

        public UserBooksBorrow(long e)
        {
            InitializeComponent();
            this.userId = e;
        }

        private void UserBooksBorrow_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(ketnoi);
            connection.Open();
            string sql = "SELECT BORROW.user_id, USERS.ten, USERS.email, USERS.trang_thai, BORROW.ngay_muon FROM BORROW INNER JOIN USERS ON BORROW.user_id = USERS.id WHERE book_id = @i";
            using(var command = new SqlCommand(sql, connection))
            {
                command.Parameters.AddWithValue("@i", userId);
                da = new SqlDataAdapter(command);
                dt.Clear();
                da.Fill(dt);
            }
            dataGridView2.DataSource = dt;
            if (dt.Rows.Count > 0)
            {
                dataGridView2.Columns[0].HeaderText = "Mã người mượn";
                dataGridView2.Columns[1].HeaderText = "Họ tên";
                dataGridView2.Columns[2].HeaderText = "Email";
                dataGridView2.Columns[3].HeaderText = "Trạng thái";
                dataGridView2.Columns[4].HeaderText = "Ngày mượn";

            }
            for (int i = 0; i < dataGridView2.RowCount; i++)
            {
                if (dataGridView2.Rows[i].Cells[3].Value.ToString() == "Hoạt động")
                {
                    dataGridView2.Rows[i].DefaultCellStyle.BackColor = Color.White;
                }
                else
                {
                    dataGridView2.Rows[i].DefaultCellStyle.BackColor = Color.LightPink;
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string keyword = ((TextBox)sender).Text.Trim();

            string sql = "SELECT  BORROW.user_id, USERS.ten, USERS.email, USERS.trang_thai, BORROW.ngay_muon FROM BORROW INNER JOIN USERS ON BORROW.user_id = USERS.id WHERE book_id = @i AND ten LIKE @ten";
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                command.Parameters.AddWithValue("@ten", "%" + keyword + "%");
                command.Parameters.AddWithValue("@i", userId);
                da = new SqlDataAdapter(command);
                dt.Clear();
                da.Fill(dt);
            }

            dataGridView2.DataSource = dt;
            if (dt.Rows.Count > 0)
            {
                dataGridView2.Columns[0].HeaderText = "Mã người mượn";
                dataGridView2.Columns[1].HeaderText = "Họ tên";
                dataGridView2.Columns[2].HeaderText = "Email";
                dataGridView2.Columns[3].HeaderText = "Trạng thái";
                dataGridView2.Columns[4].HeaderText = "Ngày mượn";

            }
            for (int i = 0; i < dataGridView2.RowCount; i++)
            {
                if (dataGridView2.Rows[i].Cells[3].Value.ToString() == "Hoạt động")
                {
                    dataGridView2.Rows[i].DefaultCellStyle.BackColor = Color.White;
                }
                else
                {
                    dataGridView2.Rows[i].DefaultCellStyle.BackColor = Color.LightPink;
                }
            }
        }
    }
}
