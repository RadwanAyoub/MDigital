using MDigital.Feature.Navigation.Factories;
using MDigital.Feature.Navigation.Mediators;
using MDigital.Feature.Navigation.Services;
using Microsoft.Extensions.DependencyInjection;
using Sitecore.DependencyInjection;

namespace MDigital.Feature.Navigation.DI
{
    public class RegisterContainer : IServicesConfigurator
    {
        public void Configure(IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<INavigationMediator, NavigationMediator>();
            serviceCollection.AddTransient<INavigationService, NavigationService>();
            serviceCollection.AddTransient<INavigationFactory, NavigationFactory>();
        }
    }
}
