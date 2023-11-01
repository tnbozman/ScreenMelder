using ScreenMelder.Lib.Core.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using ScreenMelder.Lib.ScreenCapture.Services;
using ScreenMelder.Lib.OCR.Services;
using ScreenMelder.Lib.ChangeDetection.Services;
using Microsoft.Extensions.Logging;
using ScreenMelder.Lib.Core.Logging;

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

            
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            TextBox logTextBox = new TextBox();
            // create the service collection
            var services = new ServiceCollection();
            // configure the service collection and service provider
            ConfigureServices(services, logTextBox);
            ServiceProvider serviceProvider = services.BuildServiceProvider();
            ILogger<ScreenMelder> logger = (ILogger<ScreenMelder>)serviceProvider.GetService<ILoggerFactory>().CreateLogger<ScreenMelder>();
            Application.Run(new ScreenMelder(serviceProvider, logger, logTextBox));
        }

        private static void ConfigureServices(ServiceCollection services, TextBox logTextBox)
        {
            services.AddLogging(configure => configure.SetMinimumLevel(LogLevel.Information).AddConsole().AddProvider(new TextBoxLoggerProvider(logTextBox)));
            services.AddTransient<IConfigurationService, JsonConfigurationService>();
            services.AddTransient<IScreenCaptureService, ScreenCaptureService>();
            services.AddTransient<IPayloadService, PayloadService>();
            services.AddTransient<IOcrService, TesseractOcrService>();
            services.AddTransient<IChangeDetectionService, BasicChangeDetectionService>();
        }
    }
}