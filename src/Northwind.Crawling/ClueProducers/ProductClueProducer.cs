using System;
using CluedIn.Core.Data;
using CluedIn.Crawling.Factories;
using CluedIn.Crawling.Helpers;
using CluedIn.Crawling.Northwind.Vocabularies;
using CluedIn.Crawling.Northwind.Core.Models;

namespace CluedIn.Crawling.Northwind.ClueProducers
{
    public class ProductClueProducer : BaseClueProducer<Product>
    {
        private readonly IClueFactory factory;

        public ProductClueProducer(IClueFactory factory)
        {
            this.factory = factory;
        }

        protected override Clue MakeClueImpl(Product input, Guid accountId)
        {
            var productVocabulary = new ProductVocabulary();
            var clue = factory.Create(productVocabulary.Grouping, input.ProductId.ToString(), accountId);
            var data = clue.Data.EntityData;

            if (input.ProductName!= null)
            {
                data.Name = input.ProductName;
                data.DisplayName = input.ProductName;
                data.Description = input.ProductName;
            }

            data.Properties[productVocabulary.ProductId] = input.ProductId.PrintIfAvailable();
            data.Properties[productVocabulary.ProductName] = input.ProductName.PrintIfAvailable();
            data.Properties[productVocabulary.SupplierId] = input.SupplierId.PrintIfAvailable();
            data.Properties[productVocabulary.CategoryId] = input.CategoryId.PrintIfAvailable();
            data.Properties[productVocabulary.QuantityPerUnit] = input.QuantityPerUnit.PrintIfAvailable();
            data.Properties[productVocabulary.UnitPrice] = input.UnitPrice.PrintIfAvailable();
            data.Properties[productVocabulary.UnitsInStock] = input.UnitsInStock.PrintIfAvailable();
            data.Properties[productVocabulary.UnitsOnOrder] = input.UnitsOnOrder.PrintIfAvailable();
            data.Properties[productVocabulary.ReorderLevel] = input.ReorderLevel.PrintIfAvailable();
            data.Properties[productVocabulary.Discontinued] = input.Discontinued.PrintIfAvailable();

            return clue;
        }
    }
}
