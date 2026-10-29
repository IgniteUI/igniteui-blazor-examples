# Creating a sample

This folder is the starting point for a new sample. The [gulp tasks](../../browser/IgBlazorSamples.Gulp/readme.md) copy its readme template, project file, `index.css` and shared data classes into the samples, so keep it current.

To add a sample:

1. Copy `BlazorClientApp.csproj`, `BlazorClientApp.sln`, `Program.cs`, `_Imports.razor`, `Properties/` and `wwwroot/` to `samples/<group>/<component>/<sample-name>/`.
2. Write the sample in `App.razor` in that folder.
3. Put its data classes in `Services/`, in the `Infragistics.Samples` namespace. Copy only the shared classes from `Services/` here that the sample uses.
4. Put scripts the sample needs in `wwwroot/*.js` and reference them from its `wwwroot/index.html`, after `blazor.webassembly.js`.
5. Run it with `dotnet run`, or from Visual Studio or VS Code, and open http://localhost:4200.
6. Generate its `ReadMe.md` with `npx gulp updateReadme` from `browser/IgBlazorSamples.Gulp` (after `npm install` there).

The samples browser picks the new sample up from its folder the next time its samples are copied.
