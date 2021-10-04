using Glass.Mapper.Sc.Fields;
using System.Collections.Generic;

namespace MDigital.Feautre.Navigation.Models
{
    public interface ISecondaryNavigationItem
    {
        string LinkText { get; set; }
        Link LinkUrl { get; set; }
        IEnumerable<ITertiaryNavigationItem> TertiaryNavigationItems { get; set; }
    }
}