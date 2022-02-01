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
    public class CustomerClueProducerTests : BaseClueProducerTest<Customer>
    {
        protected override BaseClueProducer<Customer> Sut =>
            new CustomerClueProducer(_clueFactory.Object);

        protected override EntityType ExpectedEntityType => NorthwindEntities.Customers;

        [Theory]
        [InlineAutoData]
        public void ClueHasEdgeToFolder(Customer customer)
        {
            var clue = Sut.MakeClue(customer, Guid.NewGuid());
            _clueFactory.Verify(
                //TODO verify some methods were called
                );
        }

        //TODO add other tests
    }
}
