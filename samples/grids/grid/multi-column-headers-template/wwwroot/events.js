
const columnGroupStates = new Map();
function toggleColumnGroup(name) {
    const grid = document.getElementsByTagName("igc-grid")[0];
    var columnGroup = grid.columns.find((col) => col.header === name)
    const columns = columnGroup.childColumns;
    if (columnGroup.header === 'General Information') {
        const col = columns[1];
        col.hidden = !col.hidden;
    } else if (columnGroup.header === 'Address Information') {
        for (const col of columns) {
            col.hidden = !col.hidden;
        }
    }
    columnGroupStates.set(name, !columnGroupStates.get(name));
}
igRegisterScript("WebGridColumnGroupHeaderTemplate", (ctx) => {
    var html = window.igTemplating.html;
    var iconName = columnGroupStates.get(ctx.column.header) ? '🔽' : '🔼';
    return html`<div>
    <span draggable="false" onclick='toggleColumnGroup("${ctx.column.header}")'>${iconName}</span>
    <span>${ctx.column.header}</span>
</div>`;
}, false);

