using MDigital.Feautre.Navigation.Factories;
using MDigital.Feautre.Navigation.Models;
using MDigital.Feautre.Navigation.Services;
using MDigital.Foundation.Core.Models;
using MDigital.Foundation.Core.Services;
using static MDigital.Feautre.Navigation.Constants;

namespace MDigital.Feautre.Navigation.Mediators
{
    public class NavigationMediator : INavigationMediator
    {
        private readonly INavigationService _navigationService;
        private readonly IMediatorService _mediatorService;
        private readonly INavigationFactory _navigationFactory;

        public NavigationMediator(INavigationService navigationService, IMediatorService mediatorService,
            INavigationFactory navigationFactory)
        {
            _navigationService = navigationService;
            _mediatorService = mediatorService;
            _navigationFactory = navigationFactory;
        }

        public MediatorResponse<NavigationViewModel> RequestHeaderNavigationViewModel()
        {
            var navigationItemDataSource = _navigationService.GetHeaderNavigationItems();

            if (navigationItemDataSource == null)
                return _mediatorService.GetMediatorResponse<NavigationViewModel>(MediatorCodes.NavigationResponse.DataSourceError);

            var viewModel =
                _navigationFactory.CreateHeaderNavigationViewModel(navigationItemDataSource, _navigationService.IsExperienceEditor);

            if (viewModel == null)
                return _mediatorService.GetMediatorResponse<NavigationViewModel>(MediatorCodes.NavigationResponse.ViewModelError);

            return _mediatorService.GetMediatorResponse(MediatorCodes.NavigationResponse.Ok, viewModel);
        }
    }
}
