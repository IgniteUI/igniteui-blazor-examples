function onGanttChartMouseEnter(o, e) {

    if (e.series.tooltipTemplate === null ||
        e.series.tooltipTemplate === undefined) {
        e.series.tooltipTemplate = onGanttTooltip;
        console.log("onGanttChartMouseEnter ");
    }
}
igRegisterScript("onGanttChartMouseEnter", onGanttChartMouseEnter, false);

function onGanttTooltip(context) {

    if (!context) return null;

    var dataItem = context.item;
    if (!dataItem) return null;

    var tooltip = document.createElement("div");
    tooltip.className = "ui-tooltip-content";
    tooltip.style.font = "normal 12px Verdana";

    var div = document.createElement("div");
    div.innerHTML = "Task Name: " + dataItem.Name;
    div.style.color = dataItem.Color;
    tooltip.appendChild(div);

    div = document.createElement("div");
    div.innerHTML = "Department: " + dataItem.Category;
    tooltip.appendChild(div);

    div = document.createElement("div");
    div.innerHTML = "Duration: " + dataItem.Duration;
    tooltip.appendChild(div);

    div = document.createElement("div");
    div.innerHTML = "Range: " + dataItem.Start + "-" + dataItem.Stop ;
    tooltip.appendChild(div);

    return tooltip;
}

function onGanttMarker(o, e) {

    var desiredSize = 45;
    return {
        measure: function (measureInfo) {
            measureInfo.width = desiredSize;
            measureInfo.height = desiredSize;
        },

        render: function (renderInfo) {
            var ctx = renderInfo.context;
            if (renderInfo.isHitTestRender) {
                ctx.fillStyle = renderInfo.data.actualItemBrush.fill;
            } else {
                ctx.fillStyle = "black";
            }

            var halfWidth  = Math.round(renderInfo.availableWidth / 2.0);
            var halfHeight = Math.round(renderInfo.availableHeight / 2.0);

            var cx = renderInfo.xPosition;
            var cy = renderInfo.yPosition;

            var x = renderInfo.xPosition - halfWidth;
            var y = renderInfo.yPosition - halfHeight;

            if (renderInfo.isHitTestRender) {
                ctx.fillRect(x, y, renderInfo.availableWidth, renderInfo.availableHeight);

            } else {

                var data = renderInfo.data;

                var viewportHeight = renderInfo.passInfo.viewportHeight;
                var viewportRatio = viewportHeight / 200.0;// 150.0;
                var markerSize = viewportRatio * desiredSize;
                var markerHalf = markerSize / 2.0;
                var actualRadius = viewportRatio * data.item.Radius;
                var markerRadius = 30; //Math.min(150, viewportRatio * data.item.Radius);
                //ctx.strokeStyle = "black";
                //ctx.fillStyle = "rgba(193, 66, 66, 0.2)";
                //ctx.lineWidth = 1;
                //ctx.beginPath();
                //ctx.arc(cx, cy, markerRadius, 0, 2 * Math.PI);
                //ctx.stroke();
                //ctx.fill();

                var text = data.item.Duration.toString();
                //var textSize = Math.round(viewportRatio * 10);
                var textSize = 12;
                ctx.font = "normal " + textSize + "px Verdana";
                ctx.textBaseline = "middle";
                ctx.textAlign = "center";
                ctx.fillStyle = "#494848";
                ctx.fillText(text, cx, cy);
            }
        }
    }
}
igRegisterScript("onGanttMarker", onGanttMarker, true);