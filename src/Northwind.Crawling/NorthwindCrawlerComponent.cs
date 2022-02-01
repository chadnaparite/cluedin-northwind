using CluedIn.Core;
using CluedIn.Crawling.Northwind.Core;

using ComponentHost;

namespace CluedIn.Crawling.Northwind
{
    [Component(NorthwindConstants.CrawlerComponentName, "Crawlers", ComponentType.Service, Components.Server, Components.ContentExtractors, Isolation = ComponentIsolation.NotIsolated)]
    public class NorthwindCrawlerComponent : CrawlerComponentBase
    {
        public NorthwindCrawlerComponent([NotNull] ComponentInfo componentInfo)
            : base(componentInfo)
        {
        }
    }
}

