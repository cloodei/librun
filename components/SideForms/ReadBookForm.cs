using System.Drawing;
using System.Windows.Forms;

namespace Library
{
    public partial class ReadBookForm : Form
    {
        public ReadBookForm(string bn, string bc)
        {
            InitializeComponent();

            this.Text = "Đọc sách: " + bn;
            lbBookName.Text = bn;
            lbBookContents.Text = bc;

            lbBookName.Location = new Point(
                (lbBookName.Parent.ClientSize.Width - lbBookName.Width) / 2,
                (lbBookName.Parent.ClientSize.Height - lbBookName.Height) / 2
            );
        }

        private void panel1_Resize(object sender, System.EventArgs e)
        {
            lbBookName.Location = new Point(
                (lbBookName.Parent.ClientSize.Width - lbBookName.Width) / 2,
                (lbBookName.Parent.ClientSize.Height - lbBookName.Height) / 2
            );
        }
    }
}
