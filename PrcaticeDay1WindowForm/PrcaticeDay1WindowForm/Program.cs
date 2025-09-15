namespace PrcaticeDay1WindowForm
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            //Application.Run(new Student());
            //Application.Run(new Student());
            //Application.Run(new Student());
            //Application.Run(new RegistrationForm());
            Application.Run(new ListBoxPlaceAdd());
            //Application.Run(new ListBox());
        }
    }
}