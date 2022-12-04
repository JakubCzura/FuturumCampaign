using FuturumCampaign.ViewModels;
using System;
using System.Windows.Input;

namespace FuturumCampaign.Commands
{
    public class DeleteKeywordCommand : BaseCommand, ICommand
    {
        public DeleteKeywordCommand(NewCampaignVM newCampaignVM)
        {
            NewCampaignVM = newCampaignVM;
        }

        public NewCampaignVM NewCampaignVM { get; set; }

        public bool CanExecute(object? parameter)
        {
            return true;
        }

        public void Execute(object? parameter)
        {
            if (NewCampaignVM.Keywords != null && String.IsNullOrWhiteSpace(NewCampaignVM.SelectedKeyword) == false)
            {
                NewCampaignVM.Keywords.Remove(NewCampaignVM.SelectedKeyword);
            }
        }
    }
}