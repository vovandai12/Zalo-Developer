using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Serilog;
using Zalo_Tool_V1.Database.Entities;
using Zalo_Tool_V1.Database.Repositories;

namespace Zalo_Tool_V1
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        private static readonly IHost _host = CreateHostBuilder();
        [STAThread]
        static void Main()
        {
            Log.Logger = new LoggerConfiguration()
                 .MinimumLevel.Debug()
                 .WriteTo.File("LOGSAPP/ZaloToolV1.txt", rollingInterval: RollingInterval.Day)
                 .CreateLogger();
            string folder = Path.Combine(Environment.CurrentDirectory, "Data\\DataImport\\User");
            string folderSession = Path.Combine(Environment.CurrentDirectory, "Data\\DataImport\\Admin\\Session");
            if (!Directory.Exists(folder))
            {
                Directory.CreateDirectory(folder);
            }
            if (!Directory.Exists(folderSession))
            {
                Directory.CreateDirectory(folderSession);
            }
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            try
            {
                _host.Start();
                Application.SetHighDpiMode(HighDpiMode.SystemAware);
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                try
                {
                    var main = _host.Services.GetRequiredService<FMain>();
                    Application.Run(main);
                    Log.Information("Application start");
                }
                catch (Exception ex)
                {
                    Log.Error("Exception: " + ex);
                    if (ex.InnerException != null)
                    {
                        Log.Error(ex.ToString());
                        Log.Error(ex.InnerException.Message);
                    }
                }
                _host.StopAsync().GetAwaiter().GetResult();
                _host.Dispose();
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
            finally
            {
                Log.CloseAndFlush();
            }
        }

        private static string dateFile = "E:\\Zalo Api Developer\\Zalo-Developer\\ZaloDeveloper\\Zalo-Tool-V1\\Database\\Local.mdf";
        //Path.Combine(Environment.CurrentDirectory, "Database\\Local.mdf");
        static IHost CreateHostBuilder()
        {
            return Host.CreateDefaultBuilder()
                .ConfigureServices((context, services) =>
                {
                    services.AddSingleton<FMain>();
                    // services.AddDbContext<ApplicationDbContext>(s => s.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\working\ToolsQnibot\ProjectTest\PhuongThanh\FBViaFarm\Database\Local.mdf;Integrated Security=True;Connect Timeout=30"));
                    services.AddDbContext<ApplicationDbContext>(options =>
                    {
                        options.UseSqlServer($"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={dateFile};Integrated Security=True");
                        options.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
                        options.EnableSensitiveDataLogging();
                    });
                    services.AddTransient<IUserRepository, UserRepository>();

                }).Build();
        }
    }
}