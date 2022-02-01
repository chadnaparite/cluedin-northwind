using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;
using CluedIn.Crawling.Northwind.Core.Constants;

namespace CluedIn.Crawling.Northwind.Vocabularies
{
    public class  ShipperVocabulary : SimpleVocabulary
    {
        public  ShipperVocabulary()
        {
            VocabularyName = "Northwind Shipper"; 
            KeyPrefix      = "northwind.shipper"; 
            KeySeparator   = ".";
            Grouping       = NorthwindEntities.Shippers; // TODO: Make sure EntityType is correct.

            //TODO: Make sure that any properties mapped into CluedIn Vocabulary are not in the group.
            AddGroup("Northwind Shipper Details", group =>
            {
                ShipperId = group.Add(new VocabularyKey("ShipperId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CompanyName = group.Add(new VocabularyKey("CompanyName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Phone = group.Add(new VocabularyKey("Phone", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                
            });

            //TODO: If the property is already set in the clueproducer, it doesn't have to be here.
             
            //TODO: Don't forget to map all possible properties into already existing CluedIn Vocabularies.
        
        }


        
        public VocabularyKey ShipperId { get; private set; }
        
        public VocabularyKey CompanyName { get; private set; }
        
        public VocabularyKey Phone { get; private set; }
        
    }
}
