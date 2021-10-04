using MDigital.Feautre.Navigation.Models;
using MDigital.Foundation.Core.Models;

namespace MDigital.Feautre.Navigation.Mediators
{
    public interface INavigationMediator
    {
        MediatorResponse<NavigationViewModel> RequestHeaderNavigationViewModel();
    }
}
