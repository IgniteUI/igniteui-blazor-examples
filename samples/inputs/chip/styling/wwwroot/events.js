function handleChipRemove(event) {
    const chip = event.target;
    chip.remove();
}
igRegisterScript("handleChipRemove", handleChipRemove, false);