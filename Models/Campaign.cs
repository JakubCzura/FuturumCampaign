using System.Collections.Generic;

namespace FuturumCampaign.Models
{
    public class Campaign
    {
        public string Name { get; set; } = default!;

        public List<Keyword> Keywords { get; set; } = default!;

        public List<Town> Towns { get; set; } = default!;
    }
}