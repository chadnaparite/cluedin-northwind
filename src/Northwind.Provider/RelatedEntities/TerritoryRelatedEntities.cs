using System;
using System.Collections.Generic;
using System.Text;
using CluedIn.Core.Data;
using CluedIn.Crawling.Northwind.Core.Constants;

namespace CluedIn.Provider.Northwind.RelatedEntities
{
    public class TerritoryRelatedEntities : BaseRelatedEntitiesProvider
    {
        public TerritoryRelatedEntities() : base(NorthwindEntities.Teritory)
        {
        }

        public override IEnumerable<DataStore.Document.Models.SuggestedSearch> SuggestedSearches(Guid id)
        {
            return new List<DataStore.Document.Models.SuggestedSearch>
            {
                RelatedEntitiesHelper.GetRelationshipForEntityOfType("Employee Territories", EntityEdgeType.OwnedBy, NorthwindEntities.EmployeeTeritory),
                RelatedEntitiesHelper.GetRelationshipForEntityOfType("Regions", EntityEdgeType.OwnedBy, NorthwindEntities.Region),
            };
        }
    }
}
