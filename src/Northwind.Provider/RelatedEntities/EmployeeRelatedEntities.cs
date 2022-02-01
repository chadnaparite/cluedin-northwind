using System;
using System.Collections.Generic;
using System.Text;
using CluedIn.Core.Data;
using CluedIn.Crawling.Northwind.Core.Constants;

namespace CluedIn.Provider.Northwind.RelatedEntities
{
    public class EmployeeRelatedEntities : BaseRelatedEntitiesProvider
    {
        public EmployeeRelatedEntities() : base(EntityType.Person)
        {
        }

        public override IEnumerable<DataStore.Document.Models.SuggestedSearch> SuggestedSearches(Guid id)
        {
            return new List<DataStore.Document.Models.SuggestedSearch>
            {
                RelatedEntitiesHelper.GetRelationshipForEntityOfType("Orders", EntityEdgeType.OwnedBy, EntityType.Sales.Order),
                RelatedEntitiesHelper.GetRelationshipForEntityOfType("Employee Territories", EntityEdgeType.OwnedBy, NorthwindEntities.EmployeeTeritory),
            };
        }
    }
}
