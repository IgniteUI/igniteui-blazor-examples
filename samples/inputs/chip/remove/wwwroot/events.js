window.chipRemoveSample = {
    focus: async (id) => {
        const element = document.getElementById(id);
        // The element renders after Blazor adds it, so wait before moving focus to it.
        await element?.updateComplete;
        if (element?.tagName === 'IGC-CHIP') {
            // The chip doesn't delegate focus, so focus its remove control directly.
            element.shadowRoot?.querySelector('slot[name="remove"] igc-icon')?.focus();
        } else {
            element?.focus();
        }
    }
};
