using ApplicationSetupWizardLite.Conf;
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
