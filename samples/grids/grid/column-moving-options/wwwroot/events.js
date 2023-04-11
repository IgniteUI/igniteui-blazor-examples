
igRegisterScript("WebGridPinHeaderTemplate", (ctx) => {
    var html = window.igTemplating.html;
    window.toggleColumnPin = function toggleColumnPin(field) {
        var grid = document.getElementsByTagName("igc-grid")[0];
        var col = grid.getColumnByName(field);
        col.pinned = !col.pinned;
        grid.markForCheck();
    }
    return html`<div>
    <span style="float:left">${ctx.column.header}</span>
    <span style="float:right" onpointerdown='toggleColumnPin("${ctx.column.field}")'>📌</span>
</div>`;
}, false);

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

