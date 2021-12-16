## Setup

- instal **.NET SDK** from this website:
https://dotnet.microsoft.com/learn/aspnet/blazor-tutorial/install

## Create Local NuGet Package

- open `Visual Studio 2015` as an Administrator
- open **Tools - Options** menu
- expand **NuGet Package Manager** menu
- select **Package Sources**
- click add button
- type **IG Blazor Local** in Name field
- type local path to [**igniteui-blazor-examples/NuGet**](https://github.com/IgniteUI/igniteui-blazor-examples) folder in the Source field, e.g.
`C:\REPOS\igniteui-blazor-examples\NuGet`

- move the new **IG Blazor Local** to top of the list of packages

## Running App in Visual Studio 2019

NOTE: VS 2019 has better code highlighting and error detection than VS Code does.

- open Visual Studio 2019 as an Administrator

- open the **BlazorClientApp.sln** solution

- right click solution and select Restore NuGet Packages

- click Debug menu and select Start Debugging or press F5 key


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

## Implementation

- create a new branch from the **master** branch

- copy content of this folder to [**IgniteUI for Blazor**](https://github.com/IgniteUI/igniteui-blazor-examples) repository under the `samples` folder, for example:

`/samples/charts/category-chart/annotations/`

- implement data source (if any) in the `Service` folder, e.g.
    - `DataChartSharedData.cs`
    - `DataChartSharedData.cs`
    - `WorldCity.cs`

NOTE: make sure `class` is under `Samples` namespace

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

- remove not used `.razor` file in `Pager` folder such there is only one `.razor` file in that folder

- remove not used `.cs` file in `Services` folder

- make sure there are only 1 file in wwwroot folder:
    - index.html

- create one pull request for up to 3 samples


## Resources

- [Razor Component Models](https://www.codemag.com/article/1911052)
- [Razor Syntax](https://docs.microsoft.com/en-us/aspnet/core/blazor/components/?view=aspnetcore-3.1#razor-syntax)
- [Getting reference to components](https://docs.microsoft.com/en-us/aspnet/core/blazor/components/?view=aspnetcore-3.1#capture-references-to-components)
