using Microsoft.UI.Xaml.Controls;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace BlendTest
{
    public partial class MyNavigationRD : ResourceDictionary
    {
        public MyNavigationRD() => InitializeComponent();

        private void TogglePaneButton_Click(object sender, RoutedEventArgs e)
        {
            ((sender as Button).Content as AnimatedVisualPlayer).AutoPlay = true;
            
        }
    }
}
