using MDigital.Feature.Navigation.Models;
using System;

namespace MDigital.Feature.Navigation.Factories
{
    public class NavigationFactory : INavigationFactory
    {
        public NavigationViewModel CreateHeaderNavigationViewModel(IHeaderNavigation navigationItemDataSource, bool isExperienceEditor)
        {
            return new NavigationViewModel
            {
                HeaderNavigation = navigationItemDataSource,
                IsExperienceEditor = isExperienceEditor
            };
        }
    }
}
