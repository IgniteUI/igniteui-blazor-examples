
igRegisterScript("WebTreeGridProductNameTemplate", (ctx) => {
    var html = window.igTemplating.html;

    var value = ctx.cell.value;

    if (value == "Grandmas Boysenberry Spread" || value == "Mishi Kobe Niku" || value == "Carnarvon Tigers" || value == "Ikura") {
        return html`<span style="color: royalblue">${value}</span>`;
    }
    else {
        return html`<span>${value}</span>`;
    }
}, false);

igRegisterScript("WebTreeGridUnitPriceTemplate", (ctx) => {
    var html = window.igTemplating.html;

    var value = ctx.cell.value;

    if (value <= 25) {
        return html`<span style="color: green">${value}</span>`;
    }
    else {
        return html`<span style="color: red">${value}</span>`;
    }
}, false);

