import { registerScript, html } from './_content/IgniteUI.Blazor/api.js';

// App.razor registers the icons in this collection.
const icons = 'overview-inventory';

const storageIcons = {
    Chilled: 'ac_unit',
    Dry: 'format_color_reset',
    Ambient: 'thermostat'
};

registerScript('InventoryProductTemplate', ({ cell }) => html`
    <div class="inventory-product">
        <img src=${cell.row.data.Image} alt="" />
        <span class="ig-typography__subtitle-2">${cell.value}</span>
    </div>`);

registerScript('InventoryStorageTemplate', ({ cell }) => html`
    <igc-chip class="inventory-storage" data-storage=${cell.value} outlined tabindex="-1">
        <igc-icon slot="prefix" name=${storageIcons[cell.value]} collection=${icons}></igc-icon>
        ${cell.value}
    </igc-chip>`);

registerScript('InventoryStockLevelTemplate', ({ cell }) => html`
    <igc-linear-progress
        class="inventory-stock-level"
        value=${cell.value}
        variant=${cell.row.data.Status === 'Low' ? 'warning' : 'success'}
        animation-duration="0"
        hide-label
        aria-label="Stock level ${cell.value}%"></igc-linear-progress>`);

registerScript('InventoryStatusTemplate', ({ cell }) => html`
    <div class="inventory-status" data-status=${cell.value}>
        <igc-badge dot aria-hidden="true"></igc-badge>
        ${cell.value}
    </div>`);

// The action buttons keep their clicks and Enter and Space presses from the grid. A click on a
// row toggles its selection, and the keyboard navigation acts on the active cell: Space toggles
// the row selection and cancels the button press.
function onActionKeydown(event) {
    if (event.key === 'Enter' || event.key === ' ') {
        event.stopPropagation();
    }
}

registerScript('InventoryActionsTemplate', ({ cell }) => {
    const product = cell.row.data.ProductName;
    const onEdit = (event) => {
        event.stopPropagation();
        editRow(cell);
    };
    const onDelete = (event) => {
        event.stopPropagation();
        cell.row.delete();
    };
    return html`
        <div class="inventory-actions">
            <igc-icon-button variant="flat" name="edit" collection=${icons} aria-label="Edit ${product}"
                @click=${onEdit} @keydown=${onActionKeydown}></igc-icon-button>
            <igc-icon-button variant="flat" name="delete" collection=${icons} aria-label="Delete ${product}"
                @click=${onDelete} @keydown=${onActionKeydown}></igc-icon-button>
        </div>`;
});

function editRow(cell) {
    const [first] = cell.row.cells
        .filter((c) => c.editable && c.column.visibleIndex >= 0)
        .sort((a, b) => a.column.visibleIndex - b.column.visibleIndex);
    // Activate the cell first: with the Actions cell still active, Tab and Escape would not act on the edited row.
    cell.grid.navigateTo(first.row.index, first.column.visibleIndex, ({ target }) => {
        target.activate();
        first.editMode = true;
    });
}
