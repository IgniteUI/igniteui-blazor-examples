## Setup

- instal **.NET SDK** from this website:
https://dotnet.microsoft.com/learn/aspnet/blazor-tutorial/install

## Running App in Visual Studio 2022

- open **Visual Studio 2022** as an Administrator

- open the **IgBlazorSamplesBrowser.sln** solution

- right click solution and select **Restore NuGet Packages**

- click **Debug** menu and select **Start Debugging** or press F5 key

## Running App in VS Code

- open `./browser/IgBlazorSamples.Server/` folder in **VS Code**

- type `dotnet restore` command in terminal to restore assemblies

- type `dotnet watch run` command in terminal to host app locally

- wait for for message:
**Now listening on: http://localhost:5000**

- open **http://localhost:5000** in your browser

## Building Samples Browser

- open `./browser/IgBlazorSamples.Gulp/` folder in VS Code

- type `npm install` command in terminal window

- type `gulp copySamplesToServer` command in terminal window

NOTE: above command will copy .razor pages and their .cs files from `./samples/` folder to:

    ./browser/IgBlazorSamples.Server/

- open `./browser/IgBlazorSamples.Server/` folder in VS Code

- type `dotnet build` command in terminal to build app

<!-- ## Resources -->

<!-- - [Getting reference to components](https://docs.microsoft.com/en-us/aspnet/core/blazor/components/?view=aspnetcore-3.1#capture-references-to-components) -->