
igRegisterScript("WebGridMasterDetailTemplate", (ctx) => {
    var html = window.igTemplating.html;
    var data = ctx.implicit;
    return html` <div class="contact-container">
        <span><strong>Name:</strong> ${data.ContactName}</span>
        <br />
        <span><strong>Title:</strong> ${data.ContactTitle}</span>
        <br />
        <span><strong>Company:</strong> ${data.CompanyName}</span>
        <br />
    </div>`;
}, false);

