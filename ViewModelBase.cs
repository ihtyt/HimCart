using CommunityToolkit.Mvvm.ComponentModel;

namespace HimCart_Desktop.ViewModels
{
    public partial class ViewModelBase : ObservableObject
    {
        [ObservableProperty]
        private bool _isBusy;

        [ObservableProperty]
        private string _title = string.Empty;
    }
}
