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
    public class ProductClueProducerTests : BaseClueProducerTest<Product>
    {
        protected override BaseClueProducer<Product> Sut =>
            new ProductClueProducer(_clueFactory.Object);

        protected override EntityType ExpectedEntityType => NorthwindEntities.Products;

        [Theory]
        [InlineAutoData]
        public void ClueHasEdgeToFolder(Product product)
        {
            var clue = Sut.MakeClue(product, Guid.NewGuid());
            _clueFactory.Verify(
                //TODO verify some methods were called
                );
        }

        //TODO add other tests
    }
}
