using FuturumCampaign.ViewModels;
using System.Windows.Input;

namespace FuturumCampaign.Commands
{
    /// <summary>
    /// Sets content for MainWindow's ContentControl
    /// </summary>
    public class SetMainWindowContentCommand : BaseCommand, ICommand
    {
        public SetMainWindowContentCommand(MainWindowVM mainWindowVM)
        {
            MainWindowVM = mainWindowVM;
        }

        public MainWindowVM MainWindowVM { get; set; }

        public bool CanExecute(object? parameter)
        {
            return true;
        }

        public void Execute(object? parameter)
        {
            if (parameter != null)
            {
                if (parameter.ToString() == "NewCampaign")
                {
                    MainWindowVM.MainWindowContent = new NewCampaignVM();
                }
                else if (parameter.ToString() == "Campaigns")
                {
                    MainWindowVM.MainWindowContent = new CampaignsVM();
                }
            }
        }
    }
}