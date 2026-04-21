const API_ENDPOINT = 'https://data-northwind.indigo.design';

async function syncTreeOnExpressionChange(detail) {
    const grid = await waitForGrid();
    if (!grid) {
        return;
    }

    const expressionTree = detail;
    if (typeof expressionTree?.operator === 'string') {
        const normalizedOperator = expressionTree.operator.toLowerCase();
        if (normalizedOperator === 'and') {
            expressionTree.operator = 0;
        } else if (normalizedOperator === 'or') {
            expressionTree.operator = 1;
        }
    }

    grid.isLoading = true;

    try {
        const res = await fetch(`${API_ENDPOINT}/QueryBuilder/ExecuteQuery`, {
            method: 'POST',
            headers: { 'Content-Type': 'application/json' },
            body: JSON.stringify(expressionTree)
        });

        if (!res.ok) {
            throw new Error(`ExecuteQuery failed: ${res.status} ${res.statusText}`);
        }

        const json = await res.json();
        grid.data = Object.values(json)[0] ?? [];
    } catch (error) {
        console.error(error);
        grid.data = [];
    } finally {
        grid.isLoading = false;
        await nextFrame();
        calculateColsInView(grid, expressionTree);
        if (typeof grid.markForCheck === 'function') {
            grid.markForCheck();
        }
    }
}

function calculateColsInView(grid, expressionTree) {
    const returnFields = expressionTree?.returnFields ?? [];

    if (returnFields.length === 0 || returnFields[0] === '*') {
        const queryBuilder = document.querySelector('igc-query-builder, igx-query-builder');
        const entities = queryBuilder?.entities ?? [];
        const selectedEntity = entities.find(entity => entity.name === expressionTree?.entity);
        const selectedEntityFields = (selectedEntity?.fields ?? []).map(field => field.field);
        grid.columns.forEach(column => {
            column.hidden = !selectedEntityFields.includes(column.field);
        });
        return;
    }

    grid.columns.forEach(column => {
        column.hidden = !returnFields.includes(column.field);
    });
}

function nextFrame() {
    return new Promise(resolve => requestAnimationFrame(() => resolve()));
}

function waitForGrid(attempts = 120) {
    return new Promise(resolve => {
        const tryResolve = () => {
            const gridById = document.getElementById('grid');
            const directGrid = isGridReady(gridById) ? gridById : null;
            const customElementGrid = document.querySelector('igc-grid');
            const grid = directGrid ?? (isGridReady(customElementGrid) ? customElementGrid : null);

            if (grid) {
                resolve(grid);
                return;
            }

            if (attempts <= 0) {
                resolve(null);
                return;
            }

            attempts -= 1;
            requestAnimationFrame(tryResolve);
        };

        tryResolve();
    });
}

function isGridReady(grid) {
    return Boolean(grid)
        && typeof grid === 'object'
        && 'data' in grid
        && 'isLoading' in grid
        && 'columns' in grid;
}

window.queryBuilderOverview = {
    loadInitialData: syncTreeOnExpressionChange
};

igRegisterScript("WebQueryBuilderExpressionTreeChange", async (evtArgs) => {
    const detail = evtArgs?.detail;
    if (!detail) {
        return;
    }

    await syncTreeOnExpressionChange(detail);
}, false);
