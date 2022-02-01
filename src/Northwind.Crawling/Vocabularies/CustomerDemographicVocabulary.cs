using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;
using CluedIn.Crawling.Northwind.Core.Constants;

namespace CluedIn.Crawling.Northwind.Vocabularies
{
    public class  CustomerDemographicVocabulary : SimpleVocabulary
    {
        public  CustomerDemographicVocabulary()
        {
            VocabularyName = "Northwind CustomerDemographic"; 
            KeyPrefix      = "northwind.customerdemographic"; 
            KeySeparator   = ".";
            Grouping       = NorthwindEntities.CustomerDemographic; // TODO: Make sure EntityType is correct.

            //TODO: Make sure that any properties mapped into CluedIn Vocabulary are not in the group.
            AddGroup("Northwind CustomerDemographic Details", group =>
            {
                CustomerId = group.Add(new VocabularyKey("CustomerId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustomerTypeId = group.Add(new VocabularyKey("CustomerTypeId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                
            });

            //TODO: If the property is already set in the clueproducer, it doesn't have to be here.
             
            //TODO: Don't forget to map all possible properties into already existing CluedIn Vocabularies.
        
        }


        
        public VocabularyKey CustomerId { get; private set; }
        
        public VocabularyKey CustomerTypeId { get; private set; }
        
    }
}
