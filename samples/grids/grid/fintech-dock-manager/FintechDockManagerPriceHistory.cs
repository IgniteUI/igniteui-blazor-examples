using System;
using System.Collections.Generic;
using System.Linq;

namespace Infragistics.Samples
{
    /// <summary>A window to draw: how long each bar covers, and how many of them.</summary>
    public class FintechDockManagerHistorySpec
    {
        public string Label { get; set; }

        /// <summary>Bar duration in milliseconds: one second up to one week.</summary>
        public double Step { get; set; }
        public int Bars { get; set; }

        /// <summary>Daily bars skip Saturdays and Sundays; weekly ones cannot.</summary>
        public bool SkipWeekends { get; set; }
    }

    /// <summary>
    /// Deterministic synthetic price history. A sample cannot ship years of real data, so candles are
    /// generated from a seed derived from the symbol: the same instrument always draws the same chart.
    /// </summary>
    public static class FintechDockManagerPriceHistory
    {
        private const double Second = 1000;
        private const double Minute = 60 * Second;
        private const double Hour = 60 * Minute;
        private const double DayMs = 24 * Hour;
        private const double Week = 7 * DayMs;

        // Everything below is quoted per day, then scaled to the bar being drawn.
        private const double DriftPerDay = 0.00025;
        private const double DailyNoise = 0.03;
        private const double MinVolume = 1200000;
        private const double VolumeRange = 8800000;

        /// <summary>Floor under how far one bar may move, as a fraction of price (the live feed's per-second move).</summary>
        private const double MinBarNoise = 0.005;

        /// <summary>
        /// The windows the chart offers, each with the bar it is drawn from. The bar counts keep every
        /// window between 22 and 260 candles; weekends come out of the daily windows only.
        /// </summary>
        public static readonly IReadOnlyList<FintechDockManagerHistorySpec> Ranges = new[]
        {
            new FintechDockManagerHistorySpec { Label = "1 min", Step = Second, Bars = 60, SkipWeekends = false },
            new FintechDockManagerHistorySpec { Label = "1 hour", Step = Minute, Bars = 60, SkipWeekends = false },
            new FintechDockManagerHistorySpec { Label = "1 week", Step = Hour, Bars = 168, SkipWeekends = false },
            new FintechDockManagerHistorySpec { Label = "1 month", Step = DayMs, Bars = 22, SkipWeekends = true },
            new FintechDockManagerHistorySpec { Label = "3 months", Step = DayMs, Bars = 63, SkipWeekends = true },
            new FintechDockManagerHistorySpec { Label = "1 year", Step = DayMs, Bars = 252, SkipWeekends = true },
            new FintechDockManagerHistorySpec { Label = "5 years", Step = Week, Bars = 260, SkipWeekends = false },
        };

        /// <summary>Opening close from the seed table: static, so the history stays stable.</summary>
        public static double AnchorPriceOf(string symbol) => FintechDockManagerSeed.FindStock(symbol)?.PreviousClose ?? 200;

        /// <summary>
        /// Builds spec.Bars candles of spec.Step each, ending now and scaled to close on the anchor
        /// price. Movement scales off the daily figures by the square root of the step.
        /// </summary>
        public static List<FintechDockManagerCandle> Build(string symbol, double anchorPrice, FintechDockManagerHistorySpec spec, double nowMs, double utcOffsetMinutes)
        {
            // The step is part of the seed, so the same instrument draws a different shape per window.
            var seed = SeedOf(symbol) + SeedOf(spec.Step.ToString(System.Globalization.CultureInfo.InvariantCulture));
            var drift = DriftPerDay * (spec.Step / DayMs);
            var noise = NoiseOf(spec);
            var candles = new List<FintechDockManagerCandle>();
            var close = anchorPrice * 0.9;

            foreach (var time in TimesOf(spec, nowMs, utcOffsetMinutes))
            {
                var key = seed * 13 + candles.Count * 37;
                var open = close;
                close = open * (1 + drift + (PseudoRandom(key * 5.7) - 0.5) * noise);
                candles.Add(CandleOf(spec, key, time, open, close));
            }

            if (candles.Count == 0)
            {
                return candles;
            }

            // Rescale so the series ends on the instrument's real opening price.
            var scale = anchorPrice / candles[candles.Count - 1].Close;
            return candles.Select(candle => new FintechDockManagerCandle
            {
                Date = candle.Date,
                Open = FintechDockManagerFormat.Round2(candle.Open * scale),
                High = FintechDockManagerFormat.Round2(candle.High * scale),
                Low = FintechDockManagerFormat.Round2(candle.Low * scale),
                Close = FintechDockManagerFormat.Round2(candle.Close * scale),
                Volume = candle.Volume,
            }).ToList();
        }

        /// <summary>The bar that follows previous, closing on price: the same model the history uses.</summary>
        public static FintechDockManagerCandle NextCandle(FintechDockManagerCandle previous, FintechDockManagerHistorySpec spec, double price, double time) =>
            CandleOf(spec, time / spec.Step, time, previous.Close, price);

        /// <summary>One bar's wick and turnover, given its open and close.</summary>
        private static FintechDockManagerCandle CandleOf(FintechDockManagerHistorySpec spec, double key, double time, double open, double close)
        {
            var wick = NoiseOf(spec) / DailyNoise;
            var highSpread = (0.002 + PseudoRandom(key * 1.9) * 0.018) * wick;
            var lowSpread = (0.002 + PseudoRandom(key * 2.3 + 9) * 0.018) * wick;

            return new FintechDockManagerCandle
            {
                Date = time,
                Open = FintechDockManagerFormat.Round2(open),
                High = FintechDockManagerFormat.Round2(Math.Max(open, close) * (1 + highSpread)),
                Low = FintechDockManagerFormat.Round2(Math.Min(open, close) * (1 - lowSpread)),
                Close = FintechDockManagerFormat.Round2(close),

                // Turnover is a rate, so this one scales linearly, and never to zero.
                Volume = Math.Max(1, Math.Floor((MinVolume + PseudoRandom(key * 9.4 + 3.1) * VolumeRange) * (spec.Step / DayMs) + 0.5)),
            };
        }

        /// <summary>How far one bar of this window may move: the square root of time off the daily figure, floored.</summary>
        private static double NoiseOf(FintechDockManagerHistorySpec spec) => Math.Max(DailyNoise * Math.Sqrt(spec.Step / DayMs), MinBarNoise);

        /// <summary>The bar timestamps, oldest first, collected backwards from now.</summary>
        private static List<double> TimesOf(FintechDockManagerHistorySpec spec, double nowMs, double utcOffsetMinutes)
        {
            var times = new List<double>();
            for (var step = 0; times.Count < spec.Bars && step < spec.Bars * 4; step++)
            {
                var time = nowMs - step * spec.Step;
                if (spec.SkipWeekends && IsWeekend(time, utcOffsetMinutes))
                {
                    continue;
                }

                times.Add(time);
            }

            // The price path has to drift forward to today, so it is walked oldest first.
            times.Reverse();
            return times;
        }

        /// <summary>A Saturday or a Sunday in the viewer's time zone (the offset is JavaScript's getTimezoneOffset).</summary>
        private static bool IsWeekend(double time, double utcOffsetMinutes)
        {
            var local = DateTime.UnixEpoch.AddMilliseconds(time).AddMinutes(-utcOffsetMinutes);
            return local.DayOfWeek == DayOfWeek.Saturday || local.DayOfWeek == DayOfWeek.Sunday;
        }

        private static double SeedOf(string text)
        {
            double total = 0;
            for (var index = 0; index < text.Length; index++)
            {
                total += text[index] * (index + 1);
            }

            return total;
        }

        /// <summary>Sine-based hash: a stable stand-in for a seeded random source.</summary>
        private static double PseudoRandom(double value)
        {
            var x = Math.Sin(value) * 10000;
            return x - Math.Floor(x);
        }
    }

    /// <summary>
    /// One chart document's series: the visible window, kept live against the tape. The chart panel
    /// owns one; the desk asks every open chart for its changes on each tick, and the changes travel
    /// in the tick's single interop call, where events.js applies them to the chart's own data with
    /// notifyInsertItem, notifyRemoveItem and notifySetItem (no re-bind, no flicker).
    /// </summary>
    public class FintechDockManagerChartSeries
    {
        public FintechDockManagerChartSeries(string symbol)
        {
            Symbol = symbol;
            ContentId = FintechDockManagerLayout.ChartContentId(symbol);
            Spec = FintechDockManagerPriceHistory.Ranges[0];
        }

        public string Symbol { get; }

        public string ContentId { get; }

        public FintechDockManagerHistorySpec Spec { get; private set; }

        public List<FintechDockManagerCandle> Data { get; private set; } = new List<FintechDockManagerCandle>();

        /// <summary>
        /// Rebuilds the window for a range, then rolls it and marks its live candle at once, so the
        /// newest candle is never a tick behind the tape.
        /// </summary>
        public void Rebuild(FintechDockManagerHistorySpec spec, double? livePrice, double nowMs, double utcOffsetMinutes)
        {
            Spec = spec;
            Data = FintechDockManagerPriceHistory.Build(Symbol, FintechDockManagerPriceHistory.AnchorPriceOf(Symbol), spec, nowMs, utcOffsetMinutes);
            Advance(livePrice, nowMs);
        }

        /// <summary>
        /// Advances the window as its bars come due (seals the live bar, appends a new one, drops the
        /// oldest), then rolls the live price into the last candle. Returns the changes for events.js:
        /// the candles appended (each one also drops the oldest) and the replaced last candle, or null
        /// when nothing moved.
        /// </summary>
        public object Advance(double? livePrice, double nowMs)
        {
            if (Data.Count == 0)
            {
                return null;
            }

            var appended = new List<FintechDockManagerCandle>();
            var newest = Data[Data.Count - 1].Date;

            // A backgrounded tab can come back hours later: rolling a whole window's worth of bars one
            // at a time would just rebuild it, so that is the cap.
            var due = (int)Math.Min(Math.Floor((nowMs - newest) / Spec.Step), Spec.Bars);
            for (var index = 1; index <= due; index++)
            {
                var previous = Data[Data.Count - 1];

                // Only the bar that is still open takes the live price; bars behind it close where they opened.
                var close = index == due && livePrice.HasValue ? livePrice.Value : previous.Close;
                var candle = FintechDockManagerPriceHistory.NextCandle(previous, Spec, close, newest + index * Spec.Step);
                Data.Add(candle);
                Data.RemoveAt(0);
                appended.Add(candle);
            }

            FintechDockManagerCandle last = null;
            if (livePrice.HasValue)
            {
                var previous = Data[Data.Count - 1];
                if (previous.Close != livePrice.Value)
                {
                    last = new FintechDockManagerCandle
                    {
                        Date = previous.Date,
                        Open = previous.Open,
                        High = Math.Max(previous.High, livePrice.Value),
                        Low = Math.Min(previous.Low, livePrice.Value),
                        Close = livePrice.Value,
                        Volume = previous.Volume,
                    };
                    Data[Data.Count - 1] = last;
                }
            }

            if (appended.Count == 0 && last == null)
            {
                return null;
            }

            return new { Id = ContentId, Roll = appended, Last = last };
        }
    }
}
