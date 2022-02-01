using System.Collections.Generic;

using CluedIn.Core.Crawling;
using CluedIn.Crawling.Northwind.Core;
using CluedIn.Crawling.Northwind.Infrastructure.Factories;

namespace CluedIn.Crawling.Northwind
{
    public class NorthwindCrawler : ICrawlerDataGenerator
    {
        private readonly INorthwindClientFactory clientFactory;
        public NorthwindCrawler(INorthwindClientFactory clientFactory)
        {
            this.clientFactory = clientFactory;
        }

        public IEnumerable<object> GetData(CrawlJobData jobData)
        {
            if (!(jobData is NorthwindCrawlJobData NorthwindcrawlJobData))
            {
                yield break;
            }

            var client = clientFactory.CreateNew(NorthwindcrawlJobData);

            //retrieve data from provider and yield objects
            
        }       
    }
}
