using System;
using System.Collections.Generic;
using System.Text;
using CluedIn.Core.Data;
using CluedIn.Crawling.Northwind.Core.Constants;

namespace CluedIn.Provider.Northwind.RelatedEntities
{
    public class OrderRelatedEntities : BaseRelatedEntitiesProvider
    {
        public OrderRelatedEntities() : base(EntityType.Sales.Order)
        {
        }

        public override IEnumerable<DataStore.Document.Models.SuggestedSearch> SuggestedSearches(Guid id)
        {
            return new List<DataStore.Document.Models.SuggestedSearch>
            {
                RelatedEntitiesHelper.GetRelationshipForEntityOfType("Customers", EntityEdgeType.OwnedBy, NorthwindEntities.Customer),
                RelatedEntitiesHelper.GetRelationshipForEntityOfType("Employees", EntityEdgeType.OwnedBy, NorthwindEntities.Employee),
            };
        }
    }
}
