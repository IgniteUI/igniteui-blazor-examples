function getDockManagerOffset() {
    var dockManager = document.querySelector("igc-dockmanager");

    if (dockManager != null) {
        var width = dockManager.offsetWidth;
        return width;
    }
}