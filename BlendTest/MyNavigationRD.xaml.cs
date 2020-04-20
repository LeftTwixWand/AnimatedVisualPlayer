using Microsoft.UI.Xaml.Controls;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;

namespace BlendTest
{
    public partial class MyNavigationRD : ResourceDictionary
    {
        public MyNavigationRD() => InitializeComponent();

        private void TogglePaneButton_Click(object sender, RoutedEventArgs e)
        {
            var window = (Style)Application.Current.Resources["MyNavigationViewStyle"];
            //var template = (ControlTemplate)window.Setters[3].GetValue(); // "MyNavigationViewControlTemplate"
            //var a = this.Resources[""]; // MyNavigationViewControlTemplate.GetValue(ContentProperty);
            //MyNavigationViewControlTemplate.GetValue(ContentControl)
            //MyNavigationViewControlTemplate.
            //MyNavigationViewControlTemplate
            
            Debug.WriteLine("Work!");
        }
    }
}
