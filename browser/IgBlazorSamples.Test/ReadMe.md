This documents provides instruction on building and running Samples Browser Tests

# Setup

- Instal Blazor **.NET SDK** from this website:
https://dotnet.microsoft.com/learn/aspnet/blazor-tutorial/install

## 1. Copying Samples to Browser

- open `./browser/IgBlazorSamples.Gulp/` folder

- execute `npm install` command

- execute `gulp copySamplesToClient` command

NOTE: Above command will copy .razor pages and their .cs files from `./samples/` folder to `./browser/IgBlazorSamples.Client/` and generate require toc file.

## 2. Generate generic error tests

- still in `./browser/IgBlazorSamples.Gulp/` folder

- execute `gulp generateTests` command

NOTE: Above command will generate generic tests in the `./browser/IgBlazorSamples.Test/Generated` forder for all grids samples that check for errors on the page.

## 3. Running Tests

- open `./browser/IgBlazorSamples.Client/` folder

- execute `dotnet run` to run the samples client. The tests requre a running app.

- open the **IgBlazorSamplesBrowser.sln** solution

- in the **Test Explorer** you can run all tests or individually.
