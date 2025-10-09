window.customOneClick = (event) => {
    const tile = event.target.closest('igc-tile');

    if (tile) {
        tile.maximized = !tile.maximized;

        const actionsSlot = tile.querySelector('[slot="actions"]');
        const currentBtn = event.target;

        if (currentBtn) {
            if (tile.maximized) {
                currentBtn.setAttribute('name', 'south_west');
                currentBtn.setAttribute('aria-label', 'collapse');

                const chartBtn = document.createElement('igc-icon-button');
                chartBtn.classList.add('additional-action');
                chartBtn.setAttribute('slot', 'actions');
                chartBtn.setAttribute('variant', 'flat');
                chartBtn.setAttribute('collection', 'material');
                chartBtn.setAttribute('name', 'chart');
                chartBtn.setAttribute('aria-label', 'chart');

                const moreBtn = document.createElement('igc-icon-button');
                moreBtn.classList.add('additional-action');
                moreBtn.setAttribute('slot', 'actions');
                moreBtn.setAttribute('variant', 'flat');
                moreBtn.setAttribute('collection', 'material');
                moreBtn.setAttribute('name', 'more');
                moreBtn.setAttribute('aria-label', 'more');

                tile.append(chartBtn);
                tile.append(moreBtn);
            } else {
                currentBtn.setAttribute('name', 'north_east');
                currentBtn.setAttribute('aria-label', 'expand');

                const additionalButtons =
                    actionsSlot.parentElement?.querySelectorAll('.additional-action');
                additionalButtons?.forEach((btn) => btn.remove());
            }
        }
    }
};

window.customTwoClick = (event) => {
    const tile = event.target.closest('igc-tile');

    if (tile) {
        tile.maximized = !tile.maximized;

        const currentBtn = event.target;

        if (currentBtn) {
            if (tile.maximized) {
                currentBtn.setAttribute('name', 'south_west');
                currentBtn.setAttribute('aria-label', 'collapse');
            }
            else {
                currentBtn.setAttribute('name', 'north_east');
                currentBtn.setAttribute('aria-label', 'expand');
            }
        }
    }
};
