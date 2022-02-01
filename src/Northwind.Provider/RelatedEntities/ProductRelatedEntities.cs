using System;
using System.Collections.Generic;
using System.Text;
using CluedIn.Core.Data;
using CluedIn.Crawling.Northwind.Core.Constants;

namespace CluedIn.Provider.Northwind.RelatedEntities
{
    public class ProductRelatedEntities : BaseRelatedEntitiesProvider
    {
        public ProductRelatedEntities() : base(NorthwindEntities.Products)
        {
        }

        public override IEnumerable<DataStore.Document.Models.SuggestedSearch> SuggestedSearches(Guid id)
        {
            return new List<DataStore.Document.Models.SuggestedSearch>
            {
                RelatedEntitiesHelper.GetRelationshipForEntityOfType("Categories", EntityEdgeType.OwnedBy, NorthwindEntities.Category),
                RelatedEntitiesHelper.GetRelationshipForEntityOfType("Order Details", EntityEdgeType.OwnedBy, NorthwindEntities.OrderDetails),
                RelatedEntitiesHelper.GetRelationshipForEntityOfType("Suppliers", EntityEdgeType.OwnedBy, NorthwindEntities.Supplier),
            };
        }
    }
}
