using Newtonsoft.Json;

namespace CluedIn.Crawling.Northwind.Core.Models
{
    public class CustomerDemographic 
    {

        [JsonProperty("CustomerID")]
        public string CustomerId {get; set;}

        [JsonProperty("CustomerTypeID")]
        public string CustomerTypeId {get; set;}

    }
}
