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

        public void NextProcess()
        {
            if (_procCtx.currentStep < 4)
            {
                _procCtx.NextStep();
            }
        }

        public void PreviousProcess()
        {
            if (_procCtx.currentStep > 0)
            {
                _procCtx.PreviousStep();
            }
        }

    }
}
