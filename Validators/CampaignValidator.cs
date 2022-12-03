using CommunityToolkit.Diagnostics;
using FuturumCampaign.Models;
using System;
using System.Windows;

namespace FuturumCampaign.Validators
{
    public class CampaignValidator : IValidator<Campaign>
    {
        /// <summary>
        /// Validate data of campaign
        /// </summary>
        /// <param name="campaign">Campaign to be validated</param>
        /// <returns>True if all properties are alright, otherwise false</returns>
        public bool Validate(Campaign campaign)
        {
            try
            {
                Guard.IsNotNullOrWhiteSpace(campaign.Name);
                Guard.IsGreaterThanOrEqualTo(campaign.BidAmount, 0);
                Guard.IsGreaterThanOrEqualTo(campaign.MinAmount, 0);
                Guard.IsGreaterThanOrEqualTo(campaign.Fund, 0);
                Guard.IsGreaterThanOrEqualTo(campaign.Radius, 0);
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