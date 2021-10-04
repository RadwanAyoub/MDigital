using Glass.Mapper.Sc.Fields;

namespace MDigital.Feautre.Navigation.Models
{
    public interface ITertiaryNavigationItem
    {
        string LinkText { get; set; }
        Link LinkUrl { get; set; }
    }
}
