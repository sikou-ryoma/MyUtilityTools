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

        public string Step1Status { get; private set; }
        public string Step2Status { get; private set; }
        public string Step3Status { get; private set; }
        public string Step4Status { get; private set; }
        public string Step5Status { get; private set; }

        public int CurrentStep { get; private set; }
        public bool IsCompleted => CurrentStep >= 4; // Assuming there are 5 steps in the process

        public ProcessContext()
        {
            CurrentStep = 0;
            Step1Status = currentText + step1Text;
            Step2Status = pendingText + step2Text;
            Step3Status = pendingText + step3Text;
            Step4Status = pendingText + step4Text;
            Step5Status = pendingText + step5Text;
        }
        public void NextStep()
        {
            CurrentStep++;
            SetStepStatus(CurrentStep); 
        }

        public void PreviousStep()
        {
            CurrentStep--;
            SetStepStatus(CurrentStep);
        }

        private void SetStepStatus(int step)
        {
            Step1Status = (step == 0 ? currentText : (step > 0 ? completeText : pendingText)) + step1Text;
            Step2Status = (step == 1 ? currentText : (step > 1 ? completeText : pendingText)) + step2Text;
            Step3Status = (step == 2 ? currentText : (step > 2 ? completeText : pendingText)) + step3Text;
            Step4Status = (step == 3 ? currentText : (step > 3 ? completeText : pendingText)) + step4Text;
            Step5Status = (step == 4 ? currentText : (step > 4 ? completeText : pendingText)) + step5Text;
        }


    }
}
