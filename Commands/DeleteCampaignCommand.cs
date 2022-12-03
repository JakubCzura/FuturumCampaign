using FuturumCampaign.DataHelper;
using FuturumCampaign.Models;
using FuturumCampaign.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Documents;
using System.Windows.Input;

namespace FuturumCampaign.Commands
{
    public class DeleteCampaignCommand : BaseCommand, ICommand
    {
        public DeleteCampaignCommand(CampaignsVM campaignsVM)
        {
            CampaignsVM = campaignsVM;
        }

        public CampaignsVM CampaignsVM { get; set; }

        public bool CanExecute(object? parameter)
        {
            if(CampaignsVM.SelectedCampaign != null)
            {
                return true;
            }
            return false;
        }

        public void Execute(object? parameter)
        {
            CampaignsVM.Campaigns.Remove(CampaignsVM.SelectedCampaign);
            List<Campaign> Campaigns = CampaignsVM.Campaigns.ToList();
            CampaignsData.SaveCampaigns(Campaigns);
        }
    }
}