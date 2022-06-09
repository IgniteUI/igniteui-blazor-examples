
function onSeriesMouseEnter(o, e) {
    if (e.series.tooltipTemplate === null ||
        e.series.tooltipTemplate === undefined) {
        e.series.tooltipTemplate = createDataChartTooltip;
        console.log("onSeriesMouseEnter");
    }
}
igRegisterScript("onSeriesMouseEnter", onSeriesMouseEnter, false);

function createDataChartTooltip(context) {
    if (!context) return null;

    var dataItem = context.item;
    if (!dataItem) return null;

    var dataSeries = context.series;
    if (!dataSeries) return null;

    var tooltip = document.createElement("div");

    var title = document.createElement("div");
    title.innerHTML = dataItem.Details;
    title.style.fontsize = "50px";
    tooltip.appendChild(title);
    return tooltip;
}