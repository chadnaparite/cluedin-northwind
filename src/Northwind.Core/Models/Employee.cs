using Newtonsoft.Json;

namespace CluedIn.Crawling.Northwind.Core.Models
{
    public class Employee 
    {

        [JsonProperty("EmployeeID")]
        public string EmployeeId {get; set;}

        [JsonProperty("LastName")]
        public string LastName {get; set;}

        [JsonProperty("FirstName")]
        public string FirstName {get; set;}

        [JsonProperty("Title")]
        public string Title {get; set;}

        [JsonProperty("TitleOfCourtesy")]
        public string TitleOfCourtesy {get; set;}

        [JsonProperty("BirthDate")]
        public string BirthDate {get; set;}

        [JsonProperty("HireDate")]
        public string HireDate {get; set;}

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

        [JsonProperty("HomePhone")]
        public string HomePhone {get; set;}

        [JsonProperty("Extension")]
        public string Extension {get; set;}

        [JsonProperty("Photo")]
        public string Photo {get; set;}

        [JsonProperty("Notes")]
        public string Notes {get; set;}

        [JsonProperty("ReportsTo")]
        public string ReportsTo {get; set;}

        [JsonProperty("PhotoPath")]
        public string PhotoPath {get; set;}

        public string FullName => string.Join(" ", FirstName, LastName);
    }
}
