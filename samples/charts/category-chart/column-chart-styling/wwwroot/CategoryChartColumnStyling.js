console.log("loaded CategoryChartColumnStyling.js");

function onCategoryChartColumnStylingMarker() {

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

            //console.log("onCategoryChartColumnStylingMarker render");

            const dataItem = renderInfo.data.item;
            if (dataItem === null) return;

            const series = renderInfo.data.series;
            const dataPath = series.valueColumn.propertyName;

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
        }
    }
}

igRegisterScript("onCategoryChartColumnStylingMarker", onCategoryChartColumnStylingMarker, true);

function onCategoryChatColumnStylingSeries(o, e) {

    if (e.series) {
        e.series.markerTemplate = onCategoryChartColumnStylingMarker();
    } 
}
igRegisterScript("onCategoryChatColumnStylingSeries", onCategoryChatColumnStylingSeries, false);
