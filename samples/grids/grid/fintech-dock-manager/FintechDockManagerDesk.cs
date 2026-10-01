using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Nodes;

namespace Infragistics.Samples
{
    /// <summary>What changed on the desk; each pane re-renders only for the changes it shows.</summary>
    [Flags]
    public enum FintechDockManagerChange
    {
        None = 0,
        Tick = 1,
        Book = 2,
        Orders = 4,
        Alerts = 8,
        News = 16,
        Clock = 32,
        Selection = 64,
        Ticket = 128,
        Watchlist = 256,
        Search = 512,
        NewsFilter = 1024,
        Layout = 2048,
        Theme = 4096,
        Feed = 8192,
        Reset = 16384,
        BlotterFilter = 32768,
        All = 65535,
    }

    /// <summary>
    /// Signal Desk's session: the market feed, the trading engine, the alerts and news wire, and the
    /// workspace state every pane follows (the selected symbol, the watchlist, the theme and the Dock
    /// Manager layout). C# owns every figure and every rule; the panes render from here, and the grids
    /// and charts get their live changes through the one interop call AdvanceTick's payload makes.
    ///
    /// Everything here runs on the renderer's synchronization context (App.razor drives the timers),
    /// so the state needs no locking.
    /// </summary>
    public class FintechDockManagerDesk
    {
        public const string StorageTheme = "theme";
        public const string StorageWatchlist = "watchlist";

        private readonly Dictionary<string, FintechDockManagerChartSeries> charts = new Dictionary<string, FintechDockManagerChartSeries>();
        private readonly Dictionary<string, string> pendingStores = new Dictionary<string, string>();

        private bool viewportSized;

        public FintechDockManagerDesk()
        {
            Market = new FintechDockManagerMarket();
            Notifications = new FintechDockManagerNotifications();
            Trading = new FintechDockManagerTrading(Market, Notifications);
            Watchlist = FintechDockManagerSeed.DefaultWatchlist.ToList();
            SetLiveLayout(FintechDockManagerLayout.BuildDefault(1440, 900, FintechDockManagerSeed.DefaultChartSymbols));

            // The opening tape already holds unusual movers, which the desk reports straight away.
            Notifications.ScanForAlerts(Market.Stocks, Market.Indices);
        }

        public event Action<FintechDockManagerChange> Changed;

        public FintechDockManagerMarket Market { get; }

        public FintechDockManagerTrading Trading { get; }

        public FintechDockManagerNotifications Notifications { get; }

        /// <summary>The viewer's UTC offset in minutes, as JavaScript's getTimezoneOffset reports it.</summary>
        public double UtcOffsetMinutes { get; set; }

        /// <summary>True from the moment events.js is connected and the stored workspace is applied.</summary>
        public bool IsConnected { get; private set; }

        // Workspace -----------------------------------------------------------------------------------

        public bool IsDark { get; private set; } = true;

        /// <summary>The instrument the order ticket, the chart focus and the news filter follow.</summary>
        public string SelectedSymbol { get; private set; } = FintechDockManagerSeed.DefaultChartSymbols[0];

        /// <summary>Side the order ticket opens on: set by the Buy shortcuts in other panes.</summary>
        public string TicketSide { get; private set; } = FintechDockManagerOrderTerms.Buy;

        public string SearchQuery { get; private set; } = "";

        /// <summary>Symbol the news wire is narrowed to; empty means the whole wire.</summary>
        public string NewsFilter { get; private set; } = "";

        /// <summary>The blotter's status filter: All, Working, Filled or Cancelled.</summary>
        public string BlotterFilter { get; private set; } = "All";

        public List<string> Watchlist { get; private set; }

        /// <summary>Bumped by a reset, so panes holding state the desk cannot reach put themselves back.</summary>
        public int ResetToken { get; private set; }

        /// <summary>The arrangement on screen, as the Dock Manager last reported it.</summary>
        public JsonObject LiveLayout { get; private set; }

        /// <summary>A layout waiting to be pushed into the Dock Manager (App.razor sends it).</summary>
        public string PendingLayout { get; private set; }

        /// <summary>Chart documents currently open, read back out of the live layout.</summary>
        public IReadOnlyList<string> ChartSymbols { get; private set; } = Array.Empty<string>();

        /// <summary>Pane visibility, recomputed from the live layout so the rail cannot drift.</summary>
        public IReadOnlyCollection<string> VisiblePanes { get; private set; } = Array.Empty<string>();

        public void Notify(FintechDockManagerChange change) => Changed?.Invoke(change);

        public string TakePendingLayout()
        {
            var layout = PendingLayout;
            PendingLayout = null;
            return layout;
        }

        /// <summary>Theme and watchlist values waiting to be written to localStorage.</summary>
        public Dictionary<string, string> TakePendingStores()
        {
            var stores = new Dictionary<string, string>(pendingStores);
            pendingStores.Clear();
            return stores;
        }

        /// <summary>
        /// Applies what the browser remembered (layout, watchlist, theme) and sizes the default layout
        /// against the real viewport, once. Called when events.js connects.
        /// </summary>
        public void Hydrate(string storedLayout, string storedTheme, string storedWatchlist, double width, double height)
        {
            IsConnected = true;
            if (storedTheme == "\"light\"" || storedTheme == "\"dark\"")
            {
                IsDark = storedTheme == "\"dark\"";
            }

            var watchlist = ParseStringArray(storedWatchlist);
            if (watchlist != null)
            {
                Watchlist = watchlist;
            }

            var restored = FintechDockManagerLayout.ParsePersisted(storedLayout);
            if (restored != null)
            {
                viewportSized = true;
                PushLayout(restored);
            }
            else
            {
                InitialiseViewport(width, height);
            }

            Notify(FintechDockManagerChange.All);
        }

        /// <summary>
        /// Sizes the shipped default against the real viewport, once. Later resizes are the Dock
        /// Manager's own business: rebuilding here would throw away the trader's arrangement.
        /// </summary>
        public void InitialiseViewport(double width, double height)
        {
            if (viewportSized)
            {
                return;
            }

            viewportSized = true;
            PushLayout(FintechDockManagerLayout.BuildDefault(width, height, ChartSymbols));
        }

        public void ToggleTheme()
        {
            IsDark = !IsDark;
            pendingStores[StorageTheme] = IsDark ? "\"dark\"" : "\"light\"";
            Notify(FintechDockManagerChange.Theme);
        }

        public void UpdateSearchQuery(string value)
        {
            SearchQuery = value ?? "";
            Notify(FintechDockManagerChange.Search);
        }

        public void SelectSymbol(string symbol)
        {
            if (string.IsNullOrEmpty(symbol))
            {
                return;
            }

            SelectedSymbol = symbol;
            Notify(FintechDockManagerChange.Selection);
        }

        public void SetNewsFilter(string symbol)
        {
            NewsFilter = symbol ?? "";
            Notify(FintechDockManagerChange.NewsFilter);
        }

        public void SetBlotterFilter(string filter)
        {
            if (filter != "All" && filter != FintechDockManagerOrderTerms.Working && filter != FintechDockManagerOrderTerms.Filled && filter != FintechDockManagerOrderTerms.Cancelled)
            {
                return;
            }

            BlotterFilter = filter;
            Notify(FintechDockManagerChange.BlotterFilter);
        }

        /// <summary>
        /// Points the whole desk at one instrument: it becomes the selection every pane follows, its
        /// chart comes up, and the wire narrows to it. This is what clicking a watchlist row does.
        /// </summary>
        public void FocusSymbol(string symbol)
        {
            if (string.IsNullOrEmpty(symbol))
            {
                return;
            }

            SetNewsFilter(symbol);
            OpenChart(symbol);
        }

        /// <summary>Points the order ticket at an instrument and side in one gesture.</summary>
        public void PrepareOrder(string symbol, string side)
        {
            SelectedSymbol = symbol;
            TicketSide = side;
            Notify(FintechDockManagerChange.Selection | FintechDockManagerChange.Ticket);
        }

        public void SetTicketSide(string side)
        {
            TicketSide = side;
            Notify(FintechDockManagerChange.Ticket);
        }

        /// <summary>Selects the symbol and brings its chart document up, opening it if needed.</summary>
        public void OpenChart(string symbol)
        {
            SelectedSymbol = symbol;
            PushLayout(FintechDockManagerLayout.WithChartDocument(LiveLayout, symbol));
            Notify(FintechDockManagerChange.Selection);
        }

        public void TogglePane(string id) => SetPaneVisible(id, !VisiblePanes.Contains(id));

        /// <summary>Idempotent counterpart to TogglePane: re-applying the current state does not churn the layout.</summary>
        public void SetPaneVisible(string id, bool visible)
        {
            if (VisiblePanes.Contains(id) == visible)
            {
                return;
            }

            PushLayout(FintechDockManagerLayout.WithPaneVisibility(LiveLayout, id, visible));
        }

        /// <summary>
        /// Adopts the arrangement the Dock Manager reports after a drag, dock or close. The layout is
        /// not pushed back: only the derived state moves (events.js persists the reported copy).
        /// </summary>
        public void ApplyLayout(string json)
        {
            if (JsonNode.Parse(json) is JsonObject layout)
            {
                SetLiveLayout(layout);
                Notify(FintechDockManagerChange.Layout);
            }
        }

        /// <summary>
        /// Returns the workspace to its opening state: the arrangement plus the watchlist, theme,
        /// selected instrument, ticket side, search box and news filter.
        /// </summary>
        public void ResetWorkspace(double width, double height)
        {
            IsDark = true;
            Watchlist = FintechDockManagerSeed.DefaultWatchlist.ToList();
            SelectedSymbol = FintechDockManagerSeed.DefaultChartSymbols[0];
            TicketSide = FintechDockManagerOrderTerms.Buy;
            SearchQuery = "";
            NewsFilter = "";
            BlotterFilter = "All";
            pendingStores[StorageTheme] = "\"dark\"";
            pendingStores[StorageWatchlist] = JsonSerializer.Serialize(Watchlist);
            viewportSized = true;
            PushLayout(FintechDockManagerLayout.BuildDefault(width, height, FintechDockManagerSeed.DefaultChartSymbols));
            ResetToken++;
        }

        /// <summary>
        /// Puts the whole sample back to how it opened: arrangement, book, tape and alerts. The book is
        /// restored before the tape, so the mark-to-market pass runs against the opening positions.
        /// </summary>
        public void ResetAll(double width, double height)
        {
            ResetWorkspace(width, height);
            Trading.Reset();
            Market.Reset();
            Notifications.Reset();

            // The reset tape re-prices the book and is scanned again, as a tick would be.
            Notifications.ScanForAlerts(Market.Stocks, Market.Indices);
            Trading.OnTick();
            Notify(FintechDockManagerChange.All);
        }

        public bool IsWatched(string symbol) => Watchlist.Contains(symbol);

        public void AddToWatchlist(string symbol)
        {
            if (string.IsNullOrEmpty(symbol) || Watchlist.Contains(symbol) || Market.QuoteOf(symbol) == null)
            {
                return;
            }

            Watchlist = new[] { symbol }.Concat(Watchlist).ToList();
            pendingStores[StorageWatchlist] = JsonSerializer.Serialize(Watchlist);
            Notify(FintechDockManagerChange.Watchlist);
        }

        public void RemoveFromWatchlist(string symbol)
        {
            if (!Watchlist.Contains(symbol))
            {
                return;
            }

            Watchlist = Watchlist.Where(entry => entry != symbol).ToList();
            pendingStores[StorageWatchlist] = JsonSerializer.Serialize(Watchlist);
            Notify(FintechDockManagerChange.Watchlist);
        }

        /// <summary>The watchlist joined against the live feed, filtered by the pane's search box.</summary>
        public List<FintechDockManagerQuote> WatchlistQuotes()
        {
            var quotes = Watchlist.Select(Market.QuoteOf).Where(quote => quote != null);
            var query = SearchQuery.Trim().ToLowerInvariant();
            if (query.Length == 0)
            {
                return quotes.ToList();
            }

            return quotes.Where(quote => (quote.Symbol + " " + quote.Name + " " + quote.Sector).ToLowerInvariant().Contains(query)).ToList();
        }

        // Orders --------------------------------------------------------------------------------------

        public FintechDockManagerOrderResult SubmitOrder(FintechDockManagerOrderDraft draft)
        {
            var result = Trading.SubmitOrder(draft, DateTime.UtcNow);
            Notify(FintechDockManagerChange.Orders | FintechDockManagerChange.Book | FintechDockManagerChange.Alerts);
            return result;
        }

        public void CancelOrder(string id)
        {
            Trading.CancelOrder(id);
            Notify(FintechDockManagerChange.Orders);
        }

        public void CancelAllWorking()
        {
            Trading.CancelAllWorking();
            Notify(FintechDockManagerChange.Orders | FintechDockManagerChange.Alerts);
        }

        public void Flatten(string symbol)
        {
            Trading.Flatten(symbol, DateTime.UtcNow);
            Notify(FintechDockManagerChange.Orders | FintechDockManagerChange.Book | FintechDockManagerChange.Alerts);
        }

        public void MarkAlertsRead()
        {
            Notifications.MarkAllRead();
            Notify(FintechDockManagerChange.Alerts);
        }

        public void ClearAlerts()
        {
            Notifications.Clear();
            Notify(FintechDockManagerChange.Alerts);
        }

        // Feed ----------------------------------------------------------------------------------------

        public void TogglePlayback()
        {
            Market.TogglePlayback();
            Notify(FintechDockManagerChange.Feed);
        }

        public void SetFrequency(int milliseconds)
        {
            Market.SetFrequency(milliseconds);
            Notify(FintechDockManagerChange.Feed);
        }

        /// <summary>The viewer's local time now.</summary>
        public DateTime LocalNow => DateTime.UtcNow.AddMinutes(-UtcOffsetMinutes);

        public double NowMs => (DateTime.UtcNow - DateTime.UnixEpoch).TotalMilliseconds;

        /// <summary>
        /// Advances the tape one step and returns the tick's changes for the grids and the charts as
        /// JSON (events.js, fintechDockManagerApplyTick): the watched quotes that moved, the whole book
        /// marked to market, and each open chart's appended and updated candles.
        /// </summary>
        public string AdvanceTick()
        {
            var bookVersion = Trading.BookVersion;
            var ordersVersion = Trading.OrdersVersion;
            var alertsVersion = Notifications.AlertsVersion;

            var repriced = Market.Advance(FintechDockManagerFormat.Clock(LocalNow));
            Notifications.ScanForAlerts(Market.Stocks, Market.Indices);
            Trading.OnTick();

            var watched = new HashSet<string>(Watchlist);
            var nowMs = NowMs;
            var payload = new
            {
                Watch = repriced.Where(quote => watched.Contains(quote.Symbol)).Select(FintechDockManagerWatchRow.From).ToList(),
                Positions = Trading.Positions.Select(FintechDockManagerPositionRow.From).ToList(),
                Charts = charts.Values.Select(series => series.Advance(Market.QuoteOf(series.Symbol)?.LastPrice, nowMs)).Where(change => change != null).ToList(),
            };

            var change = FintechDockManagerChange.Tick;
            if (Trading.BookVersion != bookVersion)
            {
                change |= FintechDockManagerChange.Book;
            }

            if (Trading.OrdersVersion != ordersVersion)
            {
                change |= FintechDockManagerChange.Orders;
            }

            if (Notifications.AlertsVersion != alertsVersion)
            {
                change |= FintechDockManagerChange.Alerts;
            }

            Notify(change);
            return JsonSerializer.Serialize(payload);
        }

        public void TickClock()
        {
            Notifications.TickClock();
            Notify(FintechDockManagerChange.Clock);
        }

        public void PublishWireItem()
        {
            Notifications.PublishWireItem();
            Notify(FintechDockManagerChange.News);
        }

        // Charts --------------------------------------------------------------------------------------

        public void RegisterChart(FintechDockManagerChartSeries series) => charts[series.ContentId] = series;

        public void UnregisterChart(FintechDockManagerChartSeries series)
        {
            if (charts.TryGetValue(series.ContentId, out var current) && current == series)
            {
                charts.Remove(series.ContentId);
            }
        }

        /// <summary>A chart's whole window as JSON, for a new chart or a new range.</summary>
        public static string SerializeCandles(IEnumerable<FintechDockManagerCandle> candles) => JsonSerializer.Serialize(candles);

        // Internals -----------------------------------------------------------------------------------

        /// <summary>Pushes a new arrangement into the Dock Manager (through App.razor) and adopts it.</summary>
        private void PushLayout(JsonObject next)
        {
            SetLiveLayout(next);
            PendingLayout = next.ToJsonString();
            Notify(FintechDockManagerChange.Layout);
        }

        private void SetLiveLayout(JsonObject layout)
        {
            LiveLayout = layout;
            ChartSymbols = FintechDockManagerLayout.ChartSymbolsOf(layout);
            VisiblePanes = FintechDockManagerLayout.PaneToggles
                .Where(pane => FintechDockManagerLayout.IsPaneVisible(layout, pane.Id))
                .Select(pane => pane.Id)
                .ToList();
        }

        private static List<string> ParseStringArray(string json)
        {
            if (string.IsNullOrEmpty(json))
            {
                return null;
            }

            try
            {
                return JsonSerializer.Deserialize<List<string>>(json);
            }
            catch (JsonException)
            {
                return null;
            }
        }
    }
}
