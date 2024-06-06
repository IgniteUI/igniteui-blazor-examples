

igRegisterScript("WebHierarchicalGridPinRowOnRendered", (event) => {
	var hierarchicalGrid = document.getElementById("grid");
	hierarchicalGrid.pinRow(hierarchicalGrid.data[0].Photo);
	hierarchicalGrid.pinRow(hierarchicalGrid.data[1].Photo);
}, false);

