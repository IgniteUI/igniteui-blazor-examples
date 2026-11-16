// the display-only dropdowns stay open when the user clicks outside them
igRegisterScript("ComboKeepOpen", (evt) => evt.preventDefault(), false);

(() => {
    const stateSheets = new WeakSet();

    // Adds to the element a copy of the rules that its theme has for the state.
    function showStateRules(element, state, takesPart) {
        const show = () => {
            const root = element.shadowRoot;
            if (root.adoptedStyleSheets.some((sheet) => stateSheets.has(sheet))) {
                return;
            }

            const stateSheet = new CSSStyleSheet();
            stateSheets.add(stateSheet);
            for (const sheet of root.adoptedStyleSheets) {
                for (const rule of sheet.cssRules) {
                    if (rule instanceof CSSStyleRule && rule.selectorText.includes(state)
                        && !rule.selectorText.includes(`:not(${state}`) && takesPart(rule.selectorText)) {
                        stateSheet.insertRule(rule.cssText.split(state).join(`:not(${state})`), stateSheet.cssRules.length);
                    }
                }
            }
            root.adoptedStyleSheets = [...root.adoptedStyleSheets, stateSheet];
        };

        // a theme change gives the element the style sheets of the new theme and updates it, so the
        // rules are copied again after each update that left the element without them
        element.addController({ hostUpdated: show });
        show();
    }

    // The themes draw the hover and the focus of the search input with `:hover` and `:focus-within` rules, and a
    // display-only search input is never hovered or focused. This copies those rules of the search input, and of the combo list around it,
    // with the condition turned around, so the theme draws the state while the search input is not in it. The
    // sample adds no styles of its own.
    async function showState(combo, cell) {
        await customElements.whenDefined("igc-combo");
        await combo.updateComplete;
        const input = combo.renderRoot.querySelector('[part~="search-input"]');
        await input.updateComplete;

        // the search input is an input inside the combo, so its text and its disabled state are set on it
        input.value = cell.getAttribute("data-search-text") ?? "";
        input.disabled = cell.hasAttribute("data-search-disabled");

        const state = cell.getAttribute("data-search-shows");
        if (state) {
            // of the rules of the combo, only those for its list take part
            showStateRules(combo, state, (selector) => selector.includes("list-wrapper"));
            showStateRules(input, state, () => true);
        }
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

    // the sample calls this after it renders; each cell names the state, the text, and the disabled state
    // of its search input in its `data-search-*` attributes
    window.showComboSearchStates = () => document.querySelectorAll("[data-search-input]")
        .forEach(async (cell) => showState(await whenRendered(cell), cell));
})();
