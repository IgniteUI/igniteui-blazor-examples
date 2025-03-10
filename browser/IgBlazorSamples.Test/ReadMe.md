This documents provides instruction on building and running Samples Browser Tests

# Setup

- Instal Blazor **.NET SDK** from this website:
https://dotnet.microsoft.com/learn/aspnet/blazor-tutorial/install

- If you don't have `pwsh`, you will have to [install Powershell](https://docs.microsoft.com/powershell/scripting/install/installing-powershell)

## 1. Copying Samples to Browser

- Open `./browser/IgBlazorSamples.Gulp/` folder

- Run `npm install` command

- Run `gulp copySamplesToClient` command

> NOTE: Above command will copy .razor pages and their .cs files from `./samples/` folder to `./browser/IgBlazorSamples.Client/` and generate required toc file.

## 2. Install Playwright browsers

- Open a Powershell terminal in the `./browser/IgBlazorSamples.Test/bin/Debug/net9.0` folder.

- Run `./playwright.ps1 install chromium` to instal only chromium for Playwright to run. For all browsers just omit the  `chromium` argument.

You can run it from the `./browser/IgBlazorSamples.Test` folder as well, but you will need to prefix the path to it: `bin/Debug/net9.0/playwright.ps1 install`

For running from **cmd** you will need to use `pwsh ./playwright.ps1 install`.

For other specific browsers refer to `./playwright.ps1 install --help`

## 3. Build Samples Browser Solution

- Open the **IgBlazorSamples.Test.sln** solution

- Build the solution. Should successfully build all projects.

## 4. Run tests

### Test settings

The `./browser/IgBlazorSamples.Test/` project once built, will generate all the tests and they should appear in the test explorer.
Each test once run will start its own instance of the Samples Browser Client, so no need for any other extra steps than just hitting run/debug on the test.


- If the tests use too much resource you can decrease number of workers in the  `./browser/.runsettings` or located also in the test solution under `Solution Items/.runsettings`.

- Disabling headless run for tests locally - uncomment the headless launch option in `.runsettings` 

- If you don't want each test using in memory browser server, you can disable it in the `.runsettings` by setting `useInMemoryClient` to `false`. In this case you will need to run your own instance of the `IgBlazorSamples.Client`, either from VS or using `dotnet run` in the project folder.
You will need to specify the `testUrl` if you use a different the run the `IgBlazorSamples.Client` on.

### Using Visual Studio

- In the **Test Explorer** you can run all tests or individually now.

- Debugging from VS - Right click a test and choose debug. Should have a breakpoint of course in test :P.

- Debugging with Playwright Inspector - https://playwright.dev/dotnet/docs/debug. Pretty much add `await page.PauseAsync();` to the start of a test or elsewhere and the Playwright inspector will start at that point onward.

### Using command line

In order to run the samples tests you need to specify its category and point to the settings of the test, other you will need to speficy each setting manually, like `-- NUnit.NumberOfTestWorkers=2` if you want to have 2 workers active.

- Running tests: `dotnet test --filter "ErrorTest" --settings:"../.runsettings"`

- For other methods of running and debugging and all using command line: https://playwright.dev/dotnet/docs/running-tests

# Resources and guidance

- For general guidance related to Playwright tests - https://playwright.dev/dotnet/docs/

- Generating selectors / tests code using Playwright Codegen - https://playwright.dev/dotnet/docs/codegen-intro

- Viewing trace of a failed test group(usually artifact from a build) - https://playwright.dev/dotnet/docs/trace-viewer#opening-the-trace

## Generic sample tests

The generic tests that run on all samples use parameter passing to the main `ErrorTest`, that parses the `toc.json` from the `IgSamplesBrowser.Client/wwwroot` and goes through it.

## Test Selector

Each component from the `toc.json` is recommended to have a specified test selector, which is used for the generic tests to wait to be rendered. This is to be ensure that the sample component is fully(mostly) rendered and the test is actually testing correctly.

If such test selector is not specified, such would be generated based on the name of the component.

## Ignoring specific sample

In order to ignore a specific test from the samples browser, you need to specify it in the `excludeSamples` group in the `testsettings.json`.

## Ignoring a whole group of test based on the toc

You will need to specify the group path under `excludedGroups` in the `testsettings.json`. The path is based on the toc group names.
If the name of a group has the `/` symbol, it needs to be ignore with `\\/` for the path to be read correctly.
