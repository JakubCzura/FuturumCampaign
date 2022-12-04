using FuturumCampaign.Commands;
using FuturumCampaign.Models;
using System.Windows.Input;

namespace FuturumCampaign.ViewModels
{
    /// <summary>
    /// View model for MainWindow.xaml
    /// </summary>
    public class MainWindowVM : BaseViewModel
    {
        private BaseViewModel mainWindowContent;

        public MainWindowVM()
        {
            Campaign = new();
            SetMainWindowContentCommand = new SetMainWindowContentCommand(this);
            MainWindowContent = new NewCampaignVM();
        }

        public Campaign Campaign { get; set; }

        public BaseViewModel MainWindowContent
        {
            get { return mainWindowContent; }
            set { mainWindowContent = value; OnPropertyChanged(); }
        }

        public ICommand SetMainWindowContentCommand { get; set; }
    }
}