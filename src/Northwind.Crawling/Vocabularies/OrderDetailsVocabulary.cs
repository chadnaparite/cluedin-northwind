using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;
using CluedIn.Crawling.Northwind.Core.Constants;

namespace CluedIn.Crawling.Northwind.Vocabularies
{
    public class  OrderDetailsVocabulary : SimpleVocabulary
    {
        public  OrderDetailsVocabulary()
        {
            VocabularyName = "Northwind OrderDetails"; 
            KeyPrefix      = "northwind.orderdetails"; 
            KeySeparator   = ".";
            Grouping       = NorthwindEntities.OrderDetails; // TODO: Make sure EntityType is correct.

            //TODO: Make sure that any properties mapped into CluedIn Vocabulary are not in the group.
            AddGroup("Northwind OrderDetails Details", group =>
            {
                OrderId = group.Add(new VocabularyKey("OrderId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductId = group.Add(new VocabularyKey("ProductId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UnitPrice = group.Add(new VocabularyKey("UnitPrice", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Quantity = group.Add(new VocabularyKey("Quantity", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Discount = group.Add(new VocabularyKey("Discount", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                
            });

            //TODO: If the property is already set in the clueproducer, it doesn't have to be here.
             
            //TODO: Don't forget to map all possible properties into already existing CluedIn Vocabularies.
        
        }


        
        public VocabularyKey OrderId { get; private set; }
        
        public VocabularyKey ProductId { get; private set; }
        
        public VocabularyKey UnitPrice { get; private set; }
        
        public VocabularyKey Quantity { get; private set; }
        
        public VocabularyKey Discount { get; private set; }
        
    }
}
