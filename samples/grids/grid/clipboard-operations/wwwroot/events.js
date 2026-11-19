import { registerScript } from './_content/IgniteUI.Blazor/api.js';

registerScript("WebGridClipboardCustomOperationsRendered", (e) => {
    const grid = e.target;
    const defaultSeparator = grid.clipboardOptions.separator;

    // the page's switches and input call these by name, so they go on window,
    // bound to the grid that rendered
    window.toggleClipboardOperations = () => {
        grid.clipboardOptions.enabled = !grid.clipboardOptions.enabled;
    };
    window.toggleHeaderCopy = () => {
        grid.clipboardOptions.copyHeaders = !grid.clipboardOptions.copyHeaders;
    };
    window.toggleFormatterCopy = () => {
        grid.clipboardOptions.copyFormatters = !grid.clipboardOptions.copyFormatters;
    };
    window.clearSelection = () => {
        grid.clearCellSelection();
    };
    window.inputChange = () => {
        grid.clipboardOptions.separator = document.getElementById("input").value || defaultSeparator;
    };
});

registerScript("WebGridClipboardCustomOperationsColumnInit", (e) => {
    var column = e.detail;
    column.formatter = (e) => { return "** " + e + " **" };
    column.header = "🎉" + column.field;
});
