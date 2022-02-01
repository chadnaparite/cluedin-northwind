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
    public class ShipperClueProducerTests : BaseClueProducerTest<Shipper>
    {
        protected override BaseClueProducer<Shipper> Sut =>
            new ShipperClueProducer(_clueFactory.Object);

        protected override EntityType ExpectedEntityType => NorthwindEntities.Shipper;

        [Theory]
        [InlineAutoData]
        public void ClueHasEdgeToFolder(Shipper shipper)
        {
            var clue = Sut.MakeClue(shipper, Guid.NewGuid());
            _clueFactory.Verify(
                //TODO verify some methods were called
                );
        }

        //TODO add other tests
    }
}
