using System;
using System.Windows.Forms;

namespace FilmIzlemeUygulamasi
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Enables visual styles for the application (e.g., control styling).
            Application.EnableVisualStyles();

            // Sets the default rendering mode for controls.
            Application.SetCompatibleTextRenderingDefault(false);

            // Starts the application by running the initial form (LoginForm).
            // LoginForm will handle the database initialization on its Load event.
            Application.Run(new LoginForm());
        }
    }
}