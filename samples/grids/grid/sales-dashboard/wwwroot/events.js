// Sales Dashboard sample. The samples browser loads this file for every sample at once, so every
// global and every igRegisterScript name here carries a salesDashboard / SalesDashboard prefix,
// and everything else stays inside this function: a top-level const would share the page's
// global scope with the other samples' scripts.
(() => {
    const html = window.igTemplating.html;

    // ---------------------------------------------------------------------------------------------
    // Recent Activity grid. The stage's pill class is decided in C# (SalesDashboardStages.ClassFor)
    // and arrives on the row as StageClass; the template only renders it. Stage and StageClass are
    // set together, and the rows never change, so the template needs nothing else to re-run it.
    // ---------------------------------------------------------------------------------------------

    igRegisterScript("SalesDashboardStageTemplate", (ctx) => {
        const row = ctx.cell.row.data;
        return html`<span class="stage-pill ${row.StageClass}">${row.Stage}</span>`;
    }, false);

    // ---------------------------------------------------------------------------------------------
    // Chart tooltips. The charts put their tooltips on document.body, outside the sample's subtree,
    // where index.css (every rule nested under .sales-dashboard-sample) cannot reach them. So the
    // templates carry their own resolved colours, one set per appearance: gray-50 / 700 / 900 of the
    // light palette and gray-100 / 300 / 900 of the dark one (index.css).
    // ---------------------------------------------------------------------------------------------

    const tooltipInk = {
        light: { background: "#f8f9fb", border: "#445d7e", label: "#445d7e", value: "#17202b" },
        dark: { background: "#29405c", border: "#5d85b7", label: "#a3bad6", value: "#f8fafc" }
    };

    // The appearance the tooltips are drawn in. salesDashboardConnect and salesDashboardSetTheme
    // set it, and salesDashboardDisconnect puts it back to light, as a new component starts. A
    // template runs on every hover, so the next tooltip shown always reads the current value.
    let isDarkTheme = false;

    // The template is rendered into the chart's tooltip container, which pads it by 5px inside a
    // 1px transparent border. The negative margin lays the tooltip's box over that frame, so the
    // container measures exactly the box and the chart places it where the Angular sample's is.
    function chartTip(label, value) {
        const ink = isDarkTheme ? tooltipInk.dark : tooltipInk.light;
        const box = "display: grid; gap: 2px; margin: -6px; padding: 7px 10px; border: 1px solid " + ink.border +
            "; border-radius: 4px; background: " + ink.background +
            "; box-shadow: none; font-family: 'Barlow', 'Segoe UI', sans-serif; font-size: 12px; line-height: normal;";
        const labelStyle = "color: " + ink.label + "; font-weight: 600; text-transform: uppercase; letter-spacing: 0.3px;";
        const valueStyle = "color: " + ink.value + "; font-weight: 700;";
        return html`<div class="sales-dashboard-chart-tip" style=${box}>
            <span style=${labelStyle}>${label}</span>
            <span style=${valueStyle}>${value}</span>
        </div>`;
    }

    // Item tooltips (ToolTipType.Item): ctx.item is the chart's data record, PascalCase as in C#.
    const trendTooltip = (ctx) => chartTip(ctx.item.Month, "Revenue " + ctx.item.Revenue + "K \u00b7 Target " + ctx.item.TargetLine + "K");
    const dealsTooltip = (ctx) => chartTip(ctx.item.Day, ctx.item.Deals + " deals");

    // The category charts hand each series they create to SeriesAddedScript, which is where a
    // series takes its tooltip template.
    //
    // The Revenue Trend chart is also labelled here. Like the Angular sample, it lists only Revenue
    // and TargetLine in IncludedProperties, so the chart takes Revenue as its categories and plots
    // TargetLine; the Angular sample then labels the axis by month (xAxisLabel="month"). In Blazor,
    // IgbCategoryChart.XAxisLabel does not reach the chart (a string throws, and XAxisLabelScript is
    // never sent), so the chart element takes the member path directly.
    igRegisterScript("SalesDashboardTrendSeriesAdded", (chart, args) => {
        if (chart && chart.xAxisLabel !== "Month") {
            chart.xAxisLabel = "Month";
        }

        if (args && args.series && args.series.tooltipTemplate !== trendTooltip) {
            args.series.tooltipTemplate = trendTooltip;
        }
    }, false);

    igRegisterScript("SalesDashboardDealsSeriesAdded", (chart, args) => {
        if (args && args.series && args.series.tooltipTemplate !== dealsTooltip) {
            args.series.tooltipTemplate = dealsTooltip;
        }
    }, false);

    // ---------------------------------------------------------------------------------------------
    // The rectangle behind a chart tooltip. Under the tooltip's own box, the chart engine paints a
    // callout (a box and a leg) on a canvas, filled from the "ui-chart-pointer-tooltip" entry of a
    // styling table that every chart on the page shares, and read when a chart is created. The
    // Angular sample sets that entry to transparent (DataChartStylingDefaults) so the tooltip's box
    // is the whole tooltip. Blazor has no API for the table; each chart element's renderer holds it
    // (_renderer._defaultsSource), so it is reached through a chart element created only for that.
    // The chart elements are defined when the first chart is created, so the entry is set as soon as
    // igc-category-chart is defined: App.razor creates its charts only after salesDashboardConnect
    // has run, and the element is defined in the task before the first chart is built. The entry is
    // set while the sample is connected and put back when it disconnects, so charts created by other
    // samples later keep the engine's default.
    // ---------------------------------------------------------------------------------------------

    const pointerTooltipKey = "ui-chart-pointer-tooltip";
    const transparentPointerTooltip = { "background-color": "transparent", "border-top-color": "transparent", "border-top-width": "0" };

    let stylingTable = null;
    let savedPointerTooltip = null;
    let connections = 0;
    let pendingPointerTooltip = false;

    // The chart created to reach the table is destroyed straight away: a chart's renderer checks its
    // size every 100ms from the moment it is created until it is destroyed, attached or not.
    function chartStylingTable() {
        if (stylingTable === null && customElements.get("igc-category-chart")) {
            const probe = document.createElement("igc-category-chart");
            const renderer = probe._renderer;
            stylingTable = (renderer && renderer._defaultsSource) || null;
            probe.destroy();
        }

        return stylingTable;
    }

    function setPointerTooltip() {
        if (!customElements.get("igc-category-chart")) {
            if (!pendingPointerTooltip) {
                pendingPointerTooltip = true;
                customElements.whenDefined("igc-category-chart").then(() => {
                    pendingPointerTooltip = false;
                    if (connections > 0 && savedPointerTooltip === null) {
                        setPointerTooltip();
                    }
                });
            }

            return;
        }

        const table = chartStylingTable();
        if (table && savedPointerTooltip === null) {
            savedPointerTooltip = { had: Object.prototype.hasOwnProperty.call(table, pointerTooltipKey), value: table[pointerTooltipKey] };
            table[pointerTooltipKey] = transparentPointerTooltip;
        }
    }

    function restorePointerTooltip() {
        const table = stylingTable;
        if (table && savedPointerTooltip) {
            if (savedPointerTooltip.had) {
                table[pointerTooltipKey] = savedPointerTooltip.value;
            } else {
                delete table[pointerTooltipKey];
            }
        }

        savedPointerTooltip = null;
    }

    // ---------------------------------------------------------------------------------------------
    // Removed doughnut charts. Every chart's renderer checks the chart's size every 100ms until the
    // chart is destroyed. IgbCategoryChart destroys its chart when it is disposed; IgbDoughnutChart
    // does not (igc-doughnut-chart has no destroy()), so each doughnut the sample drops (one per
    // theme toggle, and the last one when the sample is left) would keep polling for good. The
    // dashboard's removals are watched, and the size check of every doughnut that has left the page
    // is stopped; disconnecting stops the ones the dashboard still holds.
    // ---------------------------------------------------------------------------------------------

    let connection = null;

    function stopSizeCheck(doughnut) {
        const renderer = doughnut._renderer;
        if (renderer && typeof renderer.removeSizeWatcher === "function") {
            renderer.removeSizeWatcher();
        }
    }

    function stopRemovedDoughnuts(records) {
        for (const record of records) {
            for (const node of record.removedNodes) {
                if (node.nodeType !== Node.ELEMENT_NODE) {
                    continue;
                }

                const doughnuts = node.localName === "igc-doughnut-chart" ? [node] : node.getElementsByTagName("igc-doughnut-chart");
                for (const doughnut of doughnuts) {
                    if (!doughnut.isConnected) {
                        stopSizeCheck(doughnut);
                    }
                }
            }
        }
    }

    // The janitor's pending records go first: disconnect() would drop removals it has not been told
    // about yet. getElementsByTagName searches a dashboard that has left the page as well.
    function releaseDashboard() {
        if (!connection) {
            return;
        }

        const { dashboard, janitor } = connection;
        connection = null;
        stopRemovedDoughnuts(janitor.takeRecords());
        janitor.disconnect();
        for (const doughnut of dashboard.getElementsByTagName("igc-doughnut-chart")) {
            stopSizeCheck(doughnut);
        }
    }

    // ---------------------------------------------------------------------------------------------
    // Calls from App.razor.
    // ---------------------------------------------------------------------------------------------

    // Called once, right after the first render and before the component awaits anything else,
    // with the dashboard element and the appearance it has by then (the user can toggle before this
    // call arrives). The charts are rendered after it.
    window.salesDashboardConnect = (dashboard, isDark) => {
        isDarkTheme = isDark === true;
        connections++;
        if (connections === 1) {
            setPointerTooltip();
        }

        releaseDashboard();
        if (dashboard) {
            const janitor = new MutationObserver(stopRemovedDoughnuts);
            janitor.observe(dashboard, { childList: true, subtree: true });
            connection = { dashboard, janitor };
        }
    };

    // Theme toggle (ToggleThemeAsync). Only the tooltips read it; everything else follows the
    // dashboard's dark-theme class and the chart parameters, through the component's render.
    window.salesDashboardSetTheme = (isDark) => {
        isDarkTheme = isDark === true;
    };

    // Called when the component is disposed (DisposeAsync), whether or not the render that removes
    // the dashboard has reached the page yet.
    window.salesDashboardDisconnect = () => {
        releaseDashboard();
        connections = Math.max(0, connections - 1);
        if (connections === 0) {
            restorePointerTooltip();
            isDarkTheme = false;
        }
    };
})();
