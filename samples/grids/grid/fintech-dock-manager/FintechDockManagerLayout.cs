using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Nodes;

namespace Infragistics.Samples
{
    /// <summary>A pane the nav rail can show or hide.</summary>
    public class FintechDockManagerPaneToggle
    {
        public string Id { get; set; }
        public string Label { get; set; }
        public string Icon { get; set; }
    }

    /// <summary>
    /// The Dock Manager layout: the default arrangement plus the small set of pure transforms the
    /// desk needs (show or hide a pane, open a chart document). A layout is JSON in the Dock
    /// Manager's own shape (type, contentId, panes, ...), because that is what the dock manager
    /// reports on every change and what the desk persists: events.js assigns it to the element and
    /// sends it back after each drag, dock or close. Every transform returns a new layout.
    /// </summary>
    public static class FintechDockManagerLayout
    {
        public const string Watchlist = "watchlist";
        public const string OrderTicket = "orderTicket";
        public const string Positions = "positions";
        public const string Blotter = "blotter";
        public const string News = "news";

        /// <summary>Content ids of the fixed (non-document) panes.</summary>
        public static readonly IReadOnlyList<string> FixedPaneIds = new[] { Watchlist, OrderTicket, Positions, Blotter, News };

        public static readonly IReadOnlyList<FintechDockManagerPaneToggle> PaneToggles = new[]
        {
            new FintechDockManagerPaneToggle { Id = Watchlist, Label = "Watchlist", Icon = "visibility" },
            new FintechDockManagerPaneToggle { Id = OrderTicket, Label = "Order Ticket", Icon = "add_shopping_cart" },
            new FintechDockManagerPaneToggle { Id = Positions, Label = "Positions", Icon = "account_balance_wallet" },
            new FintechDockManagerPaneToggle { Id = Blotter, Label = "Blotter", Icon = "assignment" },
            new FintechDockManagerPaneToggle { Id = News, Label = "News", Icon = "newspaper" },
        };

        private const string ChartPrefix = "chart:";

        private const double AppShellFixedWidth = 58;
        private const double CommandBarHeight = 46;
        private const double AppChromeVerticalBorders = 2;
        private const double DockSplitterThickness = 4;

        /// <summary>Order Ticket over News, and the chart over Positions: one splitter each.</summary>
        private const double StackSplitterCount = 1;

        /// <summary>Tall enough that the default ticket needs no scrolling.</summary>
        private const double OrderTicketHeight = 470;

        /// <summary>Enough for the summary row plus a few positions before it scrolls.</summary>
        private const double PositionsHeight = 380;

        /// <summary>Floor for the watchlist and the ticket and news stack alike.</summary>
        private const double MinSidePaneWidth = 260;
        private const double MinChartWidth = 400;
        private const double MinNewsHeight = 120;
        private const double MinStackHeight = 42;

        /// <summary>The watchlist carries the most columns, so it opens widest.</summary>
        private const double WatchlistWidth = 670;

        /// <summary>The ticket and the news wire under it.</summary>
        private const double RightStackWidth = 300;

        public static bool IsFixedPaneId(string contentId) => !string.IsNullOrEmpty(contentId) && FixedPaneIds.Contains(contentId);

        public static string ChartContentId(string symbol) => ChartPrefix + symbol;

        public static bool IsChartContentId(string contentId) => contentId != null && contentId.StartsWith(ChartPrefix, StringComparison.Ordinal);

        public static string SymbolOfChartPane(string contentId) => contentId.Substring(ChartPrefix.Length);

        /// <summary>Builds the pristine desk arrangement for the given viewport.</summary>
        public static JsonObject BuildDefault(double viewportWidth, double viewportHeight, IEnumerable<string> chartSymbols)
        {
            var width = double.IsFinite(viewportWidth) && viewportWidth > 0 ? viewportWidth : 1440;
            var height = double.IsFinite(viewportHeight) && viewportHeight > 0 ? viewportHeight : 900;

            var stackHeight = Math.Max(1, height - CommandBarHeight - AppChromeVerticalBorders);
            var stackContentHeight = Math.Max(1, stackHeight - StackSplitterCount * DockSplitterThickness);

            // Sizes within a split are relative to their siblings, so each stack is expressed as the
            // fraction its fixed-height pane wants.
            var ticketSize = Math.Min(0.9, Math.Max(0.05, OrderTicketHeight / stackContentHeight));
            var newsSize = 1 - ticketSize;
            var positionsSize = Math.Min(0.6, Math.Max(0.15, PositionsHeight / stackContentHeight));
            var chartSize = 1 - positionsSize;

            // The watchlist gets its full width whenever the chart and the right stack still clear
            // their minimums beside it, and shares what is left when not.
            var usableWidth = Math.Max(320, width - AppShellFixedWidth);
            var watchlistWidth = Math.Min(WatchlistWidth, Math.Max(MinSidePaneWidth, usableWidth - MinChartWidth - MinSidePaneWidth));
            var rightWidth = Math.Min(RightStackWidth, Math.Max(MinSidePaneWidth, usableWidth - watchlistWidth - MinChartWidth));
            var chartWidth = Math.Max(MinChartWidth, usableWidth - watchlistWidth - rightWidth);

            var chartPanes = new JsonArray();
            foreach (var symbol in chartSymbols)
            {
                chartPanes.Add(ChartPane(symbol));
            }

            return new JsonObject
            {
                ["rootPane"] = new JsonObject
                {
                    ["type"] = "splitPane",
                    ["orientation"] = "horizontal",
                    ["panes"] = new JsonArray
                    {
                        FixedPane(Watchlist, "Watchlist", size: watchlistWidth, minResizeWidth: MinSidePaneWidth),
                        new JsonObject
                        {
                            // Charts on top, the book directly beneath them.
                            ["type"] = "splitPane",
                            ["orientation"] = "vertical",
                            ["size"] = chartWidth,
                            ["minResizeWidth"] = MinChartWidth,
                            ["panes"] = new JsonArray
                            {
                                new JsonObject
                                {
                                    ["type"] = "documentHost",
                                    ["size"] = chartSize,
                                    ["rootPane"] = new JsonObject
                                    {
                                        ["type"] = "splitPane",
                                        ["orientation"] = "horizontal",
                                        ["allowEmpty"] = true,
                                        ["panes"] = new JsonArray
                                        {
                                            new JsonObject { ["type"] = "tabGroupPane", ["panes"] = chartPanes },
                                        },
                                    },
                                },
                                new JsonObject
                                {
                                    ["type"] = "tabGroupPane",
                                    ["size"] = positionsSize,
                                    ["panes"] = new JsonArray
                                    {
                                        FixedPane(Positions, "Positions & P&L", minResizeHeight: MinStackHeight),
                                        FixedPane(Blotter, "Order Blotter", minResizeHeight: MinStackHeight),
                                    },
                                },
                            },
                        },
                        new JsonObject
                        {
                            ["type"] = "splitPane",
                            ["orientation"] = "vertical",
                            ["size"] = rightWidth,
                            ["minResizeWidth"] = MinSidePaneWidth,
                            ["minResizeHeight"] = OrderTicketHeight + MinNewsHeight,
                            ["panes"] = new JsonArray
                            {
                                FixedPane(OrderTicket, "Order Ticket", size: ticketSize, minResizeHeight: OrderTicketHeight),
                                FixedPane(News, "News", size: newsSize, minResizeHeight: MinNewsHeight),
                            },
                        },
                    },
                },
            };
        }

        private static JsonObject FixedPane(string contentId, string header, double? size = null, double? minResizeWidth = null, double? minResizeHeight = null)
        {
            var pane = new JsonObject
            {
                ["type"] = "contentPane",
                ["contentId"] = contentId,
                ["header"] = header,
            };

            if (size.HasValue)
            {
                pane["size"] = size.Value;
            }

            if (minResizeWidth.HasValue)
            {
                pane["minResizeWidth"] = minResizeWidth.Value;
            }

            if (minResizeHeight.HasValue)
            {
                pane["minResizeHeight"] = minResizeHeight.Value;
            }

            pane["allowPinning"] = false;
            return pane;
        }

        private static JsonObject ChartPane(string symbol) => new JsonObject
        {
            ["type"] = "contentPane",
            ["contentId"] = ChartContentId(symbol),
            ["header"] = symbol,
            ["documentOnly"] = true,
        };

        // Traversal ---------------------------------------------------------------------------------

        private static string TypeOf(JsonNode pane) => pane?["type"]?.GetValue<string>();

        private static string ContentIdOf(JsonNode pane) => pane?["contentId"]?.GetValue<string>();

        private static bool IsContentPane(JsonNode pane) => TypeOf(pane) == "contentPane";

        private static IEnumerable<JsonNode> ChildrenOf(JsonNode pane)
        {
            switch (TypeOf(pane))
            {
                case "splitPane":
                case "tabGroupPane":
                    return pane["panes"] is JsonArray panes ? panes.Where(child => child != null).ToList() : new List<JsonNode>();
                case "documentHost":
                    return pane["rootPane"] != null ? new[] { pane["rootPane"] } : Array.Empty<JsonNode>();
                default:
                    return Array.Empty<JsonNode>();
            }
        }

        /// <summary>Depth-first walk over every pane in the layout, docked and floating.</summary>
        public static IEnumerable<JsonNode> Panes(JsonObject layout)
        {
            var stack = new List<JsonNode> { layout["rootPane"] };
            if (layout["floatingPanes"] is JsonArray floating)
            {
                stack.AddRange(floating);
            }

            while (stack.Count > 0)
            {
                var pane = stack[stack.Count - 1];
                stack.RemoveAt(stack.Count - 1);
                if (pane == null)
                {
                    continue;
                }

                yield return pane;
                stack.AddRange(ChildrenOf(pane));
            }
        }

        /// <summary>All content ids currently present in the layout.</summary>
        public static List<string> ContentIdsOf(JsonObject layout) => Panes(layout)
            .Where(IsContentPane)
            .Select(ContentIdOf)
            .Where(id => !string.IsNullOrEmpty(id))
            .ToList();

        /// <summary>Symbols of the chart documents currently open, in walk order.</summary>
        public static List<string> ChartSymbolsOf(JsonObject layout) => ContentIdsOf(layout)
            .Where(IsChartContentId)
            .Select(SymbolOfChartPane)
            .ToList();

        private static JsonNode FindContentPane(JsonObject layout, string contentId) => Panes(layout)
            .Where(pane => IsContentPane(pane) && ContentIdOf(pane) == contentId)
            .LastOrDefault();

        /// <summary>False when the pane is absent or flagged hidden.</summary>
        public static bool IsPaneVisible(JsonObject layout, string contentId)
        {
            var pane = FindContentPane(layout, contentId);
            return pane != null && pane["hidden"]?.GetValue<bool>() != true;
        }

        // Transforms --------------------------------------------------------------------------------

        public static JsonObject Clone(JsonObject layout) => (JsonObject)JsonNode.Parse(layout.ToJsonString());

        /// <summary>Shows or hides a docked pane without removing it from the layout.</summary>
        public static JsonObject WithPaneVisibility(JsonObject layout, string contentId, bool visible)
        {
            var next = Clone(layout);
            var pane = FindContentPane(next, contentId);
            if (pane == null)
            {
                return layout;
            }

            pane["hidden"] = !visible;
            return next;
        }

        private static JsonNode DocumentHostOf(JsonObject layout) => Panes(layout).Where(pane => TypeOf(pane) == "documentHost").LastOrDefault();

        /// <summary>Every tab group in the document host, in layout order (breadth first).</summary>
        private static List<JsonObject> ChartTabGroups(JsonNode host)
        {
            var groups = new List<JsonObject>();
            var queue = new Queue<JsonNode>();
            if (host["rootPane"] != null)
            {
                queue.Enqueue(host["rootPane"]);
            }

            while (queue.Count > 0)
            {
                var pane = queue.Dequeue();
                if (TypeOf(pane) == "tabGroupPane")
                {
                    groups.Add((JsonObject)pane);
                    continue;
                }

                foreach (var child in ChildrenOf(pane))
                {
                    queue.Enqueue(child);
                }
            }

            return groups;
        }

        /// <summary>
        /// Closing every chart leaves the host's root split empty, so a group is created on demand:
        /// otherwise opening a chart would be a dead end once the last tab went.
        /// </summary>
        private static JsonObject AppendChartTabGroup(JsonNode host)
        {
            if (host["rootPane"] is not JsonObject root)
            {
                return null;
            }

            var group = new JsonObject { ["type"] = "tabGroupPane", ["panes"] = new JsonArray() };
            if (root["panes"] is not JsonArray panes)
            {
                panes = new JsonArray();
                root["panes"] = panes;
            }

            panes.Add(group);
            return group;
        }

        /// <summary>
        /// Adds a chart document for the symbol and selects it. If the chart is already open, in any
        /// tab group of a split document host, its existing tab is selected instead.
        /// </summary>
        public static JsonObject WithChartDocument(JsonObject layout, string symbol)
        {
            var contentId = ChartContentId(symbol);
            var next = Clone(layout);
            var host = DocumentHostOf(next);
            if (host == null)
            {
                return layout;
            }

            var groups = ChartTabGroups(host);
            foreach (var group in groups)
            {
                if (group["panes"] is not JsonArray panes)
                {
                    continue;
                }

                for (var index = 0; index < panes.Count; index++)
                {
                    if (ContentIdOf(panes[index]) == contentId)
                    {
                        panes[index]["hidden"] = false;
                        group["selectedIndex"] = index;
                        return next;
                    }
                }
            }

            var target = groups.FirstOrDefault() ?? AppendChartTabGroup(host);
            if (target == null)
            {
                return layout;
            }

            if (target["panes"] is not JsonArray targetPanes)
            {
                targetPanes = new JsonArray();
                target["panes"] = targetPanes;
            }

            targetPanes.Add(ChartPane(symbol));
            target["selectedIndex"] = targetPanes.Count - 1;
            return next;
        }

        /// <summary>
        /// Restores a persisted layout, refusing one that holds a pane this build does not render.
        /// Returns null when the payload is unusable, and the desk falls back to the default.
        /// </summary>
        public static JsonObject ParsePersisted(string raw)
        {
            if (string.IsNullOrEmpty(raw))
            {
                return null;
            }

            try
            {
                if (JsonNode.Parse(raw) is not JsonObject parsed || parsed["rootPane"] == null)
                {
                    return null;
                }

                var unknown = ContentIdsOf(parsed).Any(id => !IsChartContentId(id) && !FixedPaneIds.Contains(id));
                return unknown ? null : parsed;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
