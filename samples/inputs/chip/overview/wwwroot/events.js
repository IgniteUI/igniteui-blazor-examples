window.chipOverviewSample = {
    focusAfterRemove: (index, skillIndex) => {
        const remaining = document.querySelectorAll('#chip-overview-selected igc-chip');
        const next = remaining[index] ?? remaining[index - 1];
        // The chip doesn't delegate focus yet, so focus its remove icon or its button directly.
        const target = next
            ? next.shadowRoot?.querySelector('slot[name="remove"] igc-icon')
            : document.querySelectorAll('#chip-overview-skills igc-chip')[skillIndex]?.shadowRoot?.querySelector('button');
        target?.focus();
    }
};
