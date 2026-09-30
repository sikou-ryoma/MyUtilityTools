using ApplicationSetupWizardLite.Conf;
using ApplicationSetupWizardLite.Paths;
using ApplicationSetupWizardLite.Context;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ApplicationSetupWizardLite.Views
{
    /// <summary>
    /// ConfirmView.xaml の相互作用ロジック
    /// </summary>
    public partial class ConfirmView : UserControl
    {
        private readonly AppConfig _appConfig;
        private readonly XmlHelper _xmlHelper;
        private PathManager _paths;
        private ProcessContext _procCtx;
        public ConfirmView(AppConfig appConfig, XmlHelper xmlHelper, PathManager paths, ProcessContext procCtx)
        {
            InitializeComponent();
            _appConfig = appConfig;
            _xmlHelper = xmlHelper;
            _paths = paths;
            _procCtx = procCtx;
            ApplicationNameText.Text = _appConfig.appName;
        }
        public void UpdateConfirmView()
        {
            InstallPathText.Text = _paths.installPath;
            ShortcutText.Text = _procCtx.canCreateShortcut ? "ショートカットを作成する" : "作成しない";
        }
    }
}
