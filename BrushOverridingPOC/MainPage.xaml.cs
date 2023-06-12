using Core.Utils;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace BrushOverridingPOC
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            ModifyZAccentColorLow();
            this.InitializeComponent();
        }

        public void ModifyZAccentColorLow()
        {
            // Fetch the ZThemeColor object from the App resources
            var zAccentColorLow = Application.Current.Resources["ZAccentColorLow"] as ZThemeColor;

            if (zAccentColorLow != null)
            {
                // Modify the ColorDark and ColorLight properties
                zAccentColorLow.ColorDark = Colors.Green; // Change to the color you want
                zAccentColorLow.ColorLight = Colors.Yellow; // Change to the color you want
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (this.ActualTheme == ElementTheme.Dark) 
            { 
                this.RequestedTheme = ElementTheme.Light;
            }
            else
            {
                this.RequestedTheme = ElementTheme.Dark;
            }
        }
    }
}
