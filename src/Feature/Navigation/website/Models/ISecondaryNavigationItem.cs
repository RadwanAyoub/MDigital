using Glass.Mapper.Sc.Fields;
using MDigital.Foundation.ORM.Models;
using System.Collections.Generic;

namespace MDigital.Feature.Navigation.Models
{
    /// <summary>
    /// Secondary Navigation Item Model.
    /// </summary>
    public interface ISecondaryNavigationItem : IGlassBase
    {
        string LinkText { get; set; }
        Link LinkUrl { get; set; }
        bool IncludeInNavigation { get; set; }
        IEnumerable<ITertiaryNavigationItem> TertiaryNavigationItems { get; set; }
    }
}