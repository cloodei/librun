using System;
using System.Drawing;
using System.Windows.Forms;

namespace Library
{
    public partial class UserSidenav : UserControl
    {
        public UserSidenav()
        {
            InitializeComponent();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            global.mainUF = global.swapForm(global.mainUF, this.FindForm());
        }

        private void btnQuanLySach_Click(object sender, EventArgs e)
        {
            global.booksUF = global.swapForm(global.booksUF, this.FindForm());
        }

        private void btnGioiThieu_Click(object sender, EventArgs e)
        {
            try
            {
                string url = "https://www.youtube.com/watch?v=dQw4w9WgXcQ&pp=0gcJCdgAo7VqN5tD";
                System.Diagnostics.Process.Start(url);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Không thể mở liên kết: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pbUserProfile_Click(object sender, EventArgs e)
        {
            contextMenuStrip1.Show(pbUserProfile, new Point(pbUserProfile.Width, 0));
        }

        private void quảnLýTàiKhảoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            global.profileUF = global.swapForm(global.profileUF, this.FindForm());
        }

        private void xemThôngTinPhảnHồiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            global.repliesUF = global.swapForm(global.repliesUF, this.FindForm());
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            global.SignOut(this.FindForm());
        }
    }
}
