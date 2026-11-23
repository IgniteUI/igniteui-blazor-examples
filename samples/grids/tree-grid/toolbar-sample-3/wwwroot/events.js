import { registerScript, html } from './_content/IgniteUI.Blazor/api.js';

registerScript("WebTreeGridAvatarCellTemplate", (ctx) => {
    return html`<div style="display: flex; align-items: center;">
    <igc-avatar shape="circle" src="${ctx.cell.row.data.Avatar}">
    </igc-avatar>
    <span style="margin-left: 30px;">${ctx.cell.value}</span>
</div>`;
});

registerScript("WebTreeGridToolbarExporting", (evt) => {
    const args = evt.detail;
    const options = args.options;
    options.fileName = `Report_${new Date().toDateString()}`;
    args.exporter.columnExporting.subscribe((columnArgs) => {
        columnArgs.cancel = columnArgs.header === 'Name';
    });
});

