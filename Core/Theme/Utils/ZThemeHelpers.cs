using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI;

namespace Core.Theme.Utils
{
    public static class ZThemeHelpers
    {
        public static Color ColorFromHex(string hex)
        {
            byte a = byte.Parse(hex.Substring(1, 2), NumberStyles.HexNumber);
            byte r = byte.Parse(hex.Substring(3, 2), NumberStyles.HexNumber);
            byte g = byte.Parse(hex.Substring(5, 2), NumberStyles.HexNumber);
            byte b = byte.Parse(hex.Substring(7, 2), NumberStyles.HexNumber);
            return Color.FromArgb(a, r, g, b);
        }

    }
}
