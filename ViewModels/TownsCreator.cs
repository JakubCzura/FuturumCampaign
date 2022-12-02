
using FuturumCampaign.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuturumCampaign.ViewModels
{
    public class TownsCreator
    {
        public static List<string> CreateTowns()
        {
            return new List<string>() 
            { 
                "Cracow",
                "Warsaw",
                "New York",
                "Poznan",
                "Olsztyn",
                "Gdansk",
                "Chicago",
                "Birmingham",
                "Sydney",
                "Miami"
            };
        }
    }
}
