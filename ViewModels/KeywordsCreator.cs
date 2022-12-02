using FuturumCampaign.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuturumCampaign.ViewModels
{
    public class KeywordsCreator
    {
        public static List<string> CreateKeywords()
        {
            return new List<string>()
            {
                "TV",
                "Nice",
                "Warm",
                "AGD",
                "IT",
                "Sale",
                "Cheap",
                "Sport",
                "Fashion",
                "Food"               
            };
        }
    }
}
