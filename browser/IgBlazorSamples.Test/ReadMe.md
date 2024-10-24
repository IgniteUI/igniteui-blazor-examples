This documents provides instruction on building and running Samples Browser Tests

# Setup

- Instal Blazor **.NET SDK** from this website:
https://dotnet.microsoft.com/learn/aspnet/blazor-tutorial/install

## 1. Copying Samples to Browser

- open `./browser/IgBlazorSamples.Gulp/` folder

- execute `npm install` command

- execute `gulp copySamplesToClient` command

NOTE: Above command will copy .razor pages and their .cs files from `./samples/` folder to `./browser/IgBlazorSamples.Client/` and generate required toc file.

## 2. Running Tests

- open the **IgBlazorSamples.Test.sln** solution

- build the solution. Should successfully build all projects.

- in the **Test Explorer** you can run all tests or individually now.

NOTE: The `./browser/IgBlazorSamples.Test/` project once built, will generate all the tests and they should appear in the test explorer
