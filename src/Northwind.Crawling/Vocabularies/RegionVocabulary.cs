using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;
using CluedIn.Crawling.Northwind.Core.Constants;

namespace CluedIn.Crawling.Northwind.Vocabularies
{
    public class  RegionVocabulary : SimpleVocabulary
    {
        public  RegionVocabulary()
        {
            VocabularyName = "Northwind Region"; 
            KeyPrefix      = "northwind.region"; 
            KeySeparator   = ".";
            Grouping       = NorthwindEntities.Region; // TODO: Make sure EntityType is correct.

            //TODO: Make sure that any properties mapped into CluedIn Vocabulary are not in the group.
            AddGroup("Northwind Region Details", group =>
            {
                RegionId = group.Add(new VocabularyKey("RegionId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RegionDescription = group.Add(new VocabularyKey("RegionDescription", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                
            });

            //TODO: If the property is already set in the clueproducer, it doesn't have to be here.
             
            //TODO: Don't forget to map all possible properties into already existing CluedIn Vocabularies.
        
        }


        
        public VocabularyKey RegionId { get; private set; }
        
        public VocabularyKey RegionDescription { get; private set; }
        
    }
}
