
igRegisterScript("WebTreeGridAvatarCellTemplate", (ctx) => {
    var html = window.igTemplating.html;
    return html`<div style="display: flex; align-items: center;">
    <igc-avatar shape="circle" src="${ctx.cell.row.data.Avatar}">
    </igc-avatar>
    <span style="margin-left: 30px;">${ctx.cell.value}</span>
</div>`;
}, false);

igRegisterScript("WebTreeGridToolbarExporting", (evt) => {
    const args = evt.detail;
    const options = args.options;
    options.fileName = `Report_${new Date().toDateString()}`;
    args.exporter.columnExporting.subscribe((columnArgs) => {
        columnArgs.cancel = columnArgs.header === 'Name';
    });
}, false);

