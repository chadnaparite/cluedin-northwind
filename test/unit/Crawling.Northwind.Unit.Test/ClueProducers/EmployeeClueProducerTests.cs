using AutoFixture.Xunit2;
using System;
using Xunit;
using CluedIn.Core.Data;
using CluedIn.Crawling;
using CluedIn.Crawling.Northwind.ClueProducers;
using CluedIn.Crawling.Northwind.Core.Models;
using CluedIn.Crawling.Northwind.Core.Constants;

namespace Crawling.Northwind.Unit.Test.ClueProducers
{
    public class EmployeeClueProducerTests : BaseClueProducerTest<Employee>
    {
        protected override BaseClueProducer<Employee> Sut =>
            new EmployeeClueProducer(_clueFactory.Object);

        protected override EntityType ExpectedEntityType => EntityType.Person;

        [Theory]
        [InlineAutoData]
        public void ClueHasEdgeToFolder(Employee employee)
        {
            var clue = Sut.MakeClue(employee, Guid.NewGuid());
            _clueFactory.Verify(
                //TODO verify some methods were called
                );
        }

        //TODO add other tests
    }
}
