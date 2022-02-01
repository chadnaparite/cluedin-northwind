using Newtonsoft.Json;

namespace CluedIn.Crawling.Northwind.Core.Models
{
    public class Category 
    {

        [JsonProperty("CategoryID")]
        public string CategoryId {get; set;}

        [JsonProperty("CategoryName")]
        public string CategoryName {get; set;}

        [JsonProperty("Description")]
        public string Description {get; set;}

        [JsonProperty("Picture")]
        public string Picture {get; set;}

    }
}
