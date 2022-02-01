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
    public class CategoryClueProducerTests : BaseClueProducerTest<Category>
    {
        protected override BaseClueProducer<Category> Sut =>
            new CategoryClueProducer(_clueFactory.Object);

        protected override EntityType ExpectedEntityType => NorthwindEntities.Category;

        [Theory]
        [InlineAutoData]
        public void ClueHasEdgeToFolder(Category category)
        {
            var clue = Sut.MakeClue(category, Guid.NewGuid());
            _clueFactory.Verify(
                //TODO verify some methods were called
                );
        }

        //TODO add other tests
    }
}
