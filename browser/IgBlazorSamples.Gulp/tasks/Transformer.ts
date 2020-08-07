/* eslint-disable @typescript-eslint/no-var-requires */

let transFS = require('fs.extra');

// let platform = "React";
// let igConfig = require('./gulp-config.js')[platform];

let igConfig = require('./gulp-config.js')

// function log(msg) {
//     console.log('Transformer.ts ' + msg);
// }
// log('loaded');
class SampleFile {
    public Content: string;
    public Name: string;
    public Path: string;
    public IsChanged: boolean;

    constructor() {
        this.Content = "";
        this.Path = "";
        this.Name = "";
        this.IsChanged = false;
    }
}


class SampleSourceFile extends SampleFile {
    // public LocalPath: string;
    public Blocks: SampleSourceBlock;
    // public Content: string;
    // public Name: string;
    // public Path: string;
    // public IsChanged: boolean;

    constructor(file: SampleFile) {
        super();
        this.Content = file.Content;
        this.Path = file.Path;
        this.Name = file.Name;
        this.IsChanged = file.IsChanged;

        // this.LocalPath = "";
    }
    // constructor() {
    //     super();
    //     this.Content = "";
    // }
}

class SampleSourceBlock {
    public ImportLines: string[];
    public ImportFiles: string[];
    public HtmlCodeLines: string[];
    public CsharpCodeLines: string[];
    public OtherCodeLines: string[];

    constructor() {
        this.ImportFiles = [];
        this.ImportLines = [];
        this.ImportFiles = [];
        this.HtmlCodeLines = [];
        this.CsharpCodeLines = [];
        this.OtherCodeLines = [];
    }
}

// this class provides information about a sample that is implemented in /samples folder
class SampleInfo {
    public ComponentGroup: string;     // maps
    public ComponentFolder: string;    // geo-map
    public ComponentName: string;      // Geo Map

    // public SampleDirOnDisk: string;    // C:\repo\igniteui-react-examples\samples\maps\geo-map\binding-csv-points\
    public SampleFolderPath: string;     // /samples/maps/geo-map/binding-csv-points/
    public SampleFilePath: string;       // /samples/maps/geo-map/binding-csv-points/src/MapBindingDataCSV.razor
    public SampleRoute: string;          //         /maps/geo-map/binding-csv-points/
    public SampleFolderName: string;     //                       binding-csv-points
    public SampleFileName: string;       // MapBindingDataCSV.razor
    // public SampleImportName: string;     // MapBindingDataCSV
    // public SampleImportPath: string;     // ./geo-map/binding-csv-points/MapBindingDataCSV
    public SampleDisplayName: string;  // Map Binding Data CSV
    // public SampleFileSourcePath: string;     // /src/MapBindingDataCSV.razor
    // public SampleFileSourceCode: string;   // source code from /src/MapBindingDataCSV.razor file
    // public SampleFileSourceBlock: SampleSourceBlock;
    // public SampleImportPackages: string[];
    // public SampleImportFiles: string[];

    public SampleReadMe: string;       // content of ReadMe.md file generated for /samples/maps/geo-map/binding-csv-points/
    // public SampleFilePaths: string[];  // relative paths to files in sample folder: /samples/maps/geo-map/binding-csv-points/
    // public SampleFileNames: string[];  // names of files in sample folder: /samples/maps/geo-map/binding-csv-points/
    public SampleFiles: SampleFile[];
    public SampleSourceFile: SampleSourceFile;

    public DocsUrl: string             // https://infragistics.com/Reactsite/components/geo-map.html

    public SandboxUrlView: string;     // https://codesandbox.io/embed/github/IgniteUI/igniteui-react-examples/tree/master/samples/maps/geo-map/binding-csv-points
    public SandboxUrlEdit: string;     //     https://codesandbox.io/s/github/IgniteUI/igniteui-react-examples/tree/master/samples/maps/geo-map/binding-csv-points
    public SandboxUrlShort: string;    //     https://codesandbox.io/s/github/IgniteUI/igniteui-react-examples/tree/master/samples/maps/geo-map/binding-csv-points

    public PackageFileContent: PackageJson;
    public PackageDependencies: PackageDependency[];

    constructor() {
        // this.SampleFileSourceCode = '';
        // this.SampleFilePaths = [];
        // this.SampleFileNames = [];
        this.SampleFiles = [];
        this.PackageDependencies = [];
        // this.PackageDependencies.indexOf
    }

    public isUsingFileName(name: string): boolean {
        for (const file of this.SampleFiles) {
            if (file.Name.indexOf(name)) {
                return true;
            }
        }
        return false; // this.SampleFileNames.includes(name);
    }

    // public print() {
    //     var str = "";
    // }
}

class SampleGroup {
    public Name: string;
    public Components: SampleComponent[];

    constructor() {
        this.Components = [];
    }
}

class SampleComponent {
    public Name: string;
    public Group: string;
    public Samples: SampleInfo[];

    constructor() {
        this.Samples = [];
    }
}

class Transformer {

    // splits source code of a sample into block lines with imports, packages, and other lines
    public static getSampleBlocks(sampleSourceCode: string): SampleSourceBlock {
        let sourceBlocks = new SampleSourceBlock();

        let isImport = true;
        let isHtml = false;
        let isCS = false;

        let sampleCodeLines = sampleSourceCode.split('\n');
        for (const line of sampleCodeLines) {
            // if (line.indexOf(" from 'react'") > 0) continue;

            // skipping page routes because they will be auto-generated
            if (line.indexOf("@page") >= 0) continue;

            if (line.indexOf("<div") >= 0) {
                isImport = false; isHtml = true; isCS = false;
            }
            if (line.indexOf("@code") >= 0) {
                isImport = false; isHtml = false; isCS = true;
            }

            if (isCS) {
                sourceBlocks.CsharpCodeLines.push(line);
            } else if (isHtml) {
                sourceBlocks.HtmlCodeLines.push(line);
            } else if (isImport) {
                sourceBlocks.ImportLines.push(line);
            } else {
                sourceBlocks.OtherCodeLines.push(line);
            }

            // if (line.indexOf("import ") >= 0) {
            //     sample.ImportLines.push(line);
            //     // if (line.indexOf(" from ") === -1) continue;

            //     if (line.indexOf(" from ") > 0 && line.indexOf("./") === -1) {

            //         let importPackage = line.substring(line.indexOf("'") + 1, line.lastIndexOf("'"));
            //         if (importPackage === "") {
            //             importPackage = line.substring(line.indexOf('"') + 1, line.lastIndexOf('"'));
            //         }
            //         // console.log("<" + importPackage + ">");
            //         if (sample.ImportPackages.indexOf(importPackage) === -1) {
            //             sample.ImportPackages.push(importPackage);
            //         }
            //     } else if (line.indexOf(" from ") === -1) {
            //         sample.ImportCSS.push(line);

            //     } else if (line.indexOf("./") > 0 || line.indexOf("../") > 0) {
            //         sample.ImportFiles.push(line);
            //     }

            // } else {
            //     sample.OtherLines.push(line);
            // }
        }

        return sourceBlocks;
    }

    public static getDependencies(sampleInfo: SampleInfo): PackageDependency[] {
        let dependencies: PackageDependency[] = [];
        let packageJson = sampleInfo.PackageFileContent;
        if (packageJson && packageJson.dependencies) {
            dependencies = [];

            let packages = packageJson.dependencies;

            for (let name in packages) {
                if (packages.hasOwnProperty(name)) {
                    let dependency = new PackageDependency();
                    dependency.name = name;
                    dependency.version = packages[name];
                    dependencies.push(dependency);
                    console.log(name + ": " + packages[name]);
                }
            }
        }
        return dependencies;
    }

    public static sort(samples: SampleInfo[]): void {
        samples.sort((a, b) => a.SampleFolderPath > b.SampleFolderPath ? 1 : -1);
    }

    public static printNames(samples: SampleInfo[]): void {
        for (const info of samples) {
            console.log(info.SampleFolderPath + " => " + info.SampleDisplayName);
        }
    }
    public static printRoutes(samples: SampleInfo[]): void {
        for (const info of samples) {
            console.log(info.SampleFolderPath + " => " + info.SampleRoute);
        }
    }
    public static printUrls(samples: SampleInfo[]): void {
        for (const info of samples) {
            console.log(info.SampleFolderPath + " => " + info.SandboxUrlEdit);
        }
    }

    public static getDataRoutes(samples: SampleInfo[]): void {
        // { name: 'tests', routes: [
        //     { path: '/tests/test-component1-test-sample0', name: 'SampleFileName', component: SampleFileName},
        //     { path: '/tests/test-component1-test-sample1', name: 'MapBindingDataJSON', component: MapBindingDataJSON},
        // ]},
    }

    public static process(samples: SampleInfo[]): void {

        for (const info of samples) {

            // ../samples/maps/geo-map/binding-csv-points
            // let relativePath = this.getRelative(SampleDirectory);
            // .., samples, maps, geo-map, binding-csv-points
            console.log("pro SampleFolderPath " + info.SampleFolderPath);
            let folders = info.SampleFolderPath.split('/');

            if (folders.length > 3) info.ComponentGroup = folders[3];
            if (folders.length > 4) info.ComponentFolder = folders[4];
            if (folders.length > 5) info.SampleFolderName = folders[5];

            console.log("pro ComponentFolder " + info.ComponentFolder);

            info.ComponentName = Strings.toTitleCase(info.ComponentFolder, '-');
            info.ComponentName = info.ComponentName.replace("Geo Map", "Geographic Map");

            // info.SampleFolderPath = relativePath;
            info.SampleRoute = "/" +  info.ComponentGroup + "/" + info.ComponentFolder + "-" + info.SampleFolderName;

            console.log("pro " + info.SampleFolderPath + "/" + " === " + info.SampleRoute);

            let fileNames = [];
            // finding .razor files in Pages folder
            for (const file of info.SampleFiles) {
                console.log("pro path: " + file.Path);
                if (Strings.includes(file.Path, igConfig.SamplesFolderName) &&
                    Strings.includes(file.Path, igConfig.SamplesFileExtension) &&
                    Strings.excludes(file.Path, igConfig.SamplesFileExclusions, true)) {
                        fileNames.push(file.Path);
                    // console.log(filePath);
                }
            }

            // checking if we have only one .razor file in Pages folder
            if (fileNames.length === 0) {
                console.log("WARNING Transformer cannot match any " + igConfig.SamplesFileExtension + " files in sample: " + info.SampleFolderPath);
                for (const file of info.SampleFiles) {
                    console.log('- ' + file.Path);
                }
            } else if (fileNames.length > 1) {
                console.log("WARNING Transformer cannot decide which " + igConfig.SamplesFileExtension + " file to use for sample name: ");
                console.log(" - " + fileNames.join("\n - "));
            } else { // good we have only one .razor file per sample
                info.SampleSourceFile = new SampleSourceFile(fileNames[0])
                // info.SampleSourceFile.LocalPath = "./Pages/" + info.SampleFileName;
                // info.SampleSourceFile.Blocks = this.getSampleBlocks(info.SampleSourceFile.Content);
                // auto-generating routing paths for a sample with and without SB navigation
                // info.SampleSourceFile.Blocks.ImportLines.splice(0, 0, "@page /samples" + info.SampleRoute);
                // info.SampleSourceFile.Blocks.ImportLines.splice(1, 0, "@page         " + info.SampleRoute);
                // info.SampleSourceFile.Blocks.ImportLines.splice(2, 0, "");

                // info.SampleFilePath = fileNames[0];
                // info.SampleFileName = this.getFileName(info.SampleFilePath);
                // info.SampleFileSourcePath = "./Pages/" + info.SampleFileName;
                // info.SampleFileSourceCode = transFS.readFileSync(info.SampleFilePath, "utf8");

                // console.log("pro code: \n" + info.SampleFileSourceCode);

                // info.SampleImportLines = sampleBlocks.ImportLines;
                // info.SampleImportFiles = sampleBlocks.ImportFiles;
                // info.SampleImportPackages = sampleBlocks.ImportPackages;


                // console.log("pro ==============================");
                // console.log("pro ImportLines:\n" + info.SampleSourceFile.Blocks.ImportLines.join('\n'));
                // console.log("pro ==============================");
                // console.log("pro HtmlCodeLines:\n" + info.SampleFileSourceBlock.HtmlCodeLines.join('\n'));
                // console.log("pro ==============================");
                // console.log("pro CsharpCodeLines:\n" + info.SampleFileSourceBlock.CsharpCodeLines.join('\n'));
                // console.log("pro ==============================");
                // console.log("pro OtherCodeLines:\n" + info.SampleFileSourceBlock.OtherCodeLines.join('\n'));
                // console.log("pro ==============================");

                // info.SampleImportName = info.SampleFileName.replace('.razor','');
                // info.SampleImportPath = './' + info.ComponentFolder + '/' + info.SampleFolderName + '/' + info.SampleImportName;

                info.SampleDisplayName = Strings.splitCamel(info.SampleFileName)
                info.SampleDisplayName = Strings.replaceAll(info.SampleDisplayName, igConfig.SamplesFileExtension, "");
                info.SampleDisplayName = Strings.replaceAll(info.SampleDisplayName, "Map Type ", "");
                info.SampleDisplayName = Strings.replaceAll(info.SampleDisplayName, "Map Binding ", "Binding ");
                info.SampleDisplayName = Strings.replaceAll(info.SampleDisplayName, "Map Display ", "Display ");
                info.SampleDisplayName = Strings.replaceAll(info.SampleDisplayName, "Data Chart Type ", "");
                info.SampleDisplayName = Strings.replaceAll(info.SampleDisplayName, info.ComponentName + " ", "");
                console.log("pro SampleDisplayName: " + info.SampleDisplayName);

                info.SandboxUrlView = this.getSandboxUrl(info, igConfig.SandboxUrlView);
                info.SandboxUrlEdit = this.getSandboxUrl(info, igConfig.SandboxUrlEdit);
                info.SandboxUrlShort = this.getSandboxUrl(info, igConfig.SandboxUrlShort);

                info.DocsUrl = this.getDocsUrl(info);
                // console.log("SAMPLE " + info.SampleFilePath + " => " + info.SampleDisplayName);
            }

            // console.log(info.SampleFolderPath + " => " + info.SampleRoute + " => " + info.SampleDisplayName);

        }
    }

    public static getSandboxUrl(sampleInfo: SampleInfo, sandboxUrlFormat: string): string {
        let url = sandboxUrlFormat + "";

        url = Strings.replaceAll(url, "{SandboxUrlOptions}", igConfig.SandboxUrlOptions);
        url = Strings.replaceAll(url, "{RepositoryPath}", igConfig.RepositoryPath);
        url = Strings.replaceAll(url, "{RepositoryOrg}", igConfig.RepositoryOrg);
        url = Strings.replaceAll(url, "{RepositoryName}", igConfig.RepositoryName);
        url = Strings.replaceAll(url, "{RepositoryBranch}", igConfig.RepositoryBranch);
        url = Strings.replaceAll(url, "{ComponentGroup}", sampleInfo.ComponentGroup);
        url = Strings.replaceAll(url, "{ComponentFolder}", sampleInfo.ComponentFolder);
        url = Strings.replaceAll(url, "{SampleFolderName}", sampleInfo.SampleFolderName);
        url = Strings.replaceAll(url, "{SampleFile}", sampleInfo.SampleFileName);

        return url;
    }

    public static getDocsUrl(sampleInfo: SampleInfo): string {
        let url = igConfig.DocsUrl + "";

        url = Strings.replaceAll(url, "{PlatformName}", igConfig.PlatformName);
        url = Strings.replaceAll(url, "{ComponentFolder}", sampleInfo.ComponentFolder);

        return url;
    }

    public static updatePackage(browsersPackage: PackageJson, templatePackage: PackageJson): string {

        let errors: string[] = [];

        // if (browsersPackage.author !== templatePackage.author)
        // errors.push("author", "does not match author in browser's package.json");

        // checking if the template has same dependencies as the browser
        for (let name in browsersPackage.dependencies) {
            if (templatePackage.dependencies.hasOwnProperty(name) &&
                browsersPackage.dependencies.hasOwnProperty(name)) {
                let browsersDep = browsersPackage.dependencies[name];
                let templateDep = templatePackage.dependencies[name];
                if (templateDep !== browsersDep) {
                    if (name.indexOf('igniteui-') === 0) {
                        browsersPackage.dependencies[name] = templateDep;
                        console.log("- changed browser's package " + name + " from " + browsersDep + " to " + templateDep);
                    } else {
                        errors.push("- template's package.json has \"" + name + "\" with \"" + templateDep + "\" while \"" + browsersDep + "\" is in browser's package.json");
                    }
                }
            }
        }

        // checking if the browser has same dependencies as the template
        // for (let name in templatePackage.dependencies) {
        //     if (templatePackage.dependencies.hasOwnProperty(name) &&
        //         browsersPackage.dependencies.hasOwnProperty(name)) {
        //         let browsersDep = browsersPackage.dependencies[name];
        //         let templateDep = templatePackage.dependencies[name];
        //         if (templateDep !== browsersDep) {
        //             errors.push("- browser's package.json has \"" + name + "\" with \"" + browsersDep + "\" while \"" + templateDep + "\" in template's package.json");
        //         }
        //     }
        // }

        if (errors.length > 0) {
            console.log("ERRORS found in package.json files: \n" + errors.join('\n'))
        }

        return JSON.stringify(browsersPackage, null, '  ');
    }

    // gets updated package.json file for a sample using a template
    public static getPackage(sample: SampleInfo, tempPackage: PackageJson): string {

        let title = tempPackage.name;
        title = Strings.replaceAll(title, 'platform-name', igConfig.PlatformName);
        title = Strings.replaceAll(title, 'component-name', sample.ComponentName);
        title = Strings.replaceAll(title, 'sample-name', sample.SampleDisplayName);
        title = Strings.replaceAll(title, ' ', '-');
        title = title.toLowerCase();

        let descr = tempPackage.description;
        descr = Strings.replaceAll(descr, 'platform-name', igConfig.PlatformName);
        descr = Strings.replaceAll(descr, 'component-name', sample.ComponentName);
        descr = Strings.replaceAll(descr, 'sample-name', sample.SampleDisplayName);

        let samplePackage = sample.PackageFileContent;
        samplePackage.name = title;
        samplePackage.description = descr;
        samplePackage.author = tempPackage.author;
        samplePackage.homepage = tempPackage.homepage;
        samplePackage.version = tempPackage.version;
        samplePackage.private = tempPackage.private;
        samplePackage.browserslist = tempPackage.browserslist;
        samplePackage.scripts = tempPackage.scripts;

        // updating scripts in a sample using scripts from the template
        // for (let name in tempPackage.scripts) {
        //     if (tempPackage.scripts.hasOwnProperty(name) &&
        //         samplePackage.scripts.hasOwnProperty(name)) {
        //         samplePackage.scripts[name] = tempPackage.scripts[name]
        //     }
        // }

        // updating devDependencies in a sample using devDependencies from the template
        for (let name in tempPackage.devDependencies) {
            if (tempPackage.devDependencies.hasOwnProperty(name) &&
                samplePackage.devDependencies.hasOwnProperty(name)) {
                samplePackage.devDependencies[name] = tempPackage.devDependencies[name]
            }
        }

        // overriding sample dependencies
        samplePackage.dependencies = {};

        // // updating dependencies in sa sample by checking against OPTIONAL dependencies in the template
        // for (let name in tempPackage.dependenciesOptional) {

        //     let dependency = tempPackage.dependenciesOptional[name];
        //     if (dependency.usage === "always") {
        //         samplePackage.dependencies[name] = dependency.version;
        //     } else if (dependency.usage === "detect") {
        //         let isDependencyImported = sample.SampleFileSourceCode.indexOf(name) >= 0;
        //         if (isDependencyImported) {
        //             samplePackage.dependencies[name] = dependency.version;
        //         // using keywords to check if the dependency is used by some other file, e.g. ExcelUtility.ts
        //         } else if (dependency.keywords !== undefined && dependency.keywords.length > 0) {
        //             for (let keyword of dependency.keywords) {
        //                 let isDependencyUsed = sample.SampleFileSourceCode.indexOf(keyword) >= 0;
        //                 if (isDependencyUsed) {
        //                     samplePackage.dependencies[name] = dependency.version;
        //                     break;
        //                 }
        //             }
        //         }
        //     }
        // }

        // updating dependencies in sa sample by checking against REQUIRED dependencies in the template
        for (let name in tempPackage.dependencies) {
            samplePackage.dependencies[name] = tempPackage.dependencies[name];
        }
        // console.log("sample: " + sample.SampleFolderPath);
        // console.log("dependencies \n" + JSON.stringify(samplePackage.dependencies, null, '  '));

        return JSON.stringify(samplePackage, null, '  ');
    }



    public static getSampleInfo(sampleFile: any, sampleFilePaths?: string[]): SampleInfo {

        let info = new SampleInfo();
        info.SampleFolderPath = this.getRelative(sampleFile.dirname);
        // info.SampleFilePaths  = sampleFilePaths;
        // info.PackageFileContent = JSON.parse(sampleFile.contents.toString());
        // info.SampleFileSourceCode = sampleFile.contents.toString();

        for (const filePath of sampleFilePaths) {
            let parts = filePath.split('/');
            let file = new SampleFile();
            file.Path = filePath;
            file.Name = parts[parts.length - 1];
            file.Content = transFS.readFileSync(filePath, "utf8");

            info.SampleFiles.push(file);
            // info.SampleFileNames.push(parts[parts.length - 1]);
        }
        return info;
    }

    public static getRelative(path: string): string {
        // let path = filePath;
        if (path.indexOf(igConfig.RepositoryName) > -1) {
            path = path.split(igConfig.RepositoryName)[1];
            path = path.split("\\").join("/");
            // return "." + path;
            return "../.." + path;
            // return path;
        }

        console.log("failed on getRelative " + path);
        return path;
    }

    public static getFileName(relativePath: string): string {
        // ./samples/maps/geo-map/display-esri-imagery/src/FileName.razor
        let parts = relativePath.split("/");
        if (parts.length > 0) {
            return parts[parts.length - 1]; // FileName.razor
        }
        console.log("failed on getFileName " + relativePath);
        return "";
    }

    public static getSourcePath(relativePath: string): string {
        // ./samples/maps/geo-map/display-esri-imagery/src/FileName.razor
        let parts = relativePath.split("/src");
        if (parts.length > 0) {
            return "./src" + parts[parts.length - 1]; // ./src/FileName.razor
        }
        console.log("failed on getSourcePath " + relativePath);
        return "";
    }

    public static getParent(path: string): string {
        const folders = path.split('\\');
        if (folders.length > 1) {
            return folders[folders.length  - 1];
        }
        return "";
    }

    public static updateIndex(sample: SampleInfo, template: string): string {

        let content = template + "";

        content = Strings.replaceAll(content, "SampleFileName", sample.SampleFileName);
        content = Strings.replaceAll(content, ".razor", "");
        return content;
    }


    // generates content of readme file for a given sample based on provided template of readme file
    public static updateReadme(sample: SampleInfo, template: string): string {

        // let ComponentGroup = "maps";
        // let ComponentFolder = "geo-map";
        // let SampleFolderName = "binding-csv-points";
        // let sampleFile = "MapBindingDataCSV.razor";

        let readMe = template + "";
        // replacing variables with values that were generated while processing each sample:
        readMe = Strings.replaceAll(readMe, "{SandboxUrlView}", sample.SandboxUrlView);
        readMe = Strings.replaceAll(readMe, "{SandboxUrlEdit}", sample.SandboxUrlEdit);

        readMe = Strings.replaceAll(readMe, "{ComponentFolder}", sample.ComponentFolder);
        readMe = Strings.replaceAll(readMe, "{ComponentGroup}", sample.ComponentGroup);
        readMe = Strings.replaceAll(readMe, "{ComponentName}", sample.ComponentName);

        // readMe = Strings.replaceAll(readMe, "{SampleFolderPath}", sample.SampleFolderPath);
        readMe = Strings.replaceAll(readMe, "{SampleFolderPath}", sample.SampleFolderPath);
        readMe = Strings.replaceAll(readMe, "{SampleFolderName}", sample.SampleFolderName);
        readMe = Strings.replaceAll(readMe, "{SampleRoute}", sample.SampleRoute);
        readMe = Strings.replaceAll(readMe, "{SampleDisplayName}", sample.SampleDisplayName);
        readMe = Strings.replaceAll(readMe, "{SampleFileName}", sample.SampleFileName);
        readMe = Strings.replaceAll(readMe, "{SampleFilePath}", sample.SampleFilePath);
        readMe = Strings.replaceAll(readMe, "{SampleFileSourcePath}", sample.SampleSourceFile.Path);
        readMe = Strings.replaceAll(readMe, "{SampleFileSourceCode}", sample.SampleSourceFile.Content);

        readMe = Strings.replaceAll(readMe, "{DocsUrl}", sample.DocsUrl);

        readMe = Strings.replaceAll(readMe, "{RepositoryWarning}", igConfig.RepositoryWarning);
        readMe = Strings.replaceAll(readMe, "{RepositoryUrl}", igConfig.RepositoryUrl);
        readMe = Strings.replaceAll(readMe, "{RepositoryPath}", igConfig.RepositoryPath);
        readMe = Strings.replaceAll(readMe, "{RepositoryBranch}", igConfig.RepositoryBranch);
        readMe = Strings.replaceAll(readMe, "{RepositoryOrg}", igConfig.RepositoryOrg);
        readMe = Strings.replaceAll(readMe, "{RepositoryName}", igConfig.RepositoryName);

        readMe = Strings.replaceAll(readMe, "{PlatformCode}", igConfig.PlatformCode);
        readMe = Strings.replaceAll(readMe, "{PlatformName}", igConfig.PlatformName);

        readMe = Strings.replaceAll(readMe, "{BrowserHostUrl}", igConfig.BrowserHostUrl);
        readMe = Strings.replaceAll(readMe, "{BrowserRootPath}", igConfig.BrowserRootPath);

        // console.log("====== ReadMe.md File =======================");
        // console.log(readMe);
        // console.log("====== ReadMe.md File =======================");
        return readMe;
    }

    public static getRoutingGroups(samples: SampleInfo[]): SampleGroup[] {
        let componentsMap = new Map<string, SampleComponent>();

        for (const item of samples) {
            if (componentsMap.has(item.ComponentName)) {
                componentsMap.get(item.ComponentName).Samples.push(item);
            } else {
                let component = new SampleComponent();
                component.Name = item.ComponentName;
                component.Group = item.ComponentGroup;
                component.Samples.push(item);
                componentsMap.set(item.ComponentName, component);
            }
        }

        let groupMap = new Map<string, SampleGroup>();

        for (let key of Array.from( componentsMap.keys()) ) {
            let component = componentsMap.get(key);

            if (groupMap.has(component.Group)) {
                groupMap.get(component.Group).Components.push(component);
            } else {
                let group = new SampleGroup();
                group.Name = component.Group;
                group.Components.push(component);
                groupMap.set(component.Group, group);
            }
        }

        let groups: SampleGroup[] = [];
        for (let key of Array.from( groupMap.keys()) ) {
            let group = groupMap.get(key);
            group.Components = group.Components.sort(this.sortByComponentsName);

            for (let i = 0; i < group.Components.length; i++) {
                // const element = group.Components[i];
                group.Components[i].Samples = group.Components[i].Samples.sort(this.sortBySamplesName);
            }
            // console.log('group ' + key);
            // for (const component of group.Components) {
            //     console.log('component ' + component.name);

                // component.Samples = component.Samples.sort(this.sortBySamplesName);
            //     for (const sample of component.samples) {
            //         console.log('sample ' + sample.SampleFolderName);
            //     }
            // }
            // let group = new SampleGroup();
            // group.name = key;
            // group.samples = map.get(key);

            // for (let item of map.get(key) ) {
            //     console.log(item.SampleRoute);
            // }
            // // groups.push(map.get(key));
            groups.push(group);
        }
        return groups;
    }

    public static sortByComponentsName(a: any, b: any) {
        if (a.Name > b.Name) { return 1; }
        if (a.Name < b.Name) { return -1; }
        return 0;
    }

    public static sortBySamplesName(a: any, b: any) {
        if (a.SampleDisplayName > b.SampleDisplayName) { return 1; }
        if (a.SampleDisplayName < b.SampleDisplayName) { return -1; }
        return 0;
    }

    public static getRoutingFile(group: SampleGroup): string {

        let imports = '\n';
        imports += "import * as React from 'react';"
        imports += "import { RoutingGroup } from '../../navigation/SamplesData'; \n";

        let routes = "// creating routing data for " + group.Name + " samples: \n";
        routes += "export const " + group.Name + "RoutingData: RoutingGroup = { \n";
        routes += "    name: '" + group.Name + "',\n";
        routes += "    components: [\n";

        for (const component of group.Components) {
            console.log('coping samples for ' + component.Name + ' component');

            // let componentPath = '/' + group.name + '/' + component.name;
            // routes += "    {     path: '" + componentPath +  "', name: '" + component.name + "', routes: [ \n";
            // let componentName = component.Name; // .replace("Geo Map", "Geographic Map");
            routes += "    {     name: '" + component.Name + "', routes: [ \n";

            imports += "// importing " + component.Name + " samples: \n";

            for (const info of component.Samples) {
                console.log('- copied: ' + info.SampleFileName);

                // console.log('sample ' + sample.SampleFolderName);
                // let sampleClass = info.SampleFileName.replace('.razor','');
                // let samplePath = './' + info.ComponentFolder + '/' + info.SampleFolderName + '/' + info.SampleClassName;
                // imports += "const " + info.SampleImportName +  " = React.lazy(() => import('" + info.SampleImportPath + "')); \n";

                // routes += "        { path: '" + info.SampleRoute + "', name: '" + info.SampleDisplayName + "', component: " + info.SampleImportName + " }, \n";
            }
            routes += '    ]},\n';
        }

        routes += '    ]\n';
        routes += '};\n';

        let content = imports + "\n" + routes;
        // console.log(content);
        return content;
    }

    public static lintSample(info: SampleInfo) {

        for (const file of info.SampleFiles) {
            let orgContent = file.Content;
            if (file.Path.indexOf(".razor") > 0) {
                this.lintRazor(file);
            }

            if (file.Content !== orgContent) {
                file.IsChanged = true;
                this.NOTE("lintSample() changed " + file.Path);
            }
        }

    }

    public static WARN(msg: string) {
        console.log("WARN: " + msg);
    }
    public static NOTE(msg: string) {
        console.log("NOTE: " + msg);
    }

    public static lintRazor(file: SampleFile) {

        let invalidLines: string[] = [
            "@page ",
        ];

        let csharpCodeLines: string[] = [];
        let htmlCodeLines: string[] = [];
        let importLines: string[] = [];
        let otherLines: string[] = [];

        let isImport = true;
        let isHtml = false;
        let isCS = false;

        let fileLines = file.Content.split('\n');
        for (const line of fileLines) {
            // if (line.indexOf(" from 'react'") > 0) continue;

            // skipping page routes because they will be auto-generated

            let isInvalidLine = false;
            for (const invalid of invalidLines) {
                if (line.indexOf(invalid) >= 0) {
                    isInvalidLine = true;
                    break;
                }
            }
            if (isInvalidLine) continue;

            if (line.indexOf("<div") >= 0) {
                isImport = false; isHtml = true; isCS = false;
            }
            if (line.indexOf("@code") >= 0) {
                isImport = false; isHtml = false; isCS = true;
            }

            if (isCS) {
                csharpCodeLines.push(line);
            } else if (isHtml) {
                htmlCodeLines.push(line);
            } else if (isImport) {
                importLines.push(line);
            } else {
                otherLines.push(line);
            }
        }

        if (otherLines.length > 0) {
            this.WARN("lintRazor() failed in " + file.Path + " on line: " + otherLines[0]);
        }
        // if (csharpCodeLines.length === 0) {
        //     this.WARN("lintRazor() found no CS code in " + file.Path);
        // }
        // if (htmlCodeLines.length === 0) {
        //     this.WARN("lintRazor() found no HTML code in " + file.Path);
        // }
        // if (importLines.length === 0) {
        //     this.WARN("lintRazor() found no @using/@inject statements in " + file.Path);
        // }

        let newContent =
            importLines.join('\n') + "\n" +
            htmlCodeLines.join('\n') + "\n" +
            csharpCodeLines.join('\n') + "\n";

        file.Content = newContent;
    }

    // public static lintFile(
    //     sample: SampleInfo,
    //     fileLocation: string,
    //     fileContent: string,
    //     // callback: (err: any, results: string | null) => void
    //     ): string {



    //     let firstLine = true;
    //     let validLines: string[] = [];
    //     let fileLines = fileContent.split("\n");
    //     for (let i = 0; i < fileLines.length; i++) {
    //         const currentLine = fileLines[i].trimRight();
    //         const nextLine = i === fileLines.length - 1 ? '' : fileLines[i + 1].trimRight();

    //         // if (currentLine !== '' && nextLine !== '') {
    //         //     validLines.push(currentLine);
    //         // }
    //         if (currentLine === '' && firstLine) { continue; }
    //         if (currentLine === '' && nextLine === '') { continue; }

    //         firstLine = false;
    //         validLines.push(currentLine);

    //         // if (i === fileLines.length - 1)
    //         //     validLines.push(nextLine);
    //     }

    //     let importingLines = true;
    //     let importLines: string[] = [];
    //     let sourceLines: string[] = [];
    //     for (const line of validLines) {

    //         if (line.indexOf('import') !== 0 && line.indexOf('//') !== 0 && line !== '')
    //             importingLines = false;

    //         if (importingLines) {
    //             if (line !== '') importLines.push(line);
    //         }
    //         else
    //             sourceLines.push(line);

    //     }

    //     // importLines = importLines.sort();
    //     let lintedContent = importLines.join('\n') + '\n\n' + sourceLines.join('\n') + '\n';

    //     // console.log('======================================================');
    //     // console.log(importLines.join('\n') + '\n\n' + sourceLines.join('\n'));
    //     // console.log(validLines.join('\n'));
    //     // console.log('======================================================');
    //     // console.log('linting ' + fileLocation + ' done');
    //     // callback(null, vfile.toString());
    //     // callback(null, lintedContent);
    //     return lintedContent;
    // }
}


class Strings {

    public static excludes(str: string, exclusions: string[], useEndsWith?: boolean): boolean {
        for (const exclusion of exclusions) {
            if (useEndsWith) {
                if (str.endsWith(exclusion)) { return false; }
            } else {
                if (str.includes(exclusion)) { return false; }
            }
        }
        return true;
    }

    public static includes(str: string, pattern: string): boolean {
        return str.includes(pattern);
    }

    public static replaceAll(orgStr: string, oldStr: string, newStr: string): string {
        return orgStr.split(oldStr).join(newStr);
    }

    public static toTitleCase(str: string, separator?: string) {
        if (separator === undefined) { separator = ' '; }
        return str.toLowerCase().split(separator).map(function(word) {
          return (word.charAt(0).toUpperCase() + word.slice(1));
        }).join(' ');
      }

    public static splitCamel(orgStr: string): string {
        if (orgStr === undefined) return "";
        return orgStr.replace(/([a-z0-9])([A-Z])/g, '$1 $2');
    }

    // .replace(/([a-z0-9])([A-Z])/g, '$1 $2')
    //   .split(/(?=[A-Z])/) v

}

class PackageJson {
    public name?: string;
    public description?: string;
    public author?: string;
    public homepage?: string;
    public version?: string;
    public private?: boolean;
    public scripts: any;
    public dependencies: any;
    public dependenciesOptional: any;
    public devDependencies: any;
    public browserslist?: string[];
}

class PackageDependency {
    public name: string;
    public version: string;

    public samples?: SampleInfo[];

    constructor() {
        this.samples = [];
    }

    public toString() : string {
        return '"' + this.name + `": "` + this.version + '"';
    }
}