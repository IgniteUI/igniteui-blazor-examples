
igRegisterScript("HierarchicalGridThemingPhotoCellTemplate", (ctx) => {
    var html = window.igTemplating.html;
    return html`<div class="cell__inner_2">
    <img src="${ctx.cell.value}" class="photo" />
</div>`;
}, false);

// Show the debut year as is, without a thousands separator.
igRegisterScript("HierarchicalGridThemingDebutFormatter", (value) => {
    return value;
}, false);
