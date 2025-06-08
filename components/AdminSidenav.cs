using System;
using System.Windows.Forms;

namespace Library
{
    public partial class AdminSidenav : UserControl
    {
        public AdminSidenav()
        {
            InitializeComponent();
        }

        private void btnYeuCauMuonSach_Click(object sender, EventArgs e)
        {
            global.swapForm(global.borrowAF, this.FindForm());
        }

        private void btnQuanLySach_Click(object sender, EventArgs e)
        {
            global.swapForm(global.booksAF, this.FindForm());
        }

        private void btnQuanLyNguoiDung_Click(object sender, EventArgs e)
        {
            global.swapForm(global.usersAF, this.FindForm());
        }

        private void btnQuanLyPhanHoi_Click(object sender, EventArgs e)
        {
            global.swapForm(global.repliesAF, this.FindForm());
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            global.SignOut(this.FindForm());
        }
    }
}
