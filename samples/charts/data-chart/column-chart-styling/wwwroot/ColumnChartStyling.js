function onColumnChartStylingMarkerTemplate(o, e) {

    let style = { text: "black" };
    let size = 12;

    return {
        measure: function (measureInfo) {
            const data = measureInfo.data;
            const context = measureInfo.context;
            let value = "0.00";
            let item = data.item;
            if (item != null) {
                value = item.Solar.toString();
            }
            const height = context.measureText("M").width;
            const width = context.measureText(value).width;
            measureInfo.width = width;
            measureInfo.height = height + size;
        },
        render: function (renderInfo) {
            const item = renderInfo.data.item;
            const series = renderInfo.data.series;

            const valuePath = series.valueColumn.propertyName;

            var value = 0;

            switch (valuePath) {
                case "Solar":
                    value = item.Solar;
                    break;
                case "Coal":
                    value = item.Coal;
                    break;
                case "Hydro":
                    value = item.Hydro;
                    break;
                case "Wind":
                    value = item.Wind;
                    break;
                case "Nuclear":
                    value = item.Nuclear;
                    break;
            }

            const ctx = renderInfo.context;
            let x = renderInfo.xPosition;
            let y = renderInfo.yPosition;

            if (renderInfo.isHitTestRender) {
                ctx.fillStyle = renderInfo.data.actualItemBrush.fill;

                let width = renderInfo.availableWidth;
                let height = renderInfo.availableHeight;

                ctx.fillRect(x - (width / 2), y - (height), renderInfo.availableWidth, renderInfo.availableHeight);
                return;
            }

            let xOffset = 20;
            let yOffset = 10;

            ctx.font = '8pt Verdana';
            ctx.textBaseline = 'top';
            ctx.fillStyle = style.text;

            if (value < 0) {
                ctx.fillText(value + "%", x - (xOffset / 2), y + (yOffset ));
            }
            else {
                ctx.fillText(value + "%", x - (xOffset / 2), y - (yOffset * 2));
            }
        }
    }
}

igRegisterScript("onColumnChartStylingMarkerTemplate", onColumnChartStylingMarkerTemplate, true);