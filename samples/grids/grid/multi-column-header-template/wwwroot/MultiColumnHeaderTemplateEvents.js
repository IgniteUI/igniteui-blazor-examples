const columnGroupStates = new Map();

function toggleColumnGroup(name) {
    var columnGroup = grid.columns.find((col) => col.header === name)
    const columns = columnGroup.children.toArray();

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
igRegisterScript("HeaderTemplate", (ctx) => {
    var html = window.igTemplating.html;
    var iconName = columnGroupStates.get(ctx.column.header) ? 'expand_more' : 'expand_less';
    return html`<div>
    <igc-icon name="${iconName}" collection="material" onclick='toggleColumnGroup("${ctx.column.header}")' ></igc-icon>
    <span>${ctx.column.header}</span>
</div>`;
}, false);