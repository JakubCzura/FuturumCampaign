using System.Collections.Generic;

namespace FuturumCampaign.Models
{
    public class Campaign
    {
        public Campaign() { }

        public Campaign(decimal bidAmount, decimal minAmount, decimal fund, List<string> keywords, string name, double radius, string status, string town, string productName, string description)
        {
            BidAmount = bidAmount;
            MinAmount = minAmount;
            Fund = fund;
            Keywords = keywords;
            Name = name;
            Town.Radius = radius;
            Status.StatusValue = status;
            Town.TownName = town;
            Product.ProductName = productName;
            Product.Description = description;
        }

        public decimal BidAmount { get; set; } = default!;
        public decimal Fund { get; set; } = default!;
        public List<string> Keywords { get; set; } = new();
        public decimal MinAmount { get; set; } = default!;
        public string Name { get; set; } = default!;
        public Product Product { get; set; } = new();
        public Status Status { get; set; } = new();
        public Town Town { get; set; } = new();
    }
}