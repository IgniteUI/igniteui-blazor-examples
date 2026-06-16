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
    const currentValue = ctx?.implicit?.value;
    const changeHandler = (event) => {
        const value = event && event.detail ? event.detail.value : null;
        ctx.implicit.value = value;
    };

    return html`
      <igc-select
        placeholder="Region"
        .value=${currentValue}
        @igcChange=${changeHandler}>
        ${regionOptions.map(option => html`
          <igc-select-item value=${option.value}>${option.text}</igc-select-item>
        `)}
      </igc-select>
    `;
}

function buildStatusRadios(ctx) {
    const implicitValue = ctx?.implicit?.value;
    const currentValue = implicitValue == null ? '' : implicitValue.toString();

    const changeHandler = (event) => {
        const value = event && event.detail ? event.detail.value : undefined;
        if (!value || ctx.implicit.value === value) {
            return;
        }
        ctx.implicit.value = value;
    };

    return html`
      <igc-radio-group
        style="gap: 5px;"
        .alignment=${"horizontal"}
        .value=${currentValue}
        @igcChange=${changeHandler}>
        ${statusOptions.map(option => html`
          <igc-radio
            name="status"
            value=${option.value}
            ?checked=${option.value.toString() === currentValue}>
            ${option.text}
          </igc-radio>
        `)}
      </igc-radio-group>
    `;
}

function buildDatePicker(ctx) {
    const implicitValue = ctx.implicit?.value;
    const currentValue = implicitValue instanceof Date
        ? implicitValue
        : implicitValue
            ? new Date(implicitValue)
            : null;

    const allowedConditions = ['equals', 'doesNotEqual', 'before', 'after'];
    const isEnabled = allowedConditions.includes(ctx.selectedCondition ?? '');

    return html`
      <igc-date-picker
        .value=${currentValue}
        .disabled=${!isEnabled}
        @click=${(event) => (event.currentTarget).show()}
        @igcChange=${(event) => {
            ctx.implicit.value = event.detail;
        }}>
      </igc-date-picker>
    `;
}

function buildTimeInput(ctx) {
    const currentValue = this.normalizeTimeValue(ctx.implicit?.value);
    const allowedConditions = ['at', 'not_at', 'at_before', 'at_after', 'before', 'after'];
    const isDisabled = ctx.selectedField == null || !allowedConditions.includes(ctx.selectedCondition ?? '');

    return html`
      <igc-date-time-input
        .inputFormat=${"hh:mm tt"}
        .value=${currentValue}
        .disabled=${isDisabled}
        @igcChange=${(event) => {
            const picker = event.currentTarget;
            ctx.implicit.value = picker.value;
        }}>
        <igc-icon slot="prefix" name="clock" collection="material"></igc-icon>
      </igc-date-time-input>
    `;
}

function buildDefaultInput(ctx, equalityCondition) {
    const selectedField = ctx.selectedField;
    const dataType = selectedField?.dataType;
    const isNumber = dataType === 'number';
    const isBoolean = dataType === 'boolean';

    const placeholder = ctx.selectedCondition === 'inQuery' || ctx.selectedCondition === 'notInQuery'
        ? 'Sub-query results'
        : 'Value';

    const currentValue = typeof ctx.implicit?.value === 'object' && (ctx.implicit.value && 'text' in ctx.implicit.value)
        ? matchesEqualityCondition ? ctx.implicit.value.text : ''
        : ctx.implicit?.value;

    const inputValue = currentValue == null ? '' : currentValue;
    const disabledConditions = ['empty', 'notEmpty', 'null', 'notNull', 'inQuery', 'notInQuery'];
    const isDisabled = isBoolean || selectedField == null || disabledConditions.includes(ctx.selectedCondition ?? '');

    return html`
      <igc-input 
        .value=${inputValue}
        ?disabled=${isDisabled}
        placeholder=${placeholder}
        type=${isNumber ? 'number' : 'text'}
        @input=${(event) => {
            const target = event.target;
            ctx.implicit.value = isNumber
                ? target.value === '' ? null : Number(target.value)
                : target.value;
        }}>
      </igc-input>
    `;
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
