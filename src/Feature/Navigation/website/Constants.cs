using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDigital.Feautre.Navigation
{
    public class Constants
    {
        public static class Components
        {
            public static class Navigation
            {
                public static readonly string TemplateId = "";
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
