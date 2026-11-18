import { registerScript } from "./_content/IgniteUI.Blazor/api.js";

// the display-only dropdowns stay open when the user clicks outside them
registerScript("ComboKeepOpen", (evt) => evt.preventDefault());

(() => {
    // each state sheet, with the theme sheets that it was copied from
    const stateSheets = new WeakMap();

    // Adds to the element a copy of the rules that its theme has for the state.
    function showStateRules(element, state, takesPart) {
        const show = () => {
            const root = element.shadowRoot;
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
                        && !rule.selectorText.includes(`:not(${state}`) && takesPart(rule.selectorText)) {
                        stateSheet.insertRule(rule.cssText.split(state).join(`:not(${state})`), stateSheet.cssRules.length);
                    }
                }
            }
            root.adoptedStyleSheets = [...themeSheets, stateSheet];
        };

        // a theme change sets the style sheets of the new theme on the shadow root of the element, and may keep
        // the sheet copied from the previous theme, so the rules are copied again each time the style sheets
        // of the shadow root are set
        const adopted = Object.getOwnPropertyDescriptor(ShadowRoot.prototype, "adoptedStyleSheets");
        Object.defineProperty(element.shadowRoot, "adoptedStyleSheets", {
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

    // The themes draw the hover and the focus of the combo with `:hover` and `:focus-within` rules, and a
    // display-only combo is never hovered or focused. This copies those rules of the combo and of its input
    // with the condition turned around, so the theme draws the state while the combo is not in it. The
    // sample adds no styles of its own.
    async function showState(combo, state) {
        await customElements.whenDefined("igc-combo");
        await combo.updateComplete;
        const input = combo.renderRoot.querySelector('igc-input');
        await input.updateComplete;

        // the rules for the state of the search input in the list are left out
        showStateRules(combo, state, (selector) => !selector.includes("list-wrapper"));
        showStateRules(input, state, () => true);
    }

    // the combo of a cell is rendered after the cell itself, so the cell is watched until it is there
    function whenRendered(cell) {
        return new Promise((resolve) => {
            const combo = cell.querySelector("igc-combo");
            if (combo) {
                resolve(combo);
                return;
            }

            const observer = new MutationObserver(() => {
                const rendered = cell.querySelector("igc-combo");
                if (rendered) {
                    observer.disconnect();
                    resolve(rendered);
                }
            });
            observer.observe(cell, { childList: true, subtree: true });
        });
    }

    // the sample calls this after it renders; each cell names the state of its combo in `data-combo-shows`
    window.showComboStates = () => document.querySelectorAll("[data-combo-shows]")
        .forEach(async (cell) => showState(await whenRendered(cell), cell.getAttribute("data-combo-shows")));
})();
