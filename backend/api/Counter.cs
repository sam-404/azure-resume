using Microsoft.Identity.Client;
using Newtonsoft.Json;

namespace Company.Function
{
    public class Counter{

        [JsonProperty(PropertyName ="id")] //property name should match the names in the cosmos db
        public string Id {get; set;}

        [JsonProperty(PropertyName ="count")]
        public int Count{get; set;}

    }
}
