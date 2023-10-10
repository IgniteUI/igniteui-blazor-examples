

igRegisterScript("WebGridPinRowOnRendered", (event) => {
        var grid = document.getElementById("grid");
        grid.data = [...grid.data];
        grid.pinRow("ALFKI");
        grid.pinRow("AROUT");
}, false);

