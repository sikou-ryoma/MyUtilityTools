using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationSetupWizardLite.Context
{
    public class ProcessContext
    {
        private string step1Text { get; } = "ようこそ";
        private string step2Text { get; } = "インストール先";
        private string step3Text { get; } = "確認";
        private string step4Text { get; } = "インストール";
        private string step5Text { get; } = "完了";
        private string completeText { get; } = "✓  ";
        private string pendingText { get; } = "〇  ";
        private string currentText { get; } = "▶  ";

        public string step1Status { get; private set; }
        public string step2Status { get; private set; }
        public string step3Status { get; private set; }
        public string step4Status { get; private set; }
        public string step5Status { get; private set; }

        public int currentStep { get; private set; }
        public bool IsCompleted => currentStep >= 4; // Assuming there are 5 steps in the process

        public bool canCreateShortcut { get; set; } = true;
        public bool canOpenApplication { get; set; } = true;

        public ProcessContext()
        {
            currentStep = 0;
            step1Status = currentText + step1Text;
            step2Status = pendingText + step2Text;
            step3Status = pendingText + step3Text;
            step4Status = pendingText + step4Text;
            step5Status = pendingText + step5Text;
        }
        public void NextStep()
        {
            currentStep++;
            SetStepStatus(currentStep); 
        }

        public void PreviousStep()
        {
            currentStep--;
            SetStepStatus(currentStep);
        }

        private void SetStepStatus(int step)
        {
            step1Status = (step == 0 ? currentText : (step > 0 ? completeText : pendingText)) + step1Text;
            step2Status = (step == 1 ? currentText : (step > 1 ? completeText : pendingText)) + step2Text;
            step3Status = (step == 2 ? currentText : (step > 2 ? completeText : pendingText)) + step3Text;
            step4Status = (step == 3 ? currentText : (step > 3 ? completeText : pendingText)) + step4Text;
            step5Status = (step == 4 ? currentText : (step > 4 ? completeText : pendingText)) + step5Text;
        }


    }
}
