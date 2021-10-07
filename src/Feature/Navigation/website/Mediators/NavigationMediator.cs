using MDigital.Feature.Navigation.Factories;
using MDigital.Feature.Navigation.Services;
using MDigital.Feature.Navigation.ViewModels;
using MDigital.Foundation.Core.Models;
using MDigital.Foundation.Core.Services;
using static MDigital.Feature.Navigation.Constants;

namespace MDigital.Feature.Navigation.Mediators
{
    /// <summary>
    /// Navigation Mediator.
    /// </summary>
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

        /// <summary>
        /// Header Navigation View Model Mediator
        /// </summary>
        /// <returns>MediatorResponse of Navigation View Model</returns>
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
