using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationSetupWizardLite.Context
{
    public class ProcessContext
    {
        public int CurrentStep { get; set; }

        public ProcessContext()
        {
            CurrentStep = 0;
        }
        public void NextStep()
        {
            CurrentStep++;
        }

        public void PreviousStep()
        {
            if (CurrentStep > 0)
            {
                CurrentStep--;
            }
        }
    }
}
