# IgBlazorSamples.Gulp

Gulp tasks that maintain the samples and copy them into the samples browser apps. Run `npm install` here once, then `npx gulp <task>`.

## Copying samples to the browser apps

`copySamplesToClient` copies every sample under `samples/` into `IgBlazorSamples.Client`; then open `IgBlazorSamplesBrowser.sln` and run `IgBlazorSamples.Client`. For each sample:

- `App.razor` and any `Components/*.razor` go to `Pages/<group>/<component>/<sample>/`, with `@page` routes added and the sample's `wwwroot/*.css` inlined as a `<style>` block.
- Its C# files, except `Program.cs`, go to `Services/`.
- Its `wwwroot/*.js` files go to `wwwroot/sb/`, and a script tag for each is inserted into `wwwroot/index.html`.

It also writes the navigation (`wwwroot/toc.json`) and the code viewer files (`wwwroot/code-viewer/`), and regenerates each sample's `ReadMe.md`.

`copySamplesToServer` does the same for `IgBlazorSamples.Server`, inserting the script tags into `Pages/_Host.cshtml`.

All of this output is git-ignored. The `*CI` variants of both tasks are what the deployment pipelines run; they also set `<base href="/blazor-client/" />` for the hosted site.

## Maintaining the samples

- `updateIG` — sets the package versions listed in `packageUpgrades` (`tasks/gulp-samples.js`) in every sample and browser `.csproj`.
- `updateReadme` — regenerates each sample's `ReadMe.md` from `templates/sample/ReadMe.md`.
- `updateSamples` — `updateReadme`, plus copies the shared `templates/sample/wwwroot/index.css` to every sample and the shared data classes (`templates/sample/Services/`) to the samples that use them.
- `updateProjects` — replaces every sample's `.csproj` with `templates/sample/BlazorClientApp.csproj`.
