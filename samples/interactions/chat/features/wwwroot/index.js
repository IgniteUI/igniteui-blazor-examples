igRegisterScript("OnMessageHeaderTemplate", (ctx) => {
    var html = window.igTemplating.html;
    return ctx.message.sender !== 'user'
        ? html`
        <div>
            <span
              style="color: #c00000; font-weight: bold;"
              >Developer Support</span
            >
          </div>
        `
        : "";
}, false);


igRegisterScript("OnSuggestionPrefixTemplate", (ctx) => {
    var html = window.igTemplating.html;
    return html`<span style="font-weight: bold;">💡</span>&nbsp;`;
}, false);