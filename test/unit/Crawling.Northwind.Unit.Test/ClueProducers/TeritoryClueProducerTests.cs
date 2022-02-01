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
    public class TeritoryClueProducerTests : BaseClueProducerTest<Teritory>
    {
        protected override BaseClueProducer<Teritory> Sut =>
            new TeritoryClueProducer(_clueFactory.Object);

        protected override EntityType ExpectedEntityType => NorthwindEntities.Teritory;

        [Theory]
        [InlineAutoData]
        public void ClueHasEdgeToFolder(Teritory teritory)
        {
            var clue = Sut.MakeClue(teritory, Guid.NewGuid());
            _clueFactory.Verify(
                //TODO verify some methods were called
                );
        }

        //TODO add other tests
    }
}
