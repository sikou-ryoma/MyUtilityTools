using ApplicationSetupWizardLite.Conf;
using ApplicationSetupWizardLite.Paths;
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

namespace ApplicationSetupWizardLite.Views
{
    /// <summary>
    /// InstallLocationView.xaml の相互作用ロジック
    /// </summary>
    public partial class InstallLocationView : UserControl
    {
        private readonly AppConfig _appConfig;
        private PathManager _paths;
        public InstallLocationView(AppConfig appConfig, PathManager paths)
        {
            InitializeComponent();
            _appConfig = appConfig;
            _paths = paths;
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
            }
*/        
        }

    }
}
