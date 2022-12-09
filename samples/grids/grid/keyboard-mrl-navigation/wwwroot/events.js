

igRegisterScript("WebGridMRLCustomNavigationEvent", (args) => {
    const target = args.detail.target;
    if (args.detail.event.key.toLowerCase() === 'enter') {
        args.detail.event.preventDefault();
        args.detail.cancel = true;
        const rowIndex = target.intRow.index === undefined ? target.index : target.intRow.index;
        this.grid.navigateTo(args.detail.event.shiftKey ? rowIndex - 1 : rowIndex + 1, target.column.visibleIndex,
             (obj) => {
                obj.target.activate();
            });
    }
}, false);

