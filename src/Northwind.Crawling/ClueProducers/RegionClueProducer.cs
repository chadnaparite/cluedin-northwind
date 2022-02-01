using System;
using CluedIn.Core.Data;
using CluedIn.Crawling.Factories;
using CluedIn.Crawling.Helpers;
using CluedIn.Crawling.Northwind.Vocabularies;
using CluedIn.Crawling.Northwind.Core.Models;

namespace CluedIn.Crawling.Northwind.ClueProducers
{
    public class RegionClueProducer : BaseClueProducer<Region>
    {
        private readonly IClueFactory factory;

        public RegionClueProducer(IClueFactory factory)
        {
            this.factory = factory;
        }

        protected override Clue MakeClueImpl(Region input, Guid accountId)
        {
            var regionVocabulary = new RegionVocabulary();
            var clue = factory.Create(regionVocabulary.Grouping, input.RegionId.ToString(), accountId);
            var data = clue.Data.EntityData;

            if (input.RegionDescription != null)
            {
                data.Name = input.RegionDescription;
                data.DisplayName = input.RegionDescription;
                data.Description = input.RegionDescription;
            }

            data.Properties[regionVocabulary.RegionId] = input.RegionId.PrintIfAvailable();
            data.Properties[regionVocabulary.RegionDescription] = input.RegionDescription.PrintIfAvailable();

            return clue;
        }
    }
}
