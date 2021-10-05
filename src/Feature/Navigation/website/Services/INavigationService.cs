using MDigital.Feature.Navigation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDigital.Feature.Navigation.Services
{
    public interface INavigationService
    {
        IHeaderNavigation GetHeaderNavigationItems();
        bool IsExperienceEditor { get; }
    }
}
