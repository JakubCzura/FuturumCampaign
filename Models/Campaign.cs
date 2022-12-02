using System.Collections.Generic;

namespace FuturumCampaign.Models
{
    public class Campaign
    {
        public string Name { get; set; } = default!;
        public List<Keyword> Keywords { get; set; } = default!;
        public BidAmount BidAmount { get; set; } = default!;

        public decimal Fund { get; set; } = default!;

        public Status Status { get; set; } = default!;

        public Town Town { get; set; } = default!;

        public Radius Radius { get; set; } = default!;
    }
}