using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuturumCampaign.Models
{
    public class Product
    {
        public Product() { }
        public Product(string productName, string description)
        {
            ProductName = productName;
            Description = description;
        }

        public string ProductName { get; set; } = default!;

        public string Description { get; set; } = default!;
    }
}
