igRegisterScript("PriceTemplate", (ctx) => {
    var html = window.igTemplating.html;
    var cell = ctx.cell;
    var rowData = grid1.getRowData(cell.id.rowID);
    var icon = this.trends.positive(rowData) ? "trending_up" : "trending_down";
    var value = cell.value.toFixed(2);
    return html`
        <div class="finjs-icons">
        <span>$${value}</span>
        <igc-icon name="${icon}" collection="material"></igc-icon>
        </div>
        `;
}, false);


igRegisterScript("trends", () => this.trends, true);
igRegisterScript("trendsChange", () => this.trendsChange, true);


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
    changeNeg: this.changeNegative,
    changePos: this.changePositive,
    negative: this.negative,
    positive: this.positive,
    strongNegative: this.strongNegative,
    strongPositive: this.strongPositive
};

var trendsChange = {
    changeNeg2: this.changeNegative,
    changePos2: this.changePositive,
    strongNegative2: this.strongNegative,
    strongPositive2: this.strongPositive
};