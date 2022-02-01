using CluedIn.Core.Crawling;
using CluedIn.Crawling;
using CluedIn.Crawling.Northwind;
using CluedIn.Crawling.Northwind.Infrastructure.Factories;
using Moq;
using Shouldly;
using Xunit;

namespace Crawling.Northwind.Unit.Test
{
    public class NorthwindCrawlerBehaviour
    {
        private readonly ICrawlerDataGenerator _sut;

        public NorthwindCrawlerBehaviour()
        {
            var nameClientFactory = new Mock<INorthwindClientFactory>();

            _sut = new NorthwindCrawler(nameClientFactory.Object);
        }

        [Fact]
        public void GetDataReturnsData()
        {
            var jobData = new CrawlJobData();

            _sut.GetData(jobData)
                .ShouldNotBeNull();
        }
    }
}
