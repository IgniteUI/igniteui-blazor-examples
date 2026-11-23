import { registerScript } from "./_content/IgniteUI.Blazor/api.js";

// the display-only dropdowns stay open when the user clicks outside them
registerScript("ComboKeepOpen", (evt) => evt.preventDefault());

(() => {
    // each state sheet, with the theme sheets that it was copied from
    const stateSheets = new WeakMap();

    // watches the element until `find` returns something: the combos and their items are rendered
    // after the sample itself
    function whenRendered(element, find) {
        return new Promise((resolve) => {
            const found = find();
            if (found) {
                resolve(found);
                return;
            }

            const observer = new MutationObserver(() => {
                const rendered = find();
                if (rendered) {
                    observer.disconnect();
                    resolve(rendered);
                }
            });
            observer.observe(element, { childList: true, subtree: true });
        });
    }

    // The themes draw the hover of an item with `:hover` rules, and its focus and its disabled state with
    // rules for the `active` and the `disabled` attribute, and a display-only item is in none of these
    // states. This copies those rules of the item with the condition turned around, so the theme draws
    // the state while the item is not in it. The sample adds no styles of its own.
    async function showState(combo, state) {
        await customElements.whenDefined("igc-combo");
        await combo.updateComplete;
        const item = await whenRendered(combo.renderRoot, () => combo.renderRoot.querySelector("igc-combo-item"));
        await item.updateComplete;

        const show = () => {
            const root = item.shadowRoot;
            const themeSheets = root.adoptedStyleSheets.filter((sheet) => !stateSheets.has(sheet));
            const copied = root.adoptedStyleSheets.find((sheet) => stateSheets.has(sheet));
            const copiedFrom = copied && stateSheets.get(copied);
            if (copiedFrom && copiedFrom.length === themeSheets.length
                && copiedFrom.every((sheet, index) => sheet === themeSheets[index])) {
                return;
            }

            const stateSheet = new CSSStyleSheet();
            stateSheets.set(stateSheet, themeSheets);
            for (const sheet of themeSheets) {
                for (const rule of sheet.cssRules) {
                    if (rule instanceof CSSStyleRule && rule.selectorText.includes(state)
                        && !rule.selectorText.includes(`:not(${state}`)) {
                        stateSheet.insertRule(rule.cssText.split(state).join(`:not(${state})`), stateSheet.cssRules.length);
                    }
                }
            }
            root.adoptedStyleSheets = [...themeSheets, stateSheet];
        };

        // a theme change sets the style sheets of the new theme on the shadow root of the item, and may keep
        // the sheet copied from the previous theme, so the rules are copied again each time the style sheets
        // of the shadow root are set
        const adopted = Object.getOwnPropertyDescriptor(ShadowRoot.prototype, "adoptedStyleSheets");
        Object.defineProperty(item.shadowRoot, "adoptedStyleSheets", {
            configurable: true,
            get() {
                return adopted.get.call(this);
            },
            set(sheets) {
                adopted.set.call(this, sheets);
                queueMicrotask(show);
            },
        });
        show();
    }

    // the sample calls this after it renders, with the element around its combos and the state of each
    // combo, in the order of the combos
    window.showSingleSelectComboItemStates = async (container, states) => {
        const combos = await whenRendered(container, () => {
            const rendered = container.querySelectorAll("igc-combo");
            return rendered.length === states.length ? rendered : null;
        });
        combos.forEach((combo, index) => {
            if (states[index]) {
                showState(combo, states[index]);
            }
        });
    };
})();
