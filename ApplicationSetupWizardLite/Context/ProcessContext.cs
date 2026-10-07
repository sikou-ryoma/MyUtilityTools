namespace ApplicationSetupWizardLite.Context
{
    public class ProcessContext
    {
        public int currentStep { get; private set; }
        public bool IsCompleted => currentStep >= 4;
        
        public ProcessContext()
        {
            currentStep = 0;
        }
        public void NextStep()
        {
            currentStep++;
        }

        public void PreviousStep()
        {
            currentStep--;
        }
    }
}
