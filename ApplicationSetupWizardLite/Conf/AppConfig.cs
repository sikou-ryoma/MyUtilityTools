using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationSetupWizardLite.Conf
{
    public class AppConfig
    {
        private readonly XmlHelper _xmlHelper;
        public string appName { get; }
        public string appVersion { get; }
        public string companyName { get; }

        public AppConfig(XmlHelper xmlHelper)
        {
            _xmlHelper = xmlHelper;
            appName = _xmlHelper.GetString("App", "Meta", "AppName");
            appVersion = _xmlHelper.GetString("App", "Meta", "AppVersion");
            companyName = _xmlHelper.GetString("App", "Meta", "CompanyName");
        }
    }
}
