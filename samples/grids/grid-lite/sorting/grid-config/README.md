# GridLite Column Configuration - Simple Sample

This sample demonstrates basic column configuration for the GridLite component with:

- Simple column definitions
- Different column types (string, number)
- Fixed column widths
- 50 rows of mock product data

## Running the Sample

1. Open `BlazorClientApp.sln` in Visual Studio 2022
2. Right-click the solution and select **Restore NuGet Packages**
3. Press **F5** to run
4. Open [http://localhost:4200](http://localhost:4200) in your browser

## Features Demonstrated

- **Product Name**: String column
- **Price**: Number column with currency formatting
- **Units Sold**: Number column
- **Total Sold**: Calculated number column
- **Customer Rating**: Number column for ratings

## Component API

The sample uses:
- `IgbGridLite<TItem>` - The main grid component
- `ColumnConfiguration<TItem>` - Basic configuration for each column
- `MockDataGenerator.CreateProducts()` - Utility to generate product data

Based on the [apexgrid-samples column-config/simple](https://github.com/apexcharts/apexgrid-samples/tree/master/samples/column-config/simple).
