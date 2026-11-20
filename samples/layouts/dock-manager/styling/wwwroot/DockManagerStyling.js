// Reports the width of the sample's root to App.razor, which picks the dock manager layout that fits it.
// The observer reports once when it starts and then on every resize; App.razor disconnects it when disposed.
function observeDockManagerStylingWidth(host, component) {
    const observer = new ResizeObserver(() => component.invokeMethodAsync('OnRootWidthChanged', host.clientWidth));
    observer.observe(host);
    return observer;
}
