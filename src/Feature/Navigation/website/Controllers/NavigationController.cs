using MDigital.Feautre.Navigation.Mediators;
using MDigital.Foundation.Core.Exceptions;
using Sitecore.Mvc.Controllers;
using System.Web.Mvc;
using static MDigital.Feautre.Navigation.Constants;

namespace MDigital.Feautre.Navigation.Controllers
{
    public class NavigationController : SitecoreController
    {
        private readonly INavigationMediator _navigationMediator;

        public NavigationController(INavigationMediator navigationMediator)
        {
            _navigationMediator = navigationMediator;
        }

        public ActionResult HeaderNavigation()
        {
            var mediatorResponse = _navigationMediator.RequestHeaderNavigationViewModel();

            switch (mediatorResponse.Code)
            {
                case MediatorCodes.NavigationResponse.DataSourceError:
                case MediatorCodes.NavigationResponse.ViewModelError:
                    return View("~/views/Hero/Error.cshtml");
                case MediatorCodes.NavigationResponse.Ok:
                    return View(mediatorResponse.ViewModel);
                default:
                    throw new InvalidMediatorResponseCodeException(mediatorResponse.Code);
            }
        }
    }
}
