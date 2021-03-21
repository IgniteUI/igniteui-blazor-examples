console.log("loaded DataChartGanttChartScripts.js");

function onGanttChartMouseEnter(o, e) {
    //if (e.series.title !== "AirplaneSeats") return;

    if (e.series.tooltipTemplate === null ||
        e.series.tooltipTemplate === undefined) {
        e.series.tooltipTemplate = createGanttTooltip;
        console.log("onGanttChartMouseEnter ");
    }
}
igRegisterScript("onGanttChartMouseEnter", onGanttChartMouseEnter, false);

function createGanttTooltip(context) {

    if (!context) return null;

    var dataItem = context.item;
    if (!dataItem) return null;

    var tooltip = document.createElement("div");
    tooltip.className = "ui-tooltip-content";

    var line2 = document.createElement("div");
    line2.innerHTML = "Task Name: " + dataItem.Name;
    line2.style.color = dataItem.Color;
    tooltip.appendChild(line2);

    var line1 = document.createElement("div");
    line1.innerHTML = "Department: " + dataItem.Category;
    //line1.style.color = "black";
    tooltip.appendChild(line1);

    var line3 = document.createElement("div");
    line3.innerHTML = "Duration: " + dataItem.Duration + "";
    //line2.style.color = "black";
    tooltip.appendChild(line3);

    return tooltip;
}