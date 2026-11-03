window.chipMultipleSample = {
    focusAfterRemove: () => {
        const next = document.querySelector('#chip-multiple igc-chip');
        // The chip doesn't delegate focus yet, so focus its button directly.
        next?.shadowRoot?.querySelector('button')?.focus();
    }
};
