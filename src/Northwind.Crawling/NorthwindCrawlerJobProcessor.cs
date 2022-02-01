using CluedIn.Crawling.Northwind.Core;

namespace CluedIn.Crawling.Northwind
{
    public class NorthwindCrawlerJobProcessor : GenericCrawlerTemplateJobProcessor<NorthwindCrawlJobData>
    {
        public NorthwindCrawlerJobProcessor(NorthwindCrawlerComponent component) : base(component)
        {
        }
    }
}
