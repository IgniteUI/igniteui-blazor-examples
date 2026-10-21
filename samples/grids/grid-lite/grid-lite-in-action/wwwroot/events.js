// Cell templates, the Registered comparer and the row count for the Grid Lite in Action sample.
//
// IgniteUI.Blazor.GridLite has no Razor cell templates yet, but the <igc-grid-lite-column> elements
// it renders accept `cellTemplate` and `sortConfiguration`. A template returns DOM nodes, which the
// grid renders as is. They live in each cell's shadow root, so the grid sets AdoptRootStyles and
// index.css styles them. <igc-avatar> and <igc-rating> are defined by the modules in Program.cs.
(function () {
    'use strict';

    const MONTHS = ['jan', 'feb', 'mar', 'apr', 'may', 'jun', 'jul', 'aug', 'sep', 'oct', 'nov', 'dec'];

    // TeamMember.RegisteredLabel is formatted as "MMM d, yyyy". The grid lower-cases values before
    // comparing them unless the column sorts case-sensitively.
    function dateKey(label) {
        const [month, day, year] = label.replace(',', '').split(' ');
        return Number(year) * 10000 + (MONTHS.indexOf(month.toLowerCase()) + 1) * 100 + Number(day);
    }

    // Creates an element: `attrs` become attributes, `props` are set as properties.
    function el(tag, { className, attrs, props } = {}, ...children) {
        const node = document.createElement(tag);
        if (className) {
            node.className = className;
        }
        for (const [name, value] of Object.entries(attrs || {})) {
            node.setAttribute(name, value);
        }
        Object.assign(node, props);
        node.append(...children);
        return node;
    }

    // Keyed by the column's Field (the C# property name, which the grid keeps when serializing rows).
    const columnSettings = {
        Name: {
            cellTemplate: ({ row }) => {
                const member = row.data;
                return el('div', { className: 'team-directory__person' },
                    el('igc-avatar', {
                        className: `team-directory__avatar team-directory__avatar--tone-${member.AvatarTone}`,
                        attrs: { shape: 'circle', 'aria-hidden': 'true' },
                        props: { initials: member.Initials }
                    }),
                    el('div', { className: 'team-directory__person-text' },
                        el('span', { className: 'team-directory__name' }, member.Name),
                        el('a', { className: 'team-directory__email', attrs: { href: `mailto:${member.Email}` } }, member.Email)));
            }
        },

        Department: {
            cellTemplate: ({ value }) =>
                el('span', { className: `team-directory__department team-directory__department--${value.toLowerCase()}` },
                    el('span', { className: 'team-directory__department-dot', attrs: { 'aria-hidden': 'true' } }),
                    value)
        },

        // Read-only and out of the tab order: the score is information, not a control. The label is
        // hidden visually (see index.css) but still names the rating for assistive technology.
        Satisfaction: {
            cellTemplate: ({ value }) =>
                el('span', { className: 'team-directory__satisfaction' },
                    el('igc-rating', {
                        className: 'team-directory__rating',
                        attrs: { readonly: '', tabindex: '-1' },
                        props: { max: 5, value: value, label: 'Satisfaction', valueFormat: '{0} out of {1}' }
                    }),
                    el('span', { className: 'team-directory__rating-value', attrs: { 'aria-hidden': 'true' } }, value.toFixed(1)))
        },

        // The column shows and filters the label; this keeps its sort chronological.
        RegisteredLabel: {
            sortConfiguration: { comparer: (a, b) => dateKey(a) - dateKey(b) }
        },

        Active: {
            cellTemplate: ({ value }) =>
                el('span', { className: `team-directory__status team-directory__status--${value ? 'active' : 'inactive'}` },
                    el('span', { className: 'team-directory__status-dot', attrs: { 'aria-hidden': 'true' } }),
                    value ? 'Active' : 'Inactive')
        }
    };

    window.gridLiteInAction = {
        // Adds the cell templates and the sort comparer to the grid's columns.
        configureColumns: async function (host) {
            await customElements.whenDefined('igc-grid-lite');
            const grid = host.querySelector('igc-grid-lite');

            // Set on each column element, so the settings survive the grid re-reading its columns.
            for (const column of host.querySelectorAll('igc-grid-lite-column')) {
                Object.assign(column, columnSettings[column.getAttribute('field')]);
            }

            // The grid copies column settings only when the columns are slotted, and the column
            // elements upgrade before the grid, so a later change on them does not reach it. Hand the
            // grid its current configuration (the getter returns every setting) with the additions.
            grid.columns = grid.columns.map(config => Object.assign({}, config, columnSettings[config.field]));
        },

        // Returns how many rows pass the grid's current filters.
        countVisibleRows: async function (host) {
            const grid = host.querySelector('igc-grid-lite');
            if (!grid) {
                return 0;
            }

            // A filter change re-runs the grid's data pipeline asynchronously. Yield one task so it
            // settles, then wait for the render it triggered before reading the count.
            await new Promise(resolve => setTimeout(resolve));
            await grid.updateComplete;
            return grid.totalItems;
        }
    };
})();
