
igRegisterScript("WorldStatsDataChartTooltip", (o, e) => {
    if (e.series.tooltipTemplate === null ||
        e.series.tooltipTemplate === undefined) {
        e.series.tooltipTemplate = worldStatsDataChartTooltipOnCreate;
        console.log("WorldStatsDataChartTooltip");
    }
}, false);

function worldStatsDataChartTooltipOnCreate(context) {
    if (!context) return null;
    if (!context.series) return null;

    var item = context.item;
    if (!item) return null;

    var tooltip = document.createElement("div");
    tooltip.className = "ui-tooltip-content";

    var columns = [
        { name: "Name", value: item.Name, suffix: "" },
        { name: "Debt", value: item.PublicDebt, suffix: "%" },
        { name: "Population", value: (item.Population / 1000000).toFixed(2), suffix: "M" },
        { name: "GDP", value: (item.GdpPerPerson / 1000).toFixed(1), suffix: "K" },
    ];

    for (var i = 0; i < columns.length; i++) {
        var label = document.createElement("label");
        label.innerHTML = columns[i].name + ":";
        label.className = "tooltipLbl";
        label.style.width = "4rem";

        if (columns[i].suffix === undefined) columns[i].suffix = "";

        var value = document.createElement("label");
        value.innerHTML = columns[i].value + columns[i].suffix;
        value.className = "tooltipVal";

        var line = document.createElement("div");
        line.className = "tooltipHorizontal";
        line.style.color = "black";
        line.appendChild(label);
        line.appendChild(value);

        tooltip.appendChild(line);
    }
    return tooltip;
}
