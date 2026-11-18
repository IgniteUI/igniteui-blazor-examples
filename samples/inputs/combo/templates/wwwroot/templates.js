// the samples browser loads the scripts of all samples in one page, so the script keeps its
// declarations out of the global scope
(() => {
    const html = window.igTemplating.html;

    // the default templates show the display text of an item and the value of a group
    const defaultItemTemplate = ({ item }) => html`${item.Name}`;

    const defaultGroupHeaderTemplate = ({ item }) => html`${item.Region}`;

    // the templates render inside the shadow DOM of the combo, where the styles of the page don't
    // reach, so the group header lays out its content with inline styles; each root element of a
    // template is laid out as a block, so the item content is wrapped in one element
    const itemTemplate = ({ item }) => html`
        <span>
            <img
                src="https://dl.infragistics.com/x/img/flags/${item.CountryCode}.png"
                alt=""
                style="width: 1.25rem; vertical-align: -0.125rem; margin-inline-end: 0.5rem;"
            />
            ${item.Name} — ${item.Country} · ${item.Id} · ${item.Offset}
        </span>
    `;

    // the number of destinations in each region, set by the sample when it first renders
    let destinationCounts = {};

    window.setDestinationCounts = (counts) => {
        destinationCounts = counts;
    };

    // the group header template receives a header record, whose `GroupKey` field holds the group value
    const groupHeaderTemplate = ({ item }) => html`
        <span style="display: flex; align-items: center; gap: 0.5rem; width: 100%;">
            <strong>${item.Region}</strong>
            <span style="margin-inline-start: auto; font-weight: 400;">${destinationCounts[item.Region] ?? 0} cities</span>
        </span>
    `;

    igRegisterScript("ComboDefaultItemTemplate", defaultItemTemplate, false);
    igRegisterScript("ComboDefaultGroupHeaderTemplate", defaultGroupHeaderTemplate, false);
    igRegisterScript("ComboItemTemplate", itemTemplate, false);
    igRegisterScript("ComboGroupHeaderTemplate", groupHeaderTemplate, false);
})();
