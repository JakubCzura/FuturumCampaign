﻿using FuturumCampaign.ViewModels;
using System;
using System.Windows.Input;

namespace FuturumCampaign.Commands
{
    /// <summary>
    /// Adds keyword to campaign's keywords list
    /// </summary>
    public class AddKeywordCommand : BaseCommand, ICommand
    {
        public AddKeywordCommand(NewCampaignVM newCampaignVM)
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
            if (NewCampaignVM.Keywords != null && String.IsNullOrWhiteSpace(NewCampaignVM.Keyword) == false)
            {
                if (NewCampaignVM.Keywords.Contains(NewCampaignVM.Keyword) == false)
                {
                    NewCampaignVM.Keywords.Add(NewCampaignVM.Keyword);
                }
            }
        }
    }
}