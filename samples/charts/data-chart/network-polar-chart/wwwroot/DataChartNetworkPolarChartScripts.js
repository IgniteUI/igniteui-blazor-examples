function onNetworkPolarChartMouseEnter(o, e) {

    if (e.series.tooltipTemplate === null ||
        e.series.tooltipTemplate === undefined) {
        e.series.tooltipTemplate = onNetworkPolarChartTooltip;
        console.log("onNetworkPolarChartMouseEnter");
    }
}
igRegisterScript("onNetworkPolarChartMouseEnter", onNetworkPolarChartMouseEnter, false);

function onNetworkPolarChartTooltip(context) {

    if (!context) return null;

    var dataItem = context.item;
    if (!dataItem) return null;

    var tooltip = document.createElement("div");
    tooltip.className = "ui-tooltip-content";

    var div = document.createElement("div");
    div.innerHTML = "Node: " + dataItem.Label;
    div.style.color = dataItem.Fill;
    tooltip.appendChild(div);

    div = document.createElement("div");
    div.innerHTML = "Level: " + dataItem.Radius;
    tooltip.appendChild(div);

    return tooltip;
}

function onNetworkPolarChartMarker(o, e) {

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
                var viewportRatio = viewportHeight / 200.0;
                var markerSize = viewportRatio * desiredSize;
                var markerRadius = Math.min(50, data.item.Radius);
                ctx.strokeStyle = data.item.Outline;
                ctx.fillStyle   = data.item.Fill;
                ctx.lineWidth   = data.item.Thickness;
                ctx.beginPath();
                ctx.arc(cx, cy, markerRadius, 0, 2 * Math.PI);
                ctx.stroke();
                ctx.fill();

                var text = data.item.Label.toString();
                // var textSize = Math.round(viewportRatio * 10);
                var textSize = Math.max(10, data.item.LabelSize);
                ctx.font = "normal " + textSize + "px Verdana";
                ctx.textBaseline = "middle";
                ctx.textAlign = "center";
                ctx.fillStyle = data.item.LabelColor;
                ctx.fillText(text, cx, cy);
            }
        }
    }
}
igRegisterScript("onNetworkPolarChartMarker", onNetworkPolarChartMarker, true);