

igRegisterScript("WebGridPinRowOnRendered", (event) => {
        var grid = document.getElementById("grid");
        grid.pinRow("ALFKI");
        grid.pinRow("AROUT");
}, false);

