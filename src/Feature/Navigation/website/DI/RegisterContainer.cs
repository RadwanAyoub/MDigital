using MDigital.Feautre.Navigation.Factories;
using MDigital.Feautre.Navigation.Mediators;
using MDigital.Feautre.Navigation.Services;
using Microsoft.Extensions.DependencyInjection;
using Sitecore.DependencyInjection;

namespace MDigital.Feautre.Navigation.DI
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
