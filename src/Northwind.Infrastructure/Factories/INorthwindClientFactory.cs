using CluedIn.Crawling.Northwind.Core;

namespace CluedIn.Crawling.Northwind.Infrastructure.Factories
{
    public interface INorthwindClientFactory
    {
        NorthwindClient CreateNew(NorthwindCrawlJobData NorthwindCrawlJobData);
    }
}
