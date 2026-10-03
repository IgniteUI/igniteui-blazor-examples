using System;
using System.Collections.Generic;
using System.Linq;

namespace Infragistics.Samples
{
    /// <summary>
    /// The desk's alert and news feed. Fills are pushed in by the trading engine; price alerts are
    /// derived here from the market feed on every tick.
    /// </summary>
    public class FintechDockManagerNotifications
    {
        /// <summary>Intraday move that raises an unusual-move alert, in percent.</summary>
        public const double UnusualMovePct = 2.5;

        /// <summary>VIX level above which the desk gets a risk warning.</summary>
        public const double VixRiskLevel = 20;

        /// <summary>Minimum gap between two alerts about the same subject.</summary>
        public const double AlertCooldownMs = 45000;

        public const int NewsIntervalMs = 18000;
        public const int ClockIntervalMs = 15000;
        public const int MaxNotifications = 40;
        public const int MaxNews = 40;

        private readonly Dictionary<string, DateTime> lastAlertAt = new Dictionary<string, DateTime>();
        private int sequence;
        private int newsCursor;

        public FintechDockManagerNotifications()
        {
            News = SeedNews(DateTime.UtcNow);
        }

        /// <summary>Newest first.</summary>
        public List<FintechDockManagerAlert> Alerts { get; private set; } = new List<FintechDockManagerAlert>();

        /// <summary>Newest first.</summary>
        public List<FintechDockManagerArticle> News { get; private set; }

        public int UnreadCount => Alerts.Count(alert => !alert.Read);

        /// <summary>The coarse clock the relative timestamps are measured against.</summary>
        public DateTime Now { get; private set; } = DateTime.UtcNow;

        /// <summary>Bumped when the alert list changes.</summary>
        public int AlertsVersion { get; private set; }

        /// <summary>Bumped when the wire changes.</summary>
        public int NewsVersion { get; private set; }

        public void Push(string title, string detail, string icon, string tone)
        {
            sequence++;
            var entry = new FintechDockManagerAlert
            {
                Id = "n" + sequence,
                Title = title,
                Detail = detail,
                Icon = icon,
                Tone = tone,
                At = DateTime.UtcNow,
                Read = false,
            };

            Alerts = new[] { entry }.Concat(Alerts).Take(MaxNotifications).ToList();
            Now = DateTime.UtcNow;
            AlertsVersion++;
        }

        public void MarkAllRead()
        {
            if (Alerts.All(alert => alert.Read))
            {
                return;
            }

            foreach (var alert in Alerts)
            {
                alert.Read = true;
            }

            AlertsVersion++;
        }

        public void Clear()
        {
            Alerts = new List<FintechDockManagerAlert>();
            AlertsVersion++;
        }

        /// <summary>Drops every alert and puts the wire back to the seeded stories.</summary>
        public void Reset()
        {
            Alerts = new List<FintechDockManagerAlert>();
            News = SeedNews(DateTime.UtcNow);

            // Cooldowns are per-session state too, or the first post-reset alert for a subject the desk
            // had already warned about would be swallowed.
            lastAlertAt.Clear();
            sequence = 0;
            newsCursor = 0;
            Now = DateTime.UtcNow;
            AlertsVersion++;
            NewsVersion++;
        }

        /// <summary>Advances the coarse clock.</summary>
        public void TickClock() => Now = DateTime.UtcNow;

        /// <summary>News for one instrument plus the untagged macro wire.</summary>
        public IEnumerable<FintechDockManagerArticle> NewsFor(string symbol) => News.Where(article => article.Symbol == null || article.Symbol == symbol);

        /// <summary>Scans the feed for unusual moves and a VIX spike.</summary>
        public void ScanForAlerts(IEnumerable<FintechDockManagerQuote> quotes, IEnumerable<FintechDockManagerIndex> indices)
        {
            foreach (var quote in quotes)
            {
                if (Math.Abs(quote.ChangePct) < UnusualMovePct)
                {
                    continue;
                }

                var gaining = quote.ChangePct > 0;
                PushThrottled("move:" + quote.Symbol,
                    quote.Symbol + " unusual move",
                    "Trading " + FintechDockManagerFormat.SignedPct(quote.ChangePct) + " against yesterday's close",
                    gaining ? "trending_up" : "trending_down",
                    gaining ? "success" : "error");
            }

            var vix = indices.FirstOrDefault(index => index.Name == "VIX");
            if (vix != null && vix.Value >= VixRiskLevel)
            {
                PushThrottled("risk:vix",
                    "Volatility warning",
                    "VIX at " + FintechDockManagerFormat.Fixed2(vix.Value) + " \u2014 review position sizing",
                    "warning",
                    "warn");
            }
        }

        /// <summary>Publishes the next story from the wire pool.</summary>
        public void PublishWireItem()
        {
            var pool = FintechDockManagerSeed.NewsWirePool;
            var (headline, source, symbol) = pool[newsCursor % pool.Length];
            newsCursor++;

            var article = new FintechDockManagerArticle
            {
                Id = "w" + newsCursor,
                Headline = headline,
                Source = source,
                Symbol = symbol,
                At = DateTime.UtcNow,
            };

            News = new[] { article }.Concat(News).Take(MaxNews).ToList();
            Now = DateTime.UtcNow;
            NewsVersion++;
        }

        private void PushThrottled(string key, string title, string detail, string icon, string tone)
        {
            var now = DateTime.UtcNow;
            if (lastAlertAt.TryGetValue(key, out var last) && (now - last).TotalMilliseconds < AlertCooldownMs)
            {
                return;
            }

            lastAlertAt[key] = now;
            Push(title, detail, icon, tone);
        }

        private static List<FintechDockManagerArticle> SeedNews(DateTime now) => FintechDockManagerSeed.SeedNews
            .Select((seed, index) => new FintechDockManagerArticle
            {
                Id = "s" + index,
                Headline = seed.Headline,
                Source = seed.Source,
                Symbol = seed.Symbol,
                At = now.AddMinutes(-seed.MinutesAgo),
            })
            .ToList();
    }
}
