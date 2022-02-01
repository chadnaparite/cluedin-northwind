using Newtonsoft.Json;

namespace CluedIn.Crawling.Northwind.Core.Models
{
    public class EmployeeTeritory 
    {

        [JsonProperty("EmployeeID")]
        public string EmployeeId {get; set;}

        [JsonProperty("TerritoryID")]
        public string TerritoryId {get; set;}

    }
}
