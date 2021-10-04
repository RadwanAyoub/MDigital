using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDigital.Feautre.Navigation.Services
{
    public interface INavigationService
    {
        object GetHeaderNavigationItems();
        bool IsExperienceEditor { get; }
    }
}
