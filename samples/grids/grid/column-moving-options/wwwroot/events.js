
igRegisterScript("WebGridPinHeaderTemplate", (ctx) => {
    var html = window.igTemplating.html;
    window.toggleColumnPin = function toggleColumnPin(field) {
        var grid = document.getElementsByTagName("igc-grid")[0];
        var col = grid.getColumnByName(field);
        col.pinned = !col.pinned;
        grid.markForCheck();
    }
    return html`<div>
    <span style="float:left">${ctx.column.field}</span>
    <span style="float:right" onpointerdown='toggleColumnPin("${ctx.column.field}")'>📌</span>
</div>`;
}, false);

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

