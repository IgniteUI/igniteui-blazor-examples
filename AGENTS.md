# Ignite UI for Blazor examples

Samples embedded in the Ignite UI for Blazor documentation and listed in the samples browser. They build against the published NuGet packages, not the library source: `IgniteUI.Blazor.Trial` for the full product and `IgniteUI.Blazor.GridLite` for the Grid Lite samples.

## Layout

- `samples/<group>/<component>/<sample>/` — one standalone Blazor WebAssembly app per sample: `App.razor` holds the sample, plus `Program.cs`, `BlazorClientApp.csproj`, `wwwroot/index.html`, data classes (`*Data.cs`, `Services/`) and any sample scripts in `wwwroot/*.js`.
- `browser/` — the samples browser: `IgBlazorSamples.Client` (WebAssembly) and `IgBlazorSamples.Server` (Blazor Server). `IgBlazorSamples.Gulp` [copies the samples into them](browser/IgBlazorSamples.Gulp/readme.md) and the copies are git-ignored, so change a sample in `samples/`, never in `browser/`.
- `templates/sample/` — the starting point for a new sample (steps in its `ReadMe-DEV.md`). Each sample's `ReadMe.md` is generated from it; don't edit those per sample.
- `azure-pipelines/` — deployment builds of the samples browser; nothing runs on pull requests.

## Rules

- Many chart, gauge, geographic map and data grid samples (Grid, Tree Grid, Hierarchical Grid, Pivot Grid, Data Grid) are authored in [igniteui-xplat-examples](https://github.com/IgniteUI/igniteui-xplat-examples) as `samples/<group>/<component>/<sample>.json` and exported here. When a sample has such a source, change it there too, so the next export keeps the change.
- Package versions change only in the `packageUpgrades` array of `browser/IgBlazorSamples.Gulp/tasks/gulp-samples.js`, applied to every `.csproj` with `npx gulp updateIG`. Never edit a version in a `.csproj` by hand: the next `updateIG` run reverts it.

Branches, commits and pull requests: [.github/CONTRIBUTING.md](.github/CONTRIBUTING.md).
