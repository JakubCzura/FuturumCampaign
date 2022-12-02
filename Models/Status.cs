using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuturumCampaign.Models
{
    public class Status
    {
        enum Values
        {
            On,
            Off
        }

        public string Value { get; set; } = default!;
    }
}
