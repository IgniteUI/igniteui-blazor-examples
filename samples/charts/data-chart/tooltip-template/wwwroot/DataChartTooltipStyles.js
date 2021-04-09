﻿console.log("loaded DataChartTooltipStyles.js");

function onSeriesMouseEnter(o, e) {
    if (e.series.tooltipTemplate === null ||
        e.series.tooltipTemplate === undefined) {
        e.series.tooltipTemplate = createTooltip;
        console.log("onSeriesMouseEnter");
    }
}
igRegisterScript("onSeriesMouseEnter", onSeriesMouseEnter, false);

function createTooltip(context) {
    if (!context) return null;

    var dataItem = context.item;
    if (!dataItem) return null;

    var dataSeries = context.series;
    if (!dataSeries) return null;

    var tooltip = document.createElement("div");
    tooltip.className = "ui-tooltip-content";

    var title = document.createElement("div");
    title.innerHTML = dataItem.Country + " Production";
    title.className = "tooltipTitle";
    tooltip.appendChild(title);

    var line1 = createTooltipLine(dataSeries, "Coal", dataItem.Coal);
    var line2 = createTooltipLine(dataSeries, "Hydro", dataItem.Hydro);
    var line3 = createTooltipLine(dataSeries, "Nuclear", dataItem.Nuclear);
    var line4 = createTooltipLine(dataSeries, "Gas", dataItem.Gas);
    var line5 = createTooltipLine(dataSeries, "Oil", dataItem.Oil);

    tooltip.appendChild(line1);
    tooltip.appendChild(line2);
    tooltip.appendChild(line3);
    tooltip.appendChild(line4);
    tooltip.appendChild(line5);

    return tooltip;
}

function createTooltipLine(dataSeries, dataName, dataValue) {

    var label = document.createElement("label");
    label.innerHTML = dataName + ":";
    label.className = "tooltipLbl";
    label.style.width = "4rem";

    var value = document.createElement("label");
    value.innerHTML = dataValue;
    value.className = "tooltipVal";

    var line = document.createElement("div");
    line.className = "tooltipHorizontal";

    // applying conditional styling based on mapping of the current series
    var isMatching = dataSeries.valueMemberPath == dataName;
    if (isMatching)
        line.style.color = dataSeries.actualBrush;
    else
        line.style.color = "black";

    line.appendChild(label);
    line.appendChild(value);
    return line;
}
