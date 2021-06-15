<link href="https://fonts.googleapis.com/css2?family=Titillium+Web&display=swap" rel="stylesheet">
<div style="display: flex; flex-flow: row; font-family: 'Titillium Web'">
    <!-- <div style="font-size: 2.5rem; align-self: start; justify-content: start; margin: 0px; margin-left: 0.5rem; margin-right: 0.5rem; ">Examples</div> -->
    <img height="70px" style="border-radius: 0.25rem" alt="ignite-ui" src="./browser/IgBlazorSamples.Client/wwwroot/images/logo-ignite-ui.svg"/>
    <!-- <div style="font-size: 2.5rem; margin: 0px; margin-left: 0.5rem; margin-right: 0.5rem; color: white; ">for BLAZOR </div> -->
</div>

# Examples of Ignite UI for Blazor Components

This repository contains over 250 examples on how to use [Ignite UI for Blazor](https://infragistics.com/blazorsite/components/general-getting-started.html) components:

- [Bullet Graph, Linear Gauge, Radial Gauges](https://infragistics.com/blazorsite/components/radial-gauge.html)
- [Data Chart, Category Chart, Financial Chart, Pie Chart](https://infragistics.com/blazorsite/components/charts/chart-overview.html)
- [Data Grid / Data Table](https://infragistics.com/blazorsite/components/data-grid.html)
- [Geographic Map](https://infragistics.com/blazorsite/components/geo-map.html)
- [Treemap](https://infragistics.com/blazorsite/components/charts/types/treemap-chart.html)
- [Excel Library](https://infragistics.com/blazorsite/components/excel_library_using_workbooks.html)
- and many more
<!-- - [Excel Spreadsheet](https://infragistics.com/blazorsite/components/spreadsheet_overview.html) -->

You can run each sample project individually from the [./samples](./samples) folder or you can browse all samples in one website from the [./browser](./browser) folder.
<!-- In addition, you can run each sample on Code Sandbox website by clicking on the `Edit on CodeSandbox` button in a readme file of sample project, e.g.

[./samples/charts/category-chart/overview/README.md](./samples/charts/category-chart/overview/README.md) -->


## Running Individual Sample

- in VS 2019, open a solution file from the [./samples](./samples) folder, e.g.

[./samples/charts/category-chart/overview/BlazorClientApp.csproj](./samples/charts/category-chart/overview/BlazorClientApp.csproj)

- right click solution and select **Restore NuGet Packages** menu item

- click **Debug** menu and select **Start Debugging** or press **F5** key

- Wait until the build is completed and then open [http://localhost:4200](http://localhost:4200) in your browser

At this point, you should see a website with a single example of [Ignite UI for Blazor](https://infragistics.com/blazorsite/components/general-getting-started.html) component.


## Running All Samples

- open VS Code as Administrator

- open the [./browser/IgBlazorSamples.Gulp](./browser/IgBlazorSamples.Gulp) folder

- select **View** - **Terminal** menu item

- type `npm install` command

- type `gulp copySamplesToClient` command

- wait until all samples are copied to the browser client app

- in VS 2019, open [./browser/IgBlazorSamplesBrowser.sln](./browser/IgBlazorSamplesBrowser.sln)

- right click solution and select **Restore NuGet Packages** menu item

- click **Debug** menu and select **Start Debugging** or press **F5** key

- Wait until the build is completed and then open [http://localhost:4200](http://localhost:4200) in your browser

At this point, you should see a website hosted all examples of [Ignite UI for Blazor](https://infragistics.com/blazorsite/components/general-getting-started.html) components.