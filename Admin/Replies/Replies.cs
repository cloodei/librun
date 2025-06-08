using System;
using System.Drawing;
using System.Windows.Forms;

namespace Library
{
    public partial class Replies : Form
    {
        public Replies()
        {
            InitializeComponent();
            global.SetActiveButton(adminSidenav1.panel1.Controls, adminSidenav1.btnTtMuonSach);
        }

        private void BorrowRequests_Load(object sender, EventArgs e)
        {

        }
    }
}
