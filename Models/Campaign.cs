using System.Collections.Generic;

namespace FuturumCampaign.Models
{
    public class Campaign
    {
        public Campaign()
        {
            Keywords = new();
        }

        public Campaign(decimal bidAmount, decimal minAmount, decimal fund, List<string> keywords, string name, double radius, string status, string town, string productName, string description)
        {
            BidAmount = bidAmount;
            MinAmount = minAmount;
            Fund = fund;
            Keywords = keywords;
            Name = name;
            Radius = radius;
            Status = status;
            Town = town;
            Product.ProductName = productName;
            Product.Description = description;
        }

        public Product Product { get; set; } = new();
        public decimal BidAmount { get; set; } = default!;
        public decimal Fund { get; set; } = default!;
        public List<string> Keywords { get; set; } = default!;
        public decimal MinAmount { get; set; } = default!;
        public string Name { get; set; } = default!;
        public double Radius { get; set; } = default!;
        public string Status { get; set; } = default!;
        public string Town { get; set; } = default!;
    }
}