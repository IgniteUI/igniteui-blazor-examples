
igRegisterScript("WebGridOrderDateSummaryTemplate", (ctx) => {
    var html = window.igTemplating.html;

    var summaryArray = ctx.$implicit;

    console.log(ctx);

    //var value = ctx.cell.value;

    return html`<div style="display: grid;">
            <span><strong>${summaryArray[0].label}: </strong></span><span>${summaryArray[0].summaryResult}</span>
            <span><strong>${summaryArray[1].label}: </strong></span><span>${summaryArray[1].summaryResult}</span>
        </div>`;
}, false);

