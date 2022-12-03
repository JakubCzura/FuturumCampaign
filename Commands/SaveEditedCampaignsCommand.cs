using FuturumCampaign.DataHelper;
using FuturumCampaign.Models;
using FuturumCampaign.Validators;
using FuturumCampaign.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace FuturumCampaign.Commands
{
    /// <summary>
    /// Saves edited campaigns
    /// </summary>
    public class SaveEditedCampaignsCommand : BaseCommand, ICommand
    {
        public CampaignsVM CampaignsVM { get; set; }
        public SaveEditedCampaignsCommand(CampaignsVM campaignsVM)
        {
            CampaignsVM = campaignsVM;
        }

        public bool CanExecute(object? parameter)
        {
            if (CampaignsVM.Campaigns != null && CampaignsVM.Campaigns.Any())
            {
                return true;
            }
            return false;
        }

        public void Execute(object? parameter)
        {
            try
            {
                CampaignValidator CampaignValidator = new();
                if (CampaignsVM.Campaigns.All(CampaignValidator.Validate))
                {
                    if (CampaignsData.SaveCampaigns(CampaignsVM.Campaigns.ToList()))
                    {
                        MessageBox.Show("Campaigns edited");
                    }
                }
            }
            catch(Exception exception) 
            {
                MessageBox.Show(exception.Message, "Error while saving edited campaigns");
            }          
        }
    }
}
