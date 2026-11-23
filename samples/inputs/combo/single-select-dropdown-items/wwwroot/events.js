import { registerScript } from "./_content/IgniteUI.Blazor/api.js";

// the input fields are hidden, so the dropdowns stay open and each one works on its own
registerScript("ComboKeepOpen", (evt) => evt.preventDefault());
