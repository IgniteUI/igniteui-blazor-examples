
function onMapMarkerTemplate(o, e) {
    //console.log("onMapMarkerTemplate ");
     
    var desiredSize = 8; 
    return {
        measure: function (measureInfo) {
            var data = measureInfo.data;
            let value = "0.00";
            var item = data.item;
            if (item != null) {
                value = item.Name.toString();
            }
            var context = measureInfo.context;
            var height = context.measureText("M").width;
            var width = context.measureText(value).width;
            measureInfo.width  = width + desiredSize;
            measureInfo.height = height + desiredSize;
        },

        render: function (renderInfo) {
            var ctx = renderInfo.context;
            if (renderInfo.isHitTestRender) {
                ctx.fillStyle = renderInfo.data.actualItemBrush.fill;
            } else {
                ctx.fillStyle = "black";
            }

            var halfWidth = Math.round(renderInfo.availableWidth / 2.0);
            var halfHeight = Math.round(renderInfo.availableHeight / 2.0);

            var cx = renderInfo.xPosition;
            var cy = renderInfo.yPosition;

            var x = renderInfo.xPosition - halfWidth;
            var y = renderInfo.yPosition - halfHeight;

            if (renderInfo.isHitTestRender) {
                //ctx.fillRect(cx - rectHalf, cy - rectHalf, rectSize, rectSize);
                ctx.fillRect(x, y, renderInfo.availableWidth, renderInfo.availableHeight);
                return;

            } else {

                var data = renderInfo.data;

                var viewportHeight = renderInfo.passInfo.viewportHeight;
                var viewportRatio = viewportHeight / 500.0;
                var markerSize = viewportRatio * desiredSize;
                var markerRadius = markerSize / 2.0;

                var fontSize = Math.round(viewportRatio * 10);
                var lineSize = Math.round(viewportRatio * 6);

                x = renderInfo.xPosition + 5;
                y = renderInfo.yPosition + 10;
                if (y < 0) {
                    y -= renderInfo.availableHeight + 7.5;
                }

                let bottomEdge = renderInfo.passInfo.viewportTop + renderInfo.passInfo.viewportHeight;
                if (y + renderInfo.availableHeight > bottomEdge) {
                    y -= renderInfo.availableHeight + 5;
                }

                let rightEdge = renderInfo.passInfo.viewportLeft + renderInfo.passInfo.viewportWidth;
                if (x + renderInfo.availableWidth > rightEdge) {
                    x -= renderInfo.availableWidth + 12;
                }

                // rendering rectanlge as background of the marker's text
                ctx.beginPath();
                ctx.fillStyle = "#7D73E6";
                ctx.fillRect(x - 2, y - lineSize, renderInfo.availableWidth + 8, lineSize + 8);
                ctx.closePath();

                // rendering circle for the marker's location
                ctx.beginPath();
                ctx.arc(cx, cy, markerRadius, 0, 2 * Math.PI);
                ctx.fillStyle = "white";
                ctx.fill();
                ctx.lineWidth = 2;
                ctx.strokeStyle = "#7D73E6";
                ctx.stroke();
                ctx.closePath();

                // rendering text of the marker
                ctx.font = '8pt Verdana';
                ctx.textBaseline = "top";
                ctx.fillStyle = "white";
                var name = data.item.Name.toString();
                ctx.fillText(name, x + 2, y + 2 - lineSize);
            }
        }
    }
}

igRegisterScript("onMapMarkerTemplate", onMapMarkerTemplate, true);


function onMapMarkerClear(o, e) {

    var desiredSize = 8;
    return {
        measure: function (measureInfo) {
            measureInfo.width = desiredSize;
            measureInfo.height = desiredSize;
        },

        render: function (renderInfo) {

        }
    }
}

igRegisterScript("onMapMarkerClear", onMapMarkerClear, true);
