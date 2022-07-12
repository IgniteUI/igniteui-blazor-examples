function onCategoryChatTooltipCreated(o, e) {
    console.log("onCategoryChatTooltipCreated ");
}
igRegisterScript("onCategoryChatTooltipCreated", onCategoryChatTooltipCreated, false);

function onCategoryChatTooltipSeriesAdded(o, e) {
    console.log("onCategoryChatTooltipSeriesAdded");

    if (e.series) {
        e.series.tooltipTemplate = createCategoryChatTooltipTooltip;
        //console.log("onCategoryChatTooltipSeriesAdded tooltipTemplate");
    }
}
igRegisterScript("onCategoryChatTooltipSeriesAdded", onCategoryChatTooltipSeriesAdded, false);

function createCategoryChatTooltipTooltip(context) {

    //console.log("createCategoryChatTooltipTooltip ");

    if (!context) return null;

    var dataItem = context.item;
    if (!dataItem) return null;

    var tooltipItem1 = document.createElement("div");
    tooltipItem1.innerHTML = "Franchise: " + dataItem.Franchise;
    tooltipItem1.className = "tooltipTitle";

    var tooltipItem2 = document.createElement("div");
    tooltipItem2.innerHTML = "Revenue of All Movies: " + dataItem.TotalRevenue;
    tooltipItem2.className = "tooltipLbl";

    var tooltipItem3= document.createElement("div");
    tooltipItem3.innerHTML = "Highest Grossing Movie: $" + dataItem.HighestGrossing;
    tooltipItem3.className = "tooltipLbl";

    var tooltip = document.createElement("div");
    tooltip.className = "tooltipVertical";
    tooltip.appendChild(tooltipItem1);
    tooltip.appendChild(tooltipItem2);
    tooltip.appendChild(tooltipItem3);

    return tooltip;
}