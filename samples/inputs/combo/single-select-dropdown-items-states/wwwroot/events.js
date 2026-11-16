// the display-only dropdowns stay open when the user clicks outside them
igRegisterScript("ComboKeepOpen", (evt) => evt.preventDefault(), false);

(() => {
    const stateSheets = new WeakSet();

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
            if (root.adoptedStyleSheets.some((sheet) => stateSheets.has(sheet))) {
                return;
            }

            const stateSheet = new CSSStyleSheet();
            stateSheets.add(stateSheet);
            for (const sheet of root.adoptedStyleSheets) {
                for (const rule of sheet.cssRules) {
                    if (rule instanceof CSSStyleRule && rule.selectorText.includes(state)
                        && !rule.selectorText.includes(`:not(${state}`)) {
                        stateSheet.insertRule(rule.cssText.split(state).join(`:not(${state})`), stateSheet.cssRules.length);
                    }
                }
            }
            root.adoptedStyleSheets = [...root.adoptedStyleSheets, stateSheet];
        };

        // a theme change gives the item the style sheets of the new theme and updates it, so the rules
        // are copied again after each update that left the item without them
        item.addController({ hostUpdated: show });
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
