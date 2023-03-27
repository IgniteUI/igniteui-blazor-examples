

igRegisterScript("WebTreeGridEditingEventsCellEdit", (ev) => {
    var d = ev.detail;

    if (d.column != null && d.column.field == "Name") {
        if (d.newValue > d.rowData.Name) {
            d.cancel = true;
            alert("You cannot change the 'Name' field for this record!")
        }
    }
}, false);

