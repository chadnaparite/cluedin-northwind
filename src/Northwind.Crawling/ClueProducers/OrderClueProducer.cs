using System;
using CluedIn.Core.Data;
using CluedIn.Crawling.Factories;
using CluedIn.Crawling.Helpers;
using CluedIn.Crawling.Northwind.Vocabularies;
using CluedIn.Crawling.Northwind.Core.Models;

namespace CluedIn.Crawling.Northwind.ClueProducers
{
    public class OrderClueProducer : BaseClueProducer<Order>
    {
        private readonly IClueFactory factory;

        public OrderClueProducer(IClueFactory factory)
        {
            this.factory = factory;
        }

        protected override Clue MakeClueImpl(Order input, Guid accountId)
        {
            var orderVocabulary = new OrderVocabulary();
            var clue = factory.Create(orderVocabulary.Grouping, input.OrderId.ToString(), accountId);
            var data = clue.Data.EntityData;

            data.Name = input.OrderId;
            data.DisplayName = input.OrderId;
            data.Description = input.OrderId;

            data.Properties[orderVocabulary.OrderId] = input.OrderId.PrintIfAvailable();
            data.Properties[orderVocabulary.CustomerId] = input.CustomerId.PrintIfAvailable();
            data.Properties[orderVocabulary.EmployeeId] = input.EmployeeId.PrintIfAvailable();
            data.Properties[orderVocabulary.OrderDate] = input.OrderDate.PrintIfAvailable();
            data.Properties[orderVocabulary.RequiredDate] = input.RequiredDate.PrintIfAvailable();
            data.Properties[orderVocabulary.ShippedDate] = input.ShippedDate.PrintIfAvailable();
            data.Properties[orderVocabulary.ShipVia] = input.ShipVia.PrintIfAvailable();
            data.Properties[orderVocabulary.Freight] = input.Freight.PrintIfAvailable();
            data.Properties[orderVocabulary.ShipName] = input.ShipName.PrintIfAvailable();
            data.Properties[orderVocabulary.ShipAddress] = input.ShipAddress.PrintIfAvailable();
            data.Properties[orderVocabulary.ShipCity] = input.ShipCity.PrintIfAvailable();
            data.Properties[orderVocabulary.ShipRegion] = input.ShipRegion.PrintIfAvailable();
            data.Properties[orderVocabulary.ShipPostalCode] = input.ShipPostalCode.PrintIfAvailable();
            data.Properties[orderVocabulary.ShipCountry] = input.ShipCountry.PrintIfAvailable();

            return clue;
        }
    }
}
