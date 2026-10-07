using ApplicationSetupWizardLite.Conf;

namespace ApplicationSetupWizardLite.Views
{
    /// <summary>
    /// InstallingView.xaml の相互作用ロジック
    /// </summary>
    public partial class InstallingView : System.Windows.Controls.UserControl
    {
        private readonly AppConfig _appConfig;
        public InstallingView(AppConfig appConfig)
        {
            InitializeComponent();
            _appConfig = appConfig;
        }
    }
}
