using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;
using CluedIn.Crawling.Northwind.Core.Constants;

namespace CluedIn.Crawling.Northwind.Vocabularies
{
    public class  SupplierVocabulary : SimpleVocabulary
    {
        public  SupplierVocabulary()
        {
            VocabularyName = "Northwind Supplier"; 
            KeyPrefix      = "northwind.supplier"; 
            KeySeparator   = ".";
            Grouping       = NorthwindEntities.Suppliers; // TODO: Make sure EntityType is correct.

            //TODO: Make sure that any properties mapped into CluedIn Vocabulary are not in the group.
            AddGroup("Northwind Supplier Details", group =>
            {
                SupplierId = group.Add(new VocabularyKey("SupplierId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CompanyName = group.Add(new VocabularyKey("CompanyName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ContactName = group.Add(new VocabularyKey("ContactName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ContactTitle = group.Add(new VocabularyKey("ContactTitle", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Address = group.Add(new VocabularyKey("Address", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                City = group.Add(new VocabularyKey("City", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Region = group.Add(new VocabularyKey("Region", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PostalCode = group.Add(new VocabularyKey("PostalCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Country = group.Add(new VocabularyKey("Country", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Phone = group.Add(new VocabularyKey("Phone", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Fax = group.Add(new VocabularyKey("Fax", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                HomePage = group.Add(new VocabularyKey("HomePage", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                
            });

            //TODO: If the property is already set in the clueproducer, it doesn't have to be here.

            //TODO: Don't forget to map all possible properties into already existing CluedIn Vocabularies.
            AddMapping(Address, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInPerson.HomeAddress);
            AddMapping(City, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInPerson.HomeAddressCity);
            AddMapping(Phone, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInPerson.PhoneNumber);
        }



        public VocabularyKey SupplierId { get; private set; }
        
        public VocabularyKey CompanyName { get; private set; }
        
        public VocabularyKey ContactName { get; private set; }
        
        public VocabularyKey ContactTitle { get; private set; }
        
        public VocabularyKey Address { get; private set; }
        
        public VocabularyKey City { get; private set; }
        
        public VocabularyKey Region { get; private set; }
        
        public VocabularyKey PostalCode { get; private set; }
        
        public VocabularyKey Country { get; private set; }
        
        public VocabularyKey Phone { get; private set; }
        
        public VocabularyKey Fax { get; private set; }
        
        public VocabularyKey HomePage { get; private set; }
        
    }
}
