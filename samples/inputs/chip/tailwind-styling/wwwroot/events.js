window.chipTailwindSample = {
    focus: async (list, label) => {
        const chip = document.querySelector(`igc-chip[data-activity="${label}"]`);
        if (!chip) {
            return;
        }
        // A moved chip renders after Blazor adds it, and chips don't delegate focus yet, so wait and focus the control directly.
        await chip.updateComplete;
        const control = list === 'selected'
            ? chip.querySelector('[slot="remove"]')
            : chip.shadowRoot?.querySelector('[part="base"]');
        control?.focus();
    }
};
