
function toggleClipboardOperations() {
    grid.clipboardOptions.enabled = copyEnable.checked;
}

function toggleHeaderCopy() {
    grid.clipboardOptions.copyHeaders = headerCopy.checked;
}

function toggleFormatterCopy() {
    grid.clipboardOptions.copyFormatters = formatterCopy.checked;
}

function clearSelection() {
    grid.cellSelection = 'none';
    grid.cellSelection = 'multiple';
}

function inputChange() {
    grid.clipboardOptions.separator = input.value;
}


igRegisterScript("WebGridClipboardOperationsColumnInit", (e) => {
    var column = e.detail;
    column.formatter = (e) => { return "** " + e + " **" };
    column.header = "🎉" + column.field;
}, false);
