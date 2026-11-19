import { registerScript, html } from './_content/IgniteUI.Blazor/api.js';

registerScript("PriceTemplate", (ctx) => {
    var cell = ctx.cell;
    var rowData = grid1.getRowData(cell.id.rowID);
    var icon = trends.positive(rowData) ? "trending_up" : "trending_down";
    var value = cell.value.toFixed(2);
    return html`
        <div class="finjs-icons">
        <span>$${value}</span>
        <igc-icon name="${icon}" collection="material"></igc-icon>
        </div>
        `;
});


registerScript("trends", () => trends, true);
registerScript("trendsChange", () => trendsChange, true);


var ToobarToggle = () => {
    var toolbar = document.getElementsByTagName("igc-grid-toolbar")[0];
    toolbar.hidden = !toolbar.hidden;

}


var negative = (rowData) => rowData['changeP'] < 0;
var positive = (rowData) => rowData['changeP'] > 0;
var changeNegative = (rowData) => rowData['changeP'] < 0 && rowData['changeP'] > -1;
var changePositive = (rowData) => rowData['changeP'] > 0 && rowData['changeP'] < 1;
var strongPositive = (rowData) => rowData['changeP'] >= 1;
var strongNegative = (rowData) => rowData['changeP'] <= -1;
var trends = {
    changeNeg: changeNegative,
    changePos: changePositive,
    negative: negative,
    positive: positive,
    strongNegative: strongNegative,
    strongPositive: strongPositive
};

var trendsChange = {
    changeNeg2: changeNegative,
    changePos2: changePositive,
    strongNegative2: strongNegative,
    strongPositive2: strongPositive
};

// called by name from the page, so keep it reachable from the module
window.ToobarToggle = ToobarToggle;
