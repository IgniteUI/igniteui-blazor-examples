function onPolylineShapeStyle(o, e) {

    e.shapeOpacity = 1.0;
    e.shapeStrokeThickness = 1.0;
    e.shapeStroke = 'Black';

    var dataItem = e.item;
    if (dataItem.Class === 'First') {
        e.shapeStroke = 'DodgerBlue';
    }
    if (dataItem.Class === 'Business') {
        e.shapeStroke = 'LimeGreen';
    }
    if (dataItem.Class === 'Premium') {
        e.shapeStroke = 'Orange';
    }
    if (dataItem.Class === 'Economy') {
        e.shapeStroke = 'Red';
    }

    if (dataItem.Status === 'Sold') {
        e.shapeStroke = 'Gray';
    }
}
igRegisterScript("onPolylineShapeStyle", onPolylineShapeStyle, false);

function onPolylineSeriesMouseEnter(o, e) {
    if (e.series.title !== "AirplaneSeats") return;

    if (e.series.tooltipTemplate === null ||
        e.series.tooltipTemplate === undefined) {
        e.series.tooltipTemplate = createPolylineSeriesTooltip;
        console.log("onPolylineSeriesMouseEnter");
    }
}
igRegisterScript("onPolylineSeriesMouseEnter", onPolylineSeriesMouseEnter, false);

function createPolylineSeriesTooltip(context) {

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