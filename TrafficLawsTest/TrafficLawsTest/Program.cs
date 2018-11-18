using System;
using System.Windows.Forms;
using TrafficLawsTest.Utils.IoC;
using TrafficLawsTest.Views;

namespace TrafficLawsTest
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
            
            ShowLoginForm();
        }

        private static void ShowLoginForm()
        {
            var mainWindow = DiFactory.Resolve<MainWindow>();
            mainWindow.Visible = false;
            mainWindow.Hide();
            LoginForm form = DiFactory.Resolve<LoginForm>();
            bool logined = false;
            form.Logined += (sndr, arg) =>
            {
                logined = true;
                form.Close();
            };
            form.ShowDialog();

            if (logined)
            {
                mainWindow.Init();
                Application.Run(mainWindow);
            }
            else
            {
                Application.Exit();
            }
        }
    }
}
