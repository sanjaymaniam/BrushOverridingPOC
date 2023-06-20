﻿using Windows.UI;
using Windows.UI.Xaml;

namespace Theme
{
    public class ZThemeColorPalette : DependencyObject
    {
        #region Properties

        public Color AccentColor
        {
            get { return (Color)GetValue(AccentColorProperty); }
            set { SetValue(AccentColorProperty, value); }
        }

        public Color AccentColorLowIntensityDarkTheme
        {
            get { return (Color)GetValue(AccentColorLowIntensityDarkThemeProperty); }
            set { SetValue(AccentColorLowIntensityDarkThemeProperty, value); }
        }

        public Color AccentColorLowIntensityLightTheme
        {
            get { return (Color)GetValue(AccentColorLowIntensityLightThemeProperty); }
            set { SetValue(AccentColorLowIntensityLightThemeProperty, value); }
        }

        public Color AccentColorMediumIntensityDarkTheme
        {
            get { return (Color)GetValue(AccentColorMediumIntensityDarkThemeProperty); }
            set { SetValue(AccentColorMediumIntensityDarkThemeProperty, value); }
        }

        public Color AccentColorMediumIntensityLightTheme
        {
            get { return (Color)GetValue(AccentColorMediumIntensityLightThemeProperty); }
            set { SetValue(AccentColorMediumIntensityLightThemeProperty, value); }
        }

        public Color AccentColorHighIntensityDarkTheme
        {
            get { return (Color)GetValue(AccentColorHighIntensityDarkThemeProperty); }
            set { SetValue(AccentColorHighIntensityDarkThemeProperty, value); }
        }

        public Color AccentColorHighIntensityLightTheme
        {
            get { return (Color)GetValue(AccentColorHighIntensityLightThemeProperty); }
            set { SetValue(AccentColorHighIntensityLightThemeProperty, value); }
        }

        #endregion

        #region Dependency Properties

        public static readonly DependencyProperty AccentColorProperty =
            DependencyProperty.Register(
                "AccentColor",
                typeof(Color),
                typeof(ZThemeColorPalette),
                new PropertyMetadata(Colors.Blue, OnAccentColorChanged));

        public static readonly DependencyProperty AccentColorLowIntensityDarkThemeProperty =
            DependencyProperty.Register(
                "AccentColorLowIntensityDarkTheme",
                typeof(Color),
                typeof(ZThemeColorPalette),
                new PropertyMetadata(Colors.Black));

        public static readonly DependencyProperty AccentColorLowIntensityLightThemeProperty =
            DependencyProperty.Register(
                "AccentColorLowIntensityLightTheme",
                typeof(Color),
                typeof(ZThemeColorPalette),
                new PropertyMetadata(Colors.White));

        public static readonly DependencyProperty AccentColorMediumIntensityDarkThemeProperty =
            DependencyProperty.Register(
                "AccentColorMediumIntensityDarkTheme",
                typeof(Color),
                typeof(ZThemeColorPalette),
                new PropertyMetadata(Colors.DarkGray));

        public static readonly DependencyProperty AccentColorMediumIntensityLightThemeProperty =
            DependencyProperty.Register(
                "AccentColorMediumIntensityLightTheme",
                typeof(Color),
                typeof(ZThemeColorPalette),
                new PropertyMetadata(Colors.LightGray));

        public static readonly DependencyProperty AccentColorHighIntensityDarkThemeProperty =
            DependencyProperty.Register(
                "AccentColorHighIntensityDarkTheme",
                typeof(Color),
                typeof(ZThemeColorPalette),
                new PropertyMetadata(Colors.Black));

        public static readonly DependencyProperty AccentColorHighIntensityLightThemeProperty =
            DependencyProperty.Register(
                "AccentColorHighIntensityLightTheme",
                typeof(Color),
                typeof(ZThemeColorPalette),
                new PropertyMetadata(Colors.White));

        #endregion

        #region Constructor

        public ZThemeColorPalette()
        {
            // Set default accent color
            AccentColor = Colors.Blue;

            // Initialize accent-dependent colors
            UpdateAccentDependentColors();
        }

        #endregion

        #region Color Changed Event Handlers

        private static void OnAccentColorChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var colorPalette = (ZThemeColorPalette)d;
            colorPalette.UpdateAccentDependentColors();
        }

        #endregion

        #region Helper Methods

        private void UpdateAccentDependentColors()
        {
            // Update accent-dependent colors based on the accent color
            AccentColorLowIntensityDarkTheme = AdjustColorIntensity(AccentColor, 0.4);
            AccentColorLowIntensityLightTheme = AdjustColorIntensity(AccentColor, 0.8);
            AccentColorMediumIntensityDarkTheme = AdjustColorIntensity(AccentColor, 0.6);
            AccentColorMediumIntensityLightTheme = AdjustColorIntensity(AccentColor, 1.2);
            AccentColorHighIntensityDarkTheme = AdjustColorIntensity(AccentColor, 0.8);
            AccentColorHighIntensityLightTheme = AdjustColorIntensity(AccentColor, 1.6);
        }

        private Color AdjustColorIntensity(Color color, double intensityFactor)
        {
            // Adjusts the intensity of a color by the specified factor
            return Color.FromArgb(color.A,
                (byte)(color.R * intensityFactor),
                (byte)(color.G * intensityFactor),
                (byte)(color.B * intensityFactor));
        }

        #endregion
    }

}