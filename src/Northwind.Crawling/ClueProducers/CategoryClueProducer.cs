using System;
using CluedIn.Core.Data;
using CluedIn.Crawling.Factories;
using CluedIn.Crawling.Helpers;
using CluedIn.Crawling.Northwind.Vocabularies;
using CluedIn.Crawling.Northwind.Core.Models;

namespace CluedIn.Crawling.Northwind.ClueProducers
{
    public class CategoryClueProducer : BaseClueProducer<Category>
    {
        private readonly IClueFactory factory;

        public CategoryClueProducer(IClueFactory factory)
        {
            this.factory = factory;
        }

        protected override Clue MakeClueImpl(Category input, Guid accountId)
        {
            var categoryVocabulary = new CategoryVocabulary();
            var clue = factory.Create(categoryVocabulary.Grouping, input.CategoryId.ToString(), accountId);
            var data = clue.Data.EntityData;

            if (input.CategoryName != null)
            {
                data.Name = input.CategoryName;
                data.DisplayName = input.CategoryName;
                data.Description = input.Description;
            }

            data.Properties[categoryVocabulary.CategoryId] = input.CategoryId.PrintIfAvailable();
            data.Properties[categoryVocabulary.CategoryName] = input.CategoryName.PrintIfAvailable();
            data.Properties[categoryVocabulary.Description] = input.Description.PrintIfAvailable();
            data.Properties[categoryVocabulary.Picture] = input.Picture.PrintIfAvailable();

            return clue;
        }
    }
}
