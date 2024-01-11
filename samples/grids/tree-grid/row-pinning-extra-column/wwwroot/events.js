
igRegisterScript("WebTreeGridRowPinCellTemplate", (ctx) => {
    var html = window.igTemplating.html;
    window.toggleRowPin = function toggleRowPin(index) {
        var treeGrid = document.getElementsByTagName("igc-tree-grid")[0];
        treeGrid.getRowByIndex(index).pinned = !treeGrid.getRowByIndex(index).pinned;
    }
    const index = ctx.cell.id.rowIndex;
    return html`<div>
    <span onpointerdown='toggleRowPin("${index}")'>📌</span>
</div>`;
}, false);

