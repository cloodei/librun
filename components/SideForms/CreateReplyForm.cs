using System.Windows.Forms;

namespace Library
{
    public partial class CreateReplyForm : Form
    {
        public string userReply;
        public string userRepType;

        public CreateReplyForm()
        {
            InitializeComponent();
            this.DialogResult = DialogResult.Cancel;
        }

        public CreateReplyForm(string nd, string pl)
        {
            InitializeComponent();
            this.DialogResult = DialogResult.OK;
            this.userReply = richTextBox1.Text = nd;
            this.userRepType = comboBox1.Text = pl;
        }

        private void btnSend_Click(object sender, System.EventArgs e)
        {
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

            if (userReply == richTextBox1.Text && userRepType == comboBox1.Text)
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
                return;
            }

            userReply = richTextBox1.Text;
            userRepType = char.ToLower(comboBox1.Text[0]) + comboBox1.Text.Substring(1);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
