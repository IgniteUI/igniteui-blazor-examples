
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

