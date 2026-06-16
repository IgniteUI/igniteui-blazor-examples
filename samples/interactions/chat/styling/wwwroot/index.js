igRegisterScript("OnMessageHeaderTemplate", (ctx) => {
    var html = window.igTemplating.html;
    return ctx.message.sender !== 'user'
        ? html`
          <div style="display: flex; align-items: center; gap: 8px;">
            <igc-avatar
              shape="circle"
              src="https://dl.infragistics.com/x/img/people/men/11.png"
              style="position: relative;"
            >
            </igc-avatar>
            <span>Customer Support</span>
          </div>
        `
        : "";
}, false);