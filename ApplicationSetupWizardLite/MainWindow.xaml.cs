using ApplicationSetupWizardLite.Paths;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;


namespace ApplicationSetupWizardLite
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // XmlHelper xml;
        private PathManager paths = new PathManager(AppContext.BaseDirectory);
        public MainWindow()
        {
            InitializeComponent();
            // xml = new XmlHelper(AppContext.BaseDirectory);
            ContentArea.Content = new Views.WelcomeView();
        }
    }
}