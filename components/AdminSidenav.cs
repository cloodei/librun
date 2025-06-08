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
            var f = this.FindForm();
            //MessageBox.Show(f.ToString() + "\n" + global.borrowAF.ToString(), "" + (f == global.borrowAF));
            global.borrowAF = global.swapForm(global.borrowAF, f);
        }

        private void btnQuanLySach_Click(object sender, EventArgs e)
        {
            global.booksAF = global.swapForm(global.booksAF, this.FindForm());
        }

        private void btnQuanLyNguoiDung_Click(object sender, EventArgs e)
        {
            global.usersAF = global.swapForm(global.usersAF, this.FindForm());
        }

        private void btnQuanLyPhanHoi_Click(object sender, EventArgs e)
        {
            global.repliesAF = global.swapForm(global.repliesAF, this.FindForm());
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            global.SignOut(this.FindForm());
        }
    }
}
