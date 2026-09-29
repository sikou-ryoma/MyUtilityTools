using ApplicationSetupWizardLite.Conf;
using ApplicationSetupWizardLite.Paths;
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
        private PathManager _paths;
        public ConfirmView(AppConfig appConfig, PathManager paths)
        {
            InitializeComponent();
            _appConfig = appConfig;
            _paths = paths;
            ApplicationNameText.Text = _appConfig.appName;
            InstallPathText.Text = _paths.installPath;
        }
    }
}
