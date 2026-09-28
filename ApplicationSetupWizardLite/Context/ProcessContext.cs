using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationSetupWizardLite.Context
{
    public class ProcessContext
    {
        public const string STEP1 = "ようこそ";
        public const string STEP2 = "インストール先";
        public const string STEP3 = "確認";
        public const string STEP4 = "インストール";
        public const string STEP5 = "完了";
        public const string PROGRESS_COMPLETE = "✓  ";
        public const string PROGRESS_PENDING = "〇  ";
        public const string PROGRESS_CURRENT = "▶  ";

        public int CurrentStep { get; private set; }
        public bool IsCompleted => CurrentStep >= 5; // Assuming there are 5 steps in the process

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
