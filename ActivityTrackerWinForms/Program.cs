using ActivityTrackerWinForms.ActivityTrackerApp;
using System;
using System.Windows.Forms;

namespace ActivityTrackerWinForms
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            FontClass fc = new FontClass();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
        }
    }
}
