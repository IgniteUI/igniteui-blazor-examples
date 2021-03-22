console.log("loaded DataChartNetworkPolarChartScripts.js");
 
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

    div = document.createElement("div");
    div.innerHTML = "Angle: " + dataItem.Angle;
    //itemClass.style.color = "black";
   // tooltip.appendChild(div);

    return tooltip;
}

function onNetworkPolarChartMarker(o, e) {

    var desiredSize = 46;
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

              //  if (data.item.IsCircle) {

                 //   var markerRadius = Math.min(150, data.item.Radius);
                    var actualRadius = viewportRatio * data.item.Radius;
                   // var markerRadius = Math.min(150, viewportRatio * data.item.Radius);
                    var markerRadius = Math.min(50, data.item.Size);
                   
                    ctx.strokeStyle = data.item.Outline; //"black";
                    ctx.fillStyle   = data.item.Fill; //"rgba(193, 66, 66, 0.2)";
                    ctx.lineWidth   = data.item.Thickness;
                    // ctx.fillStyle = "rgba(193, 66, 66, 0)";
                    ctx.beginPath();
                    //ctx.arc(cx, cy, markerHalf, 0, 2 * Math.PI);
                   // ctx.arc(cx, cy, markerSize, 0, 2 * Math.PI);
                    ctx.arc(cx, cy, markerRadius, 0, 2 * Math.PI);
                    ctx.stroke();
                    ctx.fill();
                    //ctx.globalAlpha = 0.4;
               // }
                //else {

                    var text = data.item.Label.toString();
                    // var text = data.item.Value.toString();
                    // var text = data.item.Total.toString();
                    //  var text = data.item.LabelText.toString() + " " + data.item.Value.toString();

                var textSize = Math.max(10, data.item.LabelSize); // Math.round(viewportRatio * 10);
                ctx.font = "normal " + textSize + "px Verdana";
                    ctx.textBaseline = "middle";
                    ctx.textAlign = "center";
                    ctx.fillStyle = data.item.LabelColor; //"black";
                    //ctx.fillStyle = "white";
                    ctx.fillText(text, cx, cy);
                /*}*/
                //ctx.fillStyle = "#30A510";
                //ctx.fillRect(x, y, renderInfo.availableWidth, renderInfo.availableHeight);

            }
        }
    }
}
igRegisterScript("onNetworkPolarChartMarker", onNetworkPolarChartMarker, true);