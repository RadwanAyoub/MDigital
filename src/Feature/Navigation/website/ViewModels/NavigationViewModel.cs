using MDigital.Feature.Navigation.Models;

namespace MDigital.Feature.Navigation.ViewModels
{
    public class NavigationViewModel
    {
        public IHeaderNavigation HeaderNavigation { get; set; }
        public bool IsExperienceEditor { get; set; }
    }
}
