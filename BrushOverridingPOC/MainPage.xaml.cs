using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;

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

        public void ChangeAccentColorAndBrush()
        {
            // We are not changing the ZAccentBrushMedium SolidColorBrush resource itself, but only its Color property.
            // By changing the Color property of the SolidColorBrush, we ensure that all UI elements that reference this SolidColorBrush will see the change.
            // This wouldn't be the case if we were to replace the SolidColorBrush in the resources with a new one, because the existing UI elements would still have
            // references to the old brush.
            var zAccentBrush = Application.Current.Resources["ZAccentBrushMedium"] as SolidColorBrush;
            if (zAccentBrush != null)
            {   if (zAccentBrush.Color == Colors.Red)
                {
                    (Application.Current.Resources["ZAccentBrushMedium"] as SolidColorBrush).Color = Colors.Green; // Change to the color you want
                }
                else
                {
                    (Application.Current.Resources["ZAccentBrushMedium"] as SolidColorBrush).Color = Colors.Red; // Change to the color you want
                }
            }
        }

        private void AccentButton_Click(object sender, RoutedEventArgs e)
        {
            // Check if 
            ChangeAccentColorAndBrush();
            //ZThemeColor.UpdateZThemeColor("ZAccentColorLow", Colors.Red, Colors.Purple);
        }
    }
}
