using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace librun.Admin.Books
{
    public partial class BorrowBookForm : Form
    {
        string ketnoi = librun.Properties.Settings.Default.mainConnectionString;
        SqlConnection connection;
        SqlDataAdapter da;
        DataTable dt = new DataTable();
        public long ide;
        public Form form;
        public BorrowBookForm(Form bf, SqlDataAdapter da, DataTable dt, long r)
        {
            InitializeComponent();
            this.form = bf;
            this.da = da;
            this.dt = dt;
            this.ide = r;
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

            if (richTextBox1.Text.Length == 0)
            {
                MessageBox.Show("Nhập lại nội dung sách");
                return;
            }

            if (textBox4.Text.Length == 0)
            {
                MessageBox.Show("Nhập lại thể loại sách");
                return;
            }
            if (ktra())
            {
                MessageBox.Show("Sách đã tồn tại");
                return;
            }
            DialogResult result = MessageBox.Show(
                "Thêm sách không?",
                "chắc chưa?",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );
            if (result == DialogResult.No)
            {
                return;
            }

            string sql = "INSERT INTO BOOKS (tieu_de, ten_tac_gia, noi_dung, the_loai, ngay_xuat_ban) VALUES (@ten, @tac, @nd, @tl, @nxb)";
            using (var com = new SqlCommand(sql, connection))
            {
                com.Parameters.AddWithValue("@ten", textBox1.Text);
                com.Parameters.AddWithValue("@tac", textBox2.Text);
                com.Parameters.AddWithValue("@nd", richTextBox1.Text);
                com.Parameters.AddWithValue("@tl", textBox4.Text);
                com.Parameters.AddWithValue("@nxb", dateTimePicker1.Value);
                com.ExecuteNonQuery();
            }
            dt.Clear();
            da.Fill(dt);
            textBox1.Text = "";
            textBox2.Text = "";
            richTextBox1.Text = "";
            textBox4.Text = "";
            dateTimePicker1.Value = DateTime.Now;
        }

        public bool ktra()
        {
            string sql = "SELECT COUNT(*) FROM Books WHERE tieu_de = @ten";
            using (var com = new SqlCommand(sql, connection))
            {
                com.Parameters.AddWithValue("@ten", textBox1.Text);
                return (int)com.ExecuteScalar() > 0;
            }
        }
        private void BorrowBookForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libDataSet2.BOOKS' table. You can move, or remove it, as needed.
            connection = new SqlConnection(ketnoi);
            connection.Open();

        }

        private void BorrowBookForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            form.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            richTextBox1.Text = "";
            textBox4.Text = "";
            dateTimePicker1.Value = DateTime.Now;
        }

        private void button3_Click(object sender, EventArgs e)
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

            if (richTextBox1.Text.Length == 0)
            {
                MessageBox.Show("Nhập lại nội dung sách");
                return;
            }

            if (textBox4.Text.Length == 0)
            {
                MessageBox.Show("Nhập lại thể loại sách");
                return;
            }
            if (ktra())
            {
                MessageBox.Show("Sách đã tồn tại");
                return;
            }
            DialogResult result = MessageBox.Show(
                "Sửa sách không?",
                "chắc chưa?",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );
            if (result == DialogResult.No)
            {
                return;
            }
            string sql = "UPDATE BOOKS SET tieu_de = @ten, ten_tac_gia = @tac, noi_dung = @nd, the_loai = @tl, ngay_xuat_ban = @nxb WHERE id = @id";
            using (SqlCommand com = new SqlCommand(sql, connection))
            {
                com.Parameters.AddWithValue("@id", ide);
                com.Parameters.AddWithValue("@ten", textBox1.Text);
                com.Parameters.AddWithValue("@tac", textBox2.Text);
                com.Parameters.AddWithValue("@nd", richTextBox1.Text);
                com.Parameters.AddWithValue("@tl", textBox4.Text);
                com.Parameters.AddWithValue("@nxb", dateTimePicker1.Value);
                com.ExecuteNonQuery();
                MessageBox.Show("Cập nhật thành công");
            }
            dt.Clear();
            da.Fill(dt);
            textBox1.Text = "";
            textBox2.Text = "";
            richTextBox1.Text = "";
            textBox4.Text = "";
            dateTimePicker1.Value = DateTime.Now;
            form.Enabled = true;
            this.Close();
        }
    }
}
