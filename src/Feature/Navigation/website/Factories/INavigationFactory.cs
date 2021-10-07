using MDigital.Feature.Navigation.Models;
using MDigital.Feature.Navigation.ViewModels;

namespace MDigital.Feature.Navigation.Factories
{
    public interface INavigationFactory
    {
        NavigationViewModel CreateHeaderNavigationViewModel(IHeaderNavigation navigationItemDataSource, bool isExperienceEditor);
    }
}
