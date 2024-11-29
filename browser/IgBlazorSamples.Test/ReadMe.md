This documents provides instruction on building and running Samples Browser Tests

# Setup

- Instal Blazor **.NET SDK** from this website:
https://dotnet.microsoft.com/learn/aspnet/blazor-tutorial/install

- If you don't have pwsh, you will have to [install Powershell](https://docs.microsoft.com/powershell/scripting/install/installing-powershell)

## 1. Copying Samples to Browser

- Open `./browser/IgBlazorSamples.Gulp/` folder

- Run `npm install` command

- Run `gulp copySamplesToClient` command

NOTE: Above command will copy .razor pages and their .cs files from `./samples/` folder to `./browser/IgBlazorSamples.Client/` and generate required toc file.

## 2. Install Playwright browsers

- Open a Powershell terminal in the `./browser/IgBlazorSamples.Test/bin/Debug/net8.0` folder.

- Run `./playwright.ps1 install chromium` to instal only chromium for Playwright to run. For all browsers just omit the  `chromium` argument.

You can run it from the `./browser/IgBlazorSamples.Test` folder as well, but you will need to prefix the path to it: `bin/Debug/net8.0/playwright.ps1 install`

For running from **cmd** you will need to use `pwsh ./playwright.ps1 install`.

For other specific browsers refer to `./playwright.ps1 install --help`

## 3. Build Samples Browser Solution

- Open the **IgBlazorSamples.Test.sln** solution

- Build the solution. Should successfully build all projects.

## 4. Run tests

- In the **Test Explorer** you can run all tests or individually now.

NOTE: The `./browser/IgBlazorSamples.Test/` project once built, will generate all the tests and they should appear in the test explorer

# Resources

- For general guidance related to Playwright tests - https://playwright.dev/dotnet/docs/

- Generating selectors / tests code using Playwright Codegen - https://playwright.dev/dotnet/docs/codegen-intro

- Disabling headless run for tests locally - uncomment the headless launch option in `./browser/.runsettings` or in the test solution under `Solution Items/.runsettings`.

- Debugging in VS - Right click a test and choose debug. Should have a breakpoint of course in test :P.

- Debugging with Playwright Inspector - https://playwright.dev/dotnet/docs/debug. Pretty much add `await page.PauseAsync();` to the start of a test or elsewhere and the Playwright inspector will start at that point onward.

- Viewing trace of a failed test group(usually artifact from a build) - https://playwright.dev/dotnet/docs/trace-viewer#opening-the-trace
