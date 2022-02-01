using Newtonsoft.Json;

namespace CluedIn.Crawling.Northwind.Core.Models
{
    public class Order 
    {

        [JsonProperty("OrderID")]
        public string OrderId {get; set;}

        [JsonProperty("CustomerID")]
        public string CustomerId {get; set;}

        [JsonProperty("EmployeeID")]
        public string EmployeeId {get; set;}

        [JsonProperty("OrderDate")]
        public string OrderDate {get; set;}

        [JsonProperty("RequiredDate")]
        public string RequiredDate {get; set;}

        [JsonProperty("ShippedDate")]
        public string ShippedDate {get; set;}

        [JsonProperty("ShipVia")]
        public string ShipVia {get; set;}

        [JsonProperty("Freight")]
        public string Freight {get; set;}

        [JsonProperty("ShipName")]
        public string ShipName {get; set;}

        [JsonProperty("ShipAddress")]
        public string ShipAddress {get; set;}

        [JsonProperty("ShipCity")]
        public string ShipCity {get; set;}

        [JsonProperty("ShipRegion")]
        public string ShipRegion {get; set;}

        [JsonProperty("ShipPostalCode")]
        public string ShipPostalCode {get; set;}

        [JsonProperty("ShipCountry")]
        public string ShipCountry {get; set;}

    }
}
