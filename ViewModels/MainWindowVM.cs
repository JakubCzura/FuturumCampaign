using FuturumCampaign.Models;
using System.Collections.Generic;

namespace FuturumCampaign.ViewModels
{
    /// <summary>
    /// View model for MainWindow.xaml
    /// </summary>
    public class MainWindowVM : BaseViewModel
    {
        public MainWindowVM()
        {
            Campaign = new();
            AllTownsList = TownsCreator.CreateTowns();
            AllKeywordsList = KeywordsCreator.CreateKeywords();
        }

        public Campaign Campaign { get; set; }

        public List<string> AllKeywordsList { get; set; }

        public List<string> AllTownsList { get; set; }
    }
}