using Newtonsoft.Json;

namespace CluedIn.Crawling.Northwind.Core.Models
{
    public class Customer 
    {

        [JsonProperty("CustomerID")]
        public string CustomerId {get; set;}

        [JsonProperty("CompanyName")]
        public string CompanyName {get; set;}

        [JsonProperty("ContactName")]
        public string ContactName {get; set;}

        [JsonProperty("ContactTitle")]
        public string ContactTitle {get; set;}

        [JsonProperty("Address")]
        public string Address {get; set;}

        [JsonProperty("City")]
        public string City {get; set;}

        [JsonProperty("Region")]
        public string Region {get; set;}

        [JsonProperty("PostalCode")]
        public string PostalCode {get; set;}

        [JsonProperty("Country")]
        public string Country {get; set;}

        [JsonProperty("Phone")]
        public string Phone {get; set;}

        [JsonProperty("Fax")]
        public string Fax {get; set;}

    }
}
