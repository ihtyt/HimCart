using System;
using System.IO;
using System.Threading.Tasks;
using System.Windows;
using Microsoft.Extensions.DependencyInjection;
using HimCart_Desktop.Services;
using HimCart_Desktop.ViewModels;

namespace HimCart_Desktop
{
    public partial class App : Application
    {
        public static IServiceProvider? ServiceProvider { get; private set; }

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            var serviceCollection = new ServiceCollection();
            ConfigureServices(serviceCollection);
            ServiceProvider = serviceCollection.BuildServiceProvider();


            AppDomain.CurrentDomain.UnhandledException += (s, args) =>
            {
                var ex = args.ExceptionObject as Exception;
                MessageBox.Show($"FATAL ERROR: {ex?.Message}\n\nStack Trace: {ex?.StackTrace}", 
                    "HimCart Terminal Crash", MessageBoxButton.OK, MessageBoxImage.Error);
                
                try {
                    File.WriteAllText("crash_log.txt", ex?.ToString());
                } catch { }
            };

            TaskScheduler.UnobservedTaskException += (s, args) =>
            {
                MessageBox.Show($"Task Error: {args.Exception.Message}", "Background Error", MessageBoxButton.OK, MessageBoxImage.Warning);
                args.SetObserved();
            };
        }

        private void ConfigureServices(IServiceCollection services)
        {
            // Services
            services.AddSingleton<IVisionService, VisionService>();
            services.AddSingleton<ICameraService, CameraService>();
            services.AddSingleton<IAuthenticationService, FirebaseAuthService>();
            services.AddSingleton<WeatherService>();
            services.AddSingleton<EstimationEngine>();
            services.AddSingleton<IHistoryService, HistoryService>();
            services.AddSingleton<ISettingsService, SettingsService>();
            
            // New Enterprise Services
            services.AddSingleton<TaskService>();
            services.AddSingleton<ICloudSyncService, CloudSyncService>();
            services.AddSingleton<MarketIntelligenceService>();
            services.AddSingleton<SystemTelemetryService>();

            // ViewModels
            services.AddTransient<DashboardViewModel>();
        }
    }
}
