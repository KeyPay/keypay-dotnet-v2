using Newtonsoft.Json;
using RestSharp.Serializers;

namespace KeyPayV2.Common
{
    public class CustomSerializer : ISerializer
    {
        public CustomSerializer()
        {
            ContentType = "application/json";
        }

        public string Serialize(object obj)
        {
            return JsonConvert.SerializeObject(obj);
        }

        public string RootElement { get; set; }
        public string Namespace { get; set; }
        public string DateFormat { get; set; }
        public string ContentType { get; set; }
    }
}