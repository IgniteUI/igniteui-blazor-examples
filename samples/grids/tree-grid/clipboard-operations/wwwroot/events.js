var defaultSeparator;

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
    grid.clipboardOptions.separator = input.value || grid.clipboardOptions.separator;
}

igRegisterScript("WebTreeGridClipboardCustomOperationsRendered", (e) => {
    defaultSeparator = grid.clipboardOptions.separator;
}, false);

igRegisterScript("WebTreeGridClipboardCustomOperationsColumnInit", (e) => {
    var column = e.detail;
    column.formatter = (e) => { return "** " + e + " **" };
    column.header = "🎉" + column.field;
}, false);