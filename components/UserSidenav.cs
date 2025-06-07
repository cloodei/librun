using System;
using System.Drawing;
using System.Windows.Forms;

namespace Library
{
    public partial class UserSidenav : UserControl
    {
        Form f;

        public UserSidenav()
        {
            InitializeComponent();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            global.swapForm(global.mainUF, f);
        }

        private void btnQuanLySach_Click(object sender, EventArgs e)
        {
            global.swapForm(global.booksUF, f);
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
            global.swapForm(global.profileUF, f);
        }

        private void xemThôngTinPhảnHồiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            global.swapForm(global.repliesUF, f);
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            global.SignOut(f);
        }

        private void UserSidenav_Load(object sender, EventArgs e)
        {
            f = this.FindForm();
        }
    }
}
