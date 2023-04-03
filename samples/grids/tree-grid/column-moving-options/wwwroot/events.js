
igRegisterScript("WebTreeGridPinHeaderTemplate", (ctx) => {
    var html = window.igTemplating.html;
    window.toggleColumnPin = function toggleColumnPin(field) {
        var grid = document.getElementsByTagName("igc-tree-grid")[0];
        var col = grid.getColumnByName(field);
        col.pinned = !col.pinned;
        grid.markForCheck();
    }
    return html`<div>
    <span style="float:left">${ctx.column.field}</span>
    <span style="float:right" onpointerdown='toggleColumnPin("${ctx.column.field}")'>📌</span>
</div>`;
}, false);

