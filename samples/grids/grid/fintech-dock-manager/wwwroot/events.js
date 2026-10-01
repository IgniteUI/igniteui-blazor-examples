// Grid FinTech Dock Manager (Signal Desk) sample. The samples browser loads this file for every
// sample at once, so every global and every igRegisterScript name here carries a fintechDockManager /
// FintechDockManager prefix, and everything else stays inside this function: a top-level const would
// share the page's global scope with the other samples' scripts.
//
// C# owns every figure and every rule (FintechDockManagerDesk and its records). This file only:
// - formats the grids' cells (the JavaScript cell templates below);
// - applies each live tick's changes to the grids and the charts (one call per tick);
// - bridges the Dock Manager: it assigns the layouts C# builds, and reports every layout change back;
// - keeps the grids' heights in pixels, and wires the few events that must be handled synchronously
//   (a cancelled pane close, the add-symbol picker, the blotter's filter chips).
(() => {
    const html = window.igTemplating.html;

    // ---------------------------------------------------------------------------------------------
    // Formatting: en-US whatever the browser's language, as the Angular sample's pipes do.
    // ---------------------------------------------------------------------------------------------

    const numberFormats = new Map();
    function numberFormat(digits) {
        if (!numberFormats.has(digits)) {
            numberFormats.set(digits, new Intl.NumberFormat("en-US", { minimumFractionDigits: digits, maximumFractionDigits: digits }));
        }

        return numberFormats.get(digits);
    }

    const missing = "\u2014";
    const price = (value, digits = 2) => (value == null ? missing : numberFormat(digits).format(value));
    const signed = (value) => (value == null ? missing : (value < 0 ? "-" : "+") + numberFormat(2).format(Math.abs(value)));
    const signedPct = (value) => (value == null ? missing : signed(value) + "%");
    const money = (value) => (value == null ? missing : "$" + numberFormat(2).format(Math.abs(value)));
    const signedMoney = (value) => (value == null ? missing : (value < 0 ? "-" : "+") + money(value));
    const direction = (value) => (value >= 0 ? "pos" : "neg");

    const compactUnits = [[1e12, "T"], [1e9, "B"], [1e6, "M"], [1e3, "K"]];
    function compact(value) {
        if (value == null) {
            return missing;
        }

        const unit = compactUnits.find(([threshold]) => Math.abs(value) >= threshold);
        return unit ? (value / unit[0]).toFixed(2) + unit[1] : price(value, 0);
    }

    // 14:32, the blotter's time: the order's instant, in the viewer's time zone.
    const shortClock = (milliseconds) => (milliseconds == null
        ? missing
        : new Date(milliseconds).toLocaleTimeString("en-US", { hour12: false, hour: "2-digit", minute: "2-digit" }));

    // ---------------------------------------------------------------------------------------------
    // Cell templates (IgbColumn BodyTemplateScript). The grid renders them itself, with no round trip
    // to .NET. A template runs again when its own column's field changes, when its row gets another
    // record, and on markForCheck; the live patch replaces the record of every row that moved, so
    // the cells that read other fields of the row (the ranges, the P and L percentages) follow.
    // Each one reads ctx.cell once: the property builds a new cell object on every read.
    // ---------------------------------------------------------------------------------------------

    const symbolTemplate = (ctx) => html`<span class="symbol-cell">${ctx.implicit}</span>`;
    const priceTemplate = (ctx) => html`<span>${price(ctx.implicit)}</span>`;
    const moneyTemplate = (ctx) => html`<span>${money(ctx.implicit)}</span>`;
    const compactTemplate = (ctx) => html`<span>${compact(ctx.implicit)}</span>`;

    // The marker is a dot on a neutral rail; its position (0 to 100, from C#) says where the last
    // price sits inside the band, and its colour the day's direction.
    function rangeTemplate(low, high, position, positive) {
        return html`<div class="range-cell">
            <span class="range-value">${price(low)}</span>
            <div class="range-track" aria-hidden="true">
                <div class="range-marker ${positive ? "pos" : "neg"}" style="left: ${position}%"></div>
            </div>
            <span class="range-value">${price(high)}</span>
        </div>`;
    }

    // Watchlist.
    igRegisterScript("FintechDockManagerSymbolTemplate", symbolTemplate, false);
    igRegisterScript("FintechDockManagerPriceTemplate", priceTemplate, false);
    igRegisterScript("FintechDockManagerCompactTemplate", compactTemplate, false);
    igRegisterScript("FintechDockManagerChangePctTemplate", (ctx) => html`<span class=${direction(ctx.implicit)}>${signedPct(ctx.implicit)}</span>`, false);
    igRegisterScript("FintechDockManagerChangeTemplate", (ctx) => html`<span class=${direction(ctx.implicit)}>${signed(ctx.implicit)}</span>`, false);
    igRegisterScript("FintechDockManagerDayRangeTemplate", (ctx) => {
        const row = ctx.cell.row.data;
        return rangeTemplate(row.DayLow, row.DayHigh, row.DayRangePosition, row.Positive);
    }, false);
    igRegisterScript("FintechDockManagerWeekRangeTemplate", (ctx) => {
        const row = ctx.cell.row.data;
        return rangeTemplate(row.Week52Low, row.Week52High, row.Week52RangePosition, row.Positive);
    }, false);

    // Positions.
    igRegisterScript("FintechDockManagerMoneyTemplate", moneyTemplate, false);
    igRegisterScript("FintechDockManagerLiveMoneyTemplate", (ctx) => html`<span class="live-price">${money(ctx.implicit)}</span>`, false);
    function plTemplate(amount, pct) {
        return html`<div class="pl-cell ${amount >= 0 ? "pos-pnl" : "neg-pnl"}">
            <span class="pl-amount">${signedMoney(amount)}</span>
            <span class="pl-pct">${signedPct(pct)}</span>
        </div>`;
    }

    igRegisterScript("FintechDockManagerDayPlTemplate", (ctx) => {
        const row = ctx.cell.row.data;
        return plTemplate(row.DayChange, row.DayChangePct);
    }, false);
    igRegisterScript("FintechDockManagerOpenPlTemplate", (ctx) => {
        const row = ctx.cell.row.data;
        return plTemplate(row.OpenPl, row.OpenPlPct);
    }, false);
    igRegisterScript("FintechDockManagerWeightTemplate", (ctx) => html`<div class="weight-cell" title="${ctx.implicit}% of gross exposure">
            <igc-linear-progress class="weight-bar" .value=${ctx.implicit} max="100" hide-label animation-duration="0"></igc-linear-progress>
            <span class="weight-value">${price(ctx.implicit, 1)}%</span>
        </div>`, false);

    // Blotter.
    igRegisterScript("FintechDockManagerTimeTemplate", (ctx) => html`<span>${shortClock(ctx.implicit)}</span>`, false);
    igRegisterScript("FintechDockManagerSideTemplate", (ctx) => html`<span class="side-tag ${ctx.implicit === "BUY" ? "side-buy" : "side-sell"}">${ctx.implicit}</span>`, false);
    igRegisterScript("FintechDockManagerOrderPriceTemplate", (ctx) => {
        const row = ctx.cell.row.data;
        return html`<span>${money(row.DisplayPrice)}</span><span class="price-kind">${row.PriceKind}</span>`;
    }, false);
    igRegisterScript("FintechDockManagerStatusTemplate", (ctx) => {
        const row = ctx.cell.row.data;
        return html`<igc-badge class="status-badge" variant=${row.StatusVariant}>${row.Status}</igc-badge>`;
    }, false);
    igRegisterScript("FintechDockManagerNoteTemplate", (ctx) => html`<span class="note-cell" title=${ctx.implicit || ""}>${ctx.implicit}</span>`, false);

    // The positions grid's money columns total like the rest of the desk: "Total" in the desk's money
    // format and the number of positions (the Angular sample's CurrencySumSummary operand).
    class CurrencySumSummary {
        operate(data = []) {
            const total = data.reduce((sum, value) => sum + value, 0);
            return [
                { key: "total", label: "Total", summaryResult: money(total) },
                { key: "count", label: "Positions", summaryResult: data.length }
            ];
        }
    }

    const summedFields = ["MarketValue", "DayChange", "OpenPl"];
    igRegisterScript("FintechDockManagerPositionsColumnInit", (evt) => {
        const column = evt.detail;
        if (column && summedFields.includes(column.field)) {
            column.summaries = CurrencySumSummary;
        }
    }, false);

    // ---------------------------------------------------------------------------------------------
    // Events that must be decided synchronously, with .NET told the outcome.
    // ---------------------------------------------------------------------------------------------

    // The connection to App.razor (fintechDockManagerConnect to fintechDockManagerDisconnect).
    let connection = null;

    function invoke(method, ...args) {
        if (connection) {
            connection.dotnet.invokeMethodAsync(method, ...args).catch(() => undefined);
        }
    }

    // Row clicks: a watchlist row focuses its symbol (chart, ticket and news follow); positions and
    // blotter rows select theirs. A click on a row action bubbles here too, as in the Angular sample.
    igRegisterScript("FintechDockManagerWatchlistRowClick", (evt) => invoke("FintechDockManagerRowClicked", "watchlist", String(evt.detail.row.key)), false);
    igRegisterScript("FintechDockManagerPositionsRowClick", (evt) => invoke("FintechDockManagerRowClicked", "positions", String(evt.detail.row.key)), false);
    igRegisterScript("FintechDockManagerBlotterRowClick", (evt) => invoke("FintechDockManagerRowClicked", "blotter", String(evt.detail.row.key)), false);

    // The add-symbol picker fires the add and keeps no selection: a retained selection would seed
    // the next open's filter with the symbol just added. Symbols already watched stay in the list,
    // marked and inert.
    igRegisterScript("FintechDockManagerAddSymbolItem", (ctx) => {
        const item = ctx.item || ctx;
        return html`<div class="wl-option ${item.Added ? "wl-option-added" : ""}" aria-disabled=${item.Added ? "true" : "false"}>
            <span>${item.Symbol}</span>
            ${item.Added ? html`<span class="wl-option-tag">Added</span>` : ""}
        </div>`;
    }, false);

    igRegisterScript("FintechDockManagerAddSymbolChange", (evt) => {
        const combo = evt.target;
        const item = evt.detail && evt.detail.items && evt.detail.items[0];
        evt.preventDefault();
        if (combo && typeof combo.hide === "function") {
            combo.hide();
        }

        if (item && item.Symbol && evt.detail.type === "selection") {
            invoke("FintechDockManagerAddSymbol", item.Symbol);
        }
    }, false);

    // The blotter's status filter is a single choice that is always applied: a click on the active chip
    // must not clear it. igc-chip's select event cannot be cancelled (the chip has already let go of
    // its selection when it fires), so the chip takes it back.
    igRegisterScript("FintechDockManagerBlotterChipSelect", (evt) => {
        const chip = evt.target;
        if (!evt.detail) {
            chip.selected = true;
            return;
        }

        invoke("FintechDockManagerSetBlotterFilter", chip.getAttribute("data-filter"));
    }, false);

    // ---------------------------------------------------------------------------------------------
    // Calls from App.razor and the panes.
    // ---------------------------------------------------------------------------------------------

    const storagePrefix = "fintech-dock-manager.";

    function storage() {
        try {
            return window.localStorage;
        } catch (error) {
            return null;
        }
    }

    function readStored(key) {
        try {
            const store = storage();
            return store ? store.getItem(storagePrefix + key) : null;
        } catch (error) {
            return null;
        }
    }

    // Storage is best effort: private mode or a full quota must not break the desk.
    window.fintechDockManagerStore = (key, value) => {
        try {
            const store = storage();
            if (store) {
                store.setItem(storagePrefix + key, value);
            }
        } catch (error) {
            // The desk keeps working in memory.
        }
    };

    // The order ticket's numeric fields (FintechDockManagerTicketField.razor): the text the desk chose.
    // The inputs are not bound in Razor, so the trader's typing is never written back.
    window.fintechDockManagerSetFieldValue = (id, text) => {
        const input = document.getElementById(id);
        if (input && input.value !== text) {
            input.value = text;
        }
    };

    window.fintechDockManagerMeasure = () => {
        const root = connection && document.getElementById(connection.rootId);
        const rect = root ? root.getBoundingClientRect() : { width: 1440, height: 900 };
        return JSON.stringify({ width: rect.width, height: rect.height });
    };

    // Called once, right after the shell's first render and before it awaits anything else. Returns
    // what the browser remembered (layout, theme, watchlist), the sample's size for the default
    // layout, and the viewer's UTC offset for the market clock.
    window.fintechDockManagerConnect = (rootId, dotnet, gridIds, fixedPaneIds) => {
        window.fintechDockManagerDisconnect();
        const root = document.getElementById(rootId);
        connection = {
            rootId,
            dotnet,
            gridIds,
            fixedPaneIds,
            root,
            dock: null,
            pendingLayout: null,
            grids: new Map(),
            arrival: null,
            listeners: []
        };

        listen(root, "click", onRowActionClick);
        listen(root, "keydown", onActivationKey);
        listen(root, "mouseover", onRowActionHover);
        listen(root, "focusin", onRowActionHover);

        watchArrivals();
        const rect = root ? root.getBoundingClientRect() : { width: 1440, height: 900 };
        return JSON.stringify({
            layout: readStored("layout"),
            theme: readStored("theme"),
            watchlist: readStored("watchlist"),
            width: rect.width,
            height: rect.height,
            offset: new Date().getTimezoneOffset()
        });
    };

    // Called when the shell is disposed. Nothing reports the elements' own removal, so everything the
    // connection holds is released here, whether or not the render that removes them has run yet.
    window.fintechDockManagerDisconnect = () => {
        if (!connection) {
            return;
        }

        const { listeners, grids, dock, arrival } = connection;
        for (const [target, type, handler] of listeners) {
            target.removeEventListener(type, handler);
        }

        for (const entry of grids.values()) {
            entry.sizer.disconnect();
        }

        if (dock) {
            dock.element.removeEventListener("layoutChange", dock.onLayoutChange);
            dock.element.removeEventListener("paneClose", dock.onPaneClose);
        }

        if (arrival) {
            arrival.disconnect();
        }

        charts.clear();
        connection = null;
    };

    function listen(target, type, handler) {
        if (target) {
            target.addEventListener(type, handler);
            connection.listeners.push([target, type, handler]);
        }
    }

    // IgbDockManager, IgbGrid and IgbFinancialChart add their elements a moment after the render that
    // declares them (and the grids and charts in hidden panes later still), so one observer attaches
    // each element as it arrives.
    function watchArrivals() {
        attachArrivals();
        connection.arrival = new MutationObserver(attachArrivals);
        connection.arrival.observe(document.body, { childList: true, subtree: true });
    }

    function attachArrivals() {
        if (!connection) {
            return;
        }

        const root = connection.root && connection.root.isConnected ? connection.root : document.getElementById(connection.rootId);
        if (!root) {
            return;
        }

        connection.root = root;
        if (!connection.dock) {
            const element = root.querySelector("igc-dockmanager");
            if (element) {
                connectDock(element);
            }
        }

        for (const id of connection.gridIds) {
            const grid = gridOf(id);
            const current = connection.grids.get(id);
            if (grid && (!current || current.grid !== grid)) {
                if (current) {
                    current.sizer.disconnect();
                }

                connection.grids.set(id, { grid, sizer: sizeGrid(grid) });
            }
        }

        for (const [id, entry] of charts) {
            attachChart(id, entry);
        }

        releaseDetachedCharts();
    }

    // Blazor puts a grid's Id on the igc-grid element itself (and, for some wrappers, on a container
    // too), so the lookup settles on the element.
    function gridOf(id) {
        const element = document.getElementById(id);
        if (!element) {
            return null;
        }

        return element.localName === "igc-grid" ? element : element.querySelector("igc-grid");
    }

    // Keeps a grid's height in pixels, equal to its container's. With a percentage height the grid
    // measures its container again on every data update, which the live patch makes once a tick.
    function sizeGrid(grid) {
        const observer = new ResizeObserver((entries) => {
            const height = Math.floor(entries[entries.length - 1].contentRect.height);
            if (height > 0) {
                grid.height = height + "px";
            }
        });
        observer.observe(grid.parentElement);
        return observer;
    }

    // ---------------------------------------------------------------------------------------------
    // Dock Manager.
    // ---------------------------------------------------------------------------------------------

    function connectDock(element) {
        const dock = { element, onLayoutChange: null, onPaneClose: null };

        // Every arrangement the dock manager settles on goes back to C# (the rail's switches and the
        // chart documents are derived from it) and is remembered for the next visit.
        dock.onLayoutChange = (evt) => {
            const layout = (evt.detail && evt.detail.layout) || element.layout;
            if (!layout) {
                return;
            }

            const json = JSON.stringify(layout);
            window.fintechDockManagerStore("layout", json);
            invoke("FintechDockManagerLayoutChanged", json);
        };

        // The pane header's close button removes a pane from the layout, and a pane that is no longer
        // in the layout cannot be brought back by the rail. So for the fixed panes the close is
        // cancelled and turned into a hide, which is the state the rail drives; chart documents keep
        // the default behaviour, closed for good. A tab group holds either fixed panes or chart
        // documents, never both, so this either claims the whole event or leaves it alone.
        dock.onPaneClose = (evt) => {
            const panes = (evt.detail && evt.detail.panes) || [];
            if (panes.length === 0 || !panes.every((pane) => connection && connection.fixedPaneIds.includes(pane.contentId))) {
                return;
            }

            evt.preventDefault();
            for (const pane of panes) {
                pane.hidden = true;
            }
        };

        element.addEventListener("layoutChange", dock.onLayoutChange);
        element.addEventListener("paneClose", dock.onPaneClose);
        connection.dock = dock;

        if (connection.pendingLayout) {
            const layout = connection.pendingLayout;
            connection.pendingLayout = null;
            element.layout = layout;
        }
    }

    // A layout C# built: the default arrangement, a pane shown or hidden, a chart document opened.
    window.fintechDockManagerApplyLayout = (json) => {
        if (!connection) {
            return;
        }

        const layout = JSON.parse(json);
        if (connection.dock) {
            connection.dock.element.layout = layout;
        } else {
            connection.pendingLayout = layout;
        }
    };

    // ---------------------------------------------------------------------------------------------
    // Row actions (the grids' action strips). The buttons are declared in Razor with a
    // data-fintech-action; the strip's context is the row it is showing for.
    // ---------------------------------------------------------------------------------------------

    function stripRowOf(element) {
        const strip = element.closest("igc-action-strip");
        return strip && strip.context ? strip.context : null;
    }

    function onRowActionClick(evt) {
        const button = evt.target.closest && evt.target.closest("[data-fintech-action]");
        if (!button || button.hasAttribute("disabled")) {
            return;
        }

        const row = stripRowOf(button);
        if (row && row.key != null) {
            invoke("FintechDockManagerRowAction", button.getAttribute("data-fintech-action"), String(row.key));
        }
    }

    // A blotter row's cancel action is enabled only while its order is working. The strip moves to a
    // row as the pointer (or focus) reaches it, so its buttons are brought up to date then.
    function onRowActionHover(evt) {
        const grid = evt.target.closest && evt.target.closest("igc-grid");
        if (!grid) {
            return;
        }

        requestAnimationFrame(() => {
            for (const button of grid.querySelectorAll("[data-fintech-requires-working]")) {
                const row = stripRowOf(button);
                const working = !!(row && row.data && row.data.Status === "Working");
                button.disabled = !working;
            }
        });
    }

    // The rail's switches and the movers' rows are not native buttons: Enter and Space activate them.
    function onActivationKey(evt) {
        if (evt.key !== "Enter" && evt.key !== " ") {
            return;
        }

        const target = evt.target.closest && evt.target.closest("[data-fintech-activate]");
        if (target && target === evt.target) {
            evt.preventDefault();
            target.click();
        }
    }

    // ---------------------------------------------------------------------------------------------
    // Live updates.
    // ---------------------------------------------------------------------------------------------

    // Copies each moved row's figures onto a new record in the grid's own array, keyed by symbol, and
    // hands the grid a new array: every cell of a moved row renders again (its templates read other
    // fields of the row), the rows that sat the tick out keep their records, and the active sort is
    // re-applied. Rows the grid does not hold (filtered out, or not in the book any more) are skipped.
    function patchGrid(id, rows, key) {
        const entry = connection && connection.grids.get(id);
        const grid = entry ? entry.grid : gridOf(id);
        const data = grid && grid.data;
        if (!data || !rows || rows.length === 0) {
            return;
        }

        if (!entry || entry.indexSource !== data) {
            const index = new Map(data.map((row, position) => [row[key], position]));
            if (entry) {
                entry.index = index;
            }

            patchWith(grid, data, rows, key, index, entry);
            return;
        }

        patchWith(grid, data, rows, key, entry.index, entry);
    }

    function patchWith(grid, data, rows, key, index, entry) {
        const next = data.slice();
        let changed = false;
        for (const patch of rows) {
            const position = index.get(patch[key]);
            if (position !== undefined) {
                next[position] = Object.assign({}, data[position], patch);
                changed = true;
            }
        }

        if (!changed) {
            return;
        }

        if (entry) {
            entry.indexSource = next;
        }

        grid.data = next;
    }

    // One live tick (App.razor, ApplyTickAsync): the watched quotes that moved, the whole book marked
    // to market, and each open chart's rolled and updated candles.
    window.fintechDockManagerApplyTick = (json) => {
        if (!connection) {
            return;
        }

        const tick = JSON.parse(json);
        const [watchlistGrid, positionsGrid] = connection.gridIds;
        patchGrid(watchlistGrid, tick.Watch, "Symbol");
        patchGrid(positionsGrid, tick.Positions, "Symbol");
        for (const change of tick.Charts || []) {
            applyChartChange(change);
        }
    };

    // ---------------------------------------------------------------------------------------------
    // Charts. Each chart document's data lives here, keyed by its content id (chart:AAPL): C# sends
    // the whole window when a chart opens or changes range, then each tick's appended and updated
    // candles, which are applied to the same array with the chart's notify methods, not by handing
    // it a new array (which would re-bind and redraw the whole series).
    // ---------------------------------------------------------------------------------------------

    const charts = new Map();

    const toPoint = (candle) => ({
        Date: new Date(candle.Date),
        Open: candle.Open,
        High: candle.High,
        Low: candle.Low,
        Close: candle.Close,
        Volume: candle.Volume
    });

    function chartOf(id) {
        const root = (connection && connection.root) || document;
        for (const host of root.querySelectorAll("[data-fintech-chart]")) {
            if (host.getAttribute("data-fintech-chart") === id) {
                return host.querySelector("igc-financial-chart");
            }
        }

        return null;
    }

    function attachChart(id, entry) {
        const chart = chartOf(id);
        if (chart && (entry.chart !== chart || chart.dataSource !== entry.data)) {
            entry.chart = chart;
            chart.dataSource = entry.data;
        }


        if (chart && entry.studies !== undefined && entry.appliedStudies !== entry.studies) {
            entry.appliedStudies = entry.studies;
            chart.indicatorTypes = entry.studies;
        }
    }

    window.fintechDockManagerSetChartData = (id, json) => {
        const previous = charts.get(id);
        const entry = { data: JSON.parse(json).map(toPoint), chart: null, studies: previous ? previous.studies : undefined, appliedStudies: undefined };
        charts.set(id, entry);
        attachChart(id, entry);
    };

    // The RSI study. The chart takes its indicator types as a collection with no "none" member, so
    // no study is an empty collection.
    window.fintechDockManagerSetChartStudies = (id, showRsi) => {
        const entry = charts.get(id);
        if (!entry) {
            return;
        }

        entry.studies = showRsi ? "RelativeStrengthIndex" : [];
        entry.appliedStudies = undefined;
        attachChart(id, entry);
    };

    // A closed chart document's entry goes with its element (IgbFinancialChart destroys the element
    // itself). The check runs from the arrival observer, after the mutation, so a chart that Blazor
    // only moved (removed and inserted again in the same task) is connected again by then.
    function releaseDetachedCharts() {
        for (const [id, entry] of charts) {
            if (entry.chart && !entry.chart.isConnected) {
                charts.delete(id);
            }
        }
    }

    function applyChartChange(change) {
        const entry = charts.get(change.Id);
        if (!entry) {
            return;
        }

        const data = entry.data;
        const chart = entry.chart && entry.chart.isConnected && entry.chart.dataSource === data ? entry.chart : null;
        for (const candle of change.Roll || []) {
            const point = toPoint(candle);
            data.push(point);
            if (chart) {
                chart.notifyInsertItem(data, data.length - 1, point);
            }

            const dropped = data.shift();
            if (chart) {
                chart.notifyRemoveItem(data, 0, dropped);
            }
        }

        if (change.Last) {
            const index = data.length - 1;
            const previous = data[index];
            const point = toPoint(change.Last);
            data[index] = point;
            if (chart) {
                chart.notifySetItem(data, index, previous, point);
            }
        }
    }

    // ---------------------------------------------------------------------------------------------
    // Desk reset: the watchlist's column state lives on the grid's own columns, so the declared
    // hidden and pinned states (from C#) are put back, and sorting and filtering cleared.
    // ---------------------------------------------------------------------------------------------

    window.fintechDockManagerRestoreColumns = (gridId, json) => {
        const grid = gridOf(gridId);
        if (!grid) {
            return;
        }

        for (const preset of JSON.parse(json)) {
            const column = grid.getColumnByName(preset.Field);
            if (!column) {
                continue;
            }

            if (column.pinned !== preset.Pinned) {
                if (preset.Pinned) {
                    column.pin();
                } else {
                    column.unpin();
                }
            }

            column.hidden = preset.Hidden;
        }

        grid.clearSort();
        grid.clearFilter();
    };
})();
