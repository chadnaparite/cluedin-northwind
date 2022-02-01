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
    public class SupplierClueProducerTests : BaseClueProducerTest<Supplier>
    {
        protected override BaseClueProducer<Supplier> Sut =>
            new SupplierClueProducer(_clueFactory.Object);

        protected override EntityType ExpectedEntityType => NorthwindEntities.Suppliers;

        [Theory]
        [InlineAutoData]
        public void ClueHasEdgeToFolder(Supplier supplier)
        {
            var clue = Sut.MakeClue(supplier, Guid.NewGuid());
            _clueFactory.Verify(
                //TODO verify some methods were called
                );
        }

        //TODO add other tests
    }
}
