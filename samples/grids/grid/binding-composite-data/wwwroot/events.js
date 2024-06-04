
igRegisterScript("WebGridCompositeContactCellTemplate", (ctx) => {
    var html = window.igTemplating.html;
    return html` <div class="contact-container">
    <span><strong>Name:</strong> ${ctx.cell.row.data.ContactName}</span>
    <br />
    <span><strong>Title:</strong> ${ctx.cell.row.data.ContactTitle}</span>
    <br />
    <span><strong>Company:</strong> ${ctx.cell.row.data.Company}</span>
    <br />
</div>`;
}, false);

igRegisterScript("WebGridCompositeContactEditCellTemplate", (ctx) => {
    var html = window.igTemplating.html;
    window.keyUpHandler = function () {
        ctx.cell.row.data[window.event.target.id] = window.event.target.value;
    }
    return html`<div class="contact-container--edit" style="padding: 1rem">
                    <igc-input id="ContactName" label='Name' type="text" name="name" value="${ctx.cell.row.data.ContactName}" onkeyup='keyUpHandler()'></igc-input>
                    <igc-input id="ContactTitle" label='Title' type="text" name="name" value="${ctx.cell.row.data.ContactTitle}" onkeyup='keyUpHandler()'></igc-input>
                    <igc-input id="Company" label='Company' type="text" name="name" value="${ctx.cell.row.data.Company}" onkeyup='keyUpHandler()'></igc-input>
                </div>
   `;
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

    return html`
                <div class="contact-container--edit" style="padding: 1rem">
                    <igc-input id="Country" label='Country' type="text" name="country" value="${ctx.cell.row.data.Country}" onkeyup='keyUpHandler()'></igc-input>
                    <igc-input id="City" label='City' type="text" name="city" value="${ctx.cell.row.data.City}" onkeyup='keyUpHandler()'></igc-input>
                    <igc-input id="PostalCode" label='PostalCode' type="text" name="postalcode" value="${ctx.cell.row.data.PostalCode}" onkeyup='keyUpHandler()'></igc-input>
                    <igc-input id="Phone" label='Phone' type="text" name="phone" value="${ctx.cell.row.data.Phone}" onkeyup='keyUpHandler()'></igc-input>
                </div>`;
}, false);

