using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using Castle.Facilities.TypedFactory;

using CluedIn.Core;
using CluedIn.Crawling.Northwind.Infrastructure.Factories;
using RestSharp;

namespace CluedIn.Crawling.Northwind.Infrastructure.Installers
{
    public class InstallComponents : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container
                .AddFacilityIfNotExists<TypedFactoryFacility>()
                .Register(Component.For<INorthwindClientFactory>().AsFactory())
                .Register(Component.For<NorthwindClient>().LifestyleTransient());

            if (!container.Kernel.HasComponent(typeof(IRestClient)) && !container.Kernel.HasComponent(typeof(RestClient)))
                container.Register(Component.For<IRestClient, RestClient>());
        }
    }
}
