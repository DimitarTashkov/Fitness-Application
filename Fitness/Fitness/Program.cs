namespace Fitness
{
    internal static class Program
    {
        public static ApplicationContext AppContext;
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            AppContext = new ApplicationContext(new Login1());
            Application.Run(AppContext);
        }
        public static void SwitchMainForm(Form newForm)
        {
            var oldMainForm = AppContext.MainForm;
            AppContext.MainForm = newForm;
            oldMainForm?.Hide();
            oldMainForm?.Close();
            newForm.ShowDialog();
        }
    }
}