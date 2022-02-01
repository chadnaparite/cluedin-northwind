using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;
using CluedIn.Crawling.Northwind.Core.Constants;

namespace CluedIn.Crawling.Northwind.Vocabularies
{
    public class  OrderVocabulary : SimpleVocabulary
    {
        public  OrderVocabulary()
        {
            VocabularyName = "Northwind Order"; 
            KeyPrefix      = "northwind.order"; 
            KeySeparator   = ".";
            Grouping       = EntityType.Sales.Order; // TODO: Make sure EntityType is correct.

            //TODO: Make sure that any properties mapped into CluedIn Vocabulary are not in the group.
            AddGroup("Northwind Order Details", group =>
            {
                OrderId = group.Add(new VocabularyKey("OrderId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustomerId = group.Add(new VocabularyKey("CustomerId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EmployeeId = group.Add(new VocabularyKey("EmployeeId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OrderDate = group.Add(new VocabularyKey("OrderDate", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RequiredDate = group.Add(new VocabularyKey("RequiredDate", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ShippedDate = group.Add(new VocabularyKey("ShippedDate", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ShipVia = group.Add(new VocabularyKey("ShipVia", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Freight = group.Add(new VocabularyKey("Freight", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ShipName = group.Add(new VocabularyKey("ShipName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ShipAddress = group.Add(new VocabularyKey("ShipAddress", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ShipCity = group.Add(new VocabularyKey("ShipCity", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ShipRegion = group.Add(new VocabularyKey("ShipRegion", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ShipPostalCode = group.Add(new VocabularyKey("ShipPostalCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ShipCountry = group.Add(new VocabularyKey("ShipCountry", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                
            });

            //TODO: If the property is already set in the clueproducer, it doesn't have to be here.
             
            //TODO: Don't forget to map all possible properties into already existing CluedIn Vocabularies.
        
        }


        
        public VocabularyKey OrderId { get; private set; }
        
        public VocabularyKey CustomerId { get; private set; }
        
        public VocabularyKey EmployeeId { get; private set; }
        
        public VocabularyKey OrderDate { get; private set; }
        
        public VocabularyKey RequiredDate { get; private set; }
        
        public VocabularyKey ShippedDate { get; private set; }
        
        public VocabularyKey ShipVia { get; private set; }
        
        public VocabularyKey Freight { get; private set; }
        
        public VocabularyKey ShipName { get; private set; }
        
        public VocabularyKey ShipAddress { get; private set; }
        
        public VocabularyKey ShipCity { get; private set; }
        
        public VocabularyKey ShipRegion { get; private set; }
        
        public VocabularyKey ShipPostalCode { get; private set; }
        
        public VocabularyKey ShipCountry { get; private set; }
        
    }
}
