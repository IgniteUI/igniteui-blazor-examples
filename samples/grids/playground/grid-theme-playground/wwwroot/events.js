
igRegisterScript("GridThemePlaygroundColumnInit", (event) => {
    if (event.detail.field === "Quantity") {
        event.detail.summaries = class {
            operate(data) {
                const values = (data || []).filter((value) => value !== null && value !== undefined && !isNaN(value));
                return [
                    { key: "count", label: "Count", summaryResult: (data || []).length },
                    { key: "sum", label: "Sum", summaryResult: values.reduce((a, b) => +a + +b, 0) }
                ];
            }
        };
    }
}, false);

igRegisterScript("GridThemePlaygroundSummaryFormatter", (summary) => {
    const result = summary.summaryResult;
    return typeof result === "number" ? new Intl.NumberFormat("en-US", { maximumFractionDigits: 3 }).format(result) : result;
}, false);

igRegisterScript("GridThemePlaygroundAvatarCellTemplate", (ctx) => {
    var html = window.igTemplating.html;
    return html`<div class="playground__cell">
    <igc-avatar src="${ctx.cell.row.data.Avatar}" shape="circle"></igc-avatar>
    <span>${ctx.cell.value}</span>
</div>`;
}, false);

igRegisterScript("GridThemePlaygroundProductMember", (data) => {
    return data.ProductName;
}, false);

igRegisterScript("GridThemePlaygroundCityMember", (data) => {
    return data.SellerCity;
}, false);

igRegisterScript("GridThemePlaygroundSellerMember", (data) => {
    return data.SellerName;
}, false);

window.gridThemePlayground = {
    highlighter: null,

    readCompiledTheme() {
        const tokens = new Map();

        for (const sheet of Array.from(document.styleSheets)) {
            let rules;

            try {
                rules = sheet.cssRules;
            } catch {
                continue; // cross-origin sheet, not ours
            }

            for (const rule of Array.from(rules)) {
                if (!(rule instanceof CSSStyleRule) || !rule.selectorText.includes("playground__stage")) {
                    continue;
                }

                for (let i = 0; i < rule.style.length; i++) {
                    const name = rule.style.item(i);
                    if (name.startsWith("--ig-")) {
                        tokens.set(name, rule.style.getPropertyValue(name).trim());
                    }
                }
            }
        }

        return Array.from(tokens);
    },

    readSeedColors(stageId) {
        const styles = getComputedStyle(document.getElementById(stageId));

        return {
            background: styles.getPropertyValue("--ig-grid-background").trim(),
            accentColor: styles.getPropertyValue("--ig-grid-accent-color").trim()
        };
    },

    async highlight(code) {
        if (!this.highlighter) {
            const [core, engine, css, theme] = await Promise.all([
                import("https://esm.sh/shiki@4.4.3/core"),
                import("https://esm.sh/shiki@4.4.3/engine/javascript"),
                import("https://esm.sh/shiki@4.4.3/langs/css.mjs"),
                import("https://esm.sh/shiki@4.4.3/themes/dark-plus.mjs")
            ]);

            this.highlighter = await core.createHighlighterCore({
                themes: [theme.default],
                langs: [css.default],
                engine: engine.createJavaScriptRegexEngine()
            });
        }

        return this.highlighter.codeToHtml(code, { lang: "css", theme: "dark-plus" });
    }
};
