using Windows.ApplicationModel.Core;
using Windows.UI;
using Windows.UI.Core;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;

namespace Theme.Utils
{
    /// <summary>
    /// A wrapper that provides a customizable accent color palette for Light and Dark themes in an app.
    /// </summary>
    //public class ZAccentColorPalette : DependencyObject
    //{
    //    #region Note on Theme Dependent and Theme Independent Accent Colors

    //    // Theme Dependent Accent Colors are based on the current theme and automatically adjust their values accordingly.
    //    // For eg, if current app or system theme is Light, ZAccentColor will return ZAccentColorLight and ZAccentColorDark if Dark.

    //    // Theme Independent Accent Colors are not tied to the current theme and remain the same when current theme changes.
    //    // For eg, ZAccentColorLightTheme will have the same value when current theme changes.

    //    // Naming convention for Theme Independent Accent Colors, with ZAccentColorLightThemeDark1 as an example:
    //    // 'ZAccentColor': Prefix for all app level accents.
    //    // 'LightTheme': Represents the theme (light mode or dark mode). Values of these colors will not change on theme change.
    //    // 'Dark': Describes the shade of the accent color. Could be 'Light' or 'Dark'. Not to be confused with dark theme or light theme colors.
    //    // '1': Refers to the intensity of the color. Could be '1', '2' or '3'.

    //    #endregion

    //    #region Theme Dependent Accent Colors

    //    /// <summary>
    //    /// Represents if theme dependent accents should be updated when system theme changes.
    //    /// Default value is true, and colors are updated on system theme change.
    //    /// If internal set to false, the developer has to call <see cref="UpdateThemeDependentAccentsBasedOnGivenTheme(ApplicationTheme)"/> explicitly, usually after changing app theme.
    //    /// </summary>
    //    public bool ShouldUpdateAccentsOnSystemThemeChange { get; set; } = true;

    //    /// <summary>
    //    /// Accent color for the current theme. Returns the value for either light or dark mode depending on the current theme.
    //    /// </summary>
    //    public Color ZAccentColor
    //    {
    //        get { return (Color)GetValue(ZAccentColorProperty); }
    //        internal set { SetValue(ZAccentColorProperty, value); }
    //    }

    //    public static readonly DependencyProperty ZAccentColorProperty =
    //        DependencyProperty.Register("ZAccentColor", typeof(Color), typeof(ZAccentColorPalette), new PropertyMetadata(default(Color)));

    //    /// <summary>
    //    /// Low intensity light shade for the current theme. Returns the value for either light or dark mode depending on the current theme.
    //    /// </summary>
    //    public Color ZAccentColorLight1
    //    {
    //        get { return (Color)GetValue(ZAccentColorLight1Property); }
    //        internal set { SetValue(ZAccentColorLight1Property, value); }
    //    }

    //    public static readonly DependencyProperty ZAccentColorLight1Property =
    //        DependencyProperty.Register("ZAccentColorLight1", typeof(Color), typeof(ZAccentColorPalette), new PropertyMetadata(default(Color)));

    //    /// <summary>
    //    /// Medium intensity light shade for the current theme. Returns the value for either light or dark mode depending on the current theme.
    //    /// </summary>
    //    public Color ZAccentColorLight2
    //    {
    //        get { return (Color)GetValue(ZAccentColorLight2Property); }
    //        internal set { SetValue(ZAccentColorLight2Property, value); }
    //    }

    //    public static readonly DependencyProperty ZAccentColorLight2Property =
    //        DependencyProperty.Register("ZAccentColorLight2", typeof(Color), typeof(ZAccentColorPalette), new PropertyMetadata(default(Color)));

    //    /// <summary>
    //    /// High intensity light shade for the current theme. Returns the value for either light or dark mode depending on the current theme.
    //    /// </summary>
    //    public Color ZAccentColorLight3
    //    {
    //        get { return (Color)GetValue(ZAccentColorLight3Property); }
    //        internal set { SetValue(ZAccentColorLight3Property, value); }
    //    }

    //    public static readonly DependencyProperty ZAccentColorLight3Property =
    //        DependencyProperty.Register("ZAccentColorLight3", typeof(Color), typeof(ZAccentColorPalette), new PropertyMetadata(default(Color)));

    //    /// <summary>
    //    /// Low intensity dark shade for the current theme. Returns the value for either light or dark mode depending on the current theme.
    //    /// </summary>
    //    public Color ZAccentColorDark1
    //    {
    //        get { return (Color)GetValue(ZAccentColorDark1Property); }
    //        internal set { SetValue(ZAccentColorDark1Property, value); }
    //    }

    //    public static readonly DependencyProperty ZAccentColorDark1Property =
    //        DependencyProperty.Register("ZAccentColorDark1", typeof(Color), typeof(ZAccentColorPalette), new PropertyMetadata(default(Color)));

    //    /// <summary>
    //    /// Medium intensity dark shade for the current theme. Returns the value for either light or dark mode depending on the current theme.
    //    /// </summary>
    //    public Color ZAccentColorDark2
    //    {
    //        get { return (Color)GetValue(ZAccentColorDark2Property); }
    //        internal set { SetValue(ZAccentColorDark2Property, value); }
    //    }

    //    public static readonly DependencyProperty ZAccentColorDark2Property =
    //        DependencyProperty.Register("ZAccentColorDark2", typeof(Color), typeof(ZAccentColorPalette), new PropertyMetadata(default(Color)));

    //    /// <summary>
    //    /// High intensity dark shade for the current theme. Returns the value for either light or dark mode depending on the current theme.
    //    /// </summary>
    //    public Color ZAccentColorDark3
    //    {
    //        get { return (Color)GetValue(ZAccentColorDark3Property); }
    //        internal set { SetValue(ZAccentColorDark3Property, value); }
    //    }

    //    public static readonly DependencyProperty ZAccentColorDark3Property =
    //        DependencyProperty.Register("ZAccentColorDark3", typeof(Color), typeof(ZAccentColorPalette), new PropertyMetadata(default(Color)));
    //    #endregion

    //    #region Theme Independent Accent Colors

    //    #region Light Mode Colors

    //    /// <summary>
    //    /// Accent color for light mode.
    //    /// </summary>
    //    public Color ZAccentColorLightTheme
    //    {
    //        get { return (Color)GetValue(ZAccentColorLightThemeProperty); }
    //        internal set { SetValue(ZAccentColorLightThemeProperty, value); }
    //    }

    //    public static readonly DependencyProperty ZAccentColorLightThemeProperty =
    //        DependencyProperty.Register("ZAccentColorLightTheme", typeof(Color), typeof(ZAccentColorPalette), new PropertyMetadata(default(Color)));

    //    /// <summary>
    //    /// Low intensity light shade for light mode.
    //    /// </summary>
    //    public Color ZAccentColorLightThemeLight1
    //    {
    //        get { return (Color)GetValue(ZAccentColorLightThemeLight1Property); }
    //        internal set { SetValue(ZAccentColorLightThemeLight1Property, value); }
    //    }

    //    public static readonly DependencyProperty ZAccentColorLightThemeLight1Property =
    //        DependencyProperty.Register("ZAccentColorLightThemeLight1", typeof(Color), typeof(ZAccentColorPalette), new PropertyMetadata(default(Color)));

    //    /// <summary>
    //    /// Medium intensity light shade for light mode.
    //    /// </summary>
    //    public Color ZAccentColorLightThemeLight2
    //    {
    //        get { return (Color)GetValue(ZAccentColorLightThemeLight2Property); }
    //        internal set { SetValue(ZAccentColorLightThemeLight2Property, value); }
    //    }

    //    public static readonly DependencyProperty ZAccentColorLightThemeLight2Property =
    //        DependencyProperty.Register("ZAccentColorLightThemeLight2", typeof(Color), typeof(ZAccentColorPalette), new PropertyMetadata(default(Color)));

    //    /// <summary>
    //    /// High intensity light shade for light mode.
    //    /// </summary>
    //    public Color ZAccentColorLightThemeLight3
    //    {
    //        get { return (Color)GetValue(ZAccentColorLightThemeLight3Property); }
    //        internal set { SetValue(ZAccentColorLightThemeLight3Property, value); }
    //    }

    //    public static readonly DependencyProperty ZAccentColorLightThemeLight3Property =
    //        DependencyProperty.Register("ZAccentColorLightThemeLight3", typeof(Color), typeof(ZAccentColorPalette), new PropertyMetadata(default(Color)));

    //    /// <summary>
    //    /// Very light accent color for light theme.
    //    /// </summary>
    //    public Color ZAccentColorLightThemeLight4
    //    {
    //        get { return (Color)GetValue(ZAccentColorLightThemeLight4Property); }
    //        internal set { SetValue(ZAccentColorLightThemeLight4Property, value); }
    //    }

    //    public static readonly DependencyProperty ZAccentColorLightThemeLight4Property =
    //        DependencyProperty.Register("ZAccentColorLightThemeLight4", typeof(Color), typeof(ZAccentColorPalette), new PropertyMetadata(default(Color)));

    //    /// <summary>
    //    /// Extremely light accent color for light theme.
    //    /// </summary>
    //    public Color ZAccentColorLightThemeLight5
    //    {
    //        get { return (Color)GetValue(ZAccentColorLightThemeLight5Property); }
    //        internal set { SetValue(ZAccentColorLightThemeLight5Property, value); }
    //    }

    //    public static readonly DependencyProperty ZAccentColorLightThemeLight5Property =
    //        DependencyProperty.Register("ZAccentColorLightThemeLight5", typeof(Color), typeof(ZAccentColorPalette), new PropertyMetadata(default(Color)));

    //    /// <summary>
    //    /// Low intensity dark shade for light mode.
    //    /// </summary>
    //    public Color ZAccentColorLightThemeDark1
    //    {
    //        get { return (Color)GetValue(ZAccentColorLightThemeDark1Property); }
    //        internal set { SetValue(ZAccentColorLightThemeDark1Property, value); }
    //    }

    //    public static readonly DependencyProperty ZAccentColorLightThemeDark1Property =
    //        DependencyProperty.Register("ZAccentColorLightThemeDark1", typeof(Color), typeof(ZAccentColorPalette), new PropertyMetadata(default(Color)));

    //    /// <summary>
    //    /// Medium intensity dark shade for light mode.
    //    /// </summary>
    //    public Color ZAccentColorLightThemeDark2
    //    {
    //        get { return (Color)GetValue(ZAccentColorLightThemeDark2Property); }
    //        internal set { SetValue(ZAccentColorLightThemeDark2Property, value); }
    //    }

    //    public static readonly DependencyProperty ZAccentColorLightThemeDark2Property =
    //        DependencyProperty.Register("ZAccentColorLightThemeDark2", typeof(Color), typeof(ZAccentColorPalette), new PropertyMetadata(default(Color)));

    //    /// <summary>
    //    /// High intensity dark shade for light mode.
    //    /// </summary>
    //    public Color ZAccentColorLightThemeDark3
    //    {
    //        get { return (Color)GetValue(ZAccentColorLightThemeDark3Property); }
    //        internal set { SetValue(ZAccentColorLightThemeDark3Property, value); }
    //    }

    //    public static readonly DependencyProperty ZAccentColorLightThemeDark3Property =
    //        DependencyProperty.Register("ZAccentColorLightThemeDark3", typeof(Color), typeof(ZAccentColorPalette), new PropertyMetadata(default(Color)));

    //    public Color ZAccentColorLightThemeDark4
    //    {
    //        get { return (Color)GetValue(ZAccentColorLightThemeDark4Property); }
    //        internal set { SetValue(ZAccentColorLightThemeDark4Property, value); }
    //    }

    //    public static readonly DependencyProperty ZAccentColorLightThemeDark4Property =
    //        DependencyProperty.Register("ZAccentColorLightThemeDark4", typeof(Color), typeof(ZAccentColorPalette), new PropertyMetadata(default(Color)));

    //    public Color ZAccentColorLightThemeDark5
    //    {
    //        get { return (Color)GetValue(ZAccentColorLightThemeDark5Property); }
    //        internal set { SetValue(ZAccentColorLightThemeDark5Property, value); }
    //    }

    //    public static readonly DependencyProperty ZAccentColorLightThemeDark5Property =
    //        DependencyProperty.Register("ZAccentColorLightThemeDark5", typeof(Color), typeof(ZAccentColorPalette), new PropertyMetadata(default(Color)));
    //    #endregion

    //    #region Dark Mode Colors

    //    public Color ZAccentColorDarkTheme
    //    {
    //        get { return (Color)GetValue(ZAccentColorDarkThemeProperty); }
    //        internal set { SetValue(ZAccentColorDarkThemeProperty, value); }
    //    }

    //    public static readonly DependencyProperty ZAccentColorDarkThemeProperty =
    //        DependencyProperty.Register("ZAccentColorDarkTheme", typeof(Color), typeof(ZAccentColorPalette), new PropertyMetadata(default(Color)));

    //    /// <summary>
    //    /// Low intensity light shade for dark mode.
    //    /// </summary>
    //    public Color ZAccentColorDarkThemeLight1
    //    {
    //        get { return (Color)GetValue(ZAccentColorDarkThemeLight1Property); }
    //        internal set { SetValue(ZAccentColorDarkThemeLight1Property, value); }
    //    }

    //    public static readonly DependencyProperty ZAccentColorDarkThemeLight1Property =
    //        DependencyProperty.Register("ZAccentColorDarkThemeLight1", typeof(Color), typeof(ZAccentColorPalette), new PropertyMetadata(default(Color)));

    //    /// <summary>
    //    /// Medium intensity light shade for dark mode.
    //    /// </summary>
    //    public Color ZAccentColorDarkThemeLight2
    //    {
    //        get { return (Color)GetValue(ZAccentColorDarkThemeLight2Property); }
    //        internal set { SetValue(ZAccentColorDarkThemeLight2Property, value); }
    //    }

    //    public static readonly DependencyProperty ZAccentColorDarkThemeLight2Property =
    //        DependencyProperty.Register("ZAccentColorDarkThemeLight2", typeof(Color), typeof(ZAccentColorPalette), new PropertyMetadata(default(Color)));

    //    /// <summary>
    //    /// High intensity light shade for dark mode.
    //    /// </summary>
    //    public Color ZAccentColorDarkThemeLight3
    //    {
    //        get { return (Color)GetValue(ZAccentColorDarkThemeLight3Property); }
    //        internal set { SetValue(ZAccentColorDarkThemeLight3Property, value); }
    //    }

    //    public static readonly DependencyProperty ZAccentColorDarkThemeLight3Property =
    //        DependencyProperty.Register("ZAccentColorDarkThemeLight3", typeof(Color), typeof(ZAccentColorPalette), new PropertyMetadata(default(Color)));

    //    /// <summary>
    //    /// Light shade variant 4 for dark mode.
    //    /// </summary>
    //    public Color ZAccentColorDarkThemeLight4
    //    {
    //        get { return (Color)GetValue(ZAccentColorDarkThemeLight4Property); }
    //        set { SetValue(ZAccentColorDarkThemeLight4Property, value); }
    //    }

    //    public static readonly DependencyProperty ZAccentColorDarkThemeLight4Property =
    //        DependencyProperty.Register("ZAccentColorDarkThemeLight4", typeof(Color), typeof(ZAccentColorPalette), new PropertyMetadata(default(Color)));

    //    /// <summary>
    //    /// Light shade variant 5 for dark mode.
    //    /// </summary>
    //    public Color ZAccentColorDarkThemeLight5
    //    {
    //        get { return (Color)GetValue(ZAccentColorDarkThemeLight5Property); }
    //        set { SetValue(ZAccentColorDarkThemeLight5Property, value); }
    //    }

    //    public static readonly DependencyProperty ZAccentColorDarkThemeLight5Property =
    //        DependencyProperty.Register("ZAccentColorDarkThemeLight5", typeof(Color), typeof(ZAccentColorPalette), new PropertyMetadata(default(Color)));

    //    /// <summary>
    //    /// Low intensity dark shade for dark mode.
    //    /// </summary>
    //    public Color ZAccentColorDarkThemeDark1
    //    {
    //        get { return (Color)GetValue(ZAccentColorDarkThemeDark1Property); }
    //        internal set { SetValue(ZAccentColorDarkThemeDark1Property, value); }
    //    }

    //    public static readonly DependencyProperty ZAccentColorDarkThemeDark1Property =
    //        DependencyProperty.Register("ZAccentColorDarkThemeDark1", typeof(Color), typeof(ZAccentColorPalette), new PropertyMetadata(default(Color)));

    //    /// <summary>
    //    /// Medium intensity dark shade for dark mode.
    //    /// </summary>
    //    public Color ZAccentColorDarkThemeDark2
    //    {
    //        get { return (Color)GetValue(ZAccentColorDarkThemeDark2Property); }
    //        internal set { SetValue(ZAccentColorDarkThemeDark2Property, value); }
    //    }

    //    public static readonly DependencyProperty ZAccentColorDarkThemeDark2Property =
    //        DependencyProperty.Register("ZAccentColorDarkThemeDark2", typeof(Color), typeof(ZAccentColorPalette), new PropertyMetadata(default(Color)));

    //    /// <summary>
    //    /// High intensity dark shade for dark mode.
    //    /// </summary>
    //    public Color ZAccentColorDarkThemeDark3
    //    {
    //        get { return (Color)GetValue(ZAccentColorDarkThemeDark3Property); }
    //        internal set { SetValue(ZAccentColorDarkThemeDark3Property, value); }
    //    }

    //    public static readonly DependencyProperty ZAccentColorDarkThemeDark3Property =
    //        DependencyProperty.Register("ZAccentColorDarkThemeDark3", typeof(Color), typeof(ZAccentColorPalette), new PropertyMetadata(default(Color)));

    //    /// <summary>
    //    /// Dark shade variant 4 for dark mode.
    //    /// </summary>
    //    public Color ZAccentColorDarkThemeDark4
    //    {
    //        get { return (Color)GetValue(ZAccentColorDarkThemeDark4Property); }
    //        set { SetValue(ZAccentColorDarkThemeDark4Property, value); }
    //    }

    //    public static readonly DependencyProperty ZAccentColorDarkThemeDark4Property =
    //        DependencyProperty.Register("ZAccentColorDarkThemeDark4", typeof(Color), typeof(ZAccentColorPalette), new PropertyMetadata(default(Color)));

    //    /// <summary>
    //    /// Dark shade variant 5 for dark mode.
    //    /// </summary>
    //    public Color ZAccentColorDarkThemeDark5
    //    {
    //        get { return (Color)GetValue(ZAccentColorDarkThemeDark5Property); }
    //        set { SetValue(ZAccentColorDarkThemeDark5Property, value); }
    //    }

    //    public static readonly DependencyProperty ZAccentColorDarkThemeDark5Property =
    //        DependencyProperty.Register("ZAccentColorDarkThemeDark5", typeof(Color), typeof(ZAccentColorPalette), new PropertyMetadata(default(Color)));

    //    #endregion

    //    #endregion

    //    private UISettings _UISettings = new UISettings();

    //    public ZAccentColorPalette()
    //    {
    //        // Subscribe to system color changes
    //        _UISettings.ColorValuesChanged += UISettings_ColorValuesChanged;

    //        // Update accents if ShouldUpdateAccentsOnSystemThemeChange flag is true
    //        if (ShouldUpdateAccentsOnSystemThemeChange)
    //        {
    //            UpdateThemeDependentAccentsBasedOnSystemTheme();
    //        }
    //    }

    //    /// <summary>
    //    /// Raised only when system color values change.
    //    /// </summary>
    //    /// <param name="sender"></param>
    //    /// <param name="args"></param>
    //    private void UISettings_ColorValuesChanged(UISettings sender, object args)
    //    {
    //        // Update accents if ShouldUpdateAccentsOnSystemThemeChange flag is true
    //        if (ShouldUpdateAccentsOnSystemThemeChange)
    //        {
    //            UpdateThemeDependentAccentsBasedOnSystemTheme();
    //        }
    //    }

    //    private void UpdateThemeDependentAccentsBasedOnSystemTheme()
    //    {
    //        Color backgroundColor = _UISettings.GetColorValue(UIColorType.Background);
    //        ApplicationTheme currentSystemTheme = (backgroundColor == Colors.White) ? ApplicationTheme.Light : ApplicationTheme.Dark;
    //        UpdateThemeDependentAccentsBasedOnGivenTheme(currentSystemTheme);
    //    }

    //    /// <summary>
    //    /// Sets dark or light mode values for theme dependent accents.
    //    /// </summary>
    //    /// <remarks>
    //    /// Extend the class and override this method to change the logic for updating theme dependent colors.
    //    /// </remarks>
    //    public virtual void UpdateThemeDependentAccentsBasedOnGivenTheme(ApplicationTheme currentTheme)
    //    {
    //        CoreApplication.MainView?.Dispatcher?.RunAsync(CoreDispatcherPriority.Normal, () => 
    //        {
    //            if (currentTheme == ApplicationTheme.Light) // App is in Light Mode
    //            {
    //                ZAccentColor = ZAccentColorLightTheme;
    //                ZAccentColorLight1 = ZAccentColorLightThemeLight1;
    //                ZAccentColorLight2 = ZAccentColorLightThemeLight2;
    //                ZAccentColorLight3 = ZAccentColorLightThemeLight3;
    //                ZAccentColorDark1 = ZAccentColorLightThemeDark1;
    //                ZAccentColorDark2 = ZAccentColorLightThemeDark2;
    //                ZAccentColorDark3 = ZAccentColorLightThemeDark3;
    //            }
    //            else if (currentTheme == ApplicationTheme.Dark) // App is in Dark Mode
    //            {
    //                ZAccentColor = ZAccentColorDarkTheme;
    //                ZAccentColorLight1 = ZAccentColorDarkThemeLight1;
    //                ZAccentColorLight2 = ZAccentColorDarkThemeLight2;
    //                ZAccentColorLight3 = ZAccentColorDarkThemeLight3;
    //                ZAccentColorDark1 = ZAccentColorDarkThemeDark1;
    //                ZAccentColorDark2 = ZAccentColorDarkThemeDark2;
    //                ZAccentColorDark3 = ZAccentColorDarkThemeDark3;
    //            }
    //        });
    //    }
    //}
}
