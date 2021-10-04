using MDigital.Feautre.Navigation.Models;

namespace MDigital.Feautre.Navigation.Factories
{
    public interface INavigationFactory
    {
        NavigationViewModel CreateHeaderNavigationViewModel(object navigationItemDataSource, bool isExperienceEditor);
    }
}
