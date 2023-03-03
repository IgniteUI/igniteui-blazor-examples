
igRegisterScript("WebGridCurrencyCellTemplate", (ctx) => {
    var html = window.igTemplating.html;
    if (ctx.cell.value > 0) {
        return html`<div>
        <igc-badge variant="success"><span>▲</span></igc-badge>
        <span style='color:green;'>${ctx.cell.value}</span>
        </div>`;
    } else {
        return html`<div>
        <igc-badge variant="danger"><span>▼</span></igc-badge>
        <span style='color:red;'>${ctx.cell.value}</span>
        </div>`;
    }
}, false);

