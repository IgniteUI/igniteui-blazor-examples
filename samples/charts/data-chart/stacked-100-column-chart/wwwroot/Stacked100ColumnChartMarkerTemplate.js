function onStacked100ChartMarkerTemplate(o, e) {

    let style = { text: "white" };
    let size = 12;

    return {
        measure: function (measureInfo) {
            const data = measureInfo.data;
            const context = measureInfo.context;
            let value = "0.00";
            let item = data.item;
            if (item != null) {
                value = item.DesktopMarker.toString();
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
                case "DesktopMarker":
                    value = item.Desktop;
                    break;
                case "MobileMarker":
                    value = item.Mobile;
                    break;
                case "TabletMarker":
                    value = item.Tablet;
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

            let xOffset = 18;
            let yOffset = 10;

            ctx.font = '8pt Verdana';
            ctx.textBaseline = 'top';
            ctx.fillStyle = style.text;

            if (value < 10) {
                xOffset = 12;
            }

            ctx.fillText(value, x - (xOffset / 2), y - (yOffset / 2));
            
        }
    }
}

igRegisterScript("onStacked100ChartMarkerTemplate", onStacked100ChartMarkerTemplate, true);