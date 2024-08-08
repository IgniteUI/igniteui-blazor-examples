igRegisterScript("WebGridEditingExcelStyle", (ev) => {
    // Assuming `ev.detail.target` gives you the grid element or another relevant element
    var gridElement = ev.detail.target; // This is just an example; adjust based on actual structure

    // Attach the onkeydown event listener to the gridElement or a specific child element
    gridElement.addEventListener('keydown', (keydownEvent) => {

    }, false);

});

var shouldAppendValue = false;

window.attachKeyDownEvent = () => {
    var grid1 = document.querySelectorAll("igc-grid")[0];

    grid1.addEventListener('activeNodeChange', (event) => {
        grid1.endEdit();
        (grid1.getElementsByClassName("igx-grid__tbody-content")[0]).focus();
    });

    grid1.addEventListener('keydown', (e) => {
        var code = e.code;
        var grid1 = window.grid1;
        var activeElem = grid1.selectedCells[0];

        if ((e.code >= 'Digit0' && e.code <= 'Digit9') ||
            (e.code >= 'KeyA' && e.code <= 'KeyZ') &&
            e.code !== 'Enter') {

            if (activeElem && activeElem.editMode === false) {
                activeElem.editMode = true;
                activeElem.editValue = e.key;
                shouldAppendValue = true;
                grid1.markForCheck();
            } else

                if (activeElem && activeElem.editMode && this.shouldAppendValue) {
                    e.preventDefault();
                    activeElem.editValue = activeElem.editValue + e.key;
                    shouldAppendValue = false;
                }
        }

        if (code === 'Backspace') {
            if (activeElem == null || activeElem.editMode == false) {
                return;
            }
            const rowIndex = activeElem.row.index;
            const columnKey = activeElem.column.field;

            grid1.data[rowIndex][columnKey] = '';
            grid1.markForCheck();

        }

        if (code === 'Enter') {

            if (activeElem == null) {
                return;
            }

            const thisRow = activeElem.row.index;
            const dataView = this.grid1.dataView;
            const nextRowIndex = this.getNextEditableRowIndex(thisRow, dataView, e.shiftKey);

            grid1.navigateTo(nextRowIndex, activeElem.column.visibleIndex, (obj) => {
                grid1.clearCellSelection();
                obj.target.activate();
            });
        }
    });
}

window.getNextEditableRowIndex = (currentRowIndex, dataView, previous) => {
    if (currentRowIndex < 0 || (currentRowIndex === 0 && previous) || (currentRowIndex >= dataView.length - 1 && !previous)) {
        return currentRowIndex;
    }
    if (previous) {
        return dataView.findLastIndex((rec, index) => index < currentRowIndex && this.isEditableDataRecordAtIndex(index, dataView));
    }
    return dataView.findIndex((rec, index) => index > currentRowIndex && this.isEditableDataRecordAtIndex(index, dataView));
}

function isEditableDataRecordAtIndex(dataViewIndex, dataView) {
    const rec = dataView[dataViewIndex];
    return !rec.expression && !rec.summaries && !rec.childGridsData && !rec.detailsData;
}

