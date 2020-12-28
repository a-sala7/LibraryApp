using LibraryApp.Services;
using System;
using System.Windows.Forms;

namespace LibraryApp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var sqldb = new SqlDatabase(@"Data Source=(LocalDb)\MSSQLLocalDB;Initial Catalog=LibraryApp;Integrated Security=True");

            Application.Run(new LoginForm(sqldb));
        }
    }
}
