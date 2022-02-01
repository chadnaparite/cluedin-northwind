using Newtonsoft.Json;

namespace CluedIn.Crawling.Northwind.Core.Models
{
    public class OrderDetails 
    {

        [JsonProperty("OrderID")]
        public string OrderId {get; set;}

        [JsonProperty("ProductID")]
        public string ProductId {get; set;}

        [JsonProperty("UnitPrice")]
        public string UnitPrice {get; set;}

        [JsonProperty("Quantity")]
        public string Quantity {get; set;}

        [JsonProperty("Discount")]
        public string Discount {get; set;}

    }
}
