using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;
using CluedIn.Crawling.Northwind.Core.Constants;

namespace CluedIn.Crawling.Northwind.Vocabularies
{
    public class  DemographicVocabulary : SimpleVocabulary
    {
        public  DemographicVocabulary()
        {
            VocabularyName = "Northwind Demographic"; 
            KeyPrefix      = "northwind.demographic"; 
            KeySeparator   = ".";
            Grouping       = NorthwindEntities.Demographic; // TODO: Make sure EntityType is correct.

            //TODO: Make sure that any properties mapped into CluedIn Vocabulary are not in the group.
            AddGroup("Northwind Demographic Details", group =>
            {
                CustomerTypeId = group.Add(new VocabularyKey("CustomerTypeId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustomerDesc = group.Add(new VocabularyKey("CustomerDesc", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                
            });

            //TODO: If the property is already set in the clueproducer, it doesn't have to be here.
             
            //TODO: Don't forget to map all possible properties into already existing CluedIn Vocabularies.
        
        }


        
        public VocabularyKey CustomerTypeId { get; private set; }
        
        public VocabularyKey CustomerDesc { get; private set; }
        
    }
}
