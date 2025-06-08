using System.Windows.Forms;

namespace Library
{
    public partial class ReadReplyForm : Form
    {
        public ReadReplyForm(string nd, string hd)
        {
            InitializeComponent();
            label1.Text += nd;
            label2.Text += hd;
        }
    }
}
