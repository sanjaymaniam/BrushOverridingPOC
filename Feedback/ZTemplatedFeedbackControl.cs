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
            // Load the resource dictionary
            //ResourceDictionary resourceDictionary = new ResourceDictionary();
            //resourceDictionary.Source = new Uri("ms-appx:///Feedback/ZTemplatedFeedbackControl.xaml", UriKind.Absolute);

            // Merge the resource dictionary into the control's resources
            //this.Resources.MergedDictionaries.Add(resourceDictionary);

            this.DefaultStyleKey = typeof(ZTemplatedFeedbackControl);
        }
    }
}
