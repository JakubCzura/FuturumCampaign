using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuturumCampaign.Serializers
{
    public class JsonSerializer
    {
        public static T Deserialize<T>(string value)
        {
            return JsonConvert.DeserializeObject<T>(value);
        }

        public static string Serialize<T>(T value)
        {
            return JsonConvert.SerializeObject(value);
        }

    }
}
