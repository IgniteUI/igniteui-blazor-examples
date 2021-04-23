function onDataChartSeriesMarkerTemplate(o, e) {

    var desiredSize = 8;
    let style = { outline: "#9FB328", fill: "white", text: "black" };
    let size = 12;

    return {
       
        measure: function (measureInfo) {
            const data = measureInfo.data;
            const context = measureInfo.context;
            let value = "0.00";
            let item = data.item;
            if (item != null) {
                value = item.Value.toString();
            }
            const height = context.measureText("M").width;
            const width = context.measureText(value).width;
            measureInfo.width = width;
            measureInfo.height = height + size;
        },
        render: function (renderInfo) {
            const item = renderInfo.data.item;
            const value = item.Value.toString();

            const ctx = renderInfo.context;
            let x = renderInfo.xPosition;
            let y = renderInfo.yPosition;

            let halfHeight = renderInfo.availableHeight / 2.0;

            if (renderInfo.isHitTestRender) {
                ctx.fillStyle = renderInfo.data.actualItemBrush.fill;

                let width = renderInfo.availableWidth;
                let height = renderInfo.availableHeight;

                ctx.fillRect(x - (width / 2), y - (height / 2), renderInfo.availableWidth, renderInfo.availableHeight);
                return;
            }

            ctx.beginPath();
            ctx.fillStyle = style.outline;

            let xOffset = 14;
            let yOffset = 10;

            if (renderInfo.data.item.Value >= 100) {
                xOffset = 20;
            }

            let width = renderInfo.availableWidth + xOffset;
            let height = halfHeight + yOffset;

            ctx.fillRect(x - (width / 2), y - (height / 2), width, height);
            ctx.closePath();

            ctx.font = '8pt Verdana';
            ctx.textBaseline = 'top';
            ctx.fillStyle = style.fill;
            ctx.fillText(value, x - (xOffset / 2), y - (yOffset / 2));
        }
    }
}

igRegisterScript("onDataChartSeriesMarkerTemplate", onDataChartSeriesMarkerTemplate, true);