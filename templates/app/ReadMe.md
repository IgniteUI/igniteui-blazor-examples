## Setup

- instal **.NET SDK** from this website:
https://dotnet.microsoft.com/learn/aspnet/blazor-tutorial/install

## Running App in VS Code

- open VS Code as an Administrator

- open this folder in VS Code

- open a terminal window

- to restore assemblies, run this command:
```dotnet restore```

- to run samples, run this command:
```dotnet watch run```

- wait for for message:
**Now listening on: http://localhost:4200**

- open **http://localhost:4200** in your browser

## Running App in Visual Studio 2019

NOTE: VS 2019 has better code highlighting and error detection than VS Code does.

- open Visual Studio 2019 as an Administrator

- open the BlazorApp.sln solution

- right click solution and select Restore NuGet Packages

- click Debug menu and select Start Debugging or press F5 key

- open **http://localhost:44385** in your browser

## Implementation

- create a new branch from master

- copy content of this folder to [**IgniteUI for Blazor**](https://github.com/IgniteUI/igniteui-blazor-examples) repository under the `samples` folder, for example:

`/samples/charts/category-chart/annotations/`

- implement data source (if any) in the `Service` folder, e.g.
    - `DataChartSharedData.cs`
    - `DataChartSharedData.cs`
    - `WorldCity.cs`

NOTE: make sure `class` is under  `Samples` namespace

- implement the sample in one of `.razor` pages, e.g.
    - `DataGridBindingLocalData.razor`
    - `DoughnutChartSelection.razor`
    - `PieChartSelection.razor`
    - `RadialGaugeTypeColumn.razor`

NOTE: `App.razor` file controls which `.razor` is loaded

NOTE: Do not add/change any files in the `wwwroot` folder

- make sure you make changes for `TODO` items

- remove all `NOTE` and `TODO` comments when you are done implementing sample

- remove any code that does not apply to the sample

- remove not used `.razor` file in `Pager` folder such there is only one `.razor` file

- remove not used `.cs` file in `Services` folder

- make your commits and create a pull request


## Resources

- [Razor Component Models](https://www.codemag.com/article/1911052)
- [Razor Syntax](https://docs.microsoft.com/en-us/aspnet/core/blazor/components/?view=aspnetcore-3.1#razor-syntax)
- [Getting reference to components](https://docs.microsoft.com/en-us/aspnet/core/blazor/components/?view=aspnetcore-3.1#capture-references-to-components)
