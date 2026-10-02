// Finance Grid sample. The samples browser loads this file for every sample at once, so every
// global and every igRegisterScript name here carries a financeGrid / FinanceGrid prefix, and
// everything else stays inside this function: a top-level const would share the page's global
// scope with the other samples' scripts (one of them already declares a top-level html).
(() => {
    const html = window.igTemplating.html;

    // Keeps the Price Trend (sparkline) column out of every export: Excel, CSV and PDF.
    // The toolbar re-uses its exporter instances, so each one is subscribed only once.
    igRegisterScript("FinanceGridToolbarExporting", (evt) => {
        const exporter = evt.detail.exporter;
        if (exporter && !exporter.financeGridSkipsPriceTrend) {
            exporter.financeGridSkipsPriceTrend = true;
            exporter.columnExporting.subscribe((args) => {
                if (args.field === "PriceTrend") {
                    args.cancel = true;
                }
            });
        }
    }, false);

    // ---------------------------------------------------------------------------------------------
    // Formatting. The figures, and the outcome of every rule (holding term, bar values, flash state,
    // filter matches), come from C# in FinanceGridRecord; the templates only turn them into text.
    // ---------------------------------------------------------------------------------------------

    // en-US currency and number formatting whatever the browser's language: $1,315.68 and -$310.92.
    const currency = new Intl.NumberFormat("en-US", { style: "currency", currency: "USD", minimumFractionDigits: 2, maximumFractionDigits: 2 });
    const twoDecimals = new Intl.NumberFormat("en-US", { minimumFractionDigits: 2, maximumFractionDigits: 2 });

    // Year length the elapsed figure is expressed in (1y 55d). Whether a holding is long-term is
    // decided in C#: FinanceGridRow.IsLongTerm.
    const daysPerYear = 365;

    // Sparkline brushes per appearance. The chart paints to a canvas and cannot read a var().
    const sparkBrushes = {
        light: { up: "#1a9b62", down: "#d33a75" },
        dark: { up: "#34d399", down: "#ff7aae" }
    };

    // The appearance the sparklines are drawn in. financeGridConnect and financeGridSetTheme set it,
    // and financeGridDisconnect puts it back to light, as a new component starts. It is kept here
    // rather than on the grid element because the component can switch before its grid exists.
    let isDarkTheme = false;

    const formatCurrency = (value) => currency.format(value);

    // A percentage prints its magnitude: on a chip, the arrow and the colour carry the sign.
    const formatPercent = (value) => twoDecimals.format(Math.abs(value)) + "%";

    const badgeLabel = (value) => (value > 0 ? "\u2191 " : value < 0 ? "\u2193 " : "") + formatPercent(value);

    // The figure chips are coloured by the sign of their figure (index.css, "Figure chips").
    const signClass = (value) => (value > 0 ? " is-positive" : value < 0 ? " is-negative" : "");

    // The delta chips carry the latest tick's flash: is-up / is-down in its direction, is-repeat when
    // the row moved the same way as on the tick before (no second flash), and flash-b on every other
    // new flash the chip shows (an odd serial). lit keeps the chip element from one render to the
    // next, and a class the chip already has does not start its animation again; flash-b swaps it to
    // the second of two identical keyframe sets, and a changed animation name does. Each chip counts
    // its own flashes: the Price (Change) chip renders on every re-pricing and passes FlashSerial;
    // the Total Revenue chip renders only when NetProfit changes and passes ProfitFlashSerial.
    function deltaChipClass(row, figure, serial) {
        let names = "finance-chip finance-delta-chip" + signClass(figure);
        if (row.Direction === "Up" || row.Direction === "Down") {
            names += row.Direction === "Up" ? " is-up" : " is-down";
            if (row.IsRepeatMove) {
                names += " is-repeat";
            }

            if (serial % 2 === 1) {
                names += " flash-b";
            }
        }

        return names;
    }

    // Up to two letters or digits of the ticker ("AM" for AMD): igc-avatar renders every character
    // it is given.
    function avatarInitials(ticker) {
        const normalized = (ticker || "").replace(/[^A-Z0-9]/gi, "").toUpperCase();
        const initials = normalized.length > 0 ? normalized : "EQ";
        return initials.length > 2 ? initials.substring(0, 2) : initials;
    }

    function holdingElapsed(days) {
        const held = Math.max(0, days);
        const years = Math.floor(held / daysPerYear);
        const remainder = held % daysPerYear;
        return years > 0 ? (remainder > 0 ? `${years}y ${remainder}d` : `${years}y`) : `${held}d`;
    }

    function holdingHint(row) {
        if (row.IsLongTerm) {
            return "Long term \u2014 gains taxed at the long-term rate";
        }

        const remaining = row.DaysToLongTerm;
        return `Short term \u2014 ${remaining} ${remaining === 1 ? "day" : "days"} to long-term treatment`;
    }

    // Text with every occurrence of the filter marked. C# splits the text while it builds the
    // filtered rows (FinanceGridTextHighlighter.SplitOnMatches) and sends the runs as JSON text,
    // null while no filter is set: they alternate plain and matching text, the matches at the odd
    // indexes. Nothing is rendered between the parts, so "Bit", "co", "in" still read as one word.
    function highlight(text, runsJson) {
        if (!runsJson) {
            return html`<span>${text}</span>`;
        }

        const parts = [];
        JSON.parse(runsJson).forEach((run, index) => {
            if (index % 2 === 1) {
                parts.push(html`<mark class="search-hit">${run}</mark>`);
            } else if (run) {
                parts.push(html`<span>${run}</span>`);
            }
        });
        return parts;
    }

    // The sparkline plots objects through its valueMemberPath, while C# sends each series as JSON
    // text (FinanceGridRecord.Trend): on Blazor Server an array of numbers would reach the grid as
    // null, and a list of objects with an id on every point. Each ticker's series is converted once
    // per text, so a template that runs again for another reason, or for a new Data list with the
    // same series, hands the sparkline the same dataSource.
    const trendPoints = new Map();
    function trendPointsOf(ticker, trendJson) {
        if (!trendJson) {
            return null;
        }

        const cached = trendPoints.get(ticker);
        if (cached && cached.trendJson === trendJson) {
            return cached.points;
        }

        const points = JSON.parse(trendJson).map((value) => ({ Value: value }));
        trendPoints.set(ticker, { trendJson, points });
        return points;
    }

    // ---------------------------------------------------------------------------------------------
    // Cell templates (IgbColumn BodyTemplateScript). The grid renders them itself, with no round
    // trip to .NET. A template runs again when its own column's field changes, when its row gets
    // another record (a new Data list, a recycled row while scrolling) and on markForCheck. Each one
    // reads ctx.cell once: the property builds a new cell object on every read.
    //
    // The chips (delta chips in Price (Change) and Total Revenue, the term chip in Holding Period)
    // are decorative: aria-hidden, inert and never a tab stop (igc-chip is not selectable unless it
    // is asked to be). Each label sits in a finance-chip-label span: Chromium still reads a bare
    // text node slotted into an aria-hidden host into the cell's accessible name.
    // ---------------------------------------------------------------------------------------------

    igRegisterScript("FinanceGridAssetTemplate", (ctx) => {
        const row = ctx.cell.row.data;
        return html`<div class="ticker-cell">
            <igc-avatar class="ticker-logo tone-${row.Tone}" shape="circle" initials=${avatarInitials(row.Ticker)}></igc-avatar>
            <div class="ticker-meta">
                <span class="ticker-symbol">${highlight(row.Ticker, row.TickerRuns)}</span>
                <span class="ticker-name">${highlight(row.Company, row.CompanyRuns)}</span>
            </div>
        </div>`;
    }, false);

    // The brushes follow isDarkTheme, which financeGridConnect and financeGridSetTheme set before
    // they re-run the templates; the shell's dark-theme class reaches the page only with the
    // component's next render. The class is a plain attribute because the sparkline adds classes of
    // its own, and width and height are attributes the sparkline turns into its inline size.
    igRegisterScript("FinanceGridPriceTrendTemplate", (ctx) => {
        const row = ctx.cell.row.data;
        const brushes = isDarkTheme ? sparkBrushes.dark : sparkBrushes.light;
        return html`<igc-sparkline class="price-trend-spark" width="100%" height="20px"
            .valueMemberPath=${"Value"} .displayType=${"Line"} .lineThickness=${1.8}
            .brush=${row.ChangePct < 0 ? brushes.down : brushes.up} .negativeBrush=${brushes.down}
            .dataSource=${trendPointsOf(row.Ticker, row.Trend)}></igc-sparkline>`;
    }, false);

    igRegisterScript("FinanceGridPriceTemplate", (ctx) => {
        const row = ctx.cell.row.data;
        return html`<div class="price-combined-cell">
            <igc-chip class=${deltaChipClass(row, row.ChangePct, row.FlashSerial)} tabindex="-1" aria-hidden="true" inert><span class="finance-chip-label">${badgeLabel(row.ChangePct)}</span></igc-chip>
            <span class="numeric-cell price-combined-price">${formatCurrency(row.LastPrice)}</span>
        </div>`;
    }, false);

    // The tag and the bar share one colour: success once the holding is long-term, info before.
    igRegisterScript("FinanceGridHoldingPeriodTemplate", (ctx) => {
        const row = ctx.cell.row.data;
        return html`<div class="holding-cell">
            <div class="holding-head">
                <igc-chip class="finance-chip finance-term-chip${row.IsLongTerm ? " is-positive" : ""}" tabindex="-1" aria-hidden="true" inert><span class="finance-chip-label">${row.IsLongTerm ? "LONG TERM" : "SHORT TERM"}</span></igc-chip>
                <span class="holding-elapsed">${holdingElapsed(row.HoldingPeriodDays)}</span>
            </div>
            <igc-linear-progress class="holding-bar" .value=${row.HoldingBarValue} max="100" variant=${row.IsLongTerm ? "success" : "info"}
                hide-label animation-duration="0" aria-hidden="true"></igc-linear-progress>
            <span class="sr-only">${holdingHint(row)}</span>
        </div>`;
    }, false);

    // Market Value shows its own field and nothing else, so it needs no cell object.
    igRegisterScript("FinanceGridMarketValueTemplate", (ctx) => html`<span class="numeric-cell">${formatCurrency(ctx.implicit)}</span>`, false);

    igRegisterScript("FinanceGridNetProfitTemplate", (ctx) => {
        const row = ctx.cell.row.data;
        return html`<div class="net-profit-combined-cell">
            <igc-chip class=${deltaChipClass(row, row.NetProfitPct, row.ProfitFlashSerial)} tabindex="-1" aria-hidden="true" inert><span class="finance-chip-label">${badgeLabel(row.NetProfitPct)}</span></igc-chip>
            <span tabindex="-1" draggable="false" aria-hidden="true">${formatCurrency(row.NetProfit)}</span>
        </div>`;
    }, false);

    // The bar is hidden from assistive technology: its value is the share of the *largest*
    // holding (AllocationBarValue, scaled in C#), not the percentage printed above it.
    igRegisterScript("FinanceGridAllocationTemplate", (ctx) => {
        const row = ctx.cell.row.data;
        return html`<div class="allocation-cell">
            <span class="allocation-value">${formatPercent(row.AllocationPct)}</span>
            <igc-linear-progress class="allocation-bar" .value=${row.AllocationBarValue} max="100" variant="primary"
                hide-label animation-duration="0" aria-hidden="true"></igc-linear-progress>
        </div>`;
    }, false);

    // ---------------------------------------------------------------------------------------------
    // Calls from App.razor.
    // ---------------------------------------------------------------------------------------------

    // One live-feed tick (ApplyTickAsync): copies each patch onto the grid's own row object, then
    // hands the grid a new array. The rows keep their identity, so a template runs again only where
    // its column's field changed, and the new array reference makes the grid re-apply its sorting.
    // A settled holding's patch holds only its flash state, which no column shows: nothing renders
    // for it now, and a cell rendered later (after a scroll, say) reads the state it has. Rows the
    // search filter has removed are not in the grid's data and are skipped.
    window.financeGridPatchRows = (gridId, json) => {
        const grid = document.getElementById(gridId);
        const data = grid && grid.data;
        if (!data) {
            return;
        }

        if (grid.financeGridIndexSource !== data) {
            grid.financeGridIndex = new Map(data.map((row) => [row.Ticker, row]));
        }

        for (const patch of JSON.parse(json)) {
            const row = grid.financeGridIndex.get(patch.Ticker);
            if (row) {
                Object.assign(row, patch);
            }
        }

        const next = data.slice();
        grid.financeGridIndexSource = next;
        grid.data = next;
    };

    // Theme toggle (ToggleThemeAsync). The sparklines paint to a canvas with resolved brushes, so
    // the appearance is set here first, and the grid then re-runs every rendered cell template once,
    // synchronously (markForCheck); rows rendered later read the same flag. Before the grid exists
    // there is nothing to re-run: its cells render with the flag as it is by then.
    window.financeGridSetTheme = (gridId, isDark) => {
        isDarkTheme = isDark === true;
        const grid = document.getElementById(gridId);
        if (grid) {
            grid.markForCheck();
        }
    };

    // Called once, right after the first render and before the component awaits anything else,
    // with the appearance it has by then. IgbGrid adds its igc-grid element a moment later, on
    // Blazor Server as on WebAssembly, so the grid's part of the connection waits for the element
    // to arrive.
    let gridArrival = null;

    window.financeGridConnect = (gridId, dotNetReference, isDark) => {
        isDarkTheme = isDark === true;
        watchNarrow(dotNetReference);
        stopWaitingForGrid();

        // Cells the grid rendered before the appearance was set here drew light sparklines, so in
        // dark mode the templates run again once the grid is connected.
        const connect = (grid) => {
            connectGrid(grid);
            if (isDarkTheme) {
                grid.markForCheck();
            }
        };

        const grid = document.getElementById(gridId);
        if (grid) {
            connect(grid);
            return;
        }

        gridArrival = new MutationObserver(() => {
            const arrived = document.getElementById(gridId);
            if (arrived) {
                stopWaitingForGrid();
                connect(arrived);
            }
        });
        gridArrival.observe(document.body, { childList: true, subtree: true });
    };

    // Called when the component is disposed (DisposeAsync). Nothing reports the grid's own removal,
    // so the sparklines it still holds are destroyed here, whether or not the render that removes
    // the grid has reached the page yet. The series converted for its sparklines are dropped, and
    // the appearance goes back to light, so the sample opened again starts out light, as the
    // component does.
    window.financeGridDisconnect = () => {
        unwatchNarrow();
        stopWaitingForGrid();
        releaseGrid();
        trendPoints.clear();
        isDarkTheme = false;
    };

    // The connected grid, with its sizer and sparkline janitor. It is held here rather than looked
    // up by id, so the grid can still be released once it has left the page.
    let connection = null;

    function connectGrid(grid) {
        if (connection && connection.grid === grid) {
            return;
        }

        releaseGrid();
        connection = { grid, sizer: sizeGrid(grid), janitor: watchSparklines(grid) };
    }

    // The janitor's pending records go first: disconnect() would drop removals it has not been told
    // about yet. getElementsByTagName searches a grid that has left the page as well.
    function releaseGrid() {
        if (!connection) {
            return;
        }

        const { grid, sizer, janitor } = connection;
        connection = null;
        sizer.disconnect();
        destroyRemovedSparklines(janitor.takeRecords());
        janitor.disconnect();
        for (const sparkline of grid.getElementsByTagName("igc-sparkline")) {
            destroySparkline(sparkline);
        }
    }

    function stopWaitingForGrid() {
        if (gridArrival) {
            gridArrival.disconnect();
            gridArrival = null;
        }
    }

    // Keeps the grid's height in pixels, equal to its container's (IgbGrid renders igc-grid inside
    // a container that fills div.finance-grid). With a percentage height the grid measures its
    // container again on every data update, hiding its body for a moment to do so: a forced layout
    // on every live tick, and every animation running in the body starts over, so each delta chip
    // would flash again.
    function sizeGrid(grid) {
        const observer = new ResizeObserver((entries) => {
            // Rounded down: a grid taller than its container, even by a fraction of a pixel, would
            // lose part of its bottom border to the container's overflow: hidden.
            const height = Math.floor(entries[entries.length - 1].contentRect.height);
            if (height > 0) {
                grid.height = height + "px";
            }
        });
        observer.observe(grid.parentElement);
        return observer;
    }

    // An igc-sparkline checks its own size every 100 ms from the moment it is created until its
    // destroy() is called, and leaving the page does not stop it. The grid discards cells without
    // telling their templates (a hidden or pinned column, the rows a narrower filter no longer
    // needs, a shorter viewport), so its removals are watched and every sparkline that has left is
    // destroyed. Mutation records arrive after the grid's own update, so a node it only moves is
    // back in the page by then; and this grid never puts a removed cell back: showing, pinning and
    // unpinning a column, or rows coming back after a filter, all create new cells.
    function watchSparklines(grid) {
        const observer = new MutationObserver(destroyRemovedSparklines);
        observer.observe(grid, { childList: true, subtree: true });
        return observer;
    }

    function destroyRemovedSparklines(records) {
        for (const record of records) {
            for (const node of record.removedNodes) {
                if (node.nodeType !== Node.ELEMENT_NODE) {
                    continue;
                }

                const sparklines = node.localName === "igc-sparkline" ? [node] : node.getElementsByTagName("igc-sparkline");
                for (const sparkline of sparklines) {
                    if (!sparkline.isConnected) {
                        destroySparkline(sparkline);
                    }
                }
            }
        }
    }

    // Sparklines already destroyed. Once the grid has left the page, a cell it merely moves counts as
    // removed too, so the janitor and releaseGrid can both come across the same sparkline; each one
    // is destroyed only once.
    const destroyedSparklines = new WeakSet();

    function destroySparkline(sparkline) {
        if (!destroyedSparklines.has(sparkline)) {
            destroyedSparklines.add(sparkline);
            sparkline.destroy();
        }
    }

    // Price Trend, Holding Period and Market Value are hidden while window.innerWidth is under 700px.
    // The media query below matches exactly those widths, and reports each crossing to .NET.
    let narrowWatch = null;

    function watchNarrow(dotNetReference) {
        unwatchNarrow();
        const query = window.matchMedia("(max-width: 699.98px)");
        const report = () => dotNetReference.invokeMethodAsync("FinanceGridSetNarrow", query.matches);
        query.addEventListener("change", report);
        narrowWatch = { query, report };
        report();
    }

    function unwatchNarrow() {
        if (narrowWatch) {
            narrowWatch.query.removeEventListener("change", narrowWatch.report);
            narrowWatch = null;
        }
    }
})();
