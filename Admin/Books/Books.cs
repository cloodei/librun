using System;
using System.Data;

//using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Library
{
    public partial class Books : Form
    {
        private readonly Color PrimaryColor = Color.FromArgb(0, 123, 255);
        private readonly Color SecondaryColor = Color.FromArgb(40, 44, 52);
        public string ketnoi = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=lib;Integrated Security=True;Encrypt=False;Trust Server Certificate=True";
        public SqlConnection connection;
        public Books()
        {
            InitializeComponent();
            SetActiveButton(btnQuanLySach);
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

        private void btnYeuCauMuonSach_Click(object sender, EventArgs e)
        {
            var bs = new BorrowRequests();
            bs.Show();
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
        private void Books_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(ketnoi);
            connection.Open();
            string sql = "SELECT * FROM BOOKS";
            SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            dataGridView1.Columns[0].HeaderText = "Mã sách";
            dataGridView1.Columns[1].HeaderText = "Tên sách";
            dataGridView1.Columns[2].HeaderText = "Tác giả";
            dataGridView1.Columns[3].HeaderText = "Nội dung";
            dataGridView1.Columns[4].HeaderText = "Thể loại";
            dataGridView1.Columns[5].HeaderText = "Ngày xuất bản";

        }
        public bool ktra(string id)
        {
            connection = new SqlConnection(this.ketnoi);
            connection.Open();
            string sql = "SELECT COUNT(*) FROM BOOKS WHERE id = @ten";
            using (var command = new SqlCommand(sql, connection))
            {
                command.Parameters.AddWithValue("@ten", id);
                int count = (int)command.ExecuteScalar();
                return count > 0;
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            /*string ketnoi = "Data Source=.;Initial Catalog=sach;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";
            SqlConnection connection = new SqlConnection(ketnoi);
            connection.Open();
            string sql = "UPDATE sach SET tensach = @ten, tacgia = @tac, theloai = @tl, soluong = @sl, ngayxuatban = @nxb WHERE idsach = @id";
            using(SqlCommand com = new SqlCommand(sql, connection))
            {
                com.Parameters.AddWithValue("@id", textBox1.Text);
                com.Parameters.AddWithValue("@ten", textBox2.Text);
                com.Parameters.AddWithValue("@tac", textBox3.Text);
                com.Parameters.AddWithValue("@tl", textBox4.Text);
                com.Parameters.AddWithValue("@sl", textBox5.Text);
                com.Parameters.AddWithValue("@nxb", dateTimePicker1.Value);
                int rowsAffected = com.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Cập nhật thành công");
                    Books_Load(sender, e); // Refresh the DataGridView
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại");
                }
            }*/
            /*if (ktra(textBox1.Text))
            {
                MessageBox.Show("ID sách đã tồn tại");
                return;
            }
            int sl;
            try
            {
                sl = Convert.ToInt32(textBox5.Text);
            }
            catch
            {
                MessageBox.Show("Số lượng sách phải là một số nguyên");
                return;
            }*/
            connection = new SqlConnection(this.ketnoi);
            connection.Open();
            string sql = "INSERT INTO BOOKS (tieu_de, ten_tac_gia, noi_dung, the_loai, ngay_xuat_ban) VALUES (@ten, @tac, @nd, @tl, @nxb)";
            using (SqlCommand com = new SqlCommand(sql, connection))
            {
                com.Parameters.AddWithValue("@ten", textBox1.Text);
                com.Parameters.AddWithValue("@tac", textBox2.Text);
                com.Parameters.AddWithValue("@nd", textBox3.Text);
                com.Parameters.AddWithValue("@tl", textBox4.Text);
                com.Parameters.AddWithValue("@nxb", dateTimePicker1.Value);
                int rowsAffected = com.ExecuteNonQuery();
            }
            Books_Load(sender, e); // Refresh the DataGridView
            textBox1.Text = ""; // Clear the ID textbox after adding
            textBox2.Text = ""; // Clear the book name textbox after adding
            textBox3.Text = ""; // Clear the author textbox after adding
            textBox4.Text = ""; // Clear the genre textbox after adding
            //textBox5.Text = ""; // Clear the quantity textbox after adding
            dateTimePicker1.Value = DateTime.Now; // Reset the date picker to current date
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                DialogResult re = MessageBox.Show("Sửa không", "Sửa không", MessageBoxButtons.YesNo);
                if (re == DialogResult.No)
                {
                    DialogResult ro = MessageBox.Show("Xóa không", "Xóa không", MessageBoxButtons.YesNo);
                    if (ro == DialogResult.Yes)
                    {
                        DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                        int ms = Convert.ToInt32(row.Cells[0].Value); // Get the ID of the book to delete  
                        connection = new SqlConnection(this.ketnoi);
                        connection.Open();
                        string sql = "DELETE FROM sach WHERE id = @masach";
                        using (var command = new SqlCommand(sql, connection))
                        {
                            command.Parameters.AddWithValue("@masach", ms);
                            command.ExecuteNonQuery();
                        }
                        MessageBox.Show("Xóa thành công");
                        Books_Load(sender, e);
                    }
                    if (ro == DialogResult.No)
                    {
                        return; // Do nothing if the user chooses not to delete
                    }
                }
                if (re == DialogResult.Yes)
                {
                    button1.Enabled = false; // Disable the add button when editing
                    button1.Visible = false; // Hide the add button when editing
                    button2.Enabled = true; // Enable the update button when editing
                    button2.Visible = true; // Show the update button when editing
                    textBox1.Enabled = false;
                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                    textBox1.Text = row.Cells[1].Value.ToString(); // IDsach
                    textBox2.Text = row.Cells[2].Value.ToString(); // TenSach
                    textBox3.Text = row.Cells[3].Value.ToString(); // TacGia
                    textBox4.Text = row.Cells[4].Value.ToString(); // TheLoai
                    //textBox5.Text = row.Cells[4].Value.ToString(); // SoLuong
                    dateTimePicker1.Value = Convert.ToDateTime(row.Cells[5].Value); // NgayXuatBan
                }

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            connection = new SqlConnection(this.ketnoi);
            connection.Open();
            string sql = "UPDATE BOOKS SET tieu_de = @ten, ten_tac_gia = @tac, noi_dung = @nd, theloai = @tl, ngay_xuat_ban = @nxb WHERE id = @id";
            using (SqlCommand com = new SqlCommand(sql, connection))
            {
                com.Parameters.AddWithValue("@ten", textBox1.Text);
                com.Parameters.AddWithValue("@tac", textBox2.Text);
                com.Parameters.AddWithValue("@nd", textBox3.Text);
                com.Parameters.AddWithValue("@tl", textBox4.Text);
                com.Parameters.AddWithValue("@nxb", dateTimePicker1.Value);
                int rowsAffected = com.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Cập nhật thành công");
                    Books_Load(sender, e); // Refresh the DataGridView
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại");
                }
            }
            button1.Enabled = true;
            button1.Visible = true; // Show the add button after updating
            button2.Enabled = false; // Disable the update button after updating
            button2.Visible = false; // Hide the update button after updating
            Books_Load(sender, e); // Refresh the DataGridView
            textBox1.Text = ""; // Clear the ID textbox after adding
            textBox2.Text = ""; // Clear the book name textbox after adding
            textBox3.Text = ""; // Clear the author textbox after adding
            textBox4.Text = ""; // Clear the genre textbox after adding
            dateTimePicker1.Value = DateTime.Now; // Reset the date picker to current date
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            string keyword = ((TextBox)sender).Text.Trim();

            if (string.IsNullOrEmpty(keyword))
            {
                Books_Load(sender, e); // Hiển thị lại toàn bộ danh sách nếu không nhập gì
                return;
            }
            try
            {
                DataTable dataTable = new DataTable();
                using (SqlConnection connection = new SqlConnection(this.ketnoi))
                {
                    connection.Open();
                    string sql = "SELECT * FROM BOOKS WHERE tieu_de LIKE @ten";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@ten", keyword + "%"); // tìm tiêu đề bắt đầu bằng từ khóa
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        adapter.Fill(dataTable);
                    }
                }

                dataGridView1.DataSource = dataTable;

                if (dataTable.Rows.Count > 0)
                {
                    dataGridView1.Columns[0].HeaderText = "Mã sách";
                    dataGridView1.Columns[1].HeaderText = "Tên sách";
                    dataGridView1.Columns[2].HeaderText = "Tác giả";
                    dataGridView1.Columns[3].HeaderText = "Nội dung";
                    dataGridView1.Columns[4].HeaderText = "Thể loại";
                    dataGridView1.Columns[5].HeaderText = "Ngày xuất bản";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi tìm kiếm: " + ex.Message);
                Books_Load(sender, e); // Nếu có lỗi, nạp lại danh sách
            }
        
                /*DataTable dataTable = new DataTable();
                connection = new SqlConnection(this.ketnoi);
                connection.Open();
                string sql = "SELECT * FROM BOOKS WHERE tieu_de = @ten";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@ten", tk);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
                }
                dataGridView1.DataSource = dataTable;
                dataGridView1.Columns[0].HeaderText = "Mã sách";
                dataGridView1.Columns[1].HeaderText = "Tên sách";
                dataGridView1.Columns[2].HeaderText = "Tác giả";
                dataGridView1.Columns[3].HeaderText = "Nội dung";
                dataGridView1.Columns[4].HeaderText = "Thể loại";
                dataGridView1.Columns[5].HeaderText = "Ngày xuất bản";
                */
            
        }
    }
}
