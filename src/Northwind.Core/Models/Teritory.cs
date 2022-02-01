using Newtonsoft.Json;

namespace CluedIn.Crawling.Northwind.Core.Models
{
    public class Teritory 
    {

        [JsonProperty("TerritoryID")]
        public string TerritoryId {get; set;}

        [JsonProperty("TerritoryDescription")]
        public string TerritoryDescription {get; set;}

        [JsonProperty("RegionID")]
        public string RegionId {get; set;}

    }
}
