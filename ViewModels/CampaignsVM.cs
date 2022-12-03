using FuturumCampaign.Commands;
using FuturumCampaign.DataHelper;
using FuturumCampaign.DirectoriesHelper;
using FuturumCampaign.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace FuturumCampaign.ViewModels
{
    public class CampaignsVM : NewCampaignVM
    {

        private Campaign selectedCampaign;

        public ICommand DeleteCampaignCommand { get; set; }

        public ICommand SaveEditedCampaignsCommand { get; set; }
        private ObservableCollection<Campaign> campaigns { get; set; }

        public new ObservableCollection<Campaign> Campaigns
        {
            get { return campaigns; }
            set { campaigns = value; OnPropertyChanged(); }
        }

        public CampaignsVM()
        {
            SelectedCampaign = new();
            Campaigns = new ObservableCollection<Campaign>(CampaignsData.ReadCampaigns());
            DeleteCampaignCommand = new DeleteCampaignCommand(this);
            SaveEditedCampaignsCommand = new SaveEditedCampaignsCommand(this);
        }

        public Campaign SelectedCampaign
        {
            get { return selectedCampaign; }
            set { selectedCampaign = value; OnPropertyChanged(); }
        }   
    }
}
