using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationSetupWizardLite.Paths
{
    public class PathManager
    {
        // private readonly XmlHelper _xmlHelper;
        public string BaseDir { get; }

        public PathManager(string baseDir)
        {
            BaseDir = baseDir;
        }
    }
}
