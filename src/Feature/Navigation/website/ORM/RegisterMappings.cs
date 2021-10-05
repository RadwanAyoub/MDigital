using Glass.Mapper.Sc.Pipelines.AddMaps;
using MDigital.Foundation.ORM.Extensions;

namespace MDigital.Feature.Navigation.ORM
{
    public class RegisterMappings : AddMapsPipeline
    {
        public void Process(AddMapsPipelineArgs args)
        {
            args.MapsConfigFactory.AddFluentMaps("MDigital.Feature.Navigation");
        }
    }
}
