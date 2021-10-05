using MDigital.Feature.Navigation.Models;
using MDigital.Foundation.Core.Models;

namespace MDigital.Feature.Navigation.Mediators
{
    public interface INavigationMediator
    {
        MediatorResponse<NavigationViewModel> RequestHeaderNavigationViewModel();
    }
}
