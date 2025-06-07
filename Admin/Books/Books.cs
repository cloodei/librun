using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Library
{
    public partial class Books : Form
    {
        string ketnoi = librun.Properties.Settings.Default.mainConnectionString;
        SqlConnection connection;
        DataGridViewCellEventArgs a;
        SqlDataAdapter da;
        DataTable dt = new DataTable();

        public Books()
        {
            InitializeComponent();
            global.SetActiveButton(panel1.Controls, btnQuanLySach);
        }

        private void btnYeuCauMuonSach_Click(object sender, EventArgs e)
        {
            global.swapForm(global.borrowAF, this);
        }

        private void btnQuanLyNguoiDung_Click(object sender, EventArgs e)
        {
            global.swapForm(global.usersAF, this);
        }

        private void btnSignOut_Click_1(object sender, EventArgs e)
        {
            global.SignOut(this);
        }

        private void Books_Load(object sender, EventArgs e)
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
        }

        public bool ktra()
        {
            string sql = "SELECT COUNT(*) FROM Books WHERE tieu_de = @ten AND ten_tac_gia = @tac AND noi_dung = @nd AND the_loai = @tl";
            using (var com = new SqlCommand(sql, connection))
            {
                com.Parameters.AddWithValue("@ten", textBox1.Text);
                com.Parameters.AddWithValue("@tac", textBox2.Text);
                com.Parameters.AddWithValue("@nd", textBox3.Text);
                com.Parameters.AddWithValue("@tl", textBox4.Text);
                return com.ExecuteNonQuery() > 0;
            }
        }

        void flipButtons(bool show1)
        {
            button1.Enabled = show1;
            button1.Visible = show1;
            button2.Enabled = !show1;
            button2.Visible = !show1;
            button3.Enabled = !show1;
            button3.Visible = !show1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0)
            {
                MessageBox.Show("Nhập lại tên sách");
                return;
            }

            if (textBox2.Text.Length == 0)
            {
                MessageBox.Show("Nhập lại tên tác giả");
                return;
            }

            if (textBox3.Text.Length == 0)
            {
                MessageBox.Show("Nhập lại nội dung sách");
                return;
            }

            if (textBox4.Text.Length == 0)
            {
                MessageBox.Show("Nhập lại thể loại sách");
                return;
            }

            if(!ktra())
            {
                MessageBox.Show("Sách đã tồn tại trong hệ thống");
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                dateTimePicker1.Value = DateTime.Now;
                return;
            }

            string sql = "INSERT INTO BOOKS (tieu_de, ten_tac_gia, noi_dung, the_loai, ngay_xuat_ban) VALUES (@ten, @tac, @nd, @tl, @nxb)";
            using (var com = new SqlCommand(sql, connection))
            {
                com.Parameters.AddWithValue("@ten", textBox1.Text);
                com.Parameters.AddWithValue("@tac", textBox2.Text);
                com.Parameters.AddWithValue("@nd", textBox3.Text);
                com.Parameters.AddWithValue("@tl", textBox4.Text);
                com.Parameters.AddWithValue("@nxb", dateTimePicker1.Value);
                com.ExecuteNonQuery();
            }

            dt.Clear();
            da.Fill(dt);

            flipButtons(true);
            dataGridView1.ClearSelection();

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            dateTimePicker1.Value = DateTime.Now;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= dataGridView1.Rows.Count - 1 || e.RowIndex < 0)
            {
                return;
            }
            flipButtons(false);

            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            textBox1.Text = row.Cells[1].Value.ToString();
            textBox2.Text = row.Cells[2].Value.ToString();
            textBox3.Text = row.Cells[3].Value.ToString();
            textBox4.Text = row.Cells[4].Value.ToString();

            dateTimePicker1.Value = Convert.ToDateTime(row.Cells[5].Value);
            a = e;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.Rows[a.RowIndex];
            long ide = Convert.ToInt64(row.Cells[0].Value);

            string sql = "UPDATE BOOKS SET tieu_de = @ten, ten_tac_gia = @tac, noi_dung = @nd, the_loai = @tl, ngay_xuat_ban = @nxb WHERE id = @id";
            using (SqlCommand com = new SqlCommand(sql, connection))
            {
                com.Parameters.AddWithValue("@id", ide);
                com.Parameters.AddWithValue("@ten", textBox1.Text);
                com.Parameters.AddWithValue("@tac", textBox2.Text);
                com.Parameters.AddWithValue("@nd", textBox3.Text);
                com.Parameters.AddWithValue("@tl", textBox4.Text);
                com.Parameters.AddWithValue("@nxb", dateTimePicker1.Value);
                com.ExecuteNonQuery();

                MessageBox.Show("Cập nhật thành công");
            }

            flipButtons(true);

            dt.Clear();
            da.Fill(dt);

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            dateTimePicker1.Value = DateTime.Now;
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            string keyword = ((TextBox)sender).Text.Trim();

            try
            {
                if (string.IsNullOrEmpty(keyword))
                {
                    Books_Load(sender, e);
                    return;
                }
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
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi tìm kiếm: " + ex.Message);
                Books_Load(sender, e);
            }
        }

        private void dataGridView1_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= dataGridView1.Rows.Count - 1 || e.RowIndex < 0)
            {
                return;
            }
            long ma = Convert.ToInt64(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
            var ub = new UserBooksBorrow(ma);
            ub.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.Rows[a.RowIndex];
            long ide = Convert.ToInt64(row.Cells[0].Value);

            string sql = "DELETE FROM BOOKS WHERE id = @masach";
            using (var command = new SqlCommand(sql, connection))
            {
                command.Parameters.AddWithValue("@masach", ide);
                command.ExecuteNonQuery();
            }
            MessageBox.Show("Xóa thành công");

            flipButtons(true);
            dt.Clear();
            da.Fill(dt);

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            dateTimePicker1.Value = DateTime.Now;
        }
    }
}
