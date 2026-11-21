import { registerScript, html } from './_content/IgniteUI.Blazor/api.js';

// App.razor registers these icons in the "material" collection.
const storageIcons = {
    Chilled: 'ac_unit',
    Dry: 'format_color_reset',
    Ambient: 'thermostat'
};

/** Starts row editing in the first editable cell, the same as a double click on that cell. */
function editRow(row) {
    const grid = row.grid;
    const [column] = grid.visibleColumns
        .filter((c) => c.editable)
        .sort((a, b) => a.visibleIndex - b.visibleIndex);
    // Activate the cell first, so that Tab, Enter and Escape work in the row as usual.
    grid.navigateTo(row.index, column.visibleIndex, ({ target }) => {
        target.activate();
        grid.getCellByKey(row.key, column.field).editMode = true;
    });
}

/** Clicks and Space/Enter stay with the buttons, so the grid does not also select the row or edit its active cell. */
function keepFromGrid(event) {
    if (!(event instanceof KeyboardEvent) || event.key === ' ' || event.key === 'Enter') {
        event.stopPropagation();
    }
}

registerScript('InventoryProductTemplate', ({ cell }) => html`
    <div class="product">
        <img class="product__photo" src=${cell.row.data.Image} alt="" />
        <span class="product__name">${cell.value}</span>
    </div>
`);

registerScript('InventoryStorageTemplate', ({ cell }) => html`
    <igc-chip class="storage" data-storage=${cell.value} outlined tabindex="-1">
        <igc-icon slot="prefix" name=${storageIcons[cell.value]} collection="material" aria-hidden="true"></igc-icon>
        ${cell.value}
    </igc-chip>
`);

registerScript('InventoryStockLevelTemplate', ({ cell }) => html`
    <igc-linear-progress
        class="stock-level"
        value=${cell.value}
        variant=${cell.row.data.Status === 'Low' ? 'warning' : 'success'}
        hide-label
        animation-duration="0"
        aria-label=${`Stock level ${cell.value}%`}>
    </igc-linear-progress>
`);

registerScript('InventoryStatusTemplate', ({ cell }) => html`
    <div class="status">
        <igc-badge class="status__dot" data-status=${cell.value} dot aria-hidden="true"></igc-badge>
        <span class="status__text">${cell.value}</span>
    </div>
`);

registerScript('InventoryActionsTemplate', ({ cell }) => {
    const row = cell.row;
    return html`
        <div class="actions" @click=${keepFromGrid} @keydown=${keepFromGrid}>
            <igc-icon-button
                variant="flat"
                name="edit"
                collection="material"
                aria-label=${`Edit ${row.data.ProductName}`}
                @click=${() => editRow(row)}>
            </igc-icon-button>
            <igc-icon-button
                variant="flat"
                name="delete"
                collection="material"
                aria-label=${`Delete ${row.data.ProductName}`}
                @click=${() => row.grid.deleteRow(row.key)}>
            </igc-icon-button>
        </div>
    `;
});
