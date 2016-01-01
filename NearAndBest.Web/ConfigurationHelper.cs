using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace NearAndBest.Web
{
    public static class ConfigurationHelper
    {
        public static string ServiceUrl;

        static ConfigurationHelper()
        {
            ServiceUrl = ConfigurationManager.AppSettings[Constants.AppSettingKeys.ServiceUrl];
        }
    }
}