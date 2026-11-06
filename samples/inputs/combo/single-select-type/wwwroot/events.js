// a click outside a combo moves the focus out of it, and then its dropdown stays open, so each combo opens and closes on its own
igRegisterScript("ComboKeepOpenOnOutsideClick", (evt) => {
    if (!evt.target.matches(':focus-within')) {
        evt.preventDefault();
    }
}, false);
