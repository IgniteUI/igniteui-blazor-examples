window.chipOutlinedSample = {
    focusAfterRemove: (index) => {
        const remaining = document.querySelectorAll('#chip-outlined igc-chip');
        const next = remaining[index] ?? remaining[index - 1];
        // The chip doesn't delegate focus yet, so focus its remove icon directly.
        next?.shadowRoot?.querySelector('slot[name="remove"] igc-icon')?.focus();
    }
};
