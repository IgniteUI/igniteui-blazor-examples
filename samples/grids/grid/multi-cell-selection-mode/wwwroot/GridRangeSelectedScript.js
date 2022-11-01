function RangeSelectionChanging(o, e) {
    var g1 = document.querySelector("#grid1");
    var g2 = document.querySelector("#grid2");
    g2.data = g1.getSelectedData();
}

igRegisterScript("RangeSelectionChanging", RangeSelectionChanging, false);