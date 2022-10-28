// this file contains events handlers and templates used in the razor page

igRegisterScript("WebGridNestedDataCellTemplate", (ctx) => {
    var html = window.igTemplating.html;
    window.keyUpHandler = function () {
        ctx.cell.row.data[window.event.target.id] = window.event.target.value;
    }
    const people = ctx.cell.value;
    if (people.length === 0) return html``;
    const person = people[0];
    return html`
    <igc-expansion-panel>
        <h1 slot="title">
        ${person.Name}
        </h1>
        <div class="description">
            <div>
                <label for="title">Title</label>
                <input id='Title' type="text" name="title" value="${person.Title}" style="text-overflow: ellipsis;" />
            </div>
            <div>
                <label for="age">Age</label>
                <input id='Age' type="text" name="title" value="${person.Age}" style="text-overflow: ellipsis;" />
            </div>
        </div>
    </igc-expansion-panel>
        `;
}, false);


//insert eventScript
//end eventScript