using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuturumCampaign.Models
{
    public class Town
    {
        public string Name { get; set; } = default!;

        public double Population { get; set; }

        public string? Description { get; set; }

        public double Radius { get; set; }
    }
}
