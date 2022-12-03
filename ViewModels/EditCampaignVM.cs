using FuturumCampaign.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace FuturumCampaign.ViewModels
{
    public class EditCampaignVM : CampaignsVM
    {
        public static EditCampaignVM Instance { get; private set; }
        public EditCampaignVM()
        {
            Instance = this;
            Campaign = new Campaign();
            //Campaign = CampaignsVM.Instance.SelectedCampaign;
            //MessageBox.Show(Campaign.Name);
            //Name = SelectedCampaign.Name;
            // MessageBox.Show(SelectedCampaign.Name, Name);
          //  MessageBox.Show(Campaign.Name);
        }

        private Campaign campaign { get; set; }

        public Campaign Campaign
        {
            get { return campaign; }
            set { campaign = value; OnPropertyChanged(); }
        }

        
       
    }
}
