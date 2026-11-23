import { registerScript, html } from './_content/IgniteUI.Blazor/api.js';

registerScript("WebTreeGridSummariesHeaderTemplate", (ctx) => {
    window.toggleSummary = function toggleSummary(column) {
        column.hasSummary = !column.hasSummary;
    }
    return html`<div>
    <span style="float:left">${ctx.column.field}</span>
	<span style="float:right; color:${ctx.column.hasSummary ? '#e41c77' : ''}" @pointerdown=${() => toggleSummary(ctx.column)}>∑</span>
</div>`;
});

