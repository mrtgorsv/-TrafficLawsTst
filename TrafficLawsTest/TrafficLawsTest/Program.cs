using System;
using System.Reflection;
using System.Windows.Forms;
using Ninject;
using TrafficLawsTest.Logic.Utils.IoC;
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
            form.Logined += (sndr, arg) =>
            {

                form.Hide();
                form.Close();
                mainWindow.Init();
            };
            form.ShowDialog();
            Application.Run(mainWindow);
        }
    }
}
