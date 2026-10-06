using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationSetupWizardLite.Context
{
    public class ProcessContext
    {
        public int currentStep { get; private set; }
        public bool IsCompleted => currentStep >= 4;
        
        public string? installPath { get; set; }
        public bool canCreateShortcut { get; set; } = true;
        public bool canOpenApplication { get; set; } = true;

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
