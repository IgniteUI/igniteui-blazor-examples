
igRegisterScript("WebGridGroupByRowTemplate", (ctx) => {
    var html = window.igTemplating.html;
    var groupRow = ctx.implicit;
    window.calc2017 = function calc2017(values) {
        const startDate = new Date('1/1/2017');
        const endDate = new Date('12/31/2017');
        return values.filter((x) => new Date(x.OrderDate) >= startDate && new Date(x.OrderDate) <= endDate).length;
    }
    return html`<div>
        <span style="color:#09f;">
                ${groupRow.expression.fieldName } :
        </span>
        <span>${groupRow.value}</span>
        <igc-badge>${groupRow.records.length}</igc-badge>
        <span style="color:#09f;"> Ordered in 2017:</span><span>${ calc2017(groupRow.records)}</span>
</div>`;
}, false);

igRegisterScript("WebGridBooleanCellTemplate", (ctx) => {
    var html = window.igTemplating.html;
    if (ctx.cell.value) {
        return html`<img src="https://static.infragistics.com/xplatform/images/grid/active.png" title="Continued" alt="Continued" />`
    } else {
        return html`<img src="https://static.infragistics.com/xplatform/images/grid/expired.png" title="Discontinued" alt="Discontinued" />`;
    }
}, false);

