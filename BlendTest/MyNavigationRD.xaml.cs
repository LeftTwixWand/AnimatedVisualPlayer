using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;

namespace BlendTest
{
    public partial class MyNavigationRD : ResourceDictionary
    {
        public MyNavigationRD() => InitializeComponent();

        private void TogglePaneButton_Click(object sender, RoutedEventArgs e)
        {
            Debug.WriteLine("text form my debug!!");
        }
    }
}
