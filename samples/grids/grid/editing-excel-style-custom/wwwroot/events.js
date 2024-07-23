igRegisterScript("WebGridEditingExcelStyle", (ev) => {
    // Assuming `ev.detail.target` gives you the grid element or another relevant element
    var gridElement = ev.detail.target; // This is just an example; adjust based on actual structure

    // Attach the onkeydown event listener to the gridElement or a specific child element
    gridElement.addEventListener('keydown', (keydownEvent) => {
        // Handle the keydown event
        var key = keydownEvent.keyCode; // or `keydownEvent.which` for wider browser compatibility
        console.log(`Key pressed: ${key}`);

        // You can include your logic here, or call other functions as needed
    });

    // The rest of your existing logic...
}, false);

function getNextEditableRowIndex(currentRowIndex, dataView, previous) {
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

