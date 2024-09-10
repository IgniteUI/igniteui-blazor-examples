
igRegisterScript("WebGridCurrencyCellTemplate", (ctx) => {
    var html = window.igTemplating.html;
    if (ctx.cell.value > 0) {
        return html`<div style='width: 80px;
        float: right;'>
        <igc-badge variant="success" style="float: left;"><span>▲</span></igc-badge>
        <span style='color:green;float: right;'>${ctx.cell.value.toFixed(2)}</span>
        </div>`;
    } else {
        return html`<div style='width: 80px;
        float: right;'>
        <igc-badge variant="danger" style="float: left;"><span>▼</span></igc-badge>
        <span style='color:green;float: right;'>${ctx.cell.value.toFixed(2)}</span>
        </div>`;
    }
}, false);

igRegisterScript("WebGridRowStylesHandler", () => {
    return {
        'background': (row) => (+row.data['Change'] < 0 && +row.data['YearlyChange'] < 0) ? '#FF000088' : '#00000000',
        'border': (row) => (+row.data['Change'] < 0 && +row.data['YearlyChange'] < 0) ? '2px solid' : '1px solid',
        'border-color': (row) => (+row.data['Change'] < 0 && +row.data['YearlyChange'] < 0) ? '#FF000099' : '#E9E9E9'
    };
}, true);

