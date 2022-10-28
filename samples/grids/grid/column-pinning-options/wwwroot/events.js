// this file contains events handlers and templates used in the razor page


igRegisterScript("WebGridPinHeaderTemplate", (ctx) => {
    var html = window.igTemplating.html;
    window.toggleColumnPin = function toggleColumnPin(field) {
        var col = grid.getColumnByName(field);
        col.pinned = !col.pinned;
        grid.markForCheck();
    }
    return html`<div>
    <span style="float:left">${ctx.column.field}</span>
    <span style="float:right" onclick='toggleColumnPin("${ctx.column.field}")'>📌</span>
</div>`;
}, false);


