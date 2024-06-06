

igRegisterScript("WebGridSetRowPinning", (sender, evtArgs) => {
    var item = sender;
    var newVal = item.primitiveValue;
    var grid = document.getElementById("treeGrid") || document.getElementById("grid");
    grid.pinning.rows = newVal === "Top" ? 0 : 1;
}, false);

igRegisterScript("WebTreeGridPinRowOnRendered", (event) => {
        var treeGrid = document.getElementById("treeGrid") || document.getElementById("grid");
        treeGrid.data = [...treeGrid.data];
        treeGrid.pinRow(1);
        treeGrid.pinRow(11);
}, false);

