

igRegisterScript("WebTreeGridRowSelectionConditional", (event) => {
    const eventArgs = event.detail;
    if (!eventArgs.added.length && eventArgs.removed.length) {
        // ignore deselect
        return;
    }
    const originalAddedLength = eventArgs.added.length;

    // only allow selection for employees that are not on PTO
    eventArgs.newSelection = eventArgs.newSelection.filter(x => x.OnPTO === false);

    // cleanup selection if all conditionally selectable rows are already selected
    if (eventArgs.newSelection.length
        && !eventArgs.newSelection.filter(x => eventArgs.oldSelection.indexOf(x) === -1).length
        && originalAddedLength > 1) {
            // all selected from header, deselect instead
            eventArgs.newSelection = [];
    }
}, false);

