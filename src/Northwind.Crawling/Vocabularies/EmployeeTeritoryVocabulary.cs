using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;
using CluedIn.Crawling.Northwind.Core.Constants;

namespace CluedIn.Crawling.Northwind.Vocabularies
{
    public class  EmployeeTeritoryVocabulary : SimpleVocabulary
    {
        public  EmployeeTeritoryVocabulary()
        {
            VocabularyName = "Northwind EmployeeTeritory"; 
            KeyPrefix      = "northwind.employeeteritory"; 
            KeySeparator   = ".";
            Grouping       = NorthwindEntities.EmployeeTeritory; // TODO: Make sure EntityType is correct.

            //TODO: Make sure that any properties mapped into CluedIn Vocabulary are not in the group.
            AddGroup("Northwind EmployeeTeritory Details", group =>
            {
                EmployeeId = group.Add(new VocabularyKey("EmployeeId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TerritoryId = group.Add(new VocabularyKey("TerritoryId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                
            });

            //TODO: If the property is already set in the clueproducer, it doesn't have to be here.
             
            //TODO: Don't forget to map all possible properties into already existing CluedIn Vocabularies.
        
        }


        
        public VocabularyKey EmployeeId { get; private set; }
        
        public VocabularyKey TerritoryId { get; private set; }
        
    }
}
