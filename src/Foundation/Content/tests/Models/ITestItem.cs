using MDigital.Foundation.ORM.Models;

namespace MDigital.Foundation.Content.Tests.Models
{
    public interface ITestItem : IGlassBase
    {
        string Title { get; set; }
    }
}
