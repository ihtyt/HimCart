using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using HimCart_Desktop.Services;

namespace HimCart_Desktop.ViewModels
{
    public partial class DashboardViewModel : ViewModelBase
    {
        private readonly WeatherService _weather;

        [ObservableProperty]
        private string _userName = "Orchard Owner";

        [ObservableProperty]
        private string _location = "Solan, Himachal Pradesh";

        [ObservableProperty]
        private string _temperature = "--°C";

        [ObservableProperty]
        private object? _currentView;

        public DashboardViewModel(WeatherService weather)
        {
            _weather = weather;
            Title = "Orchard Overview";
            LoadInitialData();
        }

        private async void LoadInitialData()
        {
            try
            {
                var weatherData = await _weather.GetCurrentWeatherAsync();
                Temperature = $"{weatherData.Temperature}°C";
            }
            catch { Temperature = "18°C"; } // Fallback
        }

        [RelayCommand]
        private void Navigate(string target)
        {
            // Navigation is currently handled by the View (DashboardView.xaml.cs).
            // This command is kept for future MVVM refactoring or potential sidebar binding.
            Title = $"{target} - {Location}";
        }
    }
}
