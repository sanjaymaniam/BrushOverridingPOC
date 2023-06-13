using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.ServiceModel.Channels;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Documents;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;

// The Templated Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234235

namespace Feedback
{
    public sealed class ZTemplatedFeedbackControl : Control
    {
        public static readonly DependencyProperty TextProperty = DependencyProperty.Register(
        "Text",
        typeof(string),
        typeof(ZTemplatedFeedbackControl),
        new PropertyMetadata(default(string)));

        public string Text
        {
            get { return (string)GetValue(TextProperty); }
            set { SetValue(TextProperty, value); }
        }

        public ZTemplatedFeedbackControl()
        {
            this.DefaultStyleKey = typeof(ZTemplatedFeedbackControl);

            // The control template for this control is defined in ZTemplatedFeedbackControl.xaml and merged into this project's
            // generic.xaml file. As a result, we don't need to import or merge the resource dictionary defined in ZTemplatedFeedbackControl.xaml 
            // directly into this control's resources.
        }

        public void SetZAccentBrushMedium()
        {
            var zAccentBrush = Application.Current.Resources["ZAccentBrushMedium"] as SolidColorBrush;
            if (zAccentBrush != null)
            {
                // When we set ZAccentBrushMedium to Foreground like this, the value does not change on Theme change.
                // As a workaround, we might have to listen to ActualThemeChanged and assign the brush from light or dark theme dictionaries again.
                
                RunIfTemplateChildExists<TextBlock>("ZFeedbackAccentColorBrushTb", tb =>
                {
                    tb.Foreground = zAccentBrush;
                });
            }
        }

        private void RunIfTemplateChildExists<T>(string childName, Action<T> actionToRunWithChild) where T : class
        {
            var childControl = GetTemplateChild(childName) as T;
            if (childControl != null)
            {
                actionToRunWithChild(childControl);
            }
        }
    }
}
