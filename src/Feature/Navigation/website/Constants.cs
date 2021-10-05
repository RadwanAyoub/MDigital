namespace MDigital.Feature.Navigation
{
    public class Constants
    {
        public static class Components
        {
            public static class HeaderNavigation
            {
                public static readonly string TemplateId = "{61243AF8-A0BD-4D1C-AB0D-29E59E8357DE}";
            }

            public static class SecondaryNavigationItem
            {
                public static readonly string TemplateId = "{95C2152B-1AE7-4A5A-9129-CC72A98DCAC2}";
            }

            public static class TertiaryNavigationItem
            {
                public static readonly string TemplateId = "{4B3AA55F-3288-41AC-A1F2-3938F25FAA6D}";
            }
        }

        public static class Logging
        {
            public static class Error
            {
                public const string DataSourceError = "The Navigation datasource was empty";
            }
        }

        public static class MediatorCodes
        {
            public static class NavigationResponse
            {
                public const string DataSourceError = "NavigationMediator.DataSourceError";
                public const string ViewModelError = "NavigationMediator.ViewModelError";
                public const string Ok = "NavigationMediator.Ok";
            }
        }
    }
}
