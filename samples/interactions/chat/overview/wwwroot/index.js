import { registerScript, html } from './_content/IgniteUI.Blazor/api.js';

registerScript("OnMessageHeaderTemplate", (ctx) => {
    return ctx.message.sender !== 'user'
        ? html`
          <div style="display: flex; align-items: center; gap: 8px;">
            <igc-avatar
              shape="circle"
              src="https://dl.infragistics.com/x/img/people/men/11.png"
              style="position: relative;"
            >
            </igc-avatar>
            <span
              style="color: #c00000; font-weight: bold; margin: 8px"
              >Customer Support</span
            >
          </div>
        `
        : "";
});