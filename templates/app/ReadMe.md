## Setup

- instal **.NET SDK** from this website:
https://dotnet.microsoft.com/learn/aspnet/blazor-tutorial/install

## Running App

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

- implement data source (if any) in the `Service` folder, e.g.
    - `DataChartSharedData.cs`
    - `WorldCity.cs`

NOTE: make sure `class` is under  `Samples` namespace

- implement the sample in one of these pages:
    - `SampleWithFetchedData.razor`
    - `SampleWithLocalData.razor`
    - `SampleWithOptions.razor`
    - `SampleWithOptionsAndData.razor`

NOTE: `App.razor` file controls which `.razor` is loaded

NOTE: Do not add/change any files in the `wwwroot` folder

- make sure you make changes for `TODO` items

- remove all `NOTE` and `TODO` comments when you are done implementing sample

- remove any code that does not apply to the sample

- remove not used `.razor` file in `Pager` folder such there is only one `.razor` file

- remove not used `.cs` file in `Services` folder

- add content of this project to [**IgniteUI for Blazor**](https://github.com/IgniteUI/igniteui-blazor-examples) repository under the `Samples` folder, for example:

`/samples/charts/category-chart/annotations/`

## Resources

- [Razor Component Models](https://www.codemag.com/article/1911052)
- [Razor Syntax](https://docs.microsoft.com/en-us/aspnet/core/blazor/components/?view=aspnetcore-3.1#razor-syntax)
- [Getting reference to components](https://docs.microsoft.com/en-us/aspnet/core/blazor/components/?view=aspnetcore-3.1#capture-references-to-components)
