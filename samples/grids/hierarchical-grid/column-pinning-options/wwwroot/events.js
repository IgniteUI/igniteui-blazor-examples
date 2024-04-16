
igRegisterScript("HierarchicalGridPinHeaderTemplate", (ctx) => {
    var html = window.igTemplating.html;
    window.toggleColumnPin = function toggleColumnPin(column) {
            column.pinned = !column.pinned;
    }
    return html`<div>
    <span style="float:left">${ctx.column.field}</span>
    <span style="float:right" @pointerdown=${() => toggleColumnPin(ctx.column)}>📌</span>
</div>`;
}, false);

