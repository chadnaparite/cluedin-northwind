using System;
using CluedIn.Core.Data;
using CluedIn.Crawling.Factories;
using CluedIn.Crawling.Helpers;
using CluedIn.Crawling.Northwind.Vocabularies;
using CluedIn.Crawling.Northwind.Core.Models;

namespace CluedIn.Crawling.Northwind.ClueProducers
{
    public class EmployeeClueProducer : BaseClueProducer<Employee>
    {
        private readonly IClueFactory factory;

        public EmployeeClueProducer(IClueFactory factory)
        {
            this.factory = factory;
        }

        protected override Clue MakeClueImpl(Employee input, Guid accountId)
        {
            var employeeVocabulary = new EmployeeVocabulary();
            var clue = factory.Create(employeeVocabulary.Grouping, input.EmployeeId.ToString(), accountId);
            var data = clue.Data.EntityData;

            // TODO: Uncomment or delete as appropriate for the different properties
            if (input.FullName != null)
            {
                data.Name = input.FullName;
                data.DisplayName = input.FullName;
                data.Description = input.FullName;
            }

            data.Properties[employeeVocabulary.EmployeeId] = input.EmployeeId.PrintIfAvailable();
            data.Properties[employeeVocabulary.LastName] = input.LastName.PrintIfAvailable();
            data.Properties[employeeVocabulary.FirstName] = input.FirstName.PrintIfAvailable();
            data.Properties[employeeVocabulary.Title] = input.Title.PrintIfAvailable();
            data.Properties[employeeVocabulary.TitleOfCourtesy] = input.TitleOfCourtesy.PrintIfAvailable();
            data.Properties[employeeVocabulary.BirthDate] = input.BirthDate.PrintIfAvailable();
            data.Properties[employeeVocabulary.HireDate] = input.HireDate.PrintIfAvailable();
            data.Properties[employeeVocabulary.Address] = input.Address.PrintIfAvailable();
            data.Properties[employeeVocabulary.City] = input.City.PrintIfAvailable();
            data.Properties[employeeVocabulary.Region] = input.Region.PrintIfAvailable();
            data.Properties[employeeVocabulary.PostalCode] = input.PostalCode.PrintIfAvailable();
            data.Properties[employeeVocabulary.Country] = input.Country.PrintIfAvailable();
            data.Properties[employeeVocabulary.HomePhone] = input.HomePhone.PrintIfAvailable();
            data.Properties[employeeVocabulary.Extension] = input.Extension.PrintIfAvailable();
            data.Properties[employeeVocabulary.Photo] = input.Photo.PrintIfAvailable();
            data.Properties[employeeVocabulary.Notes] = input.Notes.PrintIfAvailable();
            data.Properties[employeeVocabulary.ReportsTo] = input.ReportsTo.PrintIfAvailable();
            data.Properties[employeeVocabulary.PhotoPath] = input.PhotoPath.PrintIfAvailable();

            return clue;
        }
    }
}
