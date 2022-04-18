console.log("loaded FinancialChartTooltipTemplate.js");

function onFinancialChartTooltipCreated(o, e) {
    console.log("onFinancialChartTooltipCreated ");
}
igRegisterScript("onFinancialChartTooltipCreated", onFinancialChartTooltipCreated, false);

function onFinancialChatTooltipSeriesAdded(o, e) {
    console.log("onFinancialChartTooltipSeriesAdded");

    if (e.series) {
        e.series.tooltipTemplate = createFinancialChatTooltipTooltip;
        //console.log("onFinancialChartTooltipSeriesAdded tooltipTemplate");
    }
}
igRegisterScript("onFinancialChartTooltipSeriesAdded", onFinancialChartTooltipSeriesAdded, false);

function createFinancialChartTooltipTooltip(context) {


    if (!context) return null;

    var dataItem = context.item;
    if (!dataItem) return null;

    var tooltipItem1 = document.createElement("div");
    tooltipItem1.innerHTML = "Volume: " + dataItem.Volume;
    tooltipItem1.className = "tooltipTitle";

    var tooltip = document.createElement("div");
    tooltip.className = "tooltipVertical";
    tooltip.appendChild(tooltipItem1);
   
    return tooltip;
}