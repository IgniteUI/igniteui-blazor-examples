

igRegisterScript("WebHierarchicalGridSetGridSize", (sender, evtArgs) => {
    var newVal = evtArgs.newValue.toLowerCase();
    var grid = document.getElementById("hierarchicalGrid");
    grid.style.setProperty('--ig-size', `var(--ig-size-${newVal})`);
}, false);

