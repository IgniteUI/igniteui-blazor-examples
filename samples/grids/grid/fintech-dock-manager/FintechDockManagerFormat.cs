using System;
using System.Globalization;

namespace Infragistics.Samples
{
    /// <summary>
    /// Financial formatting and math helpers for the text the panes render in Razor. Every figure is
    /// written the en-US way whatever the browser's language, like the JavaScript cell templates
    /// (wwwroot/events.js) do for the grids.
    /// </summary>
    public static class FintechDockManagerFormat
    {
        private static readonly CultureInfo Culture = CultureInfo.GetCultureInfo("en-US");

        /// <summary>The placeholder for a figure that is not there (the Angular pipes' em dash).</summary>
        public const string Missing = "\u2014";

        /// <summary>Rounds to cents the way JavaScript's Math.round does: halves go up.</summary>
        public static double Round2(double value) => Math.Floor(value * 100 + 0.5) / 100;

        /// <summary>1234.5 becomes 1,234.50.</summary>
        public static string Price(double value, int digits = 2) => value.ToString("N" + digits, Culture);

        public static string Price(double? value, int digits = 2) => value.HasValue ? Price(value.Value, digits) : Missing;

        /// <summary>-1234.5 becomes -1,234.50, and 1234.5 becomes +1,234.50.</summary>
        public static string Signed(double value, int digits = 2) => (value < 0 ? "-" : "+") + Price(Math.Abs(value), digits);

        public static string Signed(double? value) => value.HasValue ? Signed(value.Value) : Missing;

        /// <summary>-0.9 becomes -0.90%.</summary>
        public static string SignedPct(double value) => Signed(value) + "%";

        public static string SignedPct(double? value) => value.HasValue ? SignedPct(value.Value) : Missing;

        /// <summary>1234.5 becomes $1,234.50; the sign is dropped, as the desk's money format does.</summary>
        public static string Money(double value) => "$" + Price(Math.Abs(value));

        public static string Money(double? value) => value.HasValue ? Money(value.Value) : Missing;

        /// <summary>-1234.5 becomes -$1,234.50.</summary>
        public static string SignedMoney(double value) => (value < 0 ? "-" : "+") + Money(value);

        /// <summary>3,440,000,000,000 becomes 3.44T. Used for volume and market cap.</summary>
        public static string Compact(double value, int digits = 2)
        {
            var abs = Math.Abs(value);
            if (abs >= 1e12)
            {
                return (value / 1e12).ToString("F" + digits, Culture) + "T";
            }

            if (abs >= 1e9)
            {
                return (value / 1e9).ToString("F" + digits, Culture) + "B";
            }

            if (abs >= 1e6)
            {
                return (value / 1e6).ToString("F" + digits, Culture) + "M";
            }

            if (abs >= 1e3)
            {
                return (value / 1e3).ToString("F" + digits, Culture) + "K";
            }

            return Price(value, 0);
        }

        public static string Compact(double? value) => value.HasValue ? Compact(value.Value) : Missing;

        /// <summary>Where value sits inside the low to high band, clamped to 0 to 100.</summary>
        public static double RangePosition(double value, double low, double high)
        {
            if (high <= low)
            {
                return 0;
            }

            return Math.Min(100, Math.Max(0, (value - low) / (high - low) * 100));
        }

        /// <summary>Percentage change of value against a base, safe for a zero base.</summary>
        public static double PercentChange(double value, double baseValue) => baseValue == 0 ? 0 : (value - baseValue) / baseValue * 100;

        /// <summary>14:32:07, the feed's market-time stamp, in the viewer's time zone.</summary>
        public static string Clock(DateTime local) => local.ToString("HH:mm:ss", CultureInfo.InvariantCulture);

        /// <summary>just now, 14m, 3h or 2d, relative to an explicit now.</summary>
        public static string Since(DateTime at, DateTime now)
        {
            var elapsed = Math.Max(0, (now - at).TotalMilliseconds);
            if (elapsed < 60000)
            {
                return "just now";
            }

            if (elapsed < 3600000)
            {
                return Math.Floor(elapsed / 60000) + "m";
            }

            if (elapsed < 86400000)
            {
                return Math.Floor(elapsed / 3600000) + "h";
            }

            return Math.Floor(elapsed / 86400000) + "d";
        }

        /// <summary>Plain number text for an input field: 227.14, 100.</summary>
        public static string InputNumber(double value) => value.ToString("0.##########", CultureInfo.InvariantCulture);

        /// <summary>Parses an input field's text; null when it is empty or not a number.</summary>
        public static double? ParseInput(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
            {
                return null;
            }

            return double.TryParse(text, NumberStyles.Float, CultureInfo.InvariantCulture, out var value) ? value : null;
        }

        /// <summary>2.00, the fixed two-decimal text the snackbar uses for a fill price.</summary>
        public static string Fixed2(double value) => value.ToString("F2", CultureInfo.InvariantCulture);

        /// <summary>A figure's direction as the desk's pos / neg classes.</summary>
        public static string Direction(bool positive) => positive ? "pos" : "neg";

        public static string Direction(double value) => value >= 0 ? "pos" : "neg";
    }
}
