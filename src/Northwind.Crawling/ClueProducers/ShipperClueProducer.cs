using System;
using CluedIn.Core.Data;
using CluedIn.Crawling.Factories;
using CluedIn.Crawling.Helpers;
using CluedIn.Crawling.Northwind.Vocabularies;
using CluedIn.Crawling.Northwind.Core.Models;

namespace CluedIn.Crawling.Northwind.ClueProducers
{
    public class ShipperClueProducer : BaseClueProducer<Shipper>
    {
        private readonly IClueFactory factory;

        public ShipperClueProducer(IClueFactory factory)
        {
            this.factory = factory;
        }

        protected override Clue MakeClueImpl(Shipper input, Guid accountId)
        {
            var shipperVocabulary = new ShipperVocabulary();
            var clue = factory.Create(shipperVocabulary.Grouping, input.ShipperId.ToString(), accountId);
            var data = clue.Data.EntityData;

            // TODO: Uncomment or delete as appropriate for the different properties
            if (input.CompanyName != null)
            {
                data.Name = input.CompanyName;
                data.DisplayName = input.CompanyName;
                data.Description = input.CompanyName;
            }

            data.Properties[shipperVocabulary.ShipperId] = input.ShipperId.PrintIfAvailable();
            data.Properties[shipperVocabulary.CompanyName] = input.CompanyName.PrintIfAvailable();
            data.Properties[shipperVocabulary.Phone] = input.Phone.PrintIfAvailable();

            return clue;
        }
    }
}
