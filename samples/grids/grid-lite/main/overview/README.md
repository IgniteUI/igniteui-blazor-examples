# GridLite Overview Sample

This sample demonstrates the basic usage of the IgniteUI Blazor GridLite component with:

- Multiple column types (string, number, boolean, date)
- Sortable columns
- Filterable columns
- Resizable columns
- 1000 rows of mock user data

## Running the Sample

1. Open `BlazorClientApp.sln` in Visual Studio 2022
2. Right-click the solution and select **Restore NuGet Packages**
3. Press **F5** to run
4. Open [http://localhost:4200](http://localhost:4200) in your browser

## Features Demonstrated

- **Avatar Column**: Displays user avatars
- **Sortable Columns**: Click column headers to sort FirstName, LastName, Priority, Satisfaction, and RegisteredAt
- **Filterable Columns**: Use the filter UI on FirstName, LastName, and Satisfaction columns
- **Resizable Columns**: Drag column borders to resize FirstName and LastName columns
- **Multiple Data Types**: Demonstrates string, number, boolean, and date column types

## Component API

The sample uses:
- `IgbGridLite<TItem>` - The main grid component
- `ColumnConfiguration<TItem>` - Configuration for each column
- `MockDataGenerator` - Utility to generate mock data

Based on the [apexgrid-samples overview](https://github.com/apexcharts/apexgrid-samples/tree/master/samples/main/overview).
