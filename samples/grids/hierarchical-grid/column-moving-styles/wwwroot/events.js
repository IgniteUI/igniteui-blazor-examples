
igRegisterScript("HierarchicalGridPinHeaderTemplate", (ctx) => {
    var html = window.igTemplating.html;
    window.toggleColumnPin = function toggleColumnPin(column) {
            column.pinned = !column.pinned;
    }
    return html`<div style="display:flex;">
    <span>${ctx.column.field}</span>
    <span style="margin-left: auto;" @click=${() => toggleColumnPin(ctx.column)}>📌</span>
</div>`;
}, false);

