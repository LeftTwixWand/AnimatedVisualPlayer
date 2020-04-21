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
        private bool IsPlayed = false;
        AnimatedVisualPlayer player = null;
        public MyNavigationRD() => InitializeComponent();

        private async void TogglePaneButton_Click(object sender, RoutedEventArgs e)
        {
            //var window = (Style)Application.Current.Resources["MyNavigationViewStyle"];
            //var template = (ControlTemplate)window.Setters[3].GetValue(); // "MyNavigationViewControlTemplate"
            //var a = this.Resources[""]; // MyNavigationViewControlTemplate.GetValue(ContentProperty);
            //MyNavigationViewControlTemplate.GetValue(ContentControl)
            //MyNavigationViewControlTemplate.
            //MyNavigationViewControlTemplate
            //Button button = sender as Button;
            //Grid grid = (Grid)button.Parent;
            //grid.
            //AnimatedVisualPlayer animatedVisualPlayer = button.Content as AnimatedVisualPlayer;
            //animatedVisualPlayer.AutoPlay = true;

            if (player == null)
            {
                Button button = sender as Button;
                Grid grid = (Grid)button.Parent;
                player = grid.Children[2] as AnimatedVisualPlayer;

                if (IsPlayed)
                {
                    //player.SetProgress(0);
                    player.PlaybackRate = -1;
                    await player.PlayAsync(0, 1, false);
                }
                else
                {
                    player.PlaybackRate = 1;
                    await player.PlayAsync(0, 1, false);
                }
                IsPlayed = !IsPlayed;
            }
            else
            {
                if (IsPlayed)
                {
                    //player.SetProgress(0);
                    player.PlaybackRate = -1;
                    await player.PlayAsync(0,1, false);
                }
                else
                {
                    player.PlaybackRate = 1;
                    await player.PlayAsync(0, 1, false);
                }
                IsPlayed = !IsPlayed;
            }

            Debug.WriteLine("Work!");
        }
    }
}