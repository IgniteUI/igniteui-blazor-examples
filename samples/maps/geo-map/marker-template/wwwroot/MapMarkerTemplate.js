
function onMapMarkerTemplate(o, e) {
    //console.log("onMapMarkerTemplate ");
     
    var desiredSize = 8; 
    return {
        measure: function (measureInfo) {
            var data = measureInfo.data;
            let value = "0.00";
            var item = data.item;
            if (item !== null) {
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

            var labelWidth = 24;

            if (renderInfo.isHitTestRender) {
                //ctx.fillRect(x, y, renderInfo.availableWidth, renderInfo.availableHeight);
                ctx.fillRect(x, y, labelWidth, renderInfo.availableHeight);
                return;
            } else {

                var data = renderInfo.data;

                var viewportHeight = renderInfo.passInfo.viewportHeight;
                var viewportRatio = viewportHeight / 500.0;
                var markerSize = (viewportRatio * desiredSize) + 2;
                var markerRadius = markerSize / 2.0;

                var fontSize = Math.round(viewportRatio * 10);
                var lineSize = Math.round(viewportRatio * 5.5);

                x = renderInfo.xPosition + 5;
                y = renderInfo.yPosition; //+ 10;

                let labelX = x;

                let rightEdge = renderInfo.passInfo.viewportLeft + renderInfo.passInfo.viewportWidth;
                if (x + labelWidth + 10 > rightEdge) {
                    x -= labelWidth + 5;
                    labelX = x;
                } else {
                    labelX = x + 2;
                }

                // rendering rectanlge as background of the marker's text
                ctx.beginPath();
                ctx.fillStyle = "#7D73E6";
                ctx.fillRect(x - 2, y - lineSize, labelWidth, lineSize + 6);
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

                var name = data.item.Code.toString();
                // rendering text of the marker
                ctx.font = '6pt Verdana';
                ctx.textBaseline = "middle";
                ctx.fillStyle = "white";
                ctx.fillText(name, labelX, cy);
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
