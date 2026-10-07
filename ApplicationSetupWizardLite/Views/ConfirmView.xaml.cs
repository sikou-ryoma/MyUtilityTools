using ApplicationSetupWizardLite.Conf;
using ApplicationSetupWizardLite.Paths;
using ApplicationSetupWizardLite.Context;

namespace ApplicationSetupWizardLite.Views
{
    /// <summary>
    /// ConfirmView.xaml の相互作用ロジック
    /// </summary>
    public partial class ConfirmView : System.Windows.Controls.UserControl
    {
        private readonly AppConfig _appConfig;
        private readonly XmlHelper _xmlHelper;
        private PathManager _paths;
        private ProcessContext _procCtx;
        private SetupContext _setupCtx;
        public ConfirmView(AppConfig appConfig, XmlHelper xmlHelper, PathManager paths, ProcessContext procCtx, SetupContext setupCtx)
        {
            InitializeComponent();
            _appConfig = appConfig;
            _xmlHelper = xmlHelper;
            _paths = paths;
            _procCtx = procCtx;
            _setupCtx = setupCtx;
            ApplicationNameText.Text = _appConfig.appName;
            UpdateConfirmView();
        }
        public void UpdateConfirmView()
        {
            InstallPathText.Text = _setupCtx.InstallPath;
            ShortcutText.Text = _setupCtx.CreateShortcut ? "ショートカットを作成する" : "作成しない";
        }
    }
}
