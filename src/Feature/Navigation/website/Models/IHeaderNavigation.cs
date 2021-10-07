using Glass.Mapper.Sc.Fields;
using MDigital.Foundation.ORM.Models;
using System.Collections.Generic;

namespace MDigital.Feature.Navigation.Models
{
    /// <summary>
    /// Header Navigation Model.
    /// </summary>
    public interface IHeaderNavigation : IGlassBase
    {
        Image Logo { get; set; }
        string HeaderAd { get; set; }
        string UserAccountLabel { get; set; }
        Link UserAccountUrl { get; set; }
        IEnumerable<ISecondaryNavigationItem> SecondaryNavigationItems { get; set; }
    }
}
