using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;
using CluedIn.Crawling.Northwind.Core.Constants;

namespace CluedIn.Crawling.Northwind.Vocabularies
{
    public class  CategoryVocabulary : SimpleVocabulary
    {
        public  CategoryVocabulary()
        {
            VocabularyName = "Northwind Category"; 
            KeyPrefix      = "northwind.category"; 
            KeySeparator   = ".";
            Grouping       = NorthwindEntities.Category; // TODO: Make sure EntityType is correct.

            //TODO: Make sure that any properties mapped into CluedIn Vocabulary are not in the group.
            AddGroup("Northwind Category Details", group =>
            {
                CategoryId = group.Add(new VocabularyKey("CategoryId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CategoryName = group.Add(new VocabularyKey("CategoryName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey("Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Picture = group.Add(new VocabularyKey("Picture", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                
            });

            //TODO: If the property is already set in the clueproducer, it doesn't have to be here.
             
            //TODO: Don't forget to map all possible properties into already existing CluedIn Vocabularies.
        
        }


        
        public VocabularyKey CategoryId { get; private set; }
        
        public VocabularyKey CategoryName { get; private set; }
        
        public VocabularyKey Description { get; private set; }
        
        public VocabularyKey Picture { get; private set; }
        
    }
}
