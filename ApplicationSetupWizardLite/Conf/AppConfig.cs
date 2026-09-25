using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationSetupWizardLite.Conf
{
    public class AppConfig
    {
        // private readonly XmlHelper _xmlHelper;
        public string appName { get; }
        public string appVersion { get; }
        public string companyName { get; }
        public AppConfig()
        {
            // _xmlHelper = new XmlHelper(AppContext.BaseDirectory);
            appName = "Application Setup Wizard Lite";
            appVersion = "1.0.0";
            companyName = "Your Company Name";
        }
    }
}
