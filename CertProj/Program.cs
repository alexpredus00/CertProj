using CertProj.UI;

namespace CertProj
{
    internal static class Program
    {

        public class CoreBindingNavigator : BindingNavigator
        {
            public CoreBindingNavigator()
            {
                AddStandardItems();
            }
        }

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());



        }
    }
}