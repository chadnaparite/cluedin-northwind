using Castle.Windsor;
using CluedIn.Core;
using CluedIn.Core.Providers;
using CluedIn.Crawling.Northwind.Infrastructure.Factories;
using Moq;

namespace CluedIn.Provider.Northwind.Unit.Test.NorthwindProvider
{
    public abstract class NorthwindProviderTest
    {
        protected readonly ProviderBase Sut;

        protected Mock<INorthwindClientFactory> NameClientFactory;
        protected Mock<IWindsorContainer> Container;

        protected NorthwindProviderTest()
        {
            Container = new Mock<IWindsorContainer>();
            NameClientFactory = new Mock<INorthwindClientFactory>();
            var applicationContext = new ApplicationContext(Container.Object);
            Sut = new Northwind.NorthwindProvider(applicationContext, NameClientFactory.Object);
        }
    }
}
