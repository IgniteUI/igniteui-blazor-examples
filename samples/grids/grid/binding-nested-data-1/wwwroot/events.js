
igRegisterScript("WebGridNestedDataCellTemplate", (ctx) => {
    var html = window.igTemplating.html;
    window.keyUpHandler = function () {
        ctx.cell.row.data[window.event.target.id] = window.event.target.value;
    }
    const people = ctx.cell.value;
    if (people != null) {
        if (people.length === 0) return html``;
        const person = people[0];
        return html`
    <igc-expansion-panel>
        <div slot="title" style="font-size: 1.1em; font-weight: bold; margin-top: 1rem; margin-bottom: 0.25rem;">
        ${person.Name}
        </div>
        <div class="description">
            <igc-input label='Title' type="text" name="title" value="${person.Title}" style="text-overflow: ellipsis;"></igc-input>
            <igc-input label="Age" type="text" name="title" value="${person.Age}" style="text-overflow: ellipsis;"></igc-input>
        </div>
    </igc-expansion-panel>
        `;
    }
}, false);

