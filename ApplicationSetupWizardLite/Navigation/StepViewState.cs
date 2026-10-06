using ApplicationSetupWizardLite.Conf;
using ApplicationSetupWizardLite.Views;
using ApplicationSetupWizardLite.Context;
using ApplicationSetupWizardLite.Paths;
using System;
using System.Collections.Generic;
using System.Text;
using UserControl = System.Windows.Controls.UserControl;

namespace ApplicationSetupWizardLite.Navigation
{
    public class StepViewState
    {
        public UserControl? View { get; set; }

        public string? NextButtonText { get; set; }
        public string? BackButtonText { get; set; }

        public bool CanGoBack { get; set; }

        public bool ShowCancel { get; set; }
        public bool ShowBack { get; set; }

    }

}
