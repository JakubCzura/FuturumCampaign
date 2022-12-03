using System.Collections.Generic;

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