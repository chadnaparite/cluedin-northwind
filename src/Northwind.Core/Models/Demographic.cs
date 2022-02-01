using Newtonsoft.Json;

namespace CluedIn.Crawling.Northwind.Core.Models
{
    public class Demographic 
    {

        [JsonProperty("CustomerTypeID")]
        public string CustomerTypeId {get; set;}

        [JsonProperty("CustomerDesc")]
        public string CustomerDesc {get; set;}

    }
}
