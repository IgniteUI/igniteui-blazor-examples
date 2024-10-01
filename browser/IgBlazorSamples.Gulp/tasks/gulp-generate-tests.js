let fs = require("fs.extra");

const tocPath = "../../browser/IgBlazorSamples.Client/wwwroot/toc.json";
const testsOutput = "../../browser/IgBlazorSamples.Test/Generated";

// Test selector for each component that the test will wait for to be rendered.
const componentsMaps = [
    { "name": "Grid", "initial-selector": "igx-grid-header" },
    { "name": "Hierarchical Grid", "initial-selector": "igx-grid-header" },
    { "name": "Pivot Grid", "initial-selector": "igx-grid-header" },
    { "name": "Tree Grid", "initial-selector": "igx-grid-header" },
    { "name": "List", "initial-selector": "igc-list-item" },
    { "name": "Tree", "initial-selector": "igc-tree-item" },
    { "name": "Badge", "initial-selector": "igc-badge" },
    { "name": "Button", "initial-selector": "igc-button" },
    { "name": "Button Group", "initial-selector": "igc-toggle-button button" },
    { "name": "Checkbox", "initial-selector": "igc-checkbox input" },
    { "name": "Chip", "initial-selector": "igc-chip button" },
    { "name": "Circular Progress Indicator", "initial-selector": "igc-circular-progress circle" },
    { "name": "Combo", "initial-selector": "igc-combo input" },
    { "name": "Date Time Input", "initial-selector": "igc-date-time-input input" },
    { "name": "Dropdown", "initial-selector": "igc-dropdown-item" },
    { "name": "Icon Button", "initial-selector": "igc-icon-button igc-icon" },
    { "name": "Input", "initial-selector": "igc-input input" },
    { "name": "Linear Progress Indicator", "initial-selector": "igc-linear-progress" },
    { "name": "Radio", "initial-selector": "igc-radio" },
    { "name": "Rating", "initial-selector": "igc-rating-symbol" },
    { "name": "Select", "initial-selector": "igc-select igc-popover igc-input input" },
    { "name": "Slider", "initial-selector": "igc-slider" },
    { "name": "Switches", "initial-selector": "igc-switch input" },
    { "name": "Textarea", "initial-selector": "igc-textarea textarea" },
    { "name": "Textarea", "initial-selector": "igc-textarea textarea" },
    { "name": "Accordion", "initial-selector": "igc-expansion-panel" },
    { "name": "Avatar", "initial-selector": "igc-avatar" },
    { "name": "Card", "initial-selector": "igc-card-content" },
    { "name": "Expansion Panel", "initial-selector": "igc-expansion-panel" },
    { "name": "Icon", "initial-selector": "igc-icon svg" },
    { "name": "Stepper", "initial-selector": "igc-step" },
    { "name": "Tabs", "initial-selector": "igc-tab" },
    { "name": "Nav Bar", "initial-selector": "igc-navbar" },
    { "name": "Nav Drawer", "initial-selector": "igc-nav-drawer" },
    { "name": "Banner", "initial-selector": "igc-banner" },
    { "name": "Dialog", "initial-selector": "igc-dialog dialog" },
    { "name": "Snackbar", "initial-selector": "igc-snackbar" },
    { "name": "Toast", "initial-selector": "igc-toast" },
    { "name": "Calendar", "initial-selector": "igc-calendar igc-days-view" },
    { "name": "Date Picker", "initial-selector": "igc-date-picker igc-date-time-input input" },
];

// mapped based on TOC group names
const excludedRoutes = [
    { "route": "Charts/"  },
    { "route": "Editors/" },
    { "route": "Excel/" },
    { "route": "Gauges/" },
    { "route": "Maps/" },
    { "route": "Inputs/Ripple/" },
    { "route": "Layouts/Dock Manager/" },
    { "route": "Other \\/ Deprecated Components/" },
]

// mapped based on individual samples from the TOC
const excludeSamples = [
    { "route": "/grids/grid/state-persistence-about", "name": "State Persistence About" },
    { "route": "/grids/grid/state-persistence-about", "name": "State Persistence About" },
    { "route": "/grids/hierarchical-grid/complex-feature-name1", "name": "Complex Feature Name1" },
    { "route": "/grids/hierarchical-grid/complex-feature-name2", "name": "Complex Feature Name2" },
    { "route": "/grids/hierarchical-grid/state-persistence-about", "name": "State Persistence About" },
    { "route": "/grids/pivot-grid/state-persistence-about", "name": "State Persistence About" },
    { "route": "/grids/tree-grid/state-persistence-about", "name": "State Persistence About" },
];

function generateGridTests(cb, outputPath, tocPath) {
    var toc = fs.readFileSync(tocPath).toString();
    var tocJson = JSON.parse(toc);

    var excludedPaths = excludedRoutes.map(r => r.route.replaceAll("\\/", "@slash").split("/")
        .map(e => e.replaceAll("@slash", "/"))
        .filter(p => p !== ""));
    tocJson.groups.forEach(group => {
        var exGroups = excludedPaths.map(p => p.length === 1 ? p[0] : "").filter(p => p !== "");
        var isValidGroup = !exGroups.some(exGroup => group.name == exGroup);
        if (isValidGroup) {
            var exComp = excludedPaths.map(p => p[0] === group.name && p.length === 2 ? p[1] : "").filter(p => p !== "");
            var groupComponents = group.components.filter(comp => !exComp.includes(comp.name));
            groupComponents.forEach(comp => {
                var samples = comp.samples?.filter(s => s.showLink)
                    .filter(s => !excludeSamples.some(e => e.name === s.name && e.route === s.route));
                var componentName = comp.name.replaceAll(" ", "");

                // Add imports
                var fileContent = "";
                fileContent += `using System.Text;
using Microsoft.Playwright.NUnit;

namespace ${componentName};
`;
                samples.forEach(sampleInfo => {
                    fileContent += createTestContent(comp.name, sampleInfo)
                });

                var filePath = outputPath + "/" + componentName + "Tests.cs";
                fs.writeFileSync(filePath, fileContent);
            });
        }
    });
}

function createTestContent(componentName, sampleInfo) {
    var sampleClassName = sampleInfo.name.replaceAll(" ", "");
    var sampleLink = "http://localhost:4200/samples" + sampleInfo.route;
    var testSelector = componentsMaps.find(s => s.name === componentName)["initial-selector"];
    var testContent = `
[Parallelizable(ParallelScope.Self)]
[TestFixture]
public class ${sampleClassName} : PageTest
{
    [Test]
    public async Task ${sampleClassName}Test()
    {
        int numPageErrors = 0;
        StringBuilder messages = new ();
        Page.Console += (_, value) => 
        {
            if (value.Type == "warning" && value.Text.Contains("Error:"))
            {
                messages.AppendLine(value.Text);
                numPageErrors++;
            }
        };
        await Page.GotoAsync("${sampleLink}");
        await Page.WaitForSelectorAsync("${testSelector}");
        Assert.That(numPageErrors == 0, $"The following errors were thrown: \\n \${messages}");
    }
}
`

    return testContent;
}

function generateTests(cb) {
    generateGridTests(cb, testsOutput, tocPath);
} exports.generateTests = generateTests;

