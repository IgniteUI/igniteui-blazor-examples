# IgBlazorSamples.Gulp

Gulp tasks that maintain the samples and copy them into the samples browser apps. Run `npm install` here once, then `npx gulp <task>`.

## Copying samples to the browser apps

`copySamplesToClient` copies every sample under `samples/` into `IgBlazorSamples.Client`; then open `IgBlazorSamplesBrowser.sln` and run `IgBlazorSamples.Client`. For each sample:

- `App.razor` and any `Components/*.razor` go to `Pages/<group>/<component>/<sample>/`, with `@page` routes added and the sample's `wwwroot/*.css` inlined as a `<style>` block.
- Its C# files, except `Program.cs`, go to `Services/`.
- Its `wwwroot/*.js` files go to `wwwroot/sb/`, and a script tag for each is inserted into `wwwroot/index.html`.

It also writes the navigation (`wwwroot/toc.json`) and the code viewer files (`wwwroot/code-viewer/`), and regenerates each sample's `ReadMe.md`.

`copySamplesToServer` copies the samples into `IgBlazorSamples.Server` the same way, inserting the script tags into `Pages/_Host.cshtml`, and writes its `toc.json`. It doesn't write the code viewer files or regenerate the readmes; `updateReadme` does the latter on its own.

Both tasks also rewrite the host page's `<base href>`: `/` here, `/blazor-client/` in the `*CI` variants that the deployment pipelines run.

The copied pages, data classes and scripts, `toc.json` and the code viewer files are git-ignored. The host pages and the samples' `ReadMe.md` files are tracked: commit the regenerated `ReadMe.md` files and the script list in `IgBlazorSamples.Client/wwwroot/index.html` together with the sample they belong to.

## Maintaining the samples

- `updateIG` — sets the package versions listed in `packageUpgrades` (`tasks/gulp-samples.js`) in every sample and browser `.csproj`.
- `updateReadme` — regenerates each sample's `ReadMe.md` from `templates/sample/ReadMe.md`.
- `updateSamples` — `updateReadme`, plus copies the shared `templates/sample/wwwroot/index.css` to every sample and the shared data classes (`templates/sample/Services/`) to the samples that use them.
- `updateProjects` — replaces every sample's `.csproj` with `templates/sample/BlazorClientApp.csproj`.
