window.radioInteractionState = {
    // A keyup is what turns on a radio's keyboard focus ring, so dispatching one
    // shows the focused state without moving focus to the radio.
    showFocus: async () => {
        await customElements.whenDefined('igc-radio');
        document.querySelectorAll('igc-radio.focused, igc-radio.focused-hover').forEach((radio) => {
            radio.dispatchEvent(new KeyboardEvent('keyup'));
        });
    }
};
