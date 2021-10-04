using Glass.Mapper.Sc.Fields;
using MDigital.Foundation.ORM.Models;
using System.Collections.Generic;

namespace MDigital.Feautre.Navigation.Models
{
    public interface IHeaderNavigation : IGlassBase
    {
        Image Logo { get; set; }
        Image BasketIcon { get; set; }
        string SearchLabel { get; set; }
        IEnumerable<ISecondaryNavigationItem> SecondaryNavigationItems { get; set; }
    }
}
