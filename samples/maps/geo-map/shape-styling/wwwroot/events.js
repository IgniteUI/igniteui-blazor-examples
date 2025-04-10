//begin eventHandler
igRegisterScript("ShapeFileStyling", (o, e) => {
    // applying conditional styling based on Contient field loaded from DBF file
    var c = e.item.getFieldValue("Continent")
    if (c == "Africa") {
        e.shapeFill = "#ECB912"; 
    } else if (c == "Asia") {
        e.shapeFill = "#E11D1D";
    } else if (c == "Europe") {
        e.shapeFill = "#2894EC";
    } else if (c == "South America" || c == "North America") {
        e.shapeFill = "#0CC308";
    } else if (c == "Australia") {
        e.shapeFill = "#B42AE9";
    } else {
        e.shapeFill = "gray";
    }
    e.shapeOutline = "black";
}, false);
//end eventHandler

