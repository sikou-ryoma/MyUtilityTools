using ApplicationSetupWizardLite.Conf;

namespace ApplicationSetupWizardLite.Views
{
    /// <summary>
    /// CompleteView.xaml の相互作用ロジック
    /// </summary>
    public partial class CompleteView : System.Windows.Controls.UserControl
    {
        private readonly AppConfig _appConfig;
        public CompleteView(AppConfig appConfig)
        {
            InitializeComponent();
            _appConfig = appConfig;
            DescriptionText.Text = $"{_appConfig.appName} のインストールが正常に完了しました。";
        }
    }
}
