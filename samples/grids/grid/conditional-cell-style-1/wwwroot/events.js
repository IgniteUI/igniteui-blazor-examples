
igRegisterScript("WebGridBeatsPerMinuteTemplate", (ctx) => {
    var html = window.igTemplating.html;

    var value = ctx.cell.value;

    if (value > 95) {
        return html`<span style="color: red">${value}</span>`;
    }
    else {
        return html`<span style="color: green">${value}</span>`;
    }
}, false);

igRegisterScript("WebGridTopSpeedTemplate", (ctx) => {
    var html = window.igTemplating.html;

    var value = ctx.cell.value;

    if (value < 5) {
        return html`<span style="color: royalblue">${value}</span>`;
    }
    else {
        return html`<span>${value}</span>`;
    }
}, false);

igRegisterScript("WebGridImageCellTemplate", (ctx) => {
    var html = window.igTemplating.html;
    return html`<div>
    <img src="${ctx.cell.value}"
    style="border: 1px solid black;
    object-fit: fill;
    height: 2rem;
    width: 3rem;"/>
 </div>`;
}, false);

