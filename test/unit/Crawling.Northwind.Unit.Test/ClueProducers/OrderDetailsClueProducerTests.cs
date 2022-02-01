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
    public class OrderDetailsClueProducerTests : BaseClueProducerTest<OrderDetails>
    {
        protected override BaseClueProducer<OrderDetails> Sut =>
            new OrderDetailsClueProducer(_clueFactory.Object);

        protected override EntityType ExpectedEntityType => NorthwindEntities.OrderDetails;

        [Theory]
        [InlineAutoData]
        public void ClueHasEdgeToFolder(OrderDetails orderdetails)
        {
            var clue = Sut.MakeClue(orderdetails, Guid.NewGuid());
            _clueFactory.Verify(
                //TODO verify some methods were called
                );
        }

        //TODO add other tests
    }
}
