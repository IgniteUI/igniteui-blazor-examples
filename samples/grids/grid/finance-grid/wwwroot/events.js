// Finance Grid sample. The samples browser loads this file for every sample at once,
// so every global and every igRegisterScript name here carries a financeGrid / FinanceGrid prefix.

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

// One live-feed tick: copies the re-priced fields onto the grid's own row objects, then hands the
// grid a new array. The rows keep their identity, so only the cells whose value changed re-render,
// and the new array reference makes the grid re-apply its sorting. Rows the search filter has
// removed are not in the grid's data and are skipped.
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

// Price Trend, Holding Period and Market Value are hidden while window.innerWidth is under 700px.
// The media query below matches exactly those widths, and reports each crossing to .NET.
window.financeGridWatchNarrow = (dotNetReference) => {
    window.financeGridUnwatchNarrow();
    const query = window.matchMedia("(max-width: 699.98px)");
    const report = () => dotNetReference.invokeMethodAsync("FinanceGridSetNarrow", query.matches);
    query.addEventListener("change", report);
    window.financeGridNarrowWatch = { query, report };
    report();
};

window.financeGridUnwatchNarrow = () => {
    const watch = window.financeGridNarrowWatch;
    if (watch) {
        watch.query.removeEventListener("change", watch.report);
        window.financeGridNarrowWatch = null;
    }
};
