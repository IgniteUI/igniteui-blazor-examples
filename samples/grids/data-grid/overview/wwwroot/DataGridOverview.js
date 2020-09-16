// NOTE this JavaScript file implements functions for styling/templating columnd of the DataGrid control
// at end of this file, the igRegisterScript registers functions that are used .razor file

function onUpdatingSalesColumn(grid, args) {
    let content = args.content;
    let info = args.cellInfo;
    let sales = info.rowItem.Sales;
    let gaugeValue = null;
    let gaugeBar = null;

    if (content.childElementCount === 0) {
        gaugeValue = document.createElement("span");
        gaugeValue.style.margin = "0px";
        gaugeValue.style.marginTop = "2px";
        gaugeValue.style.padding = "0px";
        gaugeValue.style.fontFamily = "Verdana";
        gaugeValue.style.fontSize = "13px";
        gaugeValue.style.textAlign = "center";

        gaugeBar = document.createElement("div");
        gaugeBar.style.background = "#7f7f7f";
        gaugeBar.style.padding = "0px";
        gaugeBar.style.margin = "0px";
        gaugeBar.style.height = "6px";
        gaugeBar.style.left = "0px";
        gaugeBar.style.top = "0px";
        gaugeBar.style.position = "relative";

        const gauge = document.createElement("div");
        gauge.style.background = "#dddddd";
        gauge.style.padding = "0px";
        gauge.style.margin = "0px";
        gauge.style.height = "4px";
        gauge.style.marginTop = "8px";
        gauge.style.width = "100%";
        gauge.appendChild(gaugeBar);

        content.style.verticalAlign = "center";
        content.style.lineHeight = "normal";
        content.style.display = "flex";
        content.style.flexDirection = "column";
        content.style.justifyContent = "center";
        content.style.height = "100%";
        content.style.width = "calc(100% - 2rem)";
        content.style.marginRight = "1rem";
        content.style.marginLeft = "1rem";

        content.appendChild(gauge);
        content.appendChild(gaugeValue);
    } else {
        const gauge = content.children[0];
        gaugeBar = gauge.children[0];
        gaugeValue = content.children[1];
    }

    // conditional formatting:
    if (sales < 400000) {
        gaugeValue.style.color = "rgb(211, 17, 3)";
        gaugeBar.style.background = "rgb(211, 17, 3)";
    }
    else if (sales < 650000) {
        gaugeValue.style.color = "Orange";
        gaugeBar.style.background = "Orange";
    }
    else {
        gaugeValue.style.color = "rgb(21, 190, 6)";
        gaugeBar.style.background = "rgb(21, 190, 6)";
    }

    let gaugeWidth = (sales / 990000) * 100;
    gaugeWidth = Math.min(100, gaugeWidth);
    gaugeBar.style.width = gaugeWidth + "%";

    gaugeValue.textContent = "$" + sales / 1000 + ",000";
}

function onUpdatingAddressColumn(grid, args) {
    let content = args.content;
    let info = args.cellInfo;
    let item = info.rowItem;
    let span1 = null;
    let span2 = null;

    if (content.childElementCount === 0) {
        content.style.fontFamily = "Verdana";
        content.style.fontSize = "13px";
        content.style.verticalAlign = "center";
        content.style.lineHeight = "normal";
        content.style.display = "flex";
        content.style.flexDirection = "column";
        content.style.justifyContent = "center";
        content.style.height = "100%";
        content.style.width = "100%";
        content.style.color = "rgb(24, 29, 31)";
        // stacking above elements in the content of grid's cell
        span1 = document.createElement("span");
        span2 = document.createElement("span");
        content.appendChild(span1);
        content.appendChild(span2);
    }
    else {
        span1 = content.children[0];
        span2 = content.children[1];
    }

    if (span1 && span2) {
        // updating elements in the content of grid's cell
        span1.textContent = item.Street;
        span2.textContent = item.City + ", " + item.Country;
    }
}

function onUpdatingPhoneColumn(grid, args) {
    let content = args.content;
    let info = args.cellInfo;
    let item = info.rowItem;
    let link = null;

    if (content.childElementCount === 0) {
        link = document.createElement("a");
        content.style.verticalAlign = "center";
        content.style.justifyContent = "center"; 
        content.style.lineHeight = "normal";
        content.style.display = "inline-block";
        // content.style.display = "inline-grid";
        content.style.fontFamily = "Verdana";
        content.style.fontSize = "13px";
        content.style.color = "#4286f4";
        content.style.width = "100%";

        content.appendChild(link);
    } else {
        link = content.children[0];
    }

    link.href = "tel:" + item.Phone;
    link.textContent = item.Phone;
}

// this code allows calling above functions from a .razor file
igRegisterScript("onUpdatingSalesColumn", onUpdatingSalesColumn, false);
igRegisterScript("onUpdatingAddressColumn", onUpdatingAddressColumn, false);
igRegisterScript("onUpdatingPhoneColumn", onUpdatingPhoneColumn, false);