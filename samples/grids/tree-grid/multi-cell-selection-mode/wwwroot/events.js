function RangeSelectionChanging(o, e) {
    var leftTreeGrid = document.querySelector("#leftTreeGrid");
    var rightGrid = document.querySelector("#rightGrid");
    rightGrid.data = leftTreeGrid.getSelectedData();
}

igRegisterScript("RangeSelectionChanging", RangeSelectionChanging, false);