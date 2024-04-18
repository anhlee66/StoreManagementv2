namespace Lab8
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
           // HomeForm home = new HomeForm(new LoginForm());
            //home.setUserLogin(1);
            Application.Run(new LoginForm());
        }
    }
}