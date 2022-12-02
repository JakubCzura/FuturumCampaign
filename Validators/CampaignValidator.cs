using CommunityToolkit.Diagnostics;
using FuturumCampaign.Models;
using System;
using System.Windows;

namespace FuturumCampaign.Validators
{
    public class CampaignValidator : IValidator<Campaign>
    {
        public bool Validate(Campaign campaign)
        {
            try
            {
                Guard.IsNotNullOrWhiteSpace(campaign.Name);
                Guard.IsGreaterThanOrEqualTo(0, campaign.BidAmount);
                Guard.IsGreaterThanOrEqualTo(0, campaign.MinAmount);
                Guard.IsGreaterThanOrEqualTo(0, campaign.Fund);
                Guard.IsGreaterThanOrEqualTo(0, campaign.Radius);
                Guard.IsNotNull(campaign.Keywords);
                Guard.IsNotNullOrWhiteSpace(campaign.Status);
                Guard.IsNotNullOrWhiteSpace(campaign.Town);
                return true;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "An exception in Campaign's data");
                return false;
            }
        }
    }
}