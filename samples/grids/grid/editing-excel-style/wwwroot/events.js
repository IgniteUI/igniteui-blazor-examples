let shouldAppendValue = false;

igRegisterScript("onActiveNodeChange", (ev) => {
    const grid = ev.target;
    grid.endEdit();
    setTimeout(() => {
        (grid.getElementsByClassName("igx-grid__tbody-content")[0]).focus();
    }, 0);
}, false);

window.keydownHandler = (e) => {
    const grid = document.getElementById("grid1");
    if (!grid) return;

    const code = e.code;
    const active = grid.selectedCells?.[0];

    const isAlphaNum =
        (code >= 'Digit0' && code <= 'Digit9') ||
        (code >= 'KeyA' && code <= 'KeyZ') ||
        (code >= 'Numpad0' && code <= 'Numpad9');

    if (isAlphaNum && code !== 'Enter' && code !== 'NumpadEnter') {
        if (active && active.editMode === false) {
            active.editMode = true;
            active.editValue = e.key;
            shouldAppendValue = true;
            grid.markForCheck();
        } else if (active && active.editMode && shouldAppendValue) {
            active.editValue = `${active.editValue ?? ""}${e.key}`;
            shouldAppendValue = false;
        }
    }

    if (code === 'Backspace') {
        if (!active || active.editMode === false) return;
        const rowIndex = active.row.index;
        const columnKey = active.column.field;
        grid.data[rowIndex][columnKey] = '';
        grid.markForCheck();
    }

    if (code === 'Enter' || code === 'NumpadEnter') {
        if (!active) return;
        const thisRow = active.row.index;
        const dataView = grid.dataView;
        const nextIndex = window.getNextEditableRowIndex(thisRow, dataView, !!e.shiftKey);

        grid.navigateTo(nextIndex, active.column.visibleIndex, (obj) => {
            grid.clearCellSelection();
            obj.target.activate();
        });
    }
};

window.getNextEditableRowIndex = (currentRowIndex, dataView, previous) => {
    if (currentRowIndex < 0 || (currentRowIndex === 0 && previous) || (currentRowIndex >= dataView.length - 1 && !previous))
        return currentRowIndex;
    if (previous)
        return dataView.findLastIndex((_, i) => i < currentRowIndex && window.isEditableDataRecordAtIndex(i, dataView));
    return dataView.findIndex((_, i) => i > currentRowIndex && window.isEditableDataRecordAtIndex(i, dataView));
};

window.isEditableDataRecordAtIndex = (i, dataView) => {
    const rec = dataView[i];
    return !rec.expression && !rec.summaries && !rec.childGridsData && !rec.detailsData;
};
