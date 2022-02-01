using System;
using CluedIn.Core.Data;
using CluedIn.Crawling.Factories;
using CluedIn.Crawling.Helpers;
using CluedIn.Crawling.Northwind.Vocabularies;
using CluedIn.Crawling.Northwind.Core.Models;

namespace CluedIn.Crawling.Northwind.ClueProducers
{
    public class DemographicClueProducer : BaseClueProducer<Demographic>
    {
        private readonly IClueFactory factory;

        public DemographicClueProducer(IClueFactory factory)
        {
            this.factory = factory;
        }

        protected override Clue MakeClueImpl(Demographic input, Guid accountId)
        {
            var demographicVocabulary = new DemographicVocabulary();
            var clue = factory.Create(demographicVocabulary.Grouping, input.CustomerTypeId.ToString(), accountId);
            var data = clue.Data.EntityData;

            // TODO: Uncomment or delete as appropriate for the different properties
            if (input.CustomerDesc != null)
            {
                data.Name = input.CustomerDesc;
                data.DisplayName = input.CustomerDesc;
                data.Description = input.CustomerDesc;
            }

            data.Properties[demographicVocabulary.CustomerTypeId] = input.CustomerTypeId.PrintIfAvailable();
            data.Properties[demographicVocabulary.CustomerDesc] = input.CustomerDesc.PrintIfAvailable();

            return clue;
        }
    }
}
