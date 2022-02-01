﻿using System;
using System.Collections.Generic;
using System.Text;
using CluedIn.Core.Data;
using CluedIn.Crawling.Northwind.Core.Constants;

namespace CluedIn.Provider.Northwind.RelatedEntities
{
    public class OrderDetailsRelatedEntities : BaseRelatedEntitiesProvider
    {
        public OrderDetailsRelatedEntities() : base(NorthwindEntities.OrderDetails)
        {
        }

        public override IEnumerable<DataStore.Document.Models.SuggestedSearch> SuggestedSearches(Guid id)
        {
            return new List<DataStore.Document.Models.SuggestedSearch>
            {
                RelatedEntitiesHelper.GetRelationshipForEntityOfType("Products", EntityEdgeType.OwnedBy, NorthwindEntities.Products),
                RelatedEntitiesHelper.GetRelationshipForEntityOfType("Orders", EntityEdgeType.OwnedBy, EntityType.Sales.Order),
            };
        }
    }
}
