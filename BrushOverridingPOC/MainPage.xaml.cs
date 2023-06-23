using Core.Theme.Utils;
using System.Globalization;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

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
            this.InitializeComponent();

            // To override ZAccentColorLow, we use a util function to set its dark and light mode values.
            // ZThemeHelper.UpdateZThemeColor("ZAccentColorLow", Colors.Red, Colors.Purple);
        }

        private ApplicationTheme GetCurrentWindowThemeAsAppTheme() 
        {
            var windowContent = Window.Current.Content as FrameworkElement;
            return (windowContent.ActualTheme == ElementTheme.Light ? ApplicationTheme.Light : ApplicationTheme.Dark);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var windowContent = Window.Current.Content as FrameworkElement;
            windowContent.RequestedTheme = (windowContent.ActualTheme == ElementTheme.Light ? ElementTheme.Dark : ElementTheme.Light);
            
            // ZAppAccentColorPalette will be stored as a property later to avoid mutiple lookups
            var appThemeDummy = GetCurrentWindowThemeAsAppTheme();

            var acp = Application.Current.Resources["ZAppAccentColorPalette"] as ZAccentColorPalette;
            acp.UpdateThemeDependentAccentsBasedOnGivenTheme(appThemeDummy);
        }

        public void ToggleAccentColor()
        {
            // ZAppAccentColorPalette will be stored as a property later to avoid mutiple lookups
            var acp = Application.Current.Resources["ZAppAccentColorPalette"] as ZAccentColorPalette;

            if (acp.ZAccentColorLightTheme == ZThemeHelpers.ColorFromHex("#FF0078D4"))
            {
                SetAccentColorsToOrange(acp);
            }
            else
            {
                SetAccentColorsToBlue(acp);
            }
            // The UpdateThemeDependentAccentsBasedOnGivenTheme method must be called after applying new accent colors or changing themes.
            acp.UpdateThemeDependentAccentsBasedOnGivenTheme(Application.Current.RequestedTheme);
        }

        public void SetAccentColorsToBlue(ZAccentColorPalette cp)
        {
            //Assigning Light theme colors
            cp.ZAccentColorLightTheme = ZThemeHelpers.ColorFromHex("#FF0078D4");
            cp.ZAccentColorLightThemeLight1 = ZThemeHelpers.ColorFromHex("#FFE4EEF5");
            cp.ZAccentColorLightThemeLight2 = ZThemeHelpers.ColorFromHex("#FFD2E5F4");
            cp.ZAccentColorLightThemeLight3 = ZThemeHelpers.ColorFromHex("#FFADD4F1");
            cp.ZAccentColorLightThemeDark1 = ZThemeHelpers.ColorFromHex("#FFC8DBE8");
            cp.ZAccentColorLightThemeDark2 = ZThemeHelpers.ColorFromHex("#FF006ABB");
            cp.ZAccentColorLightThemeDark3 = ZThemeHelpers.ColorFromHex("#FF0065B2");

            // Assigning Dark theme colors
            cp.ZAccentColorDarkTheme = ZThemeHelpers.ColorFromHex("#FF0078D4");
            cp.ZAccentColorDarkThemeLight1 = ZThemeHelpers.ColorFromHex("#FF172734");
            cp.ZAccentColorDarkThemeLight2 = ZThemeHelpers.ColorFromHex("#FF143147");
            cp.ZAccentColorDarkThemeLight3 = ZThemeHelpers.ColorFromHex("#FF104065");
            cp.ZAccentColorDarkThemeDark1 = ZThemeHelpers.ColorFromHex("#FF274156");
            cp.ZAccentColorDarkThemeDark2 = ZThemeHelpers.ColorFromHex("#FF006ABB");
            cp.ZAccentColorDarkThemeDark3 = ZThemeHelpers.ColorFromHex("#FF0065B2");
        }

        public void SetAccentColorsToOrange(ZAccentColorPalette orangeAccentColorPalette)
        {
            //Assigning Light theme colors
            orangeAccentColorPalette.ZAccentColorLightTheme = ZThemeHelpers.ColorFromHex("#FFCA5010");
            orangeAccentColorPalette.ZAccentColorLightThemeLight1 = ZThemeHelpers.ColorFromHex("#FFF4EBE6");
            orangeAccentColorPalette.ZAccentColorLightThemeLight2 = ZThemeHelpers.ColorFromHex("#FFF3DFD5");
            orangeAccentColorPalette.ZAccentColorLightThemeLight3 = ZThemeHelpers.ColorFromHex("#FFECC5B1");
            orangeAccentColorPalette.ZAccentColorLightThemeDark1 = ZThemeHelpers.ColorFromHex("#FFE7D4CB");
            orangeAccentColorPalette.ZAccentColorLightThemeDark2 = ZThemeHelpers.ColorFromHex("#FFB2460E");
            orangeAccentColorPalette.ZAccentColorLightThemeDark3 = ZThemeHelpers.ColorFromHex("#FFAA430D");

            // Assigning Dark theme colors
            orangeAccentColorPalette.ZAccentColorDarkTheme = ZThemeHelpers.ColorFromHex("#FFCA5010");
            orangeAccentColorPalette.ZAccentColorDarkThemeLight1 = ZThemeHelpers.ColorFromHex("#FF332219");
            orangeAccentColorPalette.ZAccentColorDarkThemeLight2 = ZThemeHelpers.ColorFromHex("#FF442718");
            orangeAccentColorPalette.ZAccentColorDarkThemeLight3 = ZThemeHelpers.ColorFromHex("#FF613016");
            orangeAccentColorPalette.ZAccentColorDarkThemeDark1 = ZThemeHelpers.ColorFromHex("#FF53382A");
            orangeAccentColorPalette.ZAccentColorDarkThemeDark2 = ZThemeHelpers.ColorFromHex("#FFB2460E");
            orangeAccentColorPalette.ZAccentColorDarkThemeDark3 = ZThemeHelpers.ColorFromHex("#FFAA430D");
        }

        private void AccentButton_Click(object sender, RoutedEventArgs e)
        {
            ToggleAccentColor();
        }
    }
}
