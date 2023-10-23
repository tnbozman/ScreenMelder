using ScreenMelder.Lib.Core.Services;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace ScreenMelder
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // create the service collection
            var services = new ServiceCollection();
            // configure the service collection and service provider
            ConfigureServices(services);
            ServiceProvider serviceProvider = services.BuildServiceProvider();
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new ScreenMelder(serviceProvider));
        }

        private static void ConfigureServices(ServiceCollection services)
        {
            //services.AddLogging(configure => configure.SetMinimumLevel(LogLevel.Error).AddConsole());
            services.AddTransient<IConfigurationService, JsonConfigurationService>();
        }
    }
}