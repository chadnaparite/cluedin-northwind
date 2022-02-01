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
    public class RegionClueProducerTests : BaseClueProducerTest<Region>
    {
        protected override BaseClueProducer<Region> Sut =>
            new RegionClueProducer(_clueFactory.Object);

        protected override EntityType ExpectedEntityType => NorthwindEntities.Region;

        [Theory]
        [InlineAutoData]
        public void ClueHasEdgeToFolder(Region region)
        {
            var clue = Sut.MakeClue(region, Guid.NewGuid());
            _clueFactory.Verify(
                //TODO verify some methods were called
                );
        }

        //TODO add other tests
    }
}
