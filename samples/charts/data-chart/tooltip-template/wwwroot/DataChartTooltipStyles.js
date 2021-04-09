console.log("loaded DataChartTooltipStyles.js");

function onColumnSeriesMouseEnter(o, e) {
    if (e.series.tooltipTemplate === null ||
        e.series.tooltipTemplate === undefined) {
        e.series.tooltipTemplate = createTooltip;
        console.log("onColumnSeriesMouseEnter");
    }
}
igRegisterScript("onColumnSeriesMouseEnter", onColumnSeriesMouseEnter, false);

function createTooltip(context) {

    if (!context) return null;

    var dataItem = context.item;
    if (!dataItem) return null;

    var tooltip = document.createElement("div");
    tooltip.className = "ui-tooltip-content";

    var itemCountry = document.createElement("div");
    itemCountry.innerHTML = "Class: " + dataItem.Country;
    tooltip.appendChild(itemCountry);

    var itemCoal = document.createElement("div");
    itemCoal.innerHTML = "Coal: " + dataItem.Coal;
    tooltip.appendChild(itemCoal);

    var itemOil = document.createElement("div");
    itemOil.innerHTML = "Oil: " + dataItem.Oil;
    tooltip.appendChild(itemOil);

    var itemGas = document.createElement("div");
    itemGas.innerHTML = "Gas: " + dataItem.Gas;
    tooltip.appendChild(itemGas);

    var itemNuclear = document.createElement("div");
    itemNuclear.innerHTML = "Nuclear: " + dataItem.Nuclear;
    tooltip.appendChild(itemNuclear);

    var itemHydro = document.createElement("div");
    itemHydro.innerHTML = "Hydro: " + dataItem.Hydro;
    tooltip.appendChild(itemHydro);

    return tooltip;
}