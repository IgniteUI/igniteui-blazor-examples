

igRegisterScript("WebGridClearSelection", (event) => {
    console.log("TODO WebGridClearSelection");
}, false);

igRegisterScript("WebGridClipboardOperationsColumnInit", (e) => {
    var column = e.detail;
    column.formatter = columnFormatter;
    column.header = "🎉" + column.field;
}, false);

