function renderCircle(ctx, x, y, r, fill, outline) {
    ctx.strokeStyle = outline;
    ctx.fillStyle = fill;
    ctx.beginPath();
    ctx.arc(x, y, r, 0, 2 * Math.PI);
    ctx.stroke();
    ctx.fill();
}

function onCategoryChatMarkerStylingTemplate() {

    return {
        measure: function (measureInfo) {
            const context = measureInfo.context;
            const height = context.measureText("M").width;
            const width = context.measureText("0.00").width;
            measureInfo.width = width;
            measureInfo.height = height + 12;
        },
        render: function (renderInfo) {

            let ctx = renderInfo.context;
            let x = renderInfo.xPosition;
            let y = renderInfo.yPosition;

            if (renderInfo.isHitTestRender) {
                ctx.fillStyle = renderInfo.data.actualItemBrush.fill;

                let width = renderInfo.availableWidth;
                let height = renderInfo.availableHeight;

                ctx.fillRect(x - (width / 2), y - (height), renderInfo.availableWidth, renderInfo.availableHeight);
                return;
            }


            const dataItem = renderInfo.data.item;
            if (dataItem === null) return;

            const series = renderInfo.data.series;
            const dataPath = series.valueColumn.propertyName;

           // console.log("onCategoryChatMarkerStylingTemplate render");

            var dataValue = 0;
            switch (dataPath) {
                case "Solar":   dataValue = dataItem.Solar; break;
                case "Coal":    dataValue = dataItem.Coal; break;
                case "Hydro":   dataValue = dataItem.Hydro; break;
                case "Wind":    dataValue = dataItem.Wind; break;
                case "Nuclear": dataValue = dataItem.Nuclear; break;
            }
            ctx.font = '8pt Verdana';
            ctx.textBaseline = 'top';
            ctx.fillStyle = "black";

            let xOffset = 20;
            let yOffset = 10;
            if (dataValue < 0) {
                ctx.fillText(dataValue + "%", x - (xOffset / 2), y + (yOffset ));
            }
            else {
                ctx.fillText(dataValue + "%", x - (xOffset / 2), y - (yOffset * 2));
            }

            renderCircle(ctx, x, y, 6, "white", "black")
        }
    }
}

igRegisterScript("onCategoryChatMarkerStylingTemplate", onCategoryChatMarkerStylingTemplate, true);

function onCategoryChatMarkerStylingSeries(o, e) {

    if (e.series) {
        e.series.markerTemplate = onCategoryChatMarkerStylingTemplate();
    }
}
igRegisterScript("onCategoryChatMarkerStylingSeries", onCategoryChatMarkerStylingSeries, false);
