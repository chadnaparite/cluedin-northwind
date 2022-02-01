using System;
using CluedIn.Core.Data;
using CluedIn.Crawling.Factories;
using CluedIn.Crawling.Helpers;
using CluedIn.Crawling.Northwind.Vocabularies;
using CluedIn.Crawling.Northwind.Core.Models;

namespace CluedIn.Crawling.Northwind.ClueProducers
{
    public class EmployeeTeritoryClueProducer : BaseClueProducer<EmployeeTeritory>
    {
        private readonly IClueFactory factory;

        public EmployeeTeritoryClueProducer(IClueFactory factory)
        {
            this.factory = factory;
        }

        protected override Clue MakeClueImpl(EmployeeTeritory input, Guid accountId)
        {
            var employeeteritoryVocabulary = new EmployeeTeritoryVocabulary();
            var clue = factory.Create(employeeteritoryVocabulary.Grouping, input.EmployeeId.ToString(), accountId);
            var data = clue.Data.EntityData;

            data.Name = $"{input.EmployeeId}-{input.TerritoryId}";
            data.DisplayName = $"{input.EmployeeId}-{input.TerritoryId}";
            data.Description = $"{input.EmployeeId}-{input.TerritoryId}";

            data.Properties[employeeteritoryVocabulary.EmployeeId] = input.EmployeeId.PrintIfAvailable();
            data.Properties[employeeteritoryVocabulary.TerritoryId] = input.TerritoryId.PrintIfAvailable();

            return clue;
        }
    }
}
