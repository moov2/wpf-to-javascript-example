using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            // When the application loads set the registry key to force the app to
            // render in IE 9 - Use a currentuser key so that admin rights
            // are not needed. See README for other version numbers.

            // If doing a release remove the vshost from the file name.
            
            Microsoft.Win32.RegistryKey key;
            key = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Internet Explorer\\Main\\FeatureControl\\FEATURE_BROWSER_EMULATION");
            key.SetValue("WPF Javascript CSharp interface.exe.vshost.exe", "9000", Microsoft.Win32.RegistryValueKind.DWord);
            key.Close();

            InitializeComponent();
            
            //Set this up so that the web browser exposes a scripting COM interface to the JavaScript
            ObjectForScriptingHelper helper = new ObjectForScriptingHelper(this);
            this.wbMain.ObjectForScripting = helper;
            
        }
    }
}
