

igRegisterScript("WebTreeGridPinRowOnRendered", (event) => {
        var treeGrid = document.getElementById("treeGrid") || document.getElementById("grid");
        treeGrid.data = [...treeGrid.data];
        treeGrid.pinRow(1);
        treeGrid.pinRow(11);
}, false);

