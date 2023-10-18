
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

igRegisterScript("WebGridBeatsPerMinuteCellClassesHandler", () => {
    return {
        upFont: (rowData, columnKey) => rowData[columnKey] > 95,
        downFont: (rowData, columnKey) => rowData[columnKey] <= 95
    };
}, true);

igRegisterScript("WebGridTopSpeedCellClassesHandler", () => {
    return {
        topSpeed: (rowData, columnKey) => rowData[columnKey] < 5
    };
}, true);

