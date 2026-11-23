import { registerScript, html } from './_content/IgniteUI.Blazor/api.js';

registerScript("WebTreeGridPinHeaderTemplate", (ctx) => {
    window.toggleColumnPin = function toggleColumnPin(field) {
        var grid = document.getElementsByTagName("igc-tree-grid")[0];
        var col = grid.getColumnByName(field);
        col.pinned = !col.pinned;
        grid.markForCheck();
    }
    return html`<div style="display:flex;">
    <span>${ctx.column.field}</span>
    <span style="margin-left: auto; cursor: pointer;" onpointerdown='toggleColumnPin("${ctx.column.field}")'>📌</span>
</div>`;
});

