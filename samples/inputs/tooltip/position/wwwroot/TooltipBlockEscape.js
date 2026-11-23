// The tooltips in this sample stay open, so Escape is stopped before
// igc-tooltip's window listener can close them.
function tooltipBlockEscape(event) {
    if (event.key === 'Escape') {
        event.stopImmediatePropagation();
    }
}

function tooltipBlockEscapeAttach() {
    window.addEventListener('keydown', tooltipBlockEscape, true);
}

function tooltipBlockEscapeDetach() {
    window.removeEventListener('keydown', tooltipBlockEscape, true);
}
