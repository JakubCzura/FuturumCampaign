using Newtonsoft.Json;

namespace FuturumCampaign.Serializers
{
    public static class Json
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