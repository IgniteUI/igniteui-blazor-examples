let regionOptions = [];
let statusOptions = [];

function ensureImplicit(ctx) {
    if (!ctx.implicit) {
        ctx.implicit = { value: null };
    }
}

function matchesEqualityCondition(condition) {
    return condition === 'equals' || condition === 'doesNotEqual';
}

function normalizeTimeValue(value) {
    if (!value) {
        return null;
    }

    if (value instanceof Date) {
        return value;
    }

    if (typeof value === 'string') {
        const isoCandidate = value.includes('T') ? value : `1970-01-01T${value}`;
        const parsed = new Date(isoCandidate);
        return Number.isNaN(parsed.getTime()) ? null : parsed;
    }

    if (typeof value === 'number') {
        const parsed = new Date(value);
        return Number.isNaN(parsed.getTime()) ? null : parsed;
    }

    return null;
}

function buildRegionSelect(ctx) {
    const select = document.createElement('igc-select');
    const currentValue = ctx && ctx.implicit && ctx.implicit.value
        ? ctx.implicit.value.value ?? ''
        : '';

    select.placeholder = 'Region';
    if (currentValue) {
        select.value = currentValue;
    }

    for (const option of regionOptions) {
        const item = document.createElement('igc-select-item');
        item.setAttribute('value', option.value);
        item.textContent = option.text;
        select.appendChild(item);
    }

    select.addEventListener('igcChange', (event) => {
        const value = event && event.detail ? event.detail.value : null;
        const currentKey = ctx && ctx.implicit && ctx.implicit.value
            ? ctx.implicit.value.value ?? ''
            : '';

        if (!value || value === currentKey) {
            return;
        }

        ctx.implicit.value = regionOptions.find((option) => option.value === value) ?? null;
    });

    return select;
}

function buildStatusRadios(ctx) {
    const group = document.createElement('igc-radio-group');
    const implicitValue = ctx && ctx.implicit ? ctx.implicit.value : null;
    const currentValue = implicitValue == null ? '' : implicitValue.toString();

    group.style.gap = '5px';
    group.alignment = 'horizontal';
    group.value = currentValue;

    for (const option of statusOptions) {
        const radio = document.createElement('igc-radio');
        radio.setAttribute('name', 'status');
        radio.setAttribute('value', option.value.toString());
        radio.checked = option.value.toString() === currentValue;
        radio.textContent = option.text;
        group.appendChild(radio);
    }

    group.addEventListener('igcChange', (event) => {
        const value = event && event.detail ? event.detail.value : undefined;
        if (value === undefined) {
            return;
        }

        const numericValue = Number(value);
        if (ctx.implicit.value === numericValue) {
            return;
        }

        ctx.implicit.value = numericValue;
    });

    return group;
}

function buildDatePicker(ctx) {
    const picker = document.createElement('igc-date-picker');
    const implicitValue = ctx && ctx.implicit ? ctx.implicit.value : null;
    const currentValue = implicitValue instanceof Date
        ? implicitValue
        : implicitValue
            ? new Date(implicitValue)
            : null;

    const allowedConditions = ['equals', 'doesNotEqual', 'before', 'after'];
    const isEnabled = allowedConditions.includes(ctx.selectedCondition ?? '');

    picker.disabled = !isEnabled;
    if (currentValue) {
        picker.value = currentValue;
    }

    picker.addEventListener('click', () => {
        if (typeof picker.show === 'function') {
            picker.show();
        }
    });

    picker.addEventListener('igcChange', (event) => {
        ctx.implicit.value = event ? event.detail : null;
    });

    return picker;
}

function buildTimeInput(ctx) {
    const input = document.createElement('igc-date-time-input');
    const icon = document.createElement('igc-icon');
    const currentValue = normalizeTimeValue(ctx && ctx.implicit ? ctx.implicit.value : null);
    const allowedConditions = ['at', 'not_at', 'at_before', 'at_after', 'before', 'after'];
    const isDisabled = ctx.selectedField == null || !allowedConditions.includes(ctx.selectedCondition ?? '');

    input.inputFormat = 'hh:mm tt';
    input.disabled = isDisabled;
    if (currentValue) {
        input.value = currentValue;
    }

    icon.slot = 'prefix';
    icon.setAttribute('name', 'clock');
    icon.setAttribute('collection', 'material');
    input.appendChild(icon);

    input.addEventListener('igcChange', (event) => {
        const picker = event ? event.currentTarget : null;
        ctx.implicit.value = picker && 'value' in picker ? picker.value : null;
    });

    return input;
}

function buildDefaultInput(ctx, equalityCondition) {
    const input = document.createElement('igc-input');
    const selectedField = ctx.selectedField;
    const dataType = selectedField ? selectedField.dataType : null;
    const isNumber = dataType === 'number';
    const isBoolean = dataType === 'boolean';

    const placeholder = ctx.selectedCondition === 'inQuery' || ctx.selectedCondition === 'notInQuery'
        ? 'Sub-query results'
        : 'Value';

    const currentImplicitValue = ctx && ctx.implicit ? ctx.implicit.value : null;
    const currentValue = typeof currentImplicitValue === 'object' && currentImplicitValue && 'text' in currentImplicitValue
        ? equalityCondition ? currentImplicitValue.text : ''
        : currentImplicitValue;

    const disabledConditions = ['empty', 'notEmpty', 'null', 'notNull', 'inQuery', 'notInQuery'];
    const isDisabled = isBoolean || selectedField == null || disabledConditions.includes(ctx.selectedCondition ?? '');

    input.value = currentValue == null ? '' : currentValue;
    input.placeholder = placeholder;
    input.disabled = isDisabled;
    input.type = isNumber ? 'number' : 'text';

    input.addEventListener('input', (event) => {
        const target = event ? event.target : null;
        const value = target && 'value' in target ? target.value : '';

        ctx.implicit.value = isNumber
            ? value === '' ? null : Number(value)
            : value;
    });

    return input;
}

function renderExpressionTree(expressionTree) {
    const expressionOutput = document.getElementById('expressionOutput');
    if (!expressionOutput) {
        return;
    }

    expressionOutput.textContent = expressionTree
        ? JSON.stringify(expressionTree, null, 2)
        : '';
}

function renderInitialExpressionTree(attempts = 60) {
    const queryBuilder = document.querySelector('igc-query-builder');
    const expressionTree = queryBuilder?.expressionTree;

    if (expressionTree || attempts <= 0) {
        renderExpressionTree(expressionTree);
        return;
    }

    requestAnimationFrame(() => renderInitialExpressionTree(attempts - 1));
}

window.queryBuilderTemplate = {
    init: (regions, statuses) => {
        regionOptions = regions ?? [];
        statusOptions = statuses ?? [];
        renderInitialExpressionTree();
    },
    renderExpressionTree,
};

igRegisterScript('SearchValueTemplate', (ctx) => {
    const field = ctx && ctx.selectedField ? ctx.selectedField.field : null;
    const equalityCondition = matchesEqualityCondition(ctx ? ctx.selectedCondition : null);

    ensureImplicit(ctx);

    if (field === 'Region' && equalityCondition) {
        return buildRegionSelect(ctx);
    }

    if (field === 'OrderStatus' && equalityCondition) {
        return buildStatusRadios(ctx);
    }

    if (field === 'OrderDate') {
        return buildDatePicker(ctx);
    }

    if (field === 'RequiredTime') {
        return buildTimeInput(ctx);
    }

    return buildDefaultInput(ctx, equalityCondition);
}, false);

igRegisterScript('WebQueryBuilderTemplateExpressionTreeChange', (evtArgs) => {
    const expressionTree = evtArgs?.detail;
    renderExpressionTree(expressionTree);
}, false);
