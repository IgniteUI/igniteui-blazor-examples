var defaultSeparator;
var grid;

function toggleClipboardOperations() {
    grid.clipboardOptions.enabled = !grid.clipboardOptions.enabled;
}

function toggleHeaderCopy() {
    grid.clipboardOptions.copyHeaders = !grid.clipboardOptions.copyHeaders;
}

function toggleFormatterCopy() {
    grid.clipboardOptions.copyFormatters = !grid.clipboardOptions.copyFormatters;
}

function clearSelection() {
    grid.clearCellSelection();
}

function inputChange() {
    grid.clipboardOptions.separator = input.value || defaultSeparator;
}

igRegisterScript("WebTreeGridClipboardCustomOperationsRendered", (e) => {
    grid = e.target;
    defaultSeparator = grid.clipboardOptions.separator;
}, false);

igRegisterScript("WebTreeGridClipboardCustomOperationsColumnInit", (e) => {
    var column = e.detail;
    column.formatter = (e) => { return "** " + e + " **" };
    column.header = "🎉" + column.field;
}, false);