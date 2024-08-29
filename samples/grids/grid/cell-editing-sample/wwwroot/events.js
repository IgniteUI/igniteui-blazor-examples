
igRegisterScript("WebGridCellEditCellTemplate", (ctx) => {
    var html = window.igTemplating.html;
    let cellValues = [];
    let uniqueValues = [];
    for (const i of ctx.cell.grid.data) {
        const field = ctx.cell.column.field;
        if (uniqueValues.indexOf(i[field]) === -1) {
            if (ctx.cell.value == i[field]) {
                cellValues.push(html`<igc-select-item selected value=${i[field]}>${(i[field])}</igc-select-item>`);
            } else cellValues.push(html`<igc-select-item value=${i[field]}>${(i[field])}</igc-select-item>`);
            uniqueValues.push(i[field]);
        }
    }
    return html`
    <igc-select style="width:100%; height:100%; --ig-size: var(--ig-size-large);" @igcChange=${e => ctx.cell.editValue = e.detail.value}>
          ${cellValues}
    </igc-select>
`
}, false);

