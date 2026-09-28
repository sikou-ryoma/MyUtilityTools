using System;
using System.Collections.Generic;
using System.Text;
using ApplicationSetupWizardLite.Context;

namespace ApplicationSetupWizardLite.Service
{
    public class ProcessService
    {
        // private readonly XmlHelper _xmlHelper;
        private readonly ProcessContext _processContext;
        
        public ProcessService(ProcessContext processContext)
        {
            // _xmlHelper = xmlHelper;
            _processContext = processContext;
        }

        public void NextStep()
        {
            if (_processContext.CurrentStep < 4)
            {
                _processContext.NextStep();
            }
        }
    }
}
