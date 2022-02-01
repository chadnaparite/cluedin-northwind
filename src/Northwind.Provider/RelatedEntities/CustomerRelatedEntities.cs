using System;
using System.Collections.Generic;
using System.Text;
using CluedIn.Core.Data;
using CluedIn.Crawling.Northwind.Core.Constants;

namespace CluedIn.Provider.Northwind.RelatedEntities
{
    public class CustomerRelatedEntities : BaseRelatedEntitiesProvider
    {
        public CustomerRelatedEntities() : base(NorthwindEntities.Customer)
        {
        }

        public override IEnumerable<DataStore.Document.Models.SuggestedSearch> SuggestedSearches(Guid id)
        {
            return new List<DataStore.Document.Models.SuggestedSearch>
            {
                RelatedEntitiesHelper.GetRelationshipForEntityOfType("Orders", EntityEdgeType.OwnedBy, EntityType.Sales.Order),
                RelatedEntitiesHelper.GetRelationshipForEntityOfType("Customer Demographics", EntityEdgeType.OwnedBy, NorthwindEntities.CustomerDemographic),
            };
        }
    }
}
