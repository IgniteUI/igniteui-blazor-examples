function onStylingShape(o, e) {
    // applying conditional styling based on Contient field loaded from DBF file
    var c = e.item.getFieldValue("Continent")
    if (c == "Africa") {
        e.shapeFill = "#ECB912"; 
    } else if (c == "Asia") {
        e.shapeFill = "#E11D1D";
    } else if (c == "Europe") {
        e.shapeFill = "#2894EC";
    } else if (c == "South America" || c == "North America") {
        e.shapeFill = "#0CC308";
    } else if (c == "Australia") {
        e.shapeFill = "#B42AE9";
    } else {
        e.shapeFill = "gray";
    }
    e.shapeOutline = "black";
}
igRegisterScript("onStylingShape", onStylingShape, false);

function onStylingMarker(o, e) {

    return {
        // measuing size of a marker based on lenght of the Code text field loaded from DBF file
        measure: function (measureInfo) {
            var cont = measureInfo.context;
            var data = measureInfo.data;
            var code = "null";
            if (data.item != null) {
                code = data.item.getFieldValue("Code").toString();
            }
            var height = cont.measureText("M").width;
            var width = cont.measureText(code).width;
            measureInfo.width  = width;
            measureInfo.height = height;
        },

        // rendering a marker with the Code text field inside of filled rectanlge
        render: function (renderInfo) {
            //console.log("mapStyling onStylingMarker render ");
            var ctx = renderInfo.context;
            if (renderInfo.isHitTestRender) {
                ctx.fillStyle = renderInfo.data.actualItemBrush.fill;
            } else {
                ctx.fillStyle = "black";
            }

            var halfWidth  = renderInfo.availableWidth / 2.0;
            var halfHeight = renderInfo.availableHeight / 2.0; 

            var cx = renderInfo.xPosition;
            var cy = renderInfo.yPosition;

            var x = renderInfo.xPosition - halfWidth;
            var y = renderInfo.yPosition - (halfHeight);
 
            if (renderInfo.isHitTestRender) {
                ctx.fillRect(x, y, renderInfo.availableWidth, renderInfo.availableHeight);
            } else { 

                ctx.fillStyle = "rgba(100, 100, 100, 0.5)";
                ctx.fillRect(x - 2, cy - 2, renderInfo.availableWidth + 4, renderInfo.availableHeight + 4);

                ctx.lineWidth = 0.5;
                ctx.strokeStyle = "#7A7A7A"; 
                ctx.strokeRect(x - 2, cy - 2, renderInfo.availableWidth + 4, renderInfo.availableHeight + 4); 

                var data = renderInfo.data;
                var code = data.item.getFieldValue("Code").toString();
                ctx.font = "bold 8px Verdana";
                ctx.textAlign = "center";
                ctx.textBaseline = "top";
                ctx.fillStyle = "#EEEEEE";
                ctx.fillText(code, cx, cy);
            }
        }
    }
}
 
igRegisterScript("onStylingMarker", onStylingMarker, true);
 