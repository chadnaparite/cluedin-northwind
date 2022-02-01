using Newtonsoft.Json;

namespace CluedIn.Crawling.Northwind.Core.Models
{
    public class Shipper 
    {

        [JsonProperty("ShipperID")]
        public string ShipperId {get; set;}

        [JsonProperty("CompanyName")]
        public string CompanyName {get; set;}

        [JsonProperty("Phone")]
        public string Phone {get; set;}

    }
}
