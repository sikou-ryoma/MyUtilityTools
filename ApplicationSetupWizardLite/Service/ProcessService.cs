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
            switch(_procCtx.currentStep)
            {
                case 0:
                    // Step 0: Welcome
                    _procCtx.NextStep();
                    break;
                case 1:
                    // Step 1: Installation Path
                    _procCtx.NextStep();
                    break;
                case 2:
                    // Step 2: Confirmation
                    _procCtx.NextStep();
                    break;
                case 3:
                    // Step 3: Installation
                    _procCtx.NextStep();
                    break;
                case 4:
                    // Step 4: Completion
                    // Do nothing or handle completion logic if needed
                    break;
                default:
                    throw new InvalidOperationException("Invalid step index.");
            }
        }

        public void PreviousProcess()
        {
            switch(_procCtx.currentStep)
            {
                case 0:
                    // Step 0: Welcome
                    // Do nothing or handle logic if needed
                    break;
                case 1:
                    // Step 1: Installation Path
                    _procCtx.PreviousStep();
                    break;
                case 2:
                    // Step 2: Confirmation
                    _procCtx.PreviousStep();
                    break;
                case 3:
                    // Step 3: Installation
                    _procCtx.PreviousStep();
                    break;
                case 4:
                    // Step 4: Completion
                    _procCtx.PreviousStep();
                    break;
                default:
                    throw new InvalidOperationException("Invalid step index.");
            }
        }

    }
}
