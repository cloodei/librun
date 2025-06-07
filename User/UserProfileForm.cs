using System;
using System.Drawing;
using System.Windows.Forms;

namespace Library
{
    public partial class UserProfileForm : Form
    {
        public UserProfileForm()
        {
            InitializeComponent();
        }

        private void UserBooks_Load(object sender, EventArgs e)
        {
            global.SetActiveButton(userSidenav1.panel1.Controls, null);
        }
    }
}
