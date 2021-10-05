using Glass.Mapper.Sc.Fields;
using MDigital.Foundation.ORM.Models;

namespace MDigital.Feature.Navigation.Models
{
    public interface ITertiaryNavigationItem : IGlassBase
    {
        string LinkText { get; set; }
        Link LinkUrl { get; set; }
    }
}
