using Glass.Mapper.Sc.Fields;
using MDigital.Foundation.ORM.Models;
using System.Collections.Generic;

namespace MDigital.Feature.Navigation.Models
{
    public interface ISecondaryNavigationItem : IGlassBase
    {
        string LinkText { get; set; }
        Link LinkUrl { get; set; }
        IEnumerable<ITertiaryNavigationItem> TertiaryNavigationItems { get; set; }
    }
}