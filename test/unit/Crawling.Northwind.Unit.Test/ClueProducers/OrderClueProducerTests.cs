using AutoFixture.Xunit2;
using System;
using Xunit;
using CluedIn.Core.Data;
using CluedIn.Crawling;
using CluedIn.Crawling.Northwind.ClueProducers;
using CluedIn.Crawling.Northwind.Core.Models;

namespace Crawling.Northwind.Unit.Test.ClueProducers
{
    public class OrderClueProducerTests : BaseClueProducerTest<Order>
    {
        protected override BaseClueProducer<Order> Sut =>
            new OrderClueProducer(_clueFactory.Object);

        protected override EntityType ExpectedEntityType => EntityType.Sales.Order;

        [Theory]
        [InlineAutoData]
        public void ClueHasEdgeToFolder(Order order)
        {
            var clue = Sut.MakeClue(order, Guid.NewGuid());
            _clueFactory.Verify(
                //TODO verify some methods were called
                );
        }

        //TODO add other tests
    }
}
