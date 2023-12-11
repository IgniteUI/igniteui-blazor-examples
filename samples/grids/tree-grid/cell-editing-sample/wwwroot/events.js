
igRegisterScript("WebTreeGridCellEditCellTemplate", (ctx) => {
    var html = window.igTemplating.html;
    let cellValues = [];
    let uniqueValues = [];
    for (const item of ctx.cell.grid.data) {
        const field = ctx.cell.column.field;
		const value = item[field];
        if (uniqueValues.indexOf(value) === -1 && value !== "") {
            if (ctx.cell.value == value) {
                cellValues.push(html`<igc-select-item selected value=${value}>${(value)}</igc-select-item>`);
            } else cellValues.push(html`<igc-select-item value=${value}>${(value)}</igc-select-item>`);
            uniqueValues.push(value);
        }
    }
    return html`
    <igc-select style="width:100%; height:100%" size="large" @igcChange=${e => ctx.cell.editValue = e.detail.value}>
          ${cellValues}
    </igc-select>
`
}, false);

