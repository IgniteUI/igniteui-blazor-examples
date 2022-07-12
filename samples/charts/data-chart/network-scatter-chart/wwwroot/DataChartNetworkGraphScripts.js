function onNetworkGrahpMouseEnter(o, e) {

    if (e.series.tooltipTemplate !== null &&
        e.series.tooltipTemplate !== undefined) {
        return;
    }

    if (e.series.title.indexOf("Layer") > 0) {

        e.series.tooltipTemplate = createNodeInfoTooltip;
        console.log("createNodeInfoTooltip ");
    }

    if (e.series.title == "Connections") {

        e.series.tooltipTemplate = createNodeConnectionTooltip;
        console.log("createNodeConnectionTooltip ");
    }
}
igRegisterScript("onNetworkGrahpMouseEnter", onNetworkGrahpMouseEnter, false);

function createNodeInfoTooltip(context) {

    if (!context) return null;

    var dataItem = context.item;
    if (!dataItem) return null;

    var tooltip = document.createElement("div");
    tooltip.className = "ui-tooltip-content";

    var divLabel = document.createElement("div");
    divLabel.innerHTML = "" + dataItem.Label;
    tooltip.appendChild(divLabel);

    var divLayer = document.createElement("div");
    divLayer.innerHTML = "" + dataItem.Layer;
    divLayer.style.color = dataItem.Color;
    tooltip.appendChild(divLayer);

    return tooltip;
}

function createNodeConnectionTooltip(context) {

    if (!context) return null;

    var dataItem = context.item;
    if (!dataItem) return null;

    var tooltip = document.createElement("div");
    tooltip.className = "ui-tooltip-content";

    var divConnection = document.createElement("div");
    divConnection.innerHTML = dataItem.Label;
    tooltip.appendChild(divConnection);

    var divSource = document.createElement("div");
    divSource.innerHTML = "Source: " + dataItem.Source.Layer;
    divSource.style.color = dataItem.Source.Color;
    tooltip.appendChild(divSource);

    var divTarget = document.createElement("div");
    divTarget.innerHTML = "Target: " + dataItem.Target.Layer;
    divTarget.style.color = dataItem.Target.Color;
    tooltip.appendChild(divTarget);

    return tooltip;
}