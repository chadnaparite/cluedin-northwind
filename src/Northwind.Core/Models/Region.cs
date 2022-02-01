using Newtonsoft.Json;

namespace CluedIn.Crawling.Northwind.Core.Models
{
    public class Region 
    {

        [JsonProperty("RegionID")]
        public string RegionId {get; set;}

        [JsonProperty("RegionDescription")]
        public string RegionDescription {get; set;}

    }
}
