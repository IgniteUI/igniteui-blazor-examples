

igRegisterScript("WebTreeGridChangeSummaryCalculationMode", (sender, evtArgs) => {
    var treeGrid = document.getElementById("treeGrid");
	treeGrid.summaryCalculationMode = evtArgs.newValue;
}, false);

igRegisterScript("WebTreeGridChangeSummaryPosition", (sender, evtArgs) => {
    var treeGrid = document.getElementById("treeGrid");
	treeGrid.summaryPosition = evtArgs.newValue;
}, false);

