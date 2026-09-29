using ApplicationSetupWizardLite.Context;
using ApplicationSetupWizardLite.Paths;
using ApplicationSetupWizardLite.Service;
using System.Text;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using ApplicationSetupWizardLite.Conf;


namespace ApplicationSetupWizardLite
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private PathManager paths =     
            new PathManager(Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "..", "..", "..")));
        private XmlHelper xml;
        private ProcessContext procCtx;
        private ProcessService procService;
        private AppConfig appConf;

        public MainWindow()
        {
            InitializeComponent();
            xml = new XmlHelper(paths.xmlFilePath);
            procCtx = new ProcessContext();
            procService = new ProcessService(xml, procCtx);
            appConf = new AppConfig(xml);
            ContentArea.Content = new Views.WelcomeView(appConf);
            GetStepStatus(procCtx.CurrentStep);
            AppNameLbl1.Text = appConf.appName;
            VersionLbl.Text = "Version " + appConf.appVersion;
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("インストールを中止しますか？", "確認", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                this.Close();
            }
        }

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