using System;
using System.Collections.Generic;
using System.Text;
using ApplicationSetupWizardLite.Context;

namespace ApplicationSetupWizardLite.Service
{
    public class ProcessService
    {
        private readonly XmlHelper _xmlHelper;
        private readonly ProcessContext _procCtx;
        
        public ProcessService(XmlHelper xmlHelper, ProcessContext processContext)
        {
            _xmlHelper = xmlHelper;
            _procCtx = processContext;
        }

        public void NextStep()
        {
            if (_procCtx.CurrentStep < 4)
            {
                _procCtx.NextStep();
            }
        }
    }
}
