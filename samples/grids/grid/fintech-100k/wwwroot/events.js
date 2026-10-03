// FinTech 100K sample. The samples browser loads this file for every sample at once, so every
// global and every igRegisterScript name here carries a fintech100k / Fintech100k prefix, and
// everything else stays inside this function: a top-level const would share the page's global
// scope with the other samples' scripts.
(() => {
    const html = window.igTemplating.html;

    // What C# hands over in fintech100kConnect (App.razor, CreateScriptOptions): the Contract and
    // Region editors' options, and the columns and page size of a PDF export.
    const emptyOptions = { Contracts: [], Regions: [], PdfFields: [], PdfPageSize: "A3" };
    let options = emptyOptions;
    let pdfFields = new Set();

    // en-US currency whatever the browser's language, four decimals: $1,280.7317.
    const priceFormat = new Intl.NumberFormat("en-US", { style: "currency", currency: "USD", minimumFractionDigits: 4, maximumFractionDigits: 4 });

    // The trend of the daily move is decided in C# (Fintech100kTrend, on ChangeP); each row
    // carries its bucket in Trend.
    const isUp = (row) => row.Trend === "Positive" || row.Trend === "StrongPositive";
    const isDown = (row) => row.Trend === "Negative" || row.Trend === "StrongNegative";

    // Cell classes of Price, Change and Change % (IgbColumn CellClassesScript), with the homepage
    // sample's class names: positive / negative colour the Price arrow, and the four magnitude
    // classes colour the bar in front of the Change and Change % values (index.css, "Trends").
    // Registered with shouldCall true: the grid takes the object this function returns.
    igRegisterScript("Fintech100kTrendClasses", () => ({
        positive: (row) => isUp(row),
        negative: (row) => isDown(row),
        changePos: (row) => row.Trend === "Positive",
        changeNeg: (row) => row.Trend === "Negative",
        strongPositive: (row) => row.Trend === "StrongPositive",
        strongNegative: (row) => row.Trend === "StrongNegative"
    }), true);

    // Price: an arrow in the direction of the move, then the price. The arrow is decorative (the
    // Change and Change % cells state the move), so it is hidden from assistive technology. The
    // template reads ctx.cell once: the property builds a new cell object on every read.
    igRegisterScript("Fintech100kPriceTemplate", (ctx) => {
        const row = ctx.cell.row.data;
        const arrow = isUp(row) ? "arrow_upward" : isDown(row) ? "arrow_downward" : "";
        return html`<div class="finjs-icons">${arrow
            ? html`<igc-icon name=${arrow} collection="fintech-100k" aria-hidden="true"></igc-icon>`
            : ""}<span>${priceFormat.format(ctx.implicit)}</span></div>`;
    }, false);

    // The Contract and Region cell editors: a select of the column's options, focused as it
    // opens. The choice goes to the cell's edit value; the grid commits it on Enter, Tab or when
    // the cell loses the edit, as with its own editors.
    function selectEditor(ctx, values) {
        const cell = ctx.cell;
        return html`<igc-select class="finjs-cell-select" autofocus placeholder=${cell.value ?? ""} .value=${cell.editValue}
            @igcChange=${(event) => { cell.editValue = event.detail.value; }}>${values.map((value) =>
                html`<igc-select-item value=${value}>${value}</igc-select-item>`)}</igc-select>`;
    }

    igRegisterScript("Fintech100kContractEditor", (ctx) => selectEditor(ctx, options.Contracts), false);
    igRegisterScript("Fintech100kRegionEditor", (ctx) => selectEditor(ctx, options.Regions), false);

    // The select takes the focus as its cell enters edit mode, as the homepage sample's igxFocus
    // gives it: the grid keeps the focus on its body, so the select's own autofocus never lands.
    // The editor renders after this event, so the focus waits for it, a frame at a time.
    igRegisterScript("Fintech100kCellEditEnter", (evt) => {
        const grid = evt.target;
        let frames = 0;
        const focusEditor = () => {
            const select = grid.querySelector(".igx-grid__td--editing igc-select.finjs-cell-select");
            if (select) {
                select.focus();
            } else if (++frames < 10) {
                requestAnimationFrame(focusEditor);
            }
        };
        requestAnimationFrame(focusEditor);
    }, false);

    // Selecting rows clears the cell selection, as in the homepage sample.
    igRegisterScript("Fintech100kRowSelectionChanging", (evt) => {
        const grid = evt.target;
        if (grid && grid.clearCellSelection) {
            grid.clearCellSelection();
        }
    }, false);

    // A PDF export is printed on A3 and keeps only the homepage sample's PDF columns; an Excel
    // export keeps every visible column. The exporters are shared by every grid on the page (in
    // the samples browser, other samples' grids too), so each one is subscribed only once, and
    // its columns are filtered only while this sample's PDF export runs.
    let exportingPdf = false;

    igRegisterScript("Fintech100kToolbarExporting", (evt) => {
        const args = evt.detail;
        if (!args.options || !("pageSize" in args.options)) {
            return;
        }

        args.options.pageSize = options.PdfPageSize;
        exportingPdf = true;
        const exporter = args.exporter;
        if (exporter && !exporter.fintech100kKeepsPdfFields) {
            exporter.fintech100kKeepsPdfFields = true;
            exporter.columnExporting.subscribe((column) => {
                if (exportingPdf && !pdfFields.has(column.field)) {
                    column.cancel = true;
                }
            });
            exporter.exportEnded.subscribe(() => {
                exportingPdf = false;
            });
        }
    }, false);

    // ---------------------------------------------------------------------------------------------
    // Calls from App.razor.
    // ---------------------------------------------------------------------------------------------

    // Called once, right after the first render, with the options C# owns (JSON text).
    window.fintech100kConnect = (json) => {
        options = Object.assign({}, emptyOptions, JSON.parse(json));
        pdfFields = new Set(options.PdfFields);
    };

    // Called when the component is disposed (DisposeAsync): the options go, as the component does.
    window.fintech100kDisconnect = () => {
        options = emptyOptions;
        pdfFields = new Set();
        exportingPdf = false;
    };
})();
