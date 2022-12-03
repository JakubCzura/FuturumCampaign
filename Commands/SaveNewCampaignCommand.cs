using FuturumCampaign.DataHelper;
using FuturumCampaign.Models;
using FuturumCampaign.Validators;
using FuturumCampaign.ViewModels;
using System.Linq;
using System.Windows;
using System.Windows.Input;

namespace FuturumCampaign.Commands
{
    /// <summary>
    /// Saves new campaign
    /// </summary>
    public class SaveNewCampaignCommand : BaseCommand, ICommand
    {
        public SaveNewCampaignCommand(NewCampaignVM newCampaignVM)
        {
            NewCampaignVM = newCampaignVM;
        }

        private NewCampaignVM NewCampaignVM { get; set; }

        public bool CanExecute(object? parameter)
        {
            return true;
        }

        public void Execute(object? parameter)
        {
            CampaignValidator Validator = new();
            Campaign Campaign = new(NewCampaignVM.BidAmount,
                                    NewCampaignVM.MinAmount,
                                    NewCampaignVM.Fund,
                                    NewCampaignVM.Keywords.ToList(),
                                    NewCampaignVM.Name,
                                    NewCampaignVM.Radius,
                                    NewCampaignVM.Status,
                                    NewCampaignVM.Town,
                                    NewCampaignVM.ProductName,
                                    NewCampaignVM.Description);

            if (Validator.Validate(Campaign))
            {
                NewCampaignVM.Campaigns.Add(Campaign);
                if (CampaignsData.SaveCampaigns(NewCampaignVM.Campaigns))
                {
                    MessageBox.Show("New campaign saved");
                }
            }
        }
    }
}