using InformProtectLaba1.Sevices;

namespace InformProtectLaba1
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
            Application.ApplicationExit += onAppExit;
            Application.Run(new DecryptForm());
        }

        private static void onAppExit(object? sender, EventArgs e)
        {
            var task=Task.Factory.StartNew(()=>SaveChanges());
            task.Wait();
        }

        private static void SaveChanges()
        {
            var dataSaveForm=new DataSaveForm();
            dataSaveForm.Show();
            UsersAccountService.SaveData();
            dataSaveForm.Close();
        }

    }
}