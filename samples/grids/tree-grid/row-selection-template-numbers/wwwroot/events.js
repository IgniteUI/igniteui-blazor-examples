
igRegisterScript("WebGridRowSelectorTemplate", (ctx) => {
    var html = window.igTemplating.html;
    if (ctx.$implicit.selected) {
        return html`<div style="justify-content: space-evenly;display: flex;width: 70px;">
    <span> ${ctx.$implicit.index}</span>
<igc-checkbox checked></igc-checkbox>
</div>`;
    } else {
        return html`<div style="justify-content: space-evenly;display: flex;width: 70px;">
    <span> ${ctx.$implicit.index}</span>
<igc-checkbox></igc-checkbox>
</div>`;
    }
}, false);

igRegisterScript("WebGridHeaderRowSelectorTemplate", (ctx) => {
    var html = window.igTemplating.html;
    return html`<div style="width: 70px;height: 60px;display: flex;">
    <img src="https://www.infragistics.com/angular-demos-lob/assets/images/card/avatars/igLogo.png" class="header-image">
</div>`;
}, false);

