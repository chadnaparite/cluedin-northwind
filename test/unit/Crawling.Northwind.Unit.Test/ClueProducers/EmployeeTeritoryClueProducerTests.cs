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
    public class EmployeeTeritoryClueProducerTests : BaseClueProducerTest<EmployeeTeritory>
    {
        protected override BaseClueProducer<EmployeeTeritory> Sut =>
            new EmployeeTeritoryClueProducer(_clueFactory.Object);

        protected override EntityType ExpectedEntityType => NorthwindEntities.EmployeeTeritory;

        [Theory]
        [InlineAutoData]
        public void ClueHasEdgeToFolder(EmployeeTeritory employeeteritory)
        {
            var clue = Sut.MakeClue(employeeteritory, Guid.NewGuid());
            _clueFactory.Verify(
                //TODO verify some methods were called
                );
        }

        //TODO add other tests
    }
}
