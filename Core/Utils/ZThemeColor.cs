using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using Windows.UI;
using Windows.UI.Xaml;

namespace Core.Utils
{
    /// <summary>
    /// Wrapper class containing colors for dark and light mode. This allows us to change colors in run-time.
    /// </summary>
    public class ZThemeColor : INotifyPropertyChanged
    {
        private Color _colorDark;

        /// <summary>
        /// Represents the color used when the app is in Dark theme.
        /// </summary>
        public Color ColorDark
        {
            get { return _colorDark; }
            set
            {
                if (_colorDark != value)
                {
                    _colorDark = value;
                    OnPropertyChanged();
                }
            }
        }

        private Color _colorLight;

        /// <summary>
        /// Represents the color used when the app is in Light theme.
        /// </summary>
        public Color ColorLight
        {
            get { return _colorLight; }
            set
            {
                if (_colorLight != value)
                {
                    _colorLight = value;
                    OnPropertyChanged();
                }
            }
        }

        public ZThemeColor()
        {

        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    public static class ZThemeHelper
    {
        public static void UpdateZThemeColor(string resourceKey, Color colorDark, Color colorLight)
        {
            var resource = Application.Current.Resources[resourceKey];
            if (resource is ZThemeColor zThemeColor)
            {
                zThemeColor.ColorDark = colorDark;
                zThemeColor.ColorLight = colorLight;
            }
        }
    }
}