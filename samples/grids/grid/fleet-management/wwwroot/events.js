// Fleet Management sample. The samples browser loads this file for every sample at once, so every
// global and every igRegisterScript name here carries a fleetManagement / FleetManagement prefix,
// and everything else stays inside this function: a top-level const would share the page's global
// scope with the other samples' scripts.
(() => {
    const html = window.igTemplating.html;

    // The collection App.razor registers the sample's SVG icons under.
    const iconCollection = "fleet-management";

    // ---------------------------------------------------------------------------------------------
    // Chart colours, one set per appearance. The charts paint to a canvas, so they cannot read the
    // palette through a CSS variable: each value is a copy of a palette shade in index.css and has to
    // change with it.
    //   cost         primary, warn, success, error 500 (slice order: fuel, maintenance, insurance, tolls)
    //   onBrush      text painted on a series brush (slice labels, the crosshair's axis bubble)
    //   spend        primary 500
    //   utilization  primary 500, success 500 (current year, prior year)
    //   label        gray 700; gridline gray 200 (dark) / gray 600 (light)
    // ---------------------------------------------------------------------------------------------
    const chartThemes = {
        dark: {
            cost: ["#5099f9", "#ed8936", "#85ec97", "#ed546f"],
            onBrush: "#0a0e10",
            spend: ["#5099f9"],
            utilization: ["#5099f9", "#85ec97"],
            label: "#e9eef1",
            gridline: "#4b6477"
        },
        light: {
            cost: ["#1145a8", "#9a3412", "#166534", "#b91c1c"],
            onBrush: "#ffffff",
            spend: ["#1145a8"],
            utilization: ["#1145a8", "#166534"],
            label: "#3f5083",
            gridline: "#6075b3"
        }
    };

    // The appearance the charts are drawn in: dark, as the sample opens. fleetManagementConnect and
    // fleetManagementSetTheme set it before the templates run, because the shell's light-theme class
    // reaches the page only with the component's next render.
    let isDarkTheme = true;
    const chartTheme = () => (isDarkTheme ? chartThemes.dark : chartThemes.light);

    // en-US whatever the browser's language: $1,020.
    const wholeNumber = new Intl.NumberFormat("en-US");
    const currencyLabel = (value) => "$" + wholeNumber.format(Number(value));

    const axisTextStyle = "500 12px 'DM Sans', sans-serif";
    const sliceTextStyle = "600 12px 'DM Sans', sans-serif";

    // One array per binding, so lit hands the charts the same object on every run.
    const spendProperties = ["spend"];
    const utilizationProperties = ["currentYear", "priorYear"];

    // ---------------------------------------------------------------------------------------------
    // Detail data. C# builds everything an expanded row shows (FleetManagementDetails) and sends it as
    // JSON text in FleetManagementRecord.Detail. It is parsed once per text, so a template that runs
    // again with the same text hands its charts the same data source objects.
    // ---------------------------------------------------------------------------------------------
    const details = new Map();

    function detailOf(row) {
        const cached = details.get(row.Id);
        if (cached && cached.json === row.Detail) {
            return cached.detail;
        }

        const detail = JSON.parse(row.Detail);
        details.set(row.Id, { json: row.Detail, detail });
        return detail;
    }

    // ---------------------------------------------------------------------------------------------
    // Cell template (IgbColumn BodyTemplateScript). The dot is decorative (aria-hidden): the status
    // word beside it carries the meaning. The variant and the pulse come from C# and change together
    // with Status, the column's own field.
    // ---------------------------------------------------------------------------------------------
    igRegisterScript("FleetManagementStatusTemplate", (ctx) => {
        const row = ctx.cell.row.data;
        return html`<span class="status-display" data-status=${row.Status}><igc-badge class=${row.StatusPulse ? "status-badge status-badge-pulse" : "status-badge"} variant=${row.StatusVariant} dot tabindex="-1" aria-hidden="true" inert></igc-badge><span class="badge-text">${row.Status}</span></span>`;
    }, false);

    // ---------------------------------------------------------------------------------------------
    // Detail template (IgbGrid DetailTemplateScript): the tabs an expanded row opens.
    // ---------------------------------------------------------------------------------------------
    const spec = (label, value) => html`<div class="fleet-spec-item"><span>${label}</span><strong>${value}</strong></div>`;

    const kpi = (label, value, accent) => html`<div class="fleet-tab-kpi"><span>${label}</span><strong class=${accent ? "fleet-accent-value" : ""}>${value}</strong></div>`;

    // The photo, or a neutral placeholder once there is none to show (the manifest has no folder for
    // the vehicle, or every shot in it failed): any other car would misstate the paint colour.
    function vehiclePhoto(detail) {
        const urls = detail.photoUrls;
        if (!urls || urls.length === 0) {
            return html`<div class="fleet-vehicle-photo fleet-vehicle-photo-empty"><igc-icon name="directions_car" collection=${iconCollection} aria-hidden="true"></igc-icon><span>Photo unavailable</span></div>`;
        }

        return html`<img class="fleet-vehicle-photo" src=${urls[0]} alt=${detail.photoAlt} loading="lazy" decoding="async" data-photo-index="0" @error=${onPhotoError}>`;
    }

    // Steps to the next shot of the same folder. Once none is left, C# drops the photos from the
    // vehicle's record (FleetManagementPhotoUnavailable) and the template draws the placeholder.
    function onPhotoError(event) {
        const img = event.target;
        const wrap = img.closest(".fleet-detail-wrap");
        const cached = wrap && details.get(wrap.dataset.vehicleId);
        if (!cached) {
            return;
        }

        const urls = cached.detail.photoUrls;
        const next = Number(img.dataset.photoIndex || "0") + 1;
        if (next < urls.length) {
            img.dataset.photoIndex = String(next);
            img.src = urls[next];
        } else if (connection) {
            connection.dotNetReference.invokeMethodAsync("FleetManagementPhotoUnavailable", wrap.dataset.vehicleId);
        }
    }

    // The donut's own tooltip: the slice already carries its share as a label, so the tooltip is the
    // one place the money itself is named.
    const costSliceTooltip = (context) => {
        const item = context && context.item;
        if (!item) {
            return html``;
        }

        return html`<div class="fleet-chart-tooltip"><span class="fleet-chart-tooltip-label">${item.label}</span><span class="fleet-chart-tooltip-value">${currencyLabel(item.value)} \u00B7 ${item.percentage}</span></div>`;
    };

    function detailsTab(detail) {
        const specs = detail.specs;
        return html`<div class="fleet-detail-content">
            <igc-card class="fleet-vehicle-card"><igc-card-content>
                <div class="fleet-vehicle-illustration">${vehiclePhoto(detail)}</div>
            </igc-card-content></igc-card>
            <div class="fleet-spec-grid">
                ${spec("Make", detail.make)}
                ${spec("Engine", specs.engine)}
                ${spec("Generation", specs.generation)}
                ${spec("Year", specs.year)}
                ${spec("Fuel Type", specs.fuelType)}
                ${spec("Power", specs.power)}
                ${spec("Mileage", specs.mileage)}
                ${spec("Doors", detail.doors)}
                ${spec("Seats", detail.seats)}
                ${spec("Engine Displacement", specs.cubature)}
                <div class="fleet-spec-item"><span>Color</span><strong class="fleet-spec-color"><span class="fleet-color-swatch" style="background-color: ${detail.colorHex}" aria-hidden="true"></span>${detail.colorName}</strong></div>
                ${spec("Transmission", specs.transmission)}
                ${spec("MSRP", specs.msrp)}
                ${spec("Toll Pass ID", specs.tollPassId)}
                ${spec("Body Type", detail.bodyType)}
            </div>
        </div>`;
    }

    function tripsTab(detail) {
        const summary = detail.tripSummary;
        return html`<div class="fleet-tab-panel">
            <div class="fleet-tab-kpis fleet-tab-kpis-3up">
                ${kpi("Trips \u2014 Last 30 Days", summary.trips)}
                ${kpi("Total distance", summary.totalDistance)}
                ${kpi("Avg trip", summary.avgTrip)}
            </div>
            <table class="fleet-detail-table fleet-trip-table">
                <thead><tr><th>Date</th><th>From</th><th>To</th><th>Driver</th><th>Start Odometer</th><th>End Odometer</th><th>Distance</th><th class="status-cell">Duration</th></tr></thead>
                <tbody>${detail.tripRows.map((trip) => html`<tr><td>${trip.date}</td><td>${trip.from}</td><td>${trip.to}</td><td>${trip.driver}</td><td>${trip.startMeter}</td><td>${trip.endMeter}</td><td>${trip.distance}</td><td class="status-cell">${trip.duration}</td></tr>`)}</tbody>
            </table>
        </div>`;
    }

    function maintenanceTab(detail) {
        return html`<div class="fleet-tab-panel">
            <div class="fleet-maintenance-alert"><igc-icon name="build" collection=${iconCollection} aria-hidden="true"></igc-icon><span>${detail.maintenanceNotice}</span></div>
            <table class="fleet-detail-table fleet-maintenance-table">
                <thead><tr><th>Date</th><th>Service</th><th>Odometer</th><th>Cost</th><th class="status-cell">Status</th></tr></thead>
                <tbody>${detail.maintenanceRows.map((entry) => html`<tr><td>${entry.date}</td><td>${entry.service}</td><td>${entry.odometer}</td><td>${entry.cost}</td><td class="status-cell"><span class=${"fleet-detail-pill fleet-detail-pill-" + entry.tone}>${entry.status}</span></td></tr>`)}</tbody>
            </table>
        </div>`;
    }

    function costTab(detail, theme) {
        return html`<div class="fleet-tab-panel">
            <div class="fleet-tab-kpis fleet-tab-kpis-3up">
                ${kpi("Total cost \u2014 YTD", detail.totalCost, true)}
                ${kpi("Largest category", detail.topCostCategory)}
                ${kpi("Peak month", detail.peakSpendMonth)}
            </div>
            <div class="fleet-cost-charts">
                <section class="fleet-cost-panel">
                    <div class="fleet-cost-donut-layout">
                        <div class="fleet-cost-donut-legend" aria-label="Cost distribution legend">
                            <div class="fleet-cost-panel-title">Cost Breakdown \u2014 YTD</div>
                            ${detail.costDistribution.map((item) => html`<div class="fleet-cost-donut-legend-item"><span class="fleet-cost-donut-legend-main"><span class=${"fleet-cost-dot fleet-cost-tone-" + item.tone}></span><span>${item.label}</span></span><strong>${item.percentage}</strong></div>`)}
                        </div>
                        <igc-doughnut-chart class="fleet-cost-donut" width="100%" height="280px" .allowSliceSelection=${false} .allowSliceExplosion=${false} .innerExtent=${62}>
                            <igc-ring-series .dataSource=${detail.costDistribution} .valueMemberPath=${"value"} .labelMemberPath=${"displayLabel"} .labelsPosition=${"center"} .leaderLineVisibility=${"collapsed"} .labelInnerColor=${theme.onBrush} .tooltipTemplate=${costSliceTooltip} .brushes=${theme.cost} .outlines=${theme.cost} .textStyle=${sliceTextStyle}></igc-ring-series>
                        </igc-doughnut-chart>
                    </div>
                </section>
                <section class="fleet-cost-panel">
                    <div class="fleet-cost-panel-title">Monthly Operating Cost</div>
                    <igc-category-chart class="fleet-cost-column-chart" width="100%" height="280px" .chartType=${"column"} .dataSource=${detail.monthlySpend} .xAxisLabel=${"month"} .includedProperties=${spendProperties} .yAxisMinimumValue=${0} .yAxisFormatLabel=${currencyLabel} .isTransitionInEnabled=${false} .isHorizontalZoomEnabled=${false} .isVerticalZoomEnabled=${false} .thickness=${1} .brushes=${theme.spend} .outlines=${theme.spend} .crosshairsAnnotationXAxisTextColor=${theme.onBrush} .crosshairsAnnotationYAxisTextColor=${theme.onBrush} .xAxisLabelTextStyle=${axisTextStyle} .yAxisLabelTextStyle=${axisTextStyle} .xAxisLabelTextColor=${theme.label} .yAxisLabelTextColor=${theme.label} .xAxisMajorStroke=${theme.gridline} .yAxisMajorStroke=${theme.gridline} .xAxisMajorStrokeThickness=${1} .yAxisMajorStrokeThickness=${1}></igc-category-chart>
                </section>
            </div>
        </div>`;
    }

    function utilizationTab(detail, theme) {
        const utilization = detail.utilization;
        return html`<div class="fleet-tab-panel">
            <div class="fleet-tab-kpis fleet-tab-kpis-4up">
                ${kpi("Utilization rate", utilization.rate, true)}
                ${kpi("Active hours", utilization.activeHours)}
                ${kpi("Idle hours", utilization.idleHours)}
                ${kpi("Trips this month", utilization.trips)}
            </div>
            <div class="fleet-utilization-wrap">
                <div class="fleet-utilization-title">Monthly Active Hours \u2014 ${detail.utilizationCurrentYear} vs ${detail.utilizationPriorYear} ${detail.utilizationYoY}</div>
                <div class="fleet-utilization-legend" aria-label="Utilization comparison legend">
                    <span class="fleet-utilization-legend-item"><span class="fleet-utilization-legend-swatch fleet-utilization-legend-swatch-current"></span><span>${detail.utilizationCurrentYear}</span></span>
                    <span class="fleet-utilization-legend-item"><span class="fleet-utilization-legend-swatch fleet-utilization-legend-swatch-prior"></span><span>${detail.utilizationPriorYear}</span></span>
                </div>
                <igc-category-chart class="fleet-utilization-comparison-chart" width="100%" height="320px" .chartType=${"column"} .dataSource=${detail.utilizationSeries} .xAxisLabel=${"month"} .includedProperties=${utilizationProperties} .yAxisMinimumValue=${0} .isTransitionInEnabled=${false} .isHorizontalZoomEnabled=${false} .isVerticalZoomEnabled=${false} .thickness=${1} .brushes=${theme.utilization} .outlines=${theme.utilization} .crosshairsAnnotationXAxisTextColor=${theme.onBrush} .crosshairsAnnotationYAxisTextColor=${theme.onBrush} .xAxisLabelTextStyle=${axisTextStyle} .yAxisLabelTextStyle=${axisTextStyle} .xAxisLabelTextColor=${theme.label} .yAxisLabelTextColor=${theme.label} .xAxisMajorStroke=${theme.gridline} .yAxisMajorStroke=${theme.gridline} .xAxisMajorStrokeThickness=${1} .yAxisMajorStrokeThickness=${1}></igc-category-chart>
            </div>
        </div>`;
    }

    igRegisterScript("FleetManagementDetailTemplate", (ctx) => {
        const row = ctx.implicit;
        const detail = detailOf(row);
        const theme = chartTheme();
        return html`<div class="fleet-detail-wrap" data-vehicle-id=${row.Id}>
            <igc-tabs class="fleet-detail-tabs">
                <igc-tab label="Details">${detailsTab(detail)}</igc-tab>
                <igc-tab label="Trip History">${tripsTab(detail)}</igc-tab>
                <igc-tab label="Maintenance">${maintenanceTab(detail)}</igc-tab>
                <igc-tab label="Cost">${costTab(detail, theme)}</igc-tab>
                <igc-tab label="Utilization">${utilizationTab(detail, theme)}</igc-tab>
            </igc-tabs>
        </div>`;
    }, false);

    // ---------------------------------------------------------------------------------------------
    // Calls from App.razor.
    // ---------------------------------------------------------------------------------------------

    // Theme toggle (ToggleThemeAsync). The charts paint with resolved colours, so the appearance is
    // set here first and the grid then re-runs its templates; rows expanded later read the same flag.
    window.fleetManagementSetTheme = (gridId, isDark) => {
        isDarkTheme = isDark === true;
        const grid = connection ? connection.grid : document.getElementById(gridId);
        if (grid) {
            grid.markForCheck();
        }
    };

    // Called once, right after the first render and before the component awaits anything else, with
    // the appearance it has by then. IgbGrid adds its igc-grid element a moment later, so the grid's
    // part of the connection waits for the element to arrive.
    let gridArrival = null;

    window.fleetManagementConnect = (gridId, dotNetReference, isDark) => {
        isDarkTheme = isDark === true;
        stopWaitingForGrid();

        const grid = document.getElementById(gridId);
        if (grid) {
            connectGrid(grid, dotNetReference);
            return;
        }

        gridArrival = new MutationObserver(() => {
            const arrived = document.getElementById(gridId);
            if (arrived) {
                stopWaitingForGrid();
                connectGrid(arrived, dotNetReference);
            }
        });
        gridArrival.observe(document.body, { childList: true, subtree: true });
    };

    // Called when the component is disposed (DisposeAsync): the first and only call it makes. Every
    // chart the detail rows created is destroyed, whether or not the grid has left the page yet, and
    // the appearance goes back to dark, as a new component starts.
    window.fleetManagementDisconnect = () => {
        stopWaitingForGrid();
        releaseGrid();
        details.clear();
        isDarkTheme = true;
    };

    // The connected grid, its .NET reference, its click handler and its janitor. Held here rather
    // than looked up by id, so the grid can still be released once it has left the page.
    let connection = null;

    function connectGrid(grid, dotNetReference) {
        if (connection && connection.grid === grid) {
            return;
        }

        releaseGrid();
        const janitor = new MutationObserver((records) => onGridMutations(grid, records));
        janitor.observe(grid, { childList: true, subtree: true });
        grid.addEventListener("click", onRowActionClick);
        connection = { grid, dotNetReference, janitor };
        watchCharts(grid.getElementsByTagName("*"));
        syncActionStrip(grid);
    }

    function releaseGrid() {
        if (!connection) {
            return;
        }

        const { grid, janitor } = connection;
        connection = null;
        onGridMutations(grid, janitor.takeRecords());
        janitor.disconnect();
        grid.removeEventListener("click", onRowActionClick);
        for (const chart of [...liveCharts]) {
            destroyChart(chart);
        }
    }

    function stopWaitingForGrid() {
        if (gridArrival) {
            gridArrival.disconnect();
            gridArrival = null;
        }
    }

    // ---------------------------------------------------------------------------------------------
    // Row actions. The action strip is one element the grid moves into the row under the pointer;
    // its buttons (App.razor) carry the status they set in data-status. The click reads the row off
    // the strip's context and C# applies the change (FleetManagementSetStatus).
    // ---------------------------------------------------------------------------------------------
    function onRowActionClick(event) {
        const button = event.target && event.target.closest ? event.target.closest(".fleet-row-action") : null;
        if (!button || !connection) {
            return;
        }

        const strip = button.closest("igc-action-strip");
        const data = strip && strip.context && strip.context.data;
        if (data && button.dataset.status) {
            connection.dotNetReference.invokeMethodAsync("FleetManagementSetStatus", data.Id, button.dataset.status);
        }
    }

    // The strip offers one action per status the row is not already in: index.css hides the button
    // whose data-status matches the strip's. The strip's status follows the row it sits on, which
    // changes when it moves and when the row's record does, both of which change the grid's DOM.
    function syncActionStrip(grid) {
        const strip = grid.querySelector("igc-action-strip");
        if (!strip) {
            return;
        }

        const data = strip.context && strip.context.data;
        const status = data && data.Status ? data.Status : "";
        if (strip.getAttribute("data-status") !== status) {
            strip.setAttribute("data-status", status);
        }
    }

    // ---------------------------------------------------------------------------------------------
    // Chart janitor. A category or doughnut chart checks its size every 100 ms from the moment it is
    // created until it is destroyed; leaving the page, or the grid, does not stop it. The grid keeps
    // the detail view of a row once it has been expanded, and puts the same elements back when the
    // row scrolls into view again or is expanded again, so a chart cannot be destroyed while its grid
    // is alive. Every chart the grid has created is recorded here and destroyed when the component
    // disconnects (fleetManagementDisconnect).
    // ---------------------------------------------------------------------------------------------
    const liveCharts = new Set();
    const chartSelector = "igc-category-chart, igc-doughnut-chart";

    function isChart(node) {
        return node.localName === "igc-category-chart" || node.localName === "igc-doughnut-chart";
    }

    function watchCharts(nodes) {
        for (const node of nodes) {
            if (node.nodeType === Node.ELEMENT_NODE && isChart(node)) {
                liveCharts.add(node);
            }
        }
    }

    function onGridMutations(grid, records) {
        for (const record of records) {
            for (const node of record.addedNodes) {
                if (node.nodeType === Node.ELEMENT_NODE) {
                    watchCharts(isChart(node) ? [node] : node.querySelectorAll(chartSelector));
                }
            }
        }

        syncActionStrip(grid);
    }

    // Charts already destroyed. The category chart stops with destroy(); igc-doughnut-chart has no
    // destroy() and stops with ngOnDestroy().
    const destroyedCharts = new WeakSet();

    function destroyChart(chart) {
        liveCharts.delete(chart);
        if (destroyedCharts.has(chart)) {
            return;
        }

        destroyedCharts.add(chart);
        if (typeof chart.destroy === "function") {
            chart.destroy();
        } else if (typeof chart.ngOnDestroy === "function") {
            chart.ngOnDestroy();
        }
    }
})();
