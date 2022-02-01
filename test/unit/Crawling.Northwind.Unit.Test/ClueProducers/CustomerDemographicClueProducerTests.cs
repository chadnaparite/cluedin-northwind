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
    public class CustomerDemographicClueProducerTests : BaseClueProducerTest<CustomerDemographic>
    {
        protected override BaseClueProducer<CustomerDemographic> Sut =>
            new CustomerDemographicClueProducer(_clueFactory.Object);

        protected override EntityType ExpectedEntityType => NorthwindEntities.CustomerDemographic;

        [Theory]
        [InlineAutoData]
        public void ClueHasEdgeToFolder(CustomerDemographic customerdemographic)
        {
            var clue = Sut.MakeClue(customerdemographic, Guid.NewGuid());
            _clueFactory.Verify(
                //TODO verify some methods were called
                );
        }

        //TODO add other tests
    }
}
