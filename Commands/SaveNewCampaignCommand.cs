using FuturumCampaign.Validators;
using FuturumCampaign.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace FuturumCampaign.Commands
{
    public class SaveNewCampaignCommand : BaseCommand, ICommand
    {
        private NewCampaignVM NewCampaignVM { get; set; }

        public SaveNewCampaignCommand(NewCampaignVM newCampaignVM)
        {
            NewCampaignVM = newCampaignVM;
        }

        public bool CanExecute(object? parameter)
        {
            CampaignValidator Validator = new();
            return Validator.Validate(NewCampaignVM.Campaign);
        }

        public void Execute(object? parameter)
        {
            throw new NotImplementedException();
        }
    }
}
