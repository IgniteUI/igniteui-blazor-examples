/* eslint-disable no-undef */

function log(msg) {
    console.log('gulp-config.js ' + msg);
}

// change this variable depending on which platform
let platformTarget = "Blazor";

log('loaded for ' + platformTarget + ' platform' );

// this configuration defines variables for each platform
let config = {
    PlatformCode: "razor",
    PlatformName: "Blazor",
    BrowserHostUrl: "http://localhost:4200/",
    BrowserRoute: "/samples",
    BrowserRootPath: "./tmp",
    // SamplesCopyPath: "../samples",
    SamplesCopyPath: "../../samples",
    SamplesCopyFiles: [".razor", ".cs", ".csv", ".png", ".svg" ],
    SamplesFileExclusions: ["Home.razor", "index.html", "index.css"],
    SamplesFileExtension: ".razor",
    SamplesFolderName: "Pages",

    DocsUrl: "https://infragistics.com/{PlatformName}site/components/{ComponentFolder}.html",
             //  "https://infragistics.com/blazorsite/components/data-chart.html",

    RepositoryOrg: "IgniteUI",
    RepositoryBranch: "master",
    RepositoryName: "igniteui-blazor-examples",
    RepositoryPath: "github/{RepositoryOrg}/{RepositoryName}/tree/{RepositoryBranch}/samples/{ComponentGroup}/{ComponentFolder}/{SampleFolderName}",
    RepositoryUrl: "https://github.com/{RepositoryOrg}/{RepositoryName}",
    RepositoryWarning: "NOTE: do not change this file because it's auto re-generated from:",

    SandboxUrlOptions: "fontsize=14&hidenavigation=1&theme=dark&view=preview&file=/src/{SampleFile}",
    SandboxUrlView:  "https://codesandbox.io/embed/{RepositoryPath}?{SandboxUrlOptions}",
    SandboxUrlEdit:  "https://codesandbox.io/s/{RepositoryPath}?{SandboxUrlOptions}",
    SandboxUrlShort: "https://codesandbox.io/embed/{RepositoryPath}",

    PackageReferences: [
        { Name: "Infragistics.Blazor", Version: "21.1.23-dev"},
    ],
}

// exporting only config for one platform since SB do not need other variables
module.exports = config;
