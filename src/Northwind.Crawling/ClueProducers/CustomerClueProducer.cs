using System;
using CluedIn.Core.Data;
using CluedIn.Crawling.Factories;
using CluedIn.Crawling.Helpers;
using CluedIn.Crawling.Northwind.Vocabularies;
using CluedIn.Crawling.Northwind.Core.Models;

namespace CluedIn.Crawling.Northwind.ClueProducers
{
    public class CustomerClueProducer : BaseClueProducer<Customer>
    {
        private readonly IClueFactory factory;

        public CustomerClueProducer(IClueFactory factory)
        {
            this.factory = factory;
        }

        protected override Clue MakeClueImpl(Customer input, Guid accountId)
        {
            var customerVocabulary = new CustomerVocabulary();
            var clue = factory.Create(customerVocabulary.Grouping, input.CustomerId.ToString(), accountId);
            var data = clue.Data.EntityData;

            if (input.CompanyName != null)
            {
                data.Name = input.CompanyName;
                data.DisplayName = input.CompanyName;
                data.Description = input.CompanyName;
            }

            data.Properties[customerVocabulary.CustomerId] = input.CustomerId.PrintIfAvailable();
            data.Properties[customerVocabulary.CompanyName] = input.CompanyName.PrintIfAvailable();
            data.Properties[customerVocabulary.ContactName] = input.ContactName.PrintIfAvailable();
            data.Properties[customerVocabulary.ContactTitle] = input.ContactTitle.PrintIfAvailable();
            data.Properties[customerVocabulary.Address] = input.Address.PrintIfAvailable();
            data.Properties[customerVocabulary.City] = input.City.PrintIfAvailable();
            data.Properties[customerVocabulary.Region] = input.Region.PrintIfAvailable();
            data.Properties[customerVocabulary.PostalCode] = input.PostalCode.PrintIfAvailable();
            data.Properties[customerVocabulary.Country] = input.Country.PrintIfAvailable();
            data.Properties[customerVocabulary.Phone] = input.Phone.PrintIfAvailable();
            data.Properties[customerVocabulary.Fax] = input.Fax.PrintIfAvailable();

            return clue;
        }
    }
}
