using System;
using System.Windows.Forms;

namespace Library
{
    public partial class AdminSidenav : UserControl
    {
        Form f;

        public AdminSidenav()
        {
            InitializeComponent();
        }

        private void AdminSidenav_Load(object sender, EventArgs e)
        {
            f = this.FindForm();
        }

        private void btnYeuCauMuonSach_Click(object sender, EventArgs e)
        {
            global.swapForm(global.borrowAF, f);
        }

        private void btnQuanLySach_Click(object sender, EventArgs e)
        {
            global.swapForm(global.booksAF, f);
        }

        private void btnQuanLyNguoiDung_Click(object sender, EventArgs e)
        {
            global.swapForm(global.usersAF, f);
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            global.SignOut(f);
        }
    }
}
