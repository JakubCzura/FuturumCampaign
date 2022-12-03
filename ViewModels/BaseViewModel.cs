using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace FuturumCampaign.ViewModels
{
    /// <summary>
    /// Base class for all view models
    /// </summary>
    public class BaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}