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
    public class DemographicClueProducerTests : BaseClueProducerTest<Demographic>
    {
        protected override BaseClueProducer<Demographic> Sut =>
            new DemographicClueProducer(_clueFactory.Object);

        protected override EntityType ExpectedEntityType => NorthwindEntities.Demographic;

        [Theory]
        [InlineAutoData]
        public void ClueHasEdgeToFolder(Demographic demographic)
        {
            var clue = Sut.MakeClue(demographic, Guid.NewGuid());
            _clueFactory.Verify(
                //TODO verify some methods were called
                );
        }

        //TODO add other tests
    }
}
