import { registerScript } from "./_content/IgniteUI.Blazor/api.js";

// the display-only dropdowns stay open when the user clicks outside them
registerScript("ComboKeepOpen", (evt) => evt.preventDefault());
