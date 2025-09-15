namespace Ado.NETTask
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
            //Application.Run(new Form1());
            //Application.Run(new DepartTable());
            //Application.Run(new Form2());
            //Application.Run(new Employee());
            //Application.Run(new StudentRegistration());
            //Application.Run(new Combox());
            //Application.Run(new StudentRegIns());
            Application.Run(new ExamCrud());
        }
    }
}