using System.Drawing;
using System.Windows.Forms;

namespace Library
{
    public static class global
    {
        public static readonly Color PrimaryColor = Color.FromArgb(0, 123, 255);
        public static readonly Color SecondaryColor = Color.FromArgb(40, 44, 52);

        public static long user_id { get; set; } = 0;
        public static bool locked { get; set; } = false;
        public static string connectionString { get; set; } = librun.Properties.Settings.Default.libConnectionString;

        public static SignInForm signInF { get; set; } = null;
        public static SignUpForm signUpF { get; set; } = null;
        public static UserBooks booksUF { get; set; } = null;
        public static UserProfileForm profileUF { get; set; } = null;
        public static UserRepliesForm repliesUF { get; set; } = null;
        public static MainUserForm mainUF { get; set; } = null;
        public static Users usersAF { get; set; } = null;
        public static Books booksAF { get; set; } = null;
        public static BorrowRequests borrowAF { get; set; } = null;

        public static void SetActiveButton(Control.ControlCollection c, Button activeButton)
        {
            foreach (Control control in c)
                if (control is Button button)
                    button.BackColor = SecondaryColor;

            if (activeButton != null)
                activeButton.BackColor = PrimaryColor;
        }

        public static void swapForm<T, F>(T open, F close) where F : Form where T : Form, new()
        {
            if (open == null)
                open = new T();

            open.Show();

            if (close == signInF)
                close.Hide();
            else
                close.Close();
        }

        public static void SignOut(Form caller)
        {
            var result = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất?", "Xác nhận đăng xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                user_id = 0;
                swapForm(signInF, caller);
            }
        }
    }
}
