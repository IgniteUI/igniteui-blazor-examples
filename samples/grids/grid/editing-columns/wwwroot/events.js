import { registerScript, html } from './_content/IgniteUI.Blazor/api.js';

registerScript("WebGridNumericColEditCellTemplate", (ctx) => {
    const cell = ctx.cell;
    const columnName = cell.column.field;
    const cellValue = cell.row.data[columnName];
    const rowId = cell.id.rowID;
    const columnId = cell.id.columnID;
    const inputTemplateId = `edit-cell-${rowId}-${columnId}`;

    return html`
        <igc-input
            type="number"
            id="${inputTemplateId}"
            name="${cell.id.rowID}"
            style="width: 100%;"
            value="${cellValue}"
            @igcChange=${(e) => {
                cell.editValue = e.detail;
            }}>
        </igc-input>`
});

registerScript("WebGridOnEditEnter", (evtArgs) => {
    const column = evtArgs.detail.column;
    if(column.field === 'ReorderLevel') {
        setTimeout(() => {
            const rowId = evtArgs.detail.cellID.rowID;
            const columnId = evtArgs.detail.cellID.columnID;
            const inputTemplateId = `edit-cell-${rowId}-${columnId}`;
            const element = document.getElementById(inputTemplateId);
            element?.focus();
        });
    }
});

