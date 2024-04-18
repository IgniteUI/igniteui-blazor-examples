

igRegisterScript("WebRowIslandCellSelectionChange", (sender, evtArgs) => {
    const rowIsland = document.getElementsByTagName("igc-row-island")[0];
    rowIsland.cellSelection = evtArgs.newValue.toLocaleLowerCase();
}, false);

