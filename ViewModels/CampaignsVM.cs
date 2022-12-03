using FuturumCampaign.Commands;
using FuturumCampaign.DataHelper;
using FuturumCampaign.Models;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace FuturumCampaign.ViewModels
{
    public class CampaignsVM : NewCampaignVM
    {
        private ObservableCollection<Campaign> campaigns;
        private Campaign selectedCampaign;

        public CampaignsVM()
        {
            SelectedCampaign = new();
            Campaigns = new ObservableCollection<Campaign>(CampaignsData.ReadCampaigns());
            DeleteCampaignCommand = new DeleteCampaignCommand(this);
            SaveEditedCampaignsCommand = new SaveEditedCampaignsCommand(this);
        }

        public new ObservableCollection<Campaign> Campaigns
        {
            get { return campaigns; }
            set { campaigns = value; OnPropertyChanged(); }
        }

        public ICommand DeleteCampaignCommand { get; set; }

        public ICommand SaveEditedCampaignsCommand { get; set; }

        public Campaign SelectedCampaign
        {
            get { return selectedCampaign; }
            set { selectedCampaign = value; OnPropertyChanged(); }
        }
    }
}