using System;
using CluedIn.Core.Data;
using CluedIn.Crawling.Factories;
using CluedIn.Crawling.Helpers;
using CluedIn.Crawling.Northwind.Vocabularies;
using CluedIn.Crawling.Northwind.Core.Models;
using CluedIn.Crawling.Northwind.Core.Constants;

namespace CluedIn.Crawling.Northwind.ClueProducers
{
    public class CustomerDemographicClueProducer : BaseClueProducer<CustomerDemographic>
    {
        private readonly IClueFactory factory;

        public CustomerDemographicClueProducer(IClueFactory factory)
        {
            this.factory = factory;
        }

        protected override Clue MakeClueImpl(CustomerDemographic input, Guid accountId)
        {
            var customerdemographicVocabulary = new CustomerDemographicVocabulary();
            var clue = factory.Create(customerdemographicVocabulary.Grouping, input.CustomerId.ToString(), accountId);
            var data = clue.Data.EntityData;

            data.Name = $"{input.CustomerId}-{input.CustomerTypeId}";
            data.DisplayName = $"{input.CustomerId}-{input.CustomerTypeId}";
            data.Description = $"{input.CustomerId}-{input.CustomerTypeId}";

            if (input.CustomerId != null)
            {
                factory.CreateIncomingEntityReference(clue, NorthwindEntities.Customers, EntityEdgeType.OwnedBy, input.CustomerId, input.CustomerId);
            }
            if (input.CustomerTypeId != null)
            {
                factory.CreateIncomingEntityReference(clue, NorthwindEntities.Demographic, EntityEdgeType.OwnedBy, input.CustomerTypeId, input.CustomerTypeId);
            }

            data.Properties[customerdemographicVocabulary.CustomerId] = input.CustomerId.PrintIfAvailable();
            data.Properties[customerdemographicVocabulary.CustomerTypeId] = input.CustomerTypeId.PrintIfAvailable();

            return clue;
        }
    }
}
