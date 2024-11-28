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
