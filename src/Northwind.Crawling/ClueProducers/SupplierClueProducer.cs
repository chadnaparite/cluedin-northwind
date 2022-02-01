using System;
using CluedIn.Core.Data;
using CluedIn.Crawling.Factories;
using CluedIn.Crawling.Helpers;
using CluedIn.Crawling.Northwind.Vocabularies;
using CluedIn.Crawling.Northwind.Core.Models;

namespace CluedIn.Crawling.Northwind.ClueProducers
{
    public class SupplierClueProducer : BaseClueProducer<Supplier>
    {
        private readonly IClueFactory factory;

        public SupplierClueProducer(IClueFactory factory)
        {
            this.factory = factory;
        }

        protected override Clue MakeClueImpl(Supplier input, Guid accountId)
        {
            var supplierVocabulary = new SupplierVocabulary();
            var clue = factory.Create(supplierVocabulary.Grouping,input.SupplierId.ToString(), accountId);
            var data = clue.Data.EntityData;

            if (input.CompanyName != null)
            {
                data.Name = input.CompanyName;
                data.DisplayName = input.CompanyName;
                data.Description = input.CompanyName;
            }

            data.Properties[supplierVocabulary.SupplierId] = input.SupplierId.PrintIfAvailable();
            data.Properties[supplierVocabulary.CompanyName] = input.CompanyName.PrintIfAvailable();
            data.Properties[supplierVocabulary.ContactName] = input.ContactName.PrintIfAvailable();
            data.Properties[supplierVocabulary.ContactTitle] = input.ContactTitle.PrintIfAvailable();
            data.Properties[supplierVocabulary.Address] = input.Address.PrintIfAvailable();
            data.Properties[supplierVocabulary.City] = input.City.PrintIfAvailable();
            data.Properties[supplierVocabulary.Region] = input.Region.PrintIfAvailable();
            data.Properties[supplierVocabulary.PostalCode] = input.PostalCode.PrintIfAvailable();
            data.Properties[supplierVocabulary.Country] = input.Country.PrintIfAvailable();
            data.Properties[supplierVocabulary.Phone] = input.Phone.PrintIfAvailable();
            data.Properties[supplierVocabulary.Fax] = input.Fax.PrintIfAvailable();
            data.Properties[supplierVocabulary.HomePage] = input.HomePage.PrintIfAvailable();

            return clue;
        }
    }
}
