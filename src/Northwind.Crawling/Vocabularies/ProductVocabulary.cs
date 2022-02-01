using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;
using CluedIn.Crawling.Northwind.Core.Constants;

namespace CluedIn.Crawling.Northwind.Vocabularies
{
    public class  ProductVocabulary : SimpleVocabulary
    {
        public  ProductVocabulary()
        {
            VocabularyName = "Northwind Product"; 
            KeyPrefix      = "northwind.product"; 
            KeySeparator   = ".";
            Grouping       = NorthwindEntities.Products; // TODO: Make sure EntityType is correct.

            //TODO: Make sure that any properties mapped into CluedIn Vocabulary are not in the group.
            AddGroup("Northwind Product Details", group =>
            {
                ProductId = group.Add(new VocabularyKey("ProductId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductName = group.Add(new VocabularyKey("ProductName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SupplierId = group.Add(new VocabularyKey("SupplierId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CategoryId = group.Add(new VocabularyKey("CategoryId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                QuantityPerUnit = group.Add(new VocabularyKey("QuantityPerUnit", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UnitPrice = group.Add(new VocabularyKey("UnitPrice", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UnitsInStock = group.Add(new VocabularyKey("UnitsInStock", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UnitsOnOrder = group.Add(new VocabularyKey("UnitsOnOrder", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReorderLevel = group.Add(new VocabularyKey("ReorderLevel", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Discontinued = group.Add(new VocabularyKey("Discontinued", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                
            });

            //TODO: If the property is already set in the clueproducer, it doesn't have to be here.
             
            //TODO: Don't forget to map all possible properties into already existing CluedIn Vocabularies.
        
        }


        
        public VocabularyKey ProductId { get; private set; }
        
        public VocabularyKey ProductName { get; private set; }
        
        public VocabularyKey SupplierId { get; private set; }
        
        public VocabularyKey CategoryId { get; private set; }
        
        public VocabularyKey QuantityPerUnit { get; private set; }
        
        public VocabularyKey UnitPrice { get; private set; }
        
        public VocabularyKey UnitsInStock { get; private set; }
        
        public VocabularyKey UnitsOnOrder { get; private set; }
        
        public VocabularyKey ReorderLevel { get; private set; }
        
        public VocabularyKey Discontinued { get; private set; }
        
    }
}
