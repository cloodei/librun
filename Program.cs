using Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace librun
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Start();
        }

        public static void Start()
        {
            global.signInF = new SignInForm();
            global.signUpF = new SignUpForm();
            global.booksUF = new UserBooks();
            global.mainUF = new MainUserForm();
            global.profileUF = new UserProfile();
            global.usersAF = new Users();
            global.booksAF = new Books();
            global.borrowAF = new BorrowRequests();

            Application.Run(global.signInF);
        }
    }
}
