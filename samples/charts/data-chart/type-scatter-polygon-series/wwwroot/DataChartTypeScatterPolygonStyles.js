function onPolygonShapeStyle(o, e) {

    e.shapeOpacity = 1.0;
    e.shapeStrokeThickness = 0.5;
    e.shapeStroke = 'Black';

    var dataItem = e.item;
    if (dataItem.Class === 'First') {
        e.shapeFill = 'DodgerBlue';
    }
    if (dataItem.Class === 'Business') {
        e.shapeFill = 'LimeGreen';
    }
    if (dataItem.Class === 'Premium') {
        e.shapeFill = 'Orange';
    }
    if (dataItem.Class === 'Economy') {
        e.shapeFill = 'Red';
    }

    if (dataItem.Status === 'Sold') {
        e.shapeFill = 'Gray';
    }
}
igRegisterScript("onPolygonShapeStyle", onPolygonShapeStyle, false);

function onPolygonSeriesMouseEnter(o, e) {
    if (e.series.title !== "AirplaneSeats") return;

    if (e.series.tooltipTemplate === null ||
        e.series.tooltipTemplate === undefined) {
        e.series.tooltipTemplate = createPolygonSeriesTooltip;
        console.log("onPolygonSeriesMouseEnter ");
    }
}
igRegisterScript("onPolygonSeriesMouseEnter", onPolygonSeriesMouseEnter, false);

function createPolygonSeriesTooltip(context) {

    if (!context) return null;

    var dataItem = context.item;
    if (!dataItem) return null;

    var tooltip = document.createElement("div");
    tooltip.className = "ui-tooltip-content";

    var itemClass = document.createElement("div");
    itemClass.innerHTML = "Class: " + dataItem.Class;
    //itemClass.style.color = "black";
    tooltip.appendChild(itemClass);

    var itemSeat = document.createElement("div");
    itemSeat.innerHTML = "Seat: " + dataItem.Seat;
    tooltip.appendChild(itemSeat);

    var itemPrice = document.createElement("div");
    itemPrice.innerHTML = "Price: $" + dataItem.Price;
    tooltip.appendChild(itemPrice);

    var itemStatus = document.createElement("div");
    itemStatus.innerHTML = "Status: " + dataItem.Status;
    tooltip.appendChild(itemStatus);

    return tooltip;
}