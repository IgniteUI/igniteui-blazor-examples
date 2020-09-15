function onAvgSaleCellUpdating(column, args) {
    let row = args.cellInfo.rowItem;
    let priceShiftUp = row.Change >= 0;
    let templ = args.cellInfo;

    let content = args.content;
    let sp = null;
    let icon = null;

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
    
    if (priceShiftUp) {        
        icon.style.color = "#4EB862";
        sp.style.color = "#4EB862";
    } else {     
        icon.style.color = "#FF134A";
        sp.style.color = "#FF134A";
    }    
}

function onChangeCellUpdating(column, args) {
    let templ = args.cellInfo;
    let priceShiftUp = templ.value >= 0;

    let content = args.content;
    let sp = null;

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
    
    if (priceShiftUp) {
        sp.style.paddingRight = "5px";
        sp.style.borderRight = "4px solid #4EB862";        
    } else {
        sp.style.paddingRight = "5px";
        sp.style.borderRight = "4px solid #FF134A";        
    }   
}

function onPercentChangeCellUpdating(column, args) {
    let templ = args.cellInfo;
    let priceShiftUp = templ.value >= 0;

    let content = args.content;
    let sp = null;

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
    
    if (priceShiftUp) {
        sp.style.paddingRight = "5px";
        sp.style.borderRight = "4px solid #4EB862";        
    } else {
        sp.style.paddingRight = "5px";
        sp.style.borderRight = "4px solid #FF134A";        
    }
}

function onKPIColumnDataBound(column, args) {
    let value = args.resolvedValue;
    if (value < 20.0) {
        if (args.cellInfo.background !== "red") {
            args.cellInfo.background = "#FF134A";
        }
    }

    if (value > 80.0) {
        if (args.cellInfo.background !== "green") {
            args.cellInfo.background = "#4EB862";
        }
    }
}

igRegisterScript("onAvgSaleCellUpdating", onAvgSaleCellUpdating, false);
igRegisterScript("onChangeCellUpdating", onChangeCellUpdating, false);
igRegisterScript("onPercentChangeCellUpdating", onPercentChangeCellUpdating, false);
igRegisterScript("onKPIColumnDataBound", onKPIColumnDataBound, false);