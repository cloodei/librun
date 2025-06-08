using System;
using System.Windows.Forms;

namespace Library
{
    public partial class Replies : Form, IFData
    {
        public Replies()
        {
            InitializeComponent();
            global.SetActiveButton(adminSidenav1.panel1.Controls, adminSidenav1.btnQuanLyPhanHoi);
        }

        public void InitForm()
        {

        }

        private void BorrowRequests_Load(object sender, EventArgs e)
        {

        }
    }
}
