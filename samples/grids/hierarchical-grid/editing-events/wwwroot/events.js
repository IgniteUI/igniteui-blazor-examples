

igRegisterScript("WebGridEditingEventsCellEdit", (ev) => {
    var d = ev.detail;

    if (d.column != null && d.column.field == "UnitsOnOrder") {
        if (d.newValue > d.rowData.UnitsInStock) {
            d.cancel = true;
            alert("You cannot order more than the units in stock!")
        }
    }
}, false);

