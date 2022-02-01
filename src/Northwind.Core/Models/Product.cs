using Newtonsoft.Json;

namespace CluedIn.Crawling.Northwind.Core.Models
{
    public class Product 
    {

        [JsonProperty("ProductID")]
        public string ProductId {get; set;}

        [JsonProperty("ProductName")]
        public string ProductName {get; set;}

        [JsonProperty("SupplierID")]
        public string SupplierId {get; set;}

        [JsonProperty("CategoryID")]
        public string CategoryId {get; set;}

        [JsonProperty("QuantityPerUnit")]
        public string QuantityPerUnit {get; set;}

        [JsonProperty("UnitPrice")]
        public string UnitPrice {get; set;}

        [JsonProperty("UnitsInStock")]
        public string UnitsInStock {get; set;}

        [JsonProperty("UnitsOnOrder")]
        public string UnitsOnOrder {get; set;}

        [JsonProperty("ReorderLevel")]
        public string ReorderLevel {get; set;}

        [JsonProperty("Discontinued")]
        public string Discontinued {get; set;}

    }
}
