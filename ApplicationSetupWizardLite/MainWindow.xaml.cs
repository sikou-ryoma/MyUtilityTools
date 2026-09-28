using ApplicationSetupWizardLite.Context;
using ApplicationSetupWizardLite.Paths;
using ApplicationSetupWizardLite.Service;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;


namespace ApplicationSetupWizardLite
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // XmlHelper xml;
        private PathManager paths = new PathManager(AppContext.BaseDirectory);
        private ProcessContext procCtx;
        private ProcessService procService;
        public MainWindow()
        {
            InitializeComponent();
            // xml = new XmlHelper(AppContext.BaseDirectory);
            procCtx = new ProcessContext();
            procService = new ProcessService(procCtx);
            ContentArea.Content = new Views.WelcomeView();
            GetStepStatus(procCtx.CurrentStep);
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e) => this.Close();

        private void NextButton_Click(object sender, RoutedEventArgs e)
        {
            if (procCtx.CurrentStep < 4)
            {
                procCtx.NextStep();
                GetStepStatus(procCtx.CurrentStep);

                if (procCtx.CurrentStep > 0)
                { 
                    BackButton.IsEnabled = true;
                }
            }
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            if (procCtx.CurrentStep > 0)
            {
                procCtx.PreviousStep();
                GetStepStatus(procCtx.CurrentStep);

                if (procCtx.CurrentStep == 0)
                {
                    BackButton.IsEnabled = false;
                }
            }
        }

        private void GetStepStatus(int step)
        {
            Step1.Text = (step == 0 ? ProcessContext.PROGRESS_CURRENT : (step > 0 ? ProcessContext.PROGRESS_COMPLETE : ProcessContext.PROGRESS_PENDING)) + ProcessContext.STEP1;
            Step2.Text = (step == 1 ? ProcessContext.PROGRESS_CURRENT : (step > 1 ? ProcessContext.PROGRESS_COMPLETE : ProcessContext.PROGRESS_PENDING)) + ProcessContext.STEP2;
            Step3.Text = (step == 2 ? ProcessContext.PROGRESS_CURRENT : (step > 2 ? ProcessContext.PROGRESS_COMPLETE : ProcessContext.PROGRESS_PENDING)) + ProcessContext.STEP3;
            Step4.Text = (step == 3 ? ProcessContext.PROGRESS_CURRENT : (step > 3 ? ProcessContext.PROGRESS_COMPLETE : ProcessContext.PROGRESS_PENDING)) + ProcessContext.STEP4;
            Step5.Text = (step == 4 ? ProcessContext.PROGRESS_CURRENT : (step > 4 ? ProcessContext.PROGRESS_COMPLETE : ProcessContext.PROGRESS_PENDING)) + ProcessContext.STEP5;
        }

    }
}