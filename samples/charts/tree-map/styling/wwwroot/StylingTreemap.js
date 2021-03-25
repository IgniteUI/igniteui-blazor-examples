var styles = {
    "Asia": { outline: "black", fill: "#8BDC5C" },
    "Africa": { outline: "black", fill: "#735656" },
    "Europe": { outline: "black", fill: "#8B5BB1" },
    "North America": { outline: "black", fill: "#8CE7D9" },
    "Central America": { outline: "black", fill: "#F7D262" },
    "South America": { outline: "black", fill: "#EE5879" },
    "Oceania": { outline: "black", fill: "#A8A8B7" },
}; 

function onStyleTreeNode(o, e) {

    if (e.parentLabel != null) {
        var style = styles[e.parentLabel];
        if (style) {
            e.style.fill = style.fill;
        }
    }

};

igRegisterScript("onStyleTreeNode", onStyleTreeNode, false);