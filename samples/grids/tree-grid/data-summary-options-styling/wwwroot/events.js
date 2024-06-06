
igRegisterScript("WebTreeGridSummariesHeaderTemplate", (ctx) => {
    var html = window.igTemplating.html;
    window.toggleSummary = function toggleSummary(column) {
        column.hasSummary = !column.hasSummary;
    }
    return html`<div>
    <span style="float:left">${ctx.column.field}</span>
	<span style="float:right; color:${ctx.column.hasSummary ? '#e41c77' : ''}" @pointerdown=${() => toggleSummary(ctx.column)}>∑</span>
</div>`;
}, false);

