using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorAutomationFramework.Common.Helpers
{
    public static class ApplicationSettings
    {
        public static string SikuliImage => GetSettingValue("sikuliImagePath");

        public static string GetApplicationTitle(string key)
        {
            return GetSettingValue(key);
        }

        private static string GetSettingValue(string key)
        {
            return ConfigurationManager.AppSettings[key];
        }

        public static string GetApplicationPath(string key)
        {
            return GetSettingValue(key);
        }
    }
}
