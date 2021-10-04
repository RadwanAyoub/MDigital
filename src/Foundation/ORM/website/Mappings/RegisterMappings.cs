using Glass.Mapper.Sc.Pipelines.AddMaps;
using MDigital.Foundation.ORM.Extensions;

namespace MDigital.Foundation.ORM.Mappings
{
    public class RegisterMappings : AddMapsPipeline  {
        public void Process(AddMapsPipelineArgs args)
        {
            args.MapsConfigFactory.AddFluentMaps("MDigital.Foundation.ORM");
        }
    }
}
