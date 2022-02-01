using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;
using CluedIn.Crawling.Northwind.Core.Constants;

namespace CluedIn.Crawling.Northwind.Vocabularies
{
    public class  TeritoryVocabulary : SimpleVocabulary
    {
        public  TeritoryVocabulary()
        {
            VocabularyName = "Northwind Teritory"; 
            KeyPrefix      = "northwind.teritory"; 
            KeySeparator   = ".";
            Grouping       = NorthwindEntities.Teritory; // TODO: Make sure EntityType is correct.

            //TODO: Make sure that any properties mapped into CluedIn Vocabulary are not in the group.
            AddGroup("Northwind Teritory Details", group =>
            {
                TerritoryId = group.Add(new VocabularyKey("TerritoryId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TerritoryDescription = group.Add(new VocabularyKey("TerritoryDescription", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RegionId = group.Add(new VocabularyKey("RegionId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                
            });

            //TODO: If the property is already set in the clueproducer, it doesn't have to be here.
             
            //TODO: Don't forget to map all possible properties into already existing CluedIn Vocabularies.
        
        }


        
        public VocabularyKey TerritoryId { get; private set; }
        
        public VocabularyKey TerritoryDescription { get; private set; }
        
        public VocabularyKey RegionId { get; private set; }
        
    }
}
