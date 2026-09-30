using ApplicationSetupWizardLite.Conf;
using ApplicationSetupWizardLite.Paths;
using ApplicationSetupWizardLite.Context;
using System;
using System.Collections.Generic;
using System.Security.Permissions;
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
using System.Printing;

namespace ApplicationSetupWizardLite.Views
{
    /// <summary>
    /// InstallLocationView.xaml の相互作用ロジック
    /// </summary>
    public partial class InstallLocationView : UserControl
    {
        private readonly AppConfig _appConfig;
        private readonly XmlHelper _xmlHelper;
        private PathManager _paths;
        private ProcessContext _procCtx;

        public InstallLocationView(
            AppConfig appConfig,
            XmlHelper xmlHelper,
            PathManager paths,
            ProcessContext processContext)
        {
            InitializeComponent();
            _appConfig = appConfig;
            _xmlHelper = xmlHelper;
            _paths = paths;
            _procCtx = processContext;

            _paths.installPath = System.IO.Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles), 
                _appConfig.companyName,
                _appConfig.appName,
                _appConfig.appVersion);

            InstallPathTextBox.Text = _paths.installPath;
            ShortcutsCheckBox.IsChecked = true;
        }

        public void BrowseButton_Click(object sender, RoutedEventArgs e)
        {
/*            var dialog = new System.Windows.Forms.FolderBrowserDialog();
            System.Windows.Forms.DialogResult result = dialog.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                InstallLocationTextBox.Text = dialog.SelectedPath;
            }*/       
        }
    }
}
