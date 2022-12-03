using FuturumCampaign.DataHelper;
using FuturumCampaign.Models;
using FuturumCampaign.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
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
            try
            {
                CampaignsVM.Campaigns.Remove(CampaignsVM.SelectedCampaign);
                CampaignsData.SaveCampaigns(CampaignsVM.Campaigns.ToList());
            }
            catch(Exception exception)
            {
                MessageBox.Show(exception.Message, "Error while deleting campaign");
            }
        }
    }
}