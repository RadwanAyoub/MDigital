﻿using Glass.Mapper.Sc.Maps;
using MDigital.Feautre.Navigation.Models;
using static MDigital.Feautre.Navigation.Constants;

namespace MDigital.Feautre.Navigation.ORM
{
    public class HeaderNavigationGlassMappings : SitecoreGlassMap<IHeaderNavigation>
    {
        public override void Configure()
        {
            Map(config => {
                config.AutoMap();
                config.TemplateId(Components.HeaderNavigation.TemplateId);
                config.Children(x => x.SecondaryNavigationItems).InferType().EnforceTemplate();
            });
        }
    }

    public class SecondaryNavigationItemGlassMappings : SitecoreGlassMap<ISecondaryNavigationItem>
    {
        public override void Configure()
        {
            Map(config => {
                config.AutoMap();
                config.TemplateId(Components.SecondaryNavigationItem.TemplateId);
                config.Children(x => x.TertiaryNavigationItems).InferType().EnforceTemplate();
            });
        }
    }

    public class TertiaryNavigationItemGlassMappings : SitecoreGlassMap<ITertiaryNavigationItem>
    {
        public override void Configure()
        {
            Map(config => {
                config.AutoMap();
                config.TemplateId(Components.TertiaryNavigationItem.TemplateId);
            });
        }
    }
}
