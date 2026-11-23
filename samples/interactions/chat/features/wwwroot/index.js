import { registerScript, html } from './_content/IgniteUI.Blazor/api.js';

registerScript("OnMessageHeaderTemplate", (ctx) => {
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
});


registerScript("OnSuggestionPrefixTemplate", (ctx) => {
    return html`<span style="font-weight: bold;">💡</span>&nbsp;`;
});