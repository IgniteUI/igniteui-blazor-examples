# Ignite UI for Blazor examples

Samples embedded in the Ignite UI for Blazor documentation and listed in the samples browser. They build against the published NuGet packages, not the library source: `IgniteUI.Blazor.Trial` for the full product and `IgniteUI.Blazor.GridLite` for the Grid Lite samples.

## Layout

- `samples/<group>/<component>/<sample>/` — one standalone Blazor WebAssembly app per sample: `App.razor` holds the sample, plus `Program.cs`, `BlazorClientApp.csproj`, `wwwroot/index.html`, data classes (`*Data.cs`, `Services/`) and any sample scripts in `wwwroot/*.js`.
- `browser/` — the samples browser: `IgBlazorSamples.Client` (WebAssembly) and `IgBlazorSamples.Server` (Blazor Server). `IgBlazorSamples.Gulp` [copies the samples into them](browser/IgBlazorSamples.Gulp/readme.md) and the copies are git-ignored, so change a sample in `samples/`, never in `browser/`.
- `templates/sample/` — the starting point for a new sample (steps in its `ReadMe-DEV.md`). Each sample's `ReadMe.md` is generated from it; don't edit those per sample.
- `azure-pipelines/` — deployment builds of the samples browser.
- `.github/workflows` — `.github/workflows/ci.yml` builds the samples browser and runs its tests (`browser/IgBlazorSamples.Test`) on pushes and pull requests to `vnext`.

## Rules

- Many chart, gauge, geographic map and data grid samples (Grid, Tree Grid, Hierarchical Grid, Pivot Grid, Data Grid) are authored in [igniteui-xplat-examples](https://github.com/IgniteUI/igniteui-xplat-examples) as `samples/<group>/<component>/<sample>.json` and exported here. When a sample has such a source, change it there too, so the next export keeps the change.
- Package versions change only in the `packageUpgrades` array of `browser/IgBlazorSamples.Gulp/tasks/gulp-samples.js`, applied to every `.csproj` with `npx gulp updateIG`. Never edit a version in a `.csproj` by hand: the next `updateIG` run reverts it.

## Sample code

Component usage follows the [Ignite UI for Blazor skills](https://github.com/IgniteUI/igniteui-blazor/tree/master/skills), for example the [form controls reference](https://github.com/IgniteUI/igniteui-blazor/blob/master/skills/igniteui-blazor-components/references/form-controls.md) for binding. The rules below add what samples need on top.

- **Bind state.** Bind value and form controls to a typed field (`@bind-Value="size"`) rather than an inline value, and give options C# values (`Value="@("small")"`). Derive whatever depends on the value from that field, with a computed property or `@bind-Value:after`, rather than handling events with custom logic. Binding also lets Razor infer a generic component's type arguments, so the sample doesn't spell them out.
- **Refs** are for methods and API calls the scenario actually needs. Prefer bound state: pass parameters from fields rather than assigning them through a ref, and drop refs nothing uses.
- **Defaults.** Don't set a parameter to its default value (`LabelPosition="ToggleLabelPosition.After"`), unless the sample contrasts it with another value.
- **State lives in C#.** Remove an item from the collection the markup renders, not from the DOM with a script. When a removal takes focus with it, move focus on, as `inputs/chip/overview` does.
- **Forms.** Use a native `<form>` or an `EditForm`, and rely on its built-in behavior as far as possible: native submit and reset buttons, and the form's submit and reset events where the sample needs to react.
- **Styles** go in `wwwroot/index.css`, linked from `wwwroot/index.html`: the samples browser inlines it into the page and shows it in the CSS tab. Size components with CSS, like any other element. Usually the layout decides it: a flex or grid container sizes and aligns the components in it. For an explicit size, give the component a `class` and target it from `index.css`.
- **Modules.** Register with a plain `builder.Services.AddIgniteUIBlazor()`, since components load their own module on first render. List a module only when nothing loads it on render: a feature module that adds behavior to a component (`IgbDataChartInteractivityModule`, `IgbDataChartAnnotationModule`, the `*FullModule` bundles), or the module of an `igc-*` element a sample's script creates. Chart, map and gauge samples haven't had this pass yet; leave their lists as they are.
- **`app.bundle.js`** belongs only on host pages whose `wwwroot/*.js` calls `igRegisterScript` or `igTemplating` while the page loads (see `templates/sample/ReadMe-DEV.md`).

Branches, commits and pull requests: [.github/CONTRIBUTING.md](.github/CONTRIBUTING.md).
