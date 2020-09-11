// NOTE do not use typscript keywords or types, e.g. ":", "as", HTMLDivElement HTMLSpanElement etc

igRegisterScript("onUpdatingSalesColumn", (o, e) => {
    //console.log("onUpdatingSalesColumn called");
    const content = e.content;
    const info = e.cellInfo;
    const sales = info.rowItem.Sales;
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
        gauge.style.height = "6px";
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
}, false);

igRegisterScript("onUpdatingAddressColumn", (o, e) => {
    //console.log("onUpdatingAddressColumn called ");
    let content = e.content;
    let span1 = null;
    let span2 = null;
    let info = e.cellInfo;
    let item = info.rowItem;

    if (content.childElementCount === 0) {

        span1 = document.createElement("span");
        span2 = document.createElement("span");

        content.style.fontFamily = "Verdana";
        content.style.fontSize = "13px";
        content.style.verticalAlign = "center";
        content.style.lineHeight = "normal";
        content.style.display = "flex";
        content.style.flexDirection = "column";
        content.style.justifyContent = "center";
        content.style.height = "100%";
        content.style.width = "100%";

        content.appendChild(span1);
        content.appendChild(span2);
    }
    else {
        span1 = content.children[0];
        span2 = content.children[1];
    }

    if (span1 && span2) {
        span1.textContent = item.Street;
        span2.textContent = item.City + ", " + item.Country;
    }
}, false);