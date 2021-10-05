using MDigital.Feature.Navigation.Models;

namespace MDigital.Feature.Navigation.Factories
{
    public interface INavigationFactory
    {
        NavigationViewModel CreateHeaderNavigationViewModel(IHeaderNavigation navigationItemDataSource, bool isExperienceEditor);
    }
}
