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
            GetStepStatus();
            ChengeContent(procCtx.CurrentStep);
            AppNameLbl1.Text = appConf.appName;
            VersionLbl.Text = "Version " + appConf.appVersion;
        }

        private void GetStepStatus()
        {
            Step1.Text = procCtx.Step1Status;
            Step2.Text = procCtx.Step2Status;
            Step3.Text = procCtx.Step3Status;
            Step4.Text = procCtx.Step4Status;
            Step5.Text = procCtx.Step5Status;
        }

        private void ChengeContent(int step)
        {
            switch (step)
            {
                case 0:
                    ContentArea.Content = new Views.WelcomeView(appConf);
                    BackButton.IsEnabled = false;
                    break;
                case 1:
                    ContentArea.Content = new Views.InstallLocationView(appConf, paths);
                    BackButton.IsEnabled = true;
                    break;
                case 2:
                    ContentArea.Content = new Views.ConfirmView(appConf, paths);
                    NextButton.Content = "インストール";
                    break;
                case 3:
                    ContentArea.Content = new Views.InstallingView(appConf);
                    BackButton.IsEnabled = false;
                    break;
                case 4:
                    ContentArea.Content = new Views.CompleteView(appConf);
                    NextButton.Content = "完了";
                    CancelButton.Visibility = Visibility.Collapsed;
                    BackButton.Visibility = Visibility.Collapsed;
                    break;
                    // Add more cases as needed
            }
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            var result = MessageBox.Show(
                "セットアップを中止しますか？", 
                "確認", 
                MessageBoxButton.YesNo, 
                MessageBoxImage.Question
            );

            if (result == MessageBoxResult.Yes)
            {
                this.Close();
            }
        }

        private void NextButton_Click(object sender, RoutedEventArgs e)
        {
            if (procCtx.IsCompleted)
            {
                this.Close();
            }

            procService.NextProcess();
            GetStepStatus();
            ChengeContent(procCtx.CurrentStep);
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            procService.PreviousProcess();
            GetStepStatus();
            ChengeContent(procCtx.CurrentStep);
        }

    }
}