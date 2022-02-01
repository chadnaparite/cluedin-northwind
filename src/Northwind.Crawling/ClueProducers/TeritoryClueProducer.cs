using System;
using CluedIn.Core.Data;
using CluedIn.Crawling.Factories;
using CluedIn.Crawling.Helpers;
using CluedIn.Crawling.Northwind.Vocabularies;
using CluedIn.Crawling.Northwind.Core.Models;

namespace CluedIn.Crawling.Northwind.ClueProducers
{
    public class TeritoryClueProducer : BaseClueProducer<Teritory>
    {
        private readonly IClueFactory factory;

        public TeritoryClueProducer(IClueFactory factory)
        {
            this.factory = factory;
        }

        protected override Clue MakeClueImpl(Teritory input, Guid accountId)
        {
            var teritoryVocabulary = new TeritoryVocabulary();
            var clue = factory.Create(teritoryVocabulary.Grouping, input.TerritoryId.ToString(), accountId);
            var data = clue.Data.EntityData;

            if (input.TerritoryDescription != null)
            {
                data.Name = input.TerritoryDescription;
                data.DisplayName = input.TerritoryDescription;
                data.Description = input.TerritoryDescription;
            }

            data.Properties[teritoryVocabulary.TerritoryId] = input.TerritoryId.PrintIfAvailable();
            data.Properties[teritoryVocabulary.TerritoryDescription] = input.TerritoryDescription.PrintIfAvailable();
            data.Properties[teritoryVocabulary.RegionId] = input.RegionId.PrintIfAvailable();

            return clue;
        }
    }
}
