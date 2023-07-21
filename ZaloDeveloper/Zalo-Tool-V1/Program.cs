using Serilog;

namespace Zalo_Tool_V1
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Log.Logger = new LoggerConfiguration()
                 .MinimumLevel.Debug()
                 .WriteTo.File("LOGSAPP/ZaloToolV1.txt", rollingInterval: RollingInterval.Day)
                 .CreateLogger();
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            try
            {
                Application.Run(new FormDemo());
                Log.Information("Application start");
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message);
                if (ex.InnerException != null)
                {
                    Log.Error(ex.ToString());
                    Log.Error(ex.InnerException.Message);
                }
            }
        }
    }
}