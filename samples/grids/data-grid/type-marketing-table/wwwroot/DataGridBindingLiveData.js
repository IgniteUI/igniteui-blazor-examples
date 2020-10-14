// NOTE this JavaScript file implements functions for styling/templating columnd of the DataGrid control
// at end of this file, the igRegisterScript registers functions that are used .razor file

var valuesIncreasedColor = "#4EB862";
var valuesDecreasedColor = "#FF134A";
var valuesDecreasedBorder = "4px solid #FF134A";
var valuesIncreasedBorder = "4px solid #4EB862";

function onPriceStyleKey(column, args) {
    var data = column.i.grid.actualDataSource.dataSource;
    var row = null;
    if (column.i.grid) {
        row = column.i.grid.actualDataSource.getItemAtIndex(args.rowNumber);
    } else {
        row = data[args.rowNumber];
    }
    if (row.Change >= 0) {
        args.styleKey = "priceShiftUp";
    } else {
        args.styleKey = "priceShiftDown";
    }
}

function onPriceCellUpdating(grid, args) {
    let item = args.cellInfo.rowItem;
    let priceShiftUp = item.Change >= 0;
    let templ = args.cellInfo;

    if (args.isCanvasBased) {
        let resized = args.ensureCorrectSize();
        if (resized || args.cellInfo.isContentDirty) {
            args.renderStandardBackground();

            let context = args.context;

            let iconText = "trending_up";
            let iconColor = valuesIncreasedColor;

            let scale = window.devicePixelRatio;
            if (scale !== 1.0) {
                context.save();
                context.scale(scale, scale);
            }

            if (priceShiftUp) {
                iconText = "trending_up";
                iconColor = valuesIncreasedColor;
            } else {
                iconText = "trending_down";
                iconColor = valuesDecreasedColor;
            }

            // context.fillStyle = "blue";
            // context.fillRect(0,0,args.cellInfo.width,args.cellInfo.height);
            let txt = "$" + (+templ.value).toFixed(2);
            context.font = "13px Verdana";
            let width = context.measureText(txt).width;

            context.font = "13px 'Material Icons'";
            let iconWidth = context.measureText(iconText).width;

            let totalWidth = width + iconWidth;
            context.font = "13px Verdana";
            context.fillStyle = iconColor;
            context.textBaseline = "top";
            context.fillText(txt, templ.width - (totalWidth + 5), (templ.height / 2.0) - 7);

            context.font = "13px 'Material Icons'";
            context.fillStyle = iconColor;
            context.textBaseline = "top";
            context.fillText(iconText, templ.width - (iconWidth + 5), (templ.height / 2.0) - 7);

            if (scale !== 1.0) {
                context.restore();
            }
        }

        return;
    }

    var content = args.content;
    var sp;
    var icon;

    if (content.childElementCount > 0) {
        sp = content.children[0];
        icon = content.children[1];
    } else {
        content.style.textAlign = "right";
        sp = document.createElement("span");
        icon = document.createElement("span");
        sp.style.font = "13px Verdana";
        sp.style.verticalAlign = "center";
        content.appendChild(sp);
        content.appendChild(icon);
        icon.style.fontFamily = "Material Icons";
        icon.style.fontSize = "13px";
        icon.style.fontFeatureSettings = "liga";
        icon.style.verticalAlign = "center";
    }

    sp.textContent = "$" + (+templ.value).toFixed(2);

    if ((sp).__isUp === undefined ||
        (sp).__isUp !== priceShiftUp) {
        (sp).__isUp = priceShiftUp;
        if (priceShiftUp) {
            icon.textContent = "trending_up";
            icon.style.color = valuesIncreasedColor;
            sp.style.color = valuesIncreasedColor;
        } else {
            icon.textContent = "trending_down";
            icon.style.color = valuesDecreasedColor;
            sp.style.color = valuesDecreasedColor;
        }
    }
}

function onPricePercentStyleKey(grid, args) {
    if (args.resolvedValue >= 0) {
        args.styleKey = "pricePercentUp";
    } else {
        args.styleKey = "pricePercentDown";
    }
}

function onPricePercentCellUpdating(grid, args) {
    let templ = args.cellInfo;
    let priceShiftUp = templ.value >= 0;

    if (args.isCanvasBased) {
        let resized = args.ensureCorrectSize();
        if (resized || args.cellInfo.isContentDirty) {
            args.renderStandardBackground();

            let context = args.context;

            let iconColor = valuesIncreasedColor;

            let scale = window.devicePixelRatio;
            if (scale !== 1.0) {
                context.save();
                context.scale(scale, scale);
            }

            if (priceShiftUp) {
                iconColor = valuesIncreasedColor;
            } else {
                iconColor = valuesDecreasedColor;
            }

            // context.fillStyle = "blue";
            // context.fillRect(0,0,args.cellInfo.width,args.cellInfo.height);
            let txt = (+templ.value).toFixed(2) + "%";
            context.font = "13px Verdana";
            let width = context.measureText(txt).width;

            let totalWidth = width + 4;

            context.font = "13px Verdana";
            context.fillStyle = templ.textColor;
            context.textBaseline = "top";
            context.fillText(txt, templ.width - (totalWidth + 10), (templ.height / 2.0) - 7);

            context.font = "13px 'Material Icons'";
            context.fillStyle = iconColor;
            context.fillRect(templ.width - (5 + 4), (templ.height / 2.0) - 8, 4, 16);

            if (scale !== 1.0) {
                context.restore();
            }
        }

        return;
    }

    var content = args.content;
    var sp;

    if (content.childElementCount > 0) {
        sp = content.children[0];
    } else {
        content.style.textAlign = "right";
        sp = document.createElement("span");
        sp.style.font = "13px Verdana";
        sp.style.verticalAlign = "center";
        content.appendChild(sp);
    }

    sp.textContent = (+templ.value).toFixed(2) + "%";
    if ((sp).__isUp === undefined ||
        (sp).__isUp !== priceShiftUp) {
        (sp).__isUp = priceShiftUp;
        if (priceShiftUp) {
            sp.style.paddingRight = "5px";
            sp.style.borderRight = valuesIncreasedBorder;
            // sp.style.color = valuesIncreasedColor;
        } else {
            sp.style.paddingRight = "5px";
            sp.style.borderRight = valuesDecreasedBorder;
            // sp.style.color = valuesDecreasedColor;
        }
    }
}

function onPriceAmountStyleKey(grid, args) {
    if (args.resolvedValue >= 0) {
        args.styleKey = "priceAmountUp";
    } else {
        args.styleKey = "priceAmountDown";
    }
}

function onPriceAmountCellUpdating(grid, args) {
    let templ = args.cellInfo;
    let priceShiftUp = templ.value >= 0;

    if (args.isCanvasBased) {
        let resized = args.ensureCorrectSize();
        if (resized || args.cellInfo.isContentDirty) {
            args.renderStandardBackground();

            let context = args.context;
            let iconColor = valuesIncreasedColor;
            let scale = window.devicePixelRatio;
            if (scale !== 1.0) {
                context.save();
                context.scale(scale, scale);
            }

            if (priceShiftUp) {
                iconColor = valuesIncreasedColor;
            } else {
                iconColor = valuesDecreasedColor;
            }

            // context.fillStyle = "blue";
            // context.fillRect(0,0,args.cellInfo.width,args.cellInfo.height);
            let txt = (+templ.value).toFixed(2);
            context.font = "13px Verdana";
            let width = context.measureText(txt).width;

            let totalWidth = width + 4;
            context.font = "13px Verdana";
            context.fillStyle = templ.textColor;
            context.textBaseline = "top";
            context.fillText(txt, templ.width - (totalWidth + 10), (templ.height / 2.0) - 7);

            context.font = "13px 'Material Icons'";
            context.fillStyle = iconColor;
            context.fillRect(templ.width - (5 + 4), (templ.height / 2.0) - 8, 4, 16);

            if (scale !== 1.0) {
                context.restore();
            }
        }

        return;
    }

    var content = args.content;
    var sp;

    if (content.childElementCount > 0) {
        sp = content.children[0];
    } else {
        content.style.textAlign = "right";
        sp = document.createElement("span");
        sp.style.font = "13px Verdana";
        sp.style.verticalAlign = "center";
        content.appendChild(sp);
    }

    sp.textContent = (+templ.value).toFixed(2);

    if ((sp).__isUp === undefined ||
        (sp).__isUp !== priceShiftUp) {
        (sp).__isUp = priceShiftUp;
        if (priceShiftUp) {
            sp.style.paddingRight = "5px";
            sp.style.borderRight = valuesIncreasedBorder;
            // sp.style.color = valuesIncreasedColor;
        } else {
            sp.style.paddingRight = "5px";
            sp.style.borderRight = valuesDecreasedBorder;
            // sp.style.color = valuesDecreasedColor;
        }
    }
}

function onChartStyleKey(grid, args) {
    args.styleKey = "igComponent";
}

function onChartCellUpdating(grid, args) {
    if (args.isCanvasBased) {
        return;
    }

    let content = args.content;
    let icon;

    if (content.childElementCount > 0) {
        icon = content.children[0];
        icon.onclick = (e) => {
            // console.log("chart clicked!!")
            e.stopPropagation();
        }
    } else {
        icon = document.createElement("span");
        content.appendChild(icon);
        icon.style.fontFamily = "Material Icons";
        icon.style.fontSize = "13px";
        icon.style.fontFeatureSettings = "liga";
        icon.style.verticalAlign = "center";
        icon.textContent = "insertchart_outlined";
    }
}

function onGridStyleKey(grid, args) {
    args.styleKey = "grid";
}

function onGridCellUpdating(grid, args) {
    if (args.isCanvasBased) {
        return;
    }

    var content = args.content;
    var icon;

    if (content.childElementCount > 0) {
        icon = content.children[0];
        icon.onclick = (e) => {
            // console.log("grid clicked!!")
            e.stopPropagation();
        }
    } else {
        icon = document.createElement("span");
        content.appendChild(icon);
        icon.style.fontFamily = "Material Icons";
        icon.style.fontSize = "13px";
        icon.style.fontFeatureSettings = "liga";
        icon.style.verticalAlign = "center";
        icon.textContent = "tablechart";
    }
}

function onPriceDataBound(grid, args) {
    let item = args.cellInfo.rowItem;
    if (item === null) { return; }

    if (item.PriceHeat > 0) { // && this.state.heatChecked) {
        let p = +item.PriceHeat;
        let minA = 1.0;
        let maxA = 0.25;

        let maxR = 0.0;
        let minR = 1.0;
        let minG = 1.0;
        let maxG = 1.0;
        let minB = 1.0;
        let maxB = 0.0;

        let a = minA + (maxA - minA) * p;
        let r = minR + (maxR - minR) * p;
        let g = minG + (maxG - minG) * p;
        let b = minB + (maxB - minB) * p;
        r = Math.round(r * 255.0);
        g = Math.round(g * 255.0);
        b = Math.round(b * 255.0);

        let colorString = "rgba(" + r + "," + g + "," + b + "," + a + ")";
        args.cellInfo.background = colorString;
    }
    else if (item.PriceHeat < 0) { //  && this.state.heatChecked) {
        let p = +item.PriceHeat * -1.0;
        let minA = 1.0;
        let maxA = 0.25;

        let minR = 1.0;
        let maxR = 1.0;
        let minG = 1.0;
        let maxG = 0.0;
        let minB = 1.0;
        let maxB = 0.0;

        let a = minA + (maxA - minA) * p;
        let r = minR + (maxR - minR) * p;
        let g = minG + (maxG - minG) * p;
        let b = minB + (maxB - minB) * p;
        r = Math.round(r * 255.0);
        g = Math.round(g * 255.0);
        b = Math.round(b * 255.0);

        let colorString = "rgba(" + r + "," + g + "," + b + "," + a + ")";
        args.cellInfo.background = colorString;
    }
    else {
        args.cellInfo.background = "white";
    }
}

// this code allows calling above functions from a .razor file
igRegisterScript("onPriceStyleKey", onPriceStyleKey, false);
igRegisterScript("onPriceCellUpdating", onPriceCellUpdating, false);
igRegisterScript("onPriceDataBound", onPriceDataBound, false);
