
igRegisterScript("WebGridCompositeContactCellTemplate", (ctx) => {
    var html = window.igTemplating.html;
    return html` <div class="contact-container">
    <span><strong>Name:</strong> ${ctx.cell.row.data.ContactName}}</span>
    <span><strong>Title:</strong> ${ctx.cell.row.data.ContactTitle}}</span>
    <br />
    <span><strong>Company:</strong> ${ctx.cell.row.data.CompanyName}}</span>
    <br />
</div>`;
}, false);

igRegisterScript("WebGridCompositeContactEditCellTemplate", (ctx) => {
    var html = window.igTemplating.html;
    window.keyUpHandler = function () {
        ctx.cell.row.data[window.event.target.id] = window.event.target.value;
    }
    return html`<div class="contact-container--edit">
    <div style="display:flex; margin-top:3px">
        <div>
            <strong>Name:</strong>
            <input id='ContactName' onkeyup='keyUpHandler()' value="${ctx.cell.row.data.ContactName}"></input>
        </div>
        <div style="margin-left: 10px">
            <strong>Title:</strong>
            <input id='ContactTitle' onkeyup='keyUpHandler()' value='${ctx.cell.row.data.ContactTitle}'></input>
        </div>
    </div>
    <div style="margin-top: 10px">
        <strong>Company:</strong>
        <input id='CompanyName' onkeyup='keyUpHandler()' value='${ctx.cell.row.data.CompanyName}'></input>
    </div>
</div>`;
}, false);

igRegisterScript("WebGridCompositeAddressCellTemplate", (ctx) => {
    var html = window.igTemplating.html;
    return html`<div class="address-container">
    <div class="country-city">
        <span><strong>Country:</strong> ${ctx.cell.row.data.Country}</span>
        <br>
        <span><strong>City:</strong> ${ctx.cell.row.data.City}</span>
    </div>
    <div class="phone-pscode">
        <span><strong>Postal Code:</strong> ${ctx.cell.row.data.PostalCode}</span>
        <br>
        <span><strong>Phone:</strong> ${ctx.cell.row.data.Phone}</span>
    </div>
    <br />
</div>`;
}, false);

igRegisterScript("WebGridCompositeAddressEditCellTemplate", (ctx) => {
    var html = window.igTemplating.html;
    window.keyUpHandler = function () {
        ctx.cell.row.data[window.event.target.id] = window.event.target.value;
    }

    return html`<div class="address-container--edit">
    <div>
        <span><strong>Country:</strong></span>
        <input id='Country' onkeyup='keyUpHandler()' value="${ctx.cell.row.data.Country}"></input>
        <br>
        <span><strong>City:</strong></span>
        <input id='City' onkeyup='keyUpHandler()' value="${ctx.cell.row.data.City}"></input>
    </div>
    <div>
        <span><strong>Postal Code:</strong></span>
        <input id='PostalCode' onkeyup='keyUpHandler()' value="${ctx.cell.row.data.PostalCode}"></input>
        <br>
        <span><strong>Selected:</strong></span>
        <input id='Phone' onkeyup='keyUpHandler()' value="${ctx.cell.row.data.Phone}"></input>
    </div>
    <br>
</div>`;
}, false);

