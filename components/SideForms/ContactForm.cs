using System.Windows.Forms;

namespace Library
{
    public partial class ContactForm : Form
    {
        public string ue;
        public string nd;
        public string pl;

        public ContactForm()
        {
            InitializeComponent();
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnSend_Click(object sender, System.EventArgs e)
        {
            if ((richTextBox2.Text = richTextBox2.Text.Trim()).Length == 0)
            {
                MessageBox.Show("Vui lòng nhập tài khoản của bạn", "Thông tin không hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if ((richTextBox1.Text = richTextBox1.Text.Trim()).Length == 0)
            {
                MessageBox.Show("Vui lòng nhập nội dung phản hồi", "Thông tin không hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (comboBox1.Text.Length == 0)
            {
                MessageBox.Show("Vui lòng phân loại phản hồi của bạn", "Thông tin không hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ue = richTextBox2.Text;
            nd = richTextBox1.Text;
            pl = char.ToLower(comboBox1.Text[0]) + comboBox1.Text.Substring(1);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
